using CppAst;
using GCore.Source;
using GCore.Source.Generators;

namespace WrapperGenerator.CPP.PluginWrapper.Header
{
    public class CPP_PW_H_Field : SourceElement
    {
        private CppField _cppField;
        public CPP_PW_H_Field(SourceElement? parent, CppField cppField) : base(parent, cppField.Name)
        {
            _cppField = cppField;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"// field {_cppField.Name}");
        }
    }
}