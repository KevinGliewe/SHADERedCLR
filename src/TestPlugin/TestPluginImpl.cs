using System;
using SHADERedCLR.Wrapper;

namespace TestPlugin
{
    [Plugin("Managed Test Plugin", 3, 1)]
    public class TestPluginImpl : PluginWrapper
    {
        public override void Update(float delta)
        {
            Console.WriteLine($"TestPluginImpl.Update({delta})");
        }
    }
}
