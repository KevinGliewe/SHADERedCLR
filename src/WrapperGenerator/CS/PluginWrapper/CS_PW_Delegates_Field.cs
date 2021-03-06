using System;
using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Delegates_Field : SourceElement
    {
        private CppField _cppField;
        private int _counter;
        public CS_PW_Delegates_Field(SourceElement? parent, CppField cppField, int counter) : base(parent, cppField.Name) {
            _cppField = cppField;
            _counter = counter;
        }

        public override void Render(CodeWriter writer) {
            //writer.WriteLine($"// field {_cppField.Name}");

            var ptrTypedef = _cppField.Type as CppTypedef;

            if (ptrTypedef is null)
                return;

            var ptrType = ptrTypedef.ElementType as CppPointerType;

            if (ptrType is null)
                throw new Exception(_cppField + " is not a CppPointerType!");

            if (ptrType.ElementType is CppFunctionType funcType)
            {
                var delegateType = $"{_cppField.Name}Delegate";

                writer.WriteLine($"public {funcType.GetDelegateDefinitionCS(delegateType)};");
            }
            else throw new Exception(_cppField + " Type not supported!");


        }
    }
}