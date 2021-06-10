using System;
using System.Linq;
using GCore.Source.Extensions;

namespace WrapperGenerator.Helper
{
    public static class StringExtensions
    {
        public static string TrimLines(this string self)
        {
            return string.Join(Environment.NewLine, self.SplitNewLine().Select(l => l.Trim()));
        }

        public static string NormalizeNameCS(this string self)
        {
            if (self == "out")
                return self + "_";
            return self;
        }
    }
}