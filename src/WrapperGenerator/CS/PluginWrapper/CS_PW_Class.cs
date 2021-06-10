using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Class : SourceElement
    {
        private CppClass _cppClass;

        public static readonly string ClassName = "PluginWrapper";

        public CS_PW_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name) {
            _cppClass = cppClass;
            Indent = 4;

            int counter = 0;
            foreach (var field in _cppClass.CollectFields())
            {
                this.Add(new CS_PW_Field(this, field, counter++));
            }

            counter = 0;
            foreach (var cppFunction in cppClass.CollectFunctions().Where(f => f.Name != "GetVersion")) {
                this.Add(new CS_PW_Function(this, cppFunction, counter++));
            }
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"public partial class {ClassName} {{");
            base.Render(writer);

            using (new IndentContext(writer))
            {
                writer.WriteLine(
                    "protected void InitDelegates(PluginManager.InteropData.ManagedPointerCollection a_MPC) {");

                using (new IndentContext(writer))
                {
                    var counter = 0;
                    foreach (var field in _cppClass.CollectFields())
                    {
                        var typedefType = field.Type as CppTypedef;
                        if (typedefType != null)
                        {


                            var ptrType = typedefType.ElementType as CppPointerType;
                            if (ptrType.ElementType is CppFunctionType funcType)
                            {
                                var delegateType = $"{field.Name}Delegate";
                                writer.Write($"this.{field.Name} = ({delegateType})");
                                writer.Write("Marshal.GetDelegateForFunctionPointer(");
                                writer.WriteLine($"a_MPC.{field.Name}_{counter:D3},typeof({delegateType}));");
                            }
                        }

                        counter++;
                    }
                }

                writer.WriteLine("}");
            }


            writer.WriteLine("}");
        }
    }
}