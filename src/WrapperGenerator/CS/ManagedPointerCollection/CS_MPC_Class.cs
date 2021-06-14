using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.ManagedPointerCollection
{
    public class CS_MPC_Class : SourceElement
    {
        public static readonly string ClassName = "ManagedPointerCollection";

        private CppClass _cppClass;

        public CS_MPC_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name) {
            _cppClass = cppClass;
        }

        public override void Render(CodeWriter writer) {
            writer.WriteLine($"[StructLayout(LayoutKind.Explicit)]");
            writer.WriteLine($"public unsafe struct {ClassName} {{");

            int offset = 0;

            using (new IndentContext(writer)) {
                int counter = 0;
                foreach (var function in _cppClass.CollectFunctions())
                {
                    writer.Write($"[FieldOffset({offset})] ");
                    writer.WriteLine($"public IntPtr {function.Name}_{counter++:D3};");

                    offset += 8;
                }
            }

            writer.Write($"[FieldOffset({offset})] ");
            writer.WriteLine($"public IntPtr __SetUPC;");

            writer.WriteLine("}");
        }
    }
}