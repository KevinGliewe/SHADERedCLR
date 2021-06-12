using System;
using System.Security.Cryptography.X509Certificates;

namespace PluginManager
{
    public partial class PluginWrapper : IDisposable
    {
        public IntPtr NativePlugin { get; protected set; }

        public PluginWrapper()
        {
            var upc = __GetFunctionPointers();
        }

        public void Dispose()
        {

            NativePlugin = IntPtr.Zero;
        }
    }
}