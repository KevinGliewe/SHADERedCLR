using System.Collections.Generic;
using CppAst;
using CppFunction = CppAst.CppFunction;

namespace WrapperGenerator.Helper
{
    public static class CppClassExtension
    {
        public static IEnumerable<CppFunction> CollectFunctions(this CppClass self)
        {
            foreach (var baseType in self.BaseTypes) {
                if (baseType.Type is CppClass baseClass) {
                    foreach (var collectMethod in baseClass.CollectFunctions()) {
                        yield return collectMethod;
                    }
                }
            }
            
            foreach (var function in self.Functions)
            {
                if(function.Name != "GetVersion")
                    yield return function;
            }
        }

        public static IEnumerable<CppField> CollectFields(this CppClass self) {
            foreach (var baseType in self.BaseTypes) {
                if (baseType.Type is CppClass baseClass) {
                    foreach (var collectField in baseClass.CollectFields()) {
                        yield return collectField;
                    }
                }
            }

            foreach (var function in self.Fields) {
                yield return function;
            }
        }
    }
}