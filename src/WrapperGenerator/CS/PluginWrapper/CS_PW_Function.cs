using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
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

        public override void Render(CodeWriter writer)
        {
            var delegateType = $"{_cppFunction.Name}Delegate_{_counter:D3}";

            writer.WriteLine($"// function {_cppFunction.Name}");

            writer.WriteLine($"public {_cppFunction.GetDelegateDefinitionCS(delegateType)};");

            writer.Write("public virtual ");
            writer.Write(_cppFunction.ReturnType.GetFullyQualifiedCS());
            writer.Write(" ");
            writer.Write(_cppFunction.Name);
            writer.Write("(");
            writer.Write(string.Join(", ", _cppFunction.Parameters.Select(p => p.GetFullyQualifiedCS())));
            writer.WriteLine(") {");

            using (new IndentContext(writer))
            {
                if (_cppFunction.HasReturnValue())
                {
                    writer.WriteLine("return " + _cppFunction.GetDefaultReturnDataCS() + ";");
                }
            }

            writer.WriteLine("}");
        }
    }
}