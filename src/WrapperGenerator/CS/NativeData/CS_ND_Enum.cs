using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.NativeEnums
{
    public class CS_ND_Enum : SourceElement
    {
        private CppEnum _cppEnum;

        public CS_ND_Enum(SourceElement? parent, CppEnum cppEnum) : base(parent, cppEnum.Name)
        {
            _cppEnum = cppEnum;
            Indent = 4;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine("// " + _cppEnum.GetFullyQualified());
            writer.WriteLine($"public enum {_cppEnum.Name} {{");

            using (new IndentContext(writer))
            {
                foreach (var item in _cppEnum.Items)
                {
                    writer.WriteLine($"{item.Name} = {item.Value},");
                }
            }

            writer.WriteLine("}");
        }
    }
}