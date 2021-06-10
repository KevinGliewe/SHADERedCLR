using System.Collections.Generic;
using CppAst;

namespace WrapperGenerator.Helper
{
    public static class CppElementExtension
    {
        public static IEnumerable<string> GetNamespace(this ICppElement self)
        {
            if(self is CppElement elem)
                if(elem.Parent is CppElement parent)
                    foreach (var ns in parent.GetNamespace())
                        yield return ns;

            if (self is CppNamespace cppNs)
                yield return cppNs.Name;
        }

        public static string GetCppNamespace(this ICppElement self)
        {
            return string.Join("::", self.GetNamespace());
        }

    }
}