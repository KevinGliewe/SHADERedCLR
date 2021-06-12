using System;

namespace PluginManager
{
    public class ManagedPluginManager : PluginWrapper
    {
        public override void Update(float delta)
        {
            Console.WriteLine($"PluginManager.Update({delta})");
        }
    }
}