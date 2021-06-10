using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.UnmanagedPointerCollection
{
    public class CS_UPC_Class : SourceElement
    {
        public static readonly string ClassName = "UnmanagedPointerCollection";

        private CppClass _cppClass;

        public CS_UPC_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name) {
            _cppClass = cppClass;
        }

        public override void Render(CodeWriter writer) {
            writer.WriteLine($"[StructLayout(LayoutKind.Sequential)]");
            writer.WriteLine($"public unsafe struct {ClassName} {{");
            using (new IndentContext(writer)) {
                int counter = 0;
                foreach (var function in _cppClass.CollectFunctions()) {
                    writer.WriteLine($"public IntPtr {function.Name}_{counter++:D3};");
                }

                writer.WriteLine("public IntPtr PluginInstance;");
            }
            writer.WriteLine("}");
        }
    }
}