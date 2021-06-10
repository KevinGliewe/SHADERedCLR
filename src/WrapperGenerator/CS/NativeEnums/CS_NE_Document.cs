using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.CS.PluginWrapper;

namespace WrapperGenerator.CS.NativeEnums
{
    public class CS_NE_Document : SourceElement
    {
        private CppCompilation Compilation;

        public CS_NE_Document(SourceElement? parent, CppCompilation compilation) : base(parent, "CS_PW_Document") {

            Compilation = compilation;
            foreach (var cppEnum in Compilation.Namespaces[0].Namespaces[0].Enums)
            {
                this.Add(new CS_NE_Enum(this, cppEnum));
            }
        }

        public override void Render(CodeWriter writer) {
            writer.WriteLine("using System;");
            writer.WriteLine();
            writer.WriteLine("namespace PluginManager {");
            using(new IndentContext(writer))
                base.Render(writer);
            writer.WriteLine("}");
        }
    }
}