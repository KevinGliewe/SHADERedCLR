# SHADERedCLR

This is a plugin for [SHADERed](https://github.com/dfranx/SHADERed).
It loads a .NET 5 runtime and enables the possibility to load C# plugins.

This repo is just experimantal for now as i am learning how to design a propper interface between C++ and C#.

Here is an example how a C# plugin implementation looks like:

```c#
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
```
