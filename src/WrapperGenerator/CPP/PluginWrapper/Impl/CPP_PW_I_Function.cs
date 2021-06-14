using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CPP.PluginWrapper.Impl
{
    public class CPP_PW_I_Function : SourceElement
    {
        private CppFunction _cppFunction;
        private string _className;
        private int _counter;

        private static readonly string MCP = "this->m_pMPC";
        public CPP_PW_I_Function(SourceElement? parent, CppFunction cppFunction, string className, int counter) : base(parent, cppFunction.Name)
        {
            _cppFunction = cppFunction;
            _className = className;
            _counter = counter;

            Indent = 4;
        }

        public override void Render(CodeWriter writer)
        {
            var pointerMember = $"{MCP}.{_cppFunction.Name}_{_counter:D3}";

            writer.Write(_cppFunction.ReturnType.GetFullyQualified());
            writer.Write(' ');
            writer.Write(_className);
            writer.Write("::");
            writer.Write(_cppFunction.Name);
            writer.Write('(');
            writer.Write(string.Join(", ", _cppFunction.Parameters.Select(p => p.GetFullyQualified())));
            writer.WriteLine(") {");

            using (new IndentContext(writer, this.Indent))
            {
                //writer.WriteLine($"assert({MCP});");

                if (_cppFunction.Name == "Init")
                {
                    writer.WriteLine("this->InitUPC();");
                    writer.WriteLine($"((void(*)(UnmanagedPointerCollection))this->m_pMPC.__SetUPC)(this->m_sUPC);");
                }

                writer.WriteLine($"if(!{pointerMember})");

                if (_cppFunction.HasReturnValue())
                    writer.WriteLine($"    return {_cppFunction.GetDefaultReturnData()};");
                else
                    writer.WriteLine("    return;");


                // return ((const char*(*)(ed::plugin::VariableType, int))(this->m_pMPC->SystemVariables_GetName_023))(varType, index);

                if (_cppFunction.HasReturnValue())
                    writer.Write("return ");

                writer.Write("(");
                writer.Write(_cppFunction.GetFunctionPointerDefinition());
                writer.Write(pointerMember);
                writer.Write(")(");
                writer.Write(string.Join(", ", _cppFunction.Parameters.Select(p => p.Name)));
                writer.Write(");");

                writer.WriteLine();


                //if (_cppFunction.HasReturnValue)
                //    wr()iter.WriteLine($"return {_cppFunction.GetDefaultReturnData()};");
            }

            writer.WriteLine($"}} // Function {_cppFunction.Name}");
        }
    }
}