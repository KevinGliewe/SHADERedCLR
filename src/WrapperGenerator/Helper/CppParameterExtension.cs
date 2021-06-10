using CppAst;

namespace WrapperGenerator.Helper
{
    public static class CppParameterExtension
    {
        public static readonly string NAMEPLACEHOLDER =
            "XucPHeISLeFWtwwcQ7WJkqF1EhBKk8ruDZs3aWQCvgudacxp75SdqtnMQLJW7WcjGqsLbCMo6IA2tsnq6OhKuPcxzVSBACqlcIRP";

        public static string GetFullyQualified(this CppParameter self)
        {
            var type = self.Type.GetFullyQualified(NAMEPLACEHOLDER);

            if (type.Contains(NAMEPLACEHOLDER))
            {
                return type.Replace(NAMEPLACEHOLDER, self.Name);
            }

            return type + " " + self.Name;
        }

        public static string GetFullyQualifiedCS(this CppParameter self) {
            var type = self.Type.GetFullyQualifiedCS(NAMEPLACEHOLDER);

            if (type.Contains(NAMEPLACEHOLDER)) {
                return type.Replace(NAMEPLACEHOLDER, self.Name);
            }

            return type + " " + self.Name.NormalizeNameCS();
        }
    }
}