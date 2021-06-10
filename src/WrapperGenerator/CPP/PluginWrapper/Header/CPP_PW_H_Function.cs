using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CPP.PluginWrapper.Header
{
    public class CPP_PW_H_Function : SourceElement
    {
        private CppFunction _cppFunction;
        public CPP_PW_H_Function(SourceElement? parent, CppFunction cppFunction) : base(parent, cppFunction.Name)
        {
            _cppFunction = cppFunction;
        }

        public override void Render(CodeWriter writer)
        {
            //writer.Write("virtual ");
            writer.Write(_cppFunction.ReturnType.GetFullyQualified());
            writer.Write(' ');
            writer.Write(_cppFunction.Name);
            writer.Write('(');
            writer.Write(string.Join(", ", _cppFunction.Parameters.Select(p => p.GetFullyQualified())));
            writer.WriteLine(") override;");

            //writer.WriteLine($"// Function {_cppFunction.Name}");
        }
    }
}