using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SHADERedCLR.Wrapper;
using SHADERedCLR.Wrapper.InteropData;

namespace PluginManager
{
    public partial class NativeInterop
    {




        private static IntPtr s_hostHandle = IntPtr.Zero;
        private static IntPtr s_pluginPtr = IntPtr.Zero;

        public static IntPtr HostHandle
        {
            get { return s_hostHandle; }
        }

        public static IntPtr PluginPtr
        {
            get { return s_pluginPtr; }
        }

        private static ManagedPluginManager _pluginManager;


        [StructLayout(LayoutKind.Sequential)]
        private struct InitHost_Arg
        {
            public IntPtr m_hostHandle;
            public IntPtr m_pluginPtr;

            public IntPtr m_createNativePlugin;
            public IntPtr m_destroyNativePlugin;
        }

        public static int InitHost(IntPtr arg, int argLength)
        {
            if (argLength < System.Runtime.InteropServices.Marshal.SizeOf(typeof(InitHost_Arg))) {
                return 1;
            }

            var Arg = Marshal.PtrToStructure<InitHost_Arg>(arg);

            AppDomain.CurrentDomain.UnhandledException += (sender, args) => {
                Console.WriteLine($"Unhandled Exception: " + args.ExceptionObject);
            };

            Debug.WriteLine("HostHandle          = " + string.Format("{0:X8}", Arg.m_hostHandle));
            s_hostHandle = Arg.m_hostHandle;

            Debug.WriteLine("PluginPtr           = " + string.Format("{0:X8}", Arg.m_pluginPtr));
            s_pluginPtr = Arg.m_pluginPtr;

            Debug.WriteLine("CreateNativePlugin  = " + string.Format("{0:X8}", Arg.m_createNativePlugin));
            PluginWrapper.CreateNativePlugin = Marshal.GetDelegateForFunctionPointer<PluginWrapper.CreateNativePluginDelegate>(
                Arg.m_createNativePlugin);

            Debug.WriteLine("DestroyNativePlugin = " + string.Format("{0:X8}", Arg.m_destroyNativePlugin));
            PluginWrapper.DestroyNativePlugin = Marshal.GetDelegateForFunctionPointer<PluginWrapper.DestroyNativePluginDelegate>(
                Arg.m_destroyNativePlugin);

            NativeLibrary.SetDllImportResolver(typeof(NativeInterop).Assembly, ImportResolver);

            _pluginManager = new ManagedPluginManager();

            unsafe
            {
                var pArg = (InitHost_Arg*)arg;
                pArg->m_pluginPtr = _pluginManager.NativePlugin;
            }

            return 0;
        }

        private static IntPtr ImportResolver(string libraryName, Assembly assembly, DllImportSearchPath? searchPath) {
            //Console.WriteLine($"ImportResolver({libraryName})");

            IntPtr libHandle = IntPtr.Zero;
            if (libraryName == "*") {
                //Console.WriteLine("Used host handle " + string.Format("{0:X8}", s_hostHandle) + " for " + libraryName);
                libHandle = s_hostHandle;
            } else {
                libHandle = NativeLibrary.Load(libraryName, assembly, searchPath);
            }
            return libHandle;
        }
    }
}
