using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace SHADERedCLR.Wrapper
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginAttribute : Attribute
    {
        public string Name { get; private set; }
        public int ApiVersion { get; private set; }
        public int PluginVersion { get; private set; }

        public PluginAttribute(string name, int apiVersion, int pluginVersion)
        {
            Name = name;
            ApiVersion = apiVersion;
            PluginVersion = pluginVersion;
        }

        public static IEnumerable<(Type, PluginAttribute)> FindOccurrences(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                foreach (var attribute in type.GetCustomAttributes())
                {
                    var attr = attribute as PluginAttribute;

                    if (attr != null)
                        yield return (type, attr);
                }
            }
        }
    }
}