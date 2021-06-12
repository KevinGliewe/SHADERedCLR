using System;
using System.Linq;
using GCore.Source.Extensions;

namespace WrapperGenerator.Helper
{
    public static class StringExtensions
    {
        public static string[] ReservedKeywords = new string[]
        {
            "abstract",
            "as",
            "base",
            "bool",
            "break",
            "byte",
            "case",
            "catch",
            "char",
            "checked",
            "class",
            "const",
            "continue",
            "decimal",
            "default",
            "delegate",
            "do",
            "double",
            "else",
            "enum",
            "event",
            "explicit",
            "extern",
            "false",
            "finally",
            "fixed",
            "float",
            "for",
            "foreach",
            "goto",
            "if",
            "implicit",
            "in",
            "int",
            "interface",
            "internal",
            "is",
            "lock",
            "long",
            "namespace",
            "new",
            "null",
            "object",
            "operator",
            "out",
            "override",
            "params",
            "private",
            "protected",
            "public",
            "readonly",
            "ref",
            "return",
            "sbyte",
            "sealed",
            "short",
            "sizeof",
            "stackalloc",
            "static",
            "string",
            "struct",
            "switch",
            "this",
            "throw",
            "true",
            "try",
            "typeof",
            "uint",
            "ulong",
            "unchecked",
            "unsafe",
            "ushort",
            "using",
            "virtual",
            "void",
            "volatile",
            "while",
        };

        public static string TrimLines(this string self)
        {
            return string.Join(Environment.NewLine, self.SplitNewLine().Select(l => l.Trim()));
        }

        public static string NormalizeNameCS(this string self)
        {
            foreach (var keyword in ReservedKeywords)
            {
                if (self == keyword)
                    return self + "_";
            }

            return self;
        }
    }
}