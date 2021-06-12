using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.NativeEnums
{
    public class CS_ND_Struct : SourceElement
    {
        private CppClass _cppClass;

        public CS_ND_Struct(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name)
        {
            _cppClass = cppClass;
            Indent = 4;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine("[StructLayout(LayoutKind.Sequential)]");
            writer.WriteLine($"public unsafe struct {_cppClass.Name} {{");

            using (new IndentContext(writer))
            {
                foreach (var field in _cppClass.Fields)
                {
                    writer.WriteLine($"// {field.Name} - {field.Type.GetFullyQualifiedCS()}");
                }
            }

            writer.WriteLine("}");
        }
    }
}