using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.ManagedPointerCollection
{
    public class CS_MPC_Class : SourceElement
    {
        public static readonly string ClassName = "ManagedPointerCollection";

        private CppClass _cppClass;

        public CS_MPC_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name)
        {
            _cppClass = cppClass;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"[StructLayout(LayoutKind.Sequential)]");
            writer.WriteLine($"public unsafe struct {ClassName} {{");
            using (new IndentContext(writer))
            {
                int counter = 0;
                foreach (var field in _cppClass.CollectFields())
                {
                    writer.WriteLine($"public IntPtr {field.Name}_{counter++:D3};");
                }
            }
            writer.WriteLine("}");
        }
    }
}