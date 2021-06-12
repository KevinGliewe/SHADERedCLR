using System.Linq;
using ClangSharp;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.CPP.PluginWrapper.Header;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CPP.PluginWrapper.Impl
{
    public class CPP_PW_I_Plugin : SourceElement
    {
        private CppClass _cppClass;

        public CPP_PW_I_Plugin(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name)
        {
            _cppClass = cppClass;
            int counter = 0;

            foreach (var cppFunction in cppClass.CollectFunctions())
            {
                this.Add(new CPP_PW_I_Function(this, cppFunction, CPP_PW_H_Plugin.ClassName, counter++));
            }
        }

        public override void Render(CodeWriter writer)
        {
            base.Render(writer);

            writer.WriteLine();

            int counter = 0;
            writer.WriteLine($"void {CPP_PW_H_Plugin.ClassName}::InitUPC() {{");
            using (new IndentContext(writer))
            {
                foreach (var field in _cppClass.CollectFields()) {
                    writer.WriteLine($"m_sUPC.{field.Name}_{counter++:D3} = (void*)(this->{field.Name});");
                }

                writer.WriteLine("m_sUPC.PluginInstance = (void*)this;");
            }
            writer.WriteLine("}");

            writer.WriteLine();

            writer.WriteLine(
                $"{CPP_PW_H_Plugin.ClassName}::{CPP_PW_H_Plugin.ClassName}(ManagedPointerCollection* a_pMPC) {{");
            using (new IndentContext(writer))
            {
                writer.WriteLine("this->m_pMPC = a_pMPC;");
            }
            writer.WriteLine("}");
            writer.WriteLine();

            writer.WriteLine(
                $"{CPP_PW_H_Plugin.ClassName}::~{CPP_PW_H_Plugin.ClassName}() {{");
            using (new IndentContext(writer)) {
            }
            writer.WriteLine("}");
        }
    }
}