using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.CPP.PluginWrapper.Header;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Document : SourceElement
    {
        private CppCompilation Compilation;

        public CS_PW_Document(SourceElement? parent, CppCompilation compilation) : base(parent, "CS_PW_Document") {

            Compilation = compilation;
            Indent = 4;
            var cppClass = compilation.Namespaces[0].Classes.Last();
            this.Add(new CS_PW_Class(this, cppClass));
        }

        public override void Render(CodeWriter writer) {
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Runtime.InteropServices;");
            writer.WriteLine();
            writer.WriteLine("namespace SHADERedCLR.Wrapper {");
            base.Render(writer);
            writer.WriteLine("}");
        }
    }
}