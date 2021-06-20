using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Delegates_Function : SourceElement
    {
        private CppFunction _cppFunction;
        private int _counter;
        public CS_PW_Delegates_Function(SourceElement? parent, CppFunction cppFunction,int counter) : base(parent, cppFunction.Name) {
            _cppFunction = cppFunction;
            _counter = counter;
        }

        public override void Render(CodeWriter writer)
        {
            var delegateType = $"{_cppFunction.Name}Delegate_{_counter:D3}";
            var delegateField = $"{_cppFunction.Name}_{_counter:D3}";

            writer.WriteLine($"// function {_cppFunction.Name}");

            writer.WriteLine($"public {_cppFunction.GetDelegateDefinitionCS(delegateType)};");

            writer.WriteLine($"public {delegateType} {delegateField};");
        }
    }
}