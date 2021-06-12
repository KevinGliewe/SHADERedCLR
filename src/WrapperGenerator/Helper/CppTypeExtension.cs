using System;
using ClangSharp;
using CppAst;

namespace WrapperGenerator.Helper
{
    public static class CppTypeExtension
    {
        public static string GetFullyQualified(this CppType self, string name = null)
        {
            if (self is CppEnum cppEnum)
                return self.GetCppNamespace() + "::" + cppEnum.Name;

            if (self is CppPointerType cppPointer)
                return cppPointer.ElementType.GetFullyQualified() + "*";

            if (self is CppPrimitiveType cppPrimitive)
                return cppPrimitive.ToString();

            if (self is CppReferenceType cppReference)
            {
                if (cppReference.ElementType is CppArrayType cppArray)
                    if (name is null)
                        return cppArray.ElementType.GetFullyQualified() + "*";
                    else
                        return $"{cppArray.ElementType.GetFullyQualified()} (&{name})[{cppArray.Size}]";
                return cppReference.ElementType.GetFullyQualified() + "&";
            }

            if (self is CppClass cppClass)
                return self.GetCppNamespace() + "::" + cppClass.Name;

            if (self is CppTypedef cppTypedef)
                return cppTypedef.Name;

            var ns = self.GetCppNamespace();
            if (ns.Length > 0)
                ns += "::";

            return ns + self;
        }

        public static string GetFullyQualifiedCS(this CppType self, string name = null) {
            if (self is CppEnum cppEnum)
                return "PluginManager." + cppEnum.Name;

            if (self is CppPointerType cppPointer)
                return "IntPtr";

            if (self is CppPrimitiveType cppPrimitive)
                return cppPrimitive.Kind switch
                {
                    CppPrimitiveKind.Void => "void",
                    CppPrimitiveKind.Bool => "bool",
                    CppPrimitiveKind.WChar => "char",
                    CppPrimitiveKind.Char => "char",
                    CppPrimitiveKind.Short => "Int16",
                    CppPrimitiveKind.Int => "Int32",
                    CppPrimitiveKind.LongLong => "Int64",
                    CppPrimitiveKind.UnsignedChar => "char",
                    CppPrimitiveKind.UnsignedShort => "UInt16",
                    CppPrimitiveKind.UnsignedInt => "UInt32",
                    CppPrimitiveKind.UnsignedLongLong => "UInt64",
                    CppPrimitiveKind.Float => "float",
                    CppPrimitiveKind.Double => "double",
                    _ => throw new Exception(cppPrimitive.Kind + " not defined!")
                };

            if (self is CppReferenceType cppReference)
                return cppReference.ElementType.GetFullyQualifiedCS(name);

            if (self is CppArrayType cppArray)
                return "IntPtr";

            if (self is CppClass cppClass)
                return cppClass.Name;

            if (self is CppTypedef cppTypedef)
                return cppTypedef.ElementType.GetFullyQualifiedCS(name);

            return self.ToString();
        }
    }
}