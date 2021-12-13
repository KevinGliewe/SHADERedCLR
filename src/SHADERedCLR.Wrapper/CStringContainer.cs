using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace SHADERedCLR.Wrapper
{
    public class CStringContainer : IDisposable
    {
        private Dictionary<int, IntPtr> _data = new Dictionary<int, IntPtr>();

        public IntPtr Get(string str)
        {
            var hash = str.GetHashCode();

            if (_data.ContainsKey(hash))
                return _data[hash];

            var prt = Marshal.StringToHGlobalAnsi(str);

            _data.Add(hash, prt);

            return IntPtr.Zero;
        }

        public void Dispose()
        {
            foreach (var ptr in _data.Values)
            {
                Marshal.FreeHGlobal(ptr);
            }
        }
    }
}