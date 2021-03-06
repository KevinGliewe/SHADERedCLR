using System;
using System.Linq;
using System.Text;
using CppAst;

namespace WrapperGenerator.Helper
{
    public static class CppFunctionExtension
    {
        public static bool HasReturnValue(this CppFunction self)
        {
            return self.ReturnType.SizeOf > 0;
        }

        public static string GetDefaultReturnData(this CppFunction self)
        {
            if (self.ReturnType.TypeKind == CppTypeKind.Pointer)
                return "nullptr";

            if (self.ReturnType is CppEnum cppEnum)
                return $"({cppEnum.GetFullyQualified()})0";

            return "0";
        }

        public static string GetDefaultReturnDataCS(this CppFunction self) {
            if (self.ReturnType.TypeKind == CppTypeKind.Pointer)
                return "IntPtr.Zero";

            if (self.ReturnType is CppEnum cppEnum)
                return $"({cppEnum.GetFullyQualifiedCS()})0";

            if (self.ReturnType is CppPrimitiveType cppPrimitive)
            {
                return cppPrimitive.Kind switch
                {
                    CppPrimitiveKind.Bool => "false",
                    CppPrimitiveKind.Int => "0",
                    CppPrimitiveKind.UnsignedInt => "0",
                    CppPrimitiveKind.Float => "0",
                    _ => throw new Exception(cppPrimitive.Kind + " is not implemented!"),
                };
            }

            return "0";
        }

        public static string GetFunctionPointerDefinition(this CppFunction self, string name = "*")
        {
            // (const char*(*)(ed::plugin::VariableType, int))

            var sb = new StringBuilder();

            sb.Append("(");
            sb.Append(self.ReturnType.GetFullyQualified());
            sb.Append("(");
            sb.Append(name);
            sb.Append(")(");
            sb.Append(string.Join(", ", self.Parameters.Select(p => p.Type.GetFullyQualified())));
            sb.Append("))");

            return sb.ToString();
        }

        public static string GetDelegateDefinitionCS(this CppFunction self, string name = null)
        {
            var sb = new StringBuilder();

            var delName = name is null ? self.Name + "Delegate" : name;

            sb.Append($"delegate ");
            sb.Append(self.ReturnType.GetFullyQualifiedCS());
            sb.Append(" ");
            sb.Append(delName);
            sb.Append("(");
            sb.Append(string.Join(", ", self.Parameters.Select(p => p.GetFullyQualifiedCS())));
            sb.Append(")");
            return sb.ToString();
        }
    }
}