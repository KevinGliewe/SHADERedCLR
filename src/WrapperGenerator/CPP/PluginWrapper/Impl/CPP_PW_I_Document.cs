using System.Linq;
using ClangSharp;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.CPP.PluginWrapper.Header;

namespace WrapperGenerator.CPP.PluginWrapper.Impl
{
    public class CPP_PW_I_Document : SourceElement
    {
        private CppCompilation Compilation;

        public CPP_PW_I_Document(SourceElement? parent, CppCompilation compilation) : base(parent, "CPP_PW_I_Document")
        {
            
            Compilation = compilation;
            var cppClass = compilation.Namespaces[0].Classes.Last();
            this.Add(new CPP_PW_I_Plugin(this, cppClass));
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine("#include \"pch.h\"");
            writer.WriteLine("#include <assert.h>");
            writer.WriteLine($"#include \"{CPP_PW_H_Plugin.ClassName}.h\"");
            writer.WriteLine();

            base.Render(writer);
        }
    }
}