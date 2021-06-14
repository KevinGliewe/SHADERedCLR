using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using SHADERedCLR.Wrapper;

namespace PluginManager
{
    public class ManagedPluginManager : PluginWrapper
    {
        public static List<string> AssemblyResolveDirs = new List<string>();

        public override bool Init(bool isWeb, int sedVersion)
        {
            AssemblyResolveDirs.Add(Path.GetDirectoryName(GetType().Assembly.Location));

            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomainOnAssemblyResolve;

            return true;
        }

        private Assembly? CurrentDomainOnAssemblyResolve(object? sender, ResolveEventArgs args)
        {
            var assemblyName = new AssemblyName(args.Name).Name + ".dll";

            foreach (var ass in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (ass.GetName().Name == new AssemblyName(args.Name).Name)
                    return ass;
            }

            foreach (var folderPath in AssemblyResolveDirs.Concat(
                new string[] { Path.GetDirectoryName(args.RequestingAssembly.Location ?? ".") }))
            {

                string assemblyPath = Path.Combine(folderPath, assemblyName);
                if (!File.Exists(assemblyPath)) return null;
                Assembly assembly = Assembly.LoadFrom(assemblyPath);
                return assembly;
            }

            return null;
        }

        public override void PluginManager_RegisterPlugins()
        {
            var pluginsBasePath = Path.GetFullPath(
                Path.Combine(
                    Path.GetDirectoryName(typeof(ManagedPluginManager).Assembly.Location),
                    "..",
                    "plugins"));

            foreach (var pluginDir in Directory.EnumerateDirectories(pluginsBasePath))
            {
                LoadPluginAssembly(pluginDir);
            }

        }

        private void LoadPluginAssembly(string dir)
        {
            foreach (var file in Directory.EnumerateFiles(dir))
            {
                if(!file.EndsWith(".dll"))
                    continue;

                var fileName = Path.GetFileNameWithoutExtension(file);

                if (!fileName.EndsWith("Plugin"))
                    continue;

                var assembly = Assembly.LoadFrom(Path.GetFullPath(file));

                foreach (var type in PluginAttribute.FindOccurrences(assembly))
                {
                    var plugin = Activator.CreateInstance(type.Item1) as PluginWrapper;
                    var pluginAttr = type.Item2;

                    unsafe {
                        fixed (byte* p = Encoding.ASCII.GetBytes(pluginAttr.Name))
                        {
                            this.RegisterPlugin(
                                this.UnmanagedPointerCollection.Plugins_006,
                                plugin.NativePlugin,
                                (IntPtr)p,
                                pluginAttr.ApiVersion,
                                pluginAttr.PluginVersion,
                                IntPtr.Zero);
                        }
                    }
                }
            }
        }
    }
}