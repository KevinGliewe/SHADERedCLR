using System.Linq;
using System.Text;
using CppAst;

namespace WrapperGenerator.Helper
{
    public static class CppFunctionTypeExtension
    {
        public static string GetDelegateDefinitionCS(this CppFunctionType self, string name) {
            var sb = new StringBuilder();

            sb.Append($"delegate ");
            sb.Append(self.ReturnType.GetFullyQualifiedCS());
            sb.Append(" ");
            sb.Append(name);
            sb.Append("(");
            sb.Append(string.Join(", ", self.Parameters.Select(p => p.GetFullyQualifiedCS())));
            sb.Append(")");
            return sb.ToString();
        }
    }
}