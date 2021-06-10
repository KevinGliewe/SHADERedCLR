using CppAst;
using GCore.Source;
using GCore.Source.Generators;

namespace WrapperGenerator.CPP.PluginWrapper.Impl
{
    public class CPP_PW_I_Field : SourceElement
    {
        private CppField _cppField;
        public CPP_PW_I_Field(SourceElement? parent, CppField cppField) : base(parent, cppField.Name)
        {
            _cppField = cppField;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"// field {_cppField.Name}");
        }
    }
}