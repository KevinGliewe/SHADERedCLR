using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using SHADERedCLR.Wrapper.InteropData;

namespace SHADERedCLR.Wrapper
{
    public partial class PluginWrapper : IDisposable
    {
        public delegate IntPtr CreateNativePluginDelegate(ManagedPointerCollection a_MPC);
        public delegate void DestroyNativePluginDelegate(IntPtr a_pPlugin);

        public static CreateNativePluginDelegate CreateNativePlugin { get; set; }
        public static DestroyNativePluginDelegate DestroyNativePlugin { get; set; }

        public static List<PluginWrapper> PluginWrappers { get; set; } = new List<PluginWrapper>();

        public IntPtr NativePlugin { get; protected set; }

        public delegate void __SetUPCDelegate(UnmanagedPointerCollection a_UPC);

        public UnmanagedPointerCollection UnmanagedPointerCollection { get; protected set; }

        public void __SetUPC(UnmanagedPointerCollection a_UPC)
        {
            this.UnmanagedPointerCollection = a_UPC;
            this.__SetDelegates(a_UPC);
        }

        public PluginWrapper()
        {
            PluginWrappers.Add(this);

            var mpc = __GetFunctionPointers();
            mpc.__SetUPC = Marshal.GetFunctionPointerForDelegate(new __SetUPCDelegate(this.__SetUPC));
            this.NativePlugin = CreateNativePlugin(mpc);
        }

        public void Dispose()
        {
            PluginWrappers.Remove(this);

            NativePlugin = IntPtr.Zero;
        }
    }
}