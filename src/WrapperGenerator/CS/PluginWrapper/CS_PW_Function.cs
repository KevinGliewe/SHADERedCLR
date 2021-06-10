using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Function : SourceElement
    {
        private CppFunction _cppFunction;
        private int _counter;
        public CS_PW_Function(SourceElement? parent, CppFunction cppFunction,int counter) : base(parent, cppFunction.Name) {
            _cppFunction = cppFunction;
            _counter = counter;
        }

        public override void Render(CodeWriter writer) {
            writer.WriteLine($"// function {_cppFunction.Name}");
        }
    }
}