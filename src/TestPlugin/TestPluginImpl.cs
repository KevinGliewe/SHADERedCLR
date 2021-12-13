using System;
//using ImGuiNET;
using SHADERedCLR.Wrapper;

namespace TestPlugin
{
    [Plugin("Managed Test Plugin", 3, 1)]
    public class TestPluginImpl : PluginWrapper
    {
        public override bool Init(bool isWeb, int sedVersion)
        {
            return true;
        }

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

        public override bool Options_HasSection()
        {
            return true;
        }

        public override void Options_RenderSection()
        {
            //ImGui.Text("Hello from " + nameof(TestPluginImpl));
        }
    }
}
