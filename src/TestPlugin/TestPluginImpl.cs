using System;
using SHADERedCLR.Wrapper;

namespace TestPlugin
{
    [Plugin("Managed Test Plugin", 3, 1)]
    public class TestPluginImpl : PluginWrapper
    {
        public override void Update(float delta)
        {
            var data = new float[16];

            unsafe
            {
                fixed (float* p = data)
                {
                    GetViewMatrix((IntPtr)p);
                }
            }

            Console.WriteLine(string.Join(", ", data));
        }
    }
}
