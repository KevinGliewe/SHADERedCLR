using System.Linq;
using ClangSharp;
using CppAst;
using GCore.Source;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;

namespace WrapperGenerator.CPP.PluginWrapper.Header
{
    public class CPP_PW_H_Document : SourceElement
    {
        private CppCompilation Compilation;

        public CPP_PW_H_Document(SourceElement? parent, CppCompilation compilation) : base(parent, "CPP_PW_H_Document")
        {
            
            Compilation = compilation;
            var cppClass = compilation.Namespaces[0].Classes.Last();
            this.Add(new CPP_PW_H_Plugin(this, cppClass));
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine("#pragma once");
            writer.WriteLine("#include <PluginAPI/Plugin.h>");
            writer.WriteLine();

            base.Render(writer);
        }
    }
}