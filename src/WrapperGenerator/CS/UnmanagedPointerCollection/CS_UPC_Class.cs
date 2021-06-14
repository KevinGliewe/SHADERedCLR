using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.UnmanagedPointerCollection
{
    public class CS_UPC_Class : SourceElement
    {
        public static readonly string ClassName = "UnmanagedPointerCollection";

        private CppClass _cppClass;

        public CS_UPC_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name)
        {
            _cppClass = cppClass;
        }

        public override void Render(CodeWriter writer)
        {
            int offset = 0;

            writer.WriteLine($"[StructLayout(LayoutKind.Explicit)]");
            writer.WriteLine($"public unsafe struct {ClassName} {{");
            using (new IndentContext(writer))
            {
                int counter = 0;
                foreach (var field in _cppClass.CollectFields())
                {
                    writer.Write($"[FieldOffset({offset})] ");
                    writer.WriteLine($"public IntPtr {field.Name}_{counter++:D3};");
                    offset += 8;
                }

                writer.Write($"[FieldOffset({offset})] ");
                writer.WriteLine("public IntPtr PluginInstance;");
            }
            writer.WriteLine("}");
        }
    }
}