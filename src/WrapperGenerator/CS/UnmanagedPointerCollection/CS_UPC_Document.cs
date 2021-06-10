using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;

namespace WrapperGenerator.CS.UnmanagedPointerCollection
{
    public class CS_UPC_Document : SourceElement
    {
        private CppCompilation Compilation;

        public CS_UPC_Document(SourceElement? parent, CppCompilation compilation) : base(parent, "CS_UPC_Document") {
            Indent = 4;
            Compilation = compilation;
            var cppClass = compilation.Namespaces[0].Classes.Last();
            this.Add(new CS_UPC_Class(this, cppClass));
        }

        public override void Render(CodeWriter writer) {

            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine("namespace PluginManager.InteropData {");
            base.Render(writer);
            writer.WriteLine("}");
        }
    }
}