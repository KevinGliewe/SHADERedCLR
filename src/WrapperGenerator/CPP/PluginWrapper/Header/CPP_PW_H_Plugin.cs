using System.Linq;
using ClangSharp;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CPP.PluginWrapper.Header
{
    public class CPP_PW_H_Plugin : SourceElement
    {
        private CppClass _cppClass;

        public static readonly string ClassName = "PluginWrapper";

        public CPP_PW_H_Plugin(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name)
        {
            _cppClass = cppClass;

            foreach (var cppFunction in cppClass.CollectFunctions().Where( f => f.Name != "GetVersion"))
            {
                this.Add(new CPP_PW_H_Function(this, cppFunction));
            }

            Indent = 4;
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"class {ClassName} : public ed::{_cppClass.Name} {{");
            writer.WriteLine("public:");

            using (new IndentContext(writer))
            {
                int counter = 0;

                writer.WriteLine("struct UnmanagedPointerCollection {");
                using (new IndentContext(writer))
                {
                    foreach (var field in _cppClass.CollectFields())
                    {
                        writer.WriteLine($"void* {field.Name}_{counter++:D3} = nullptr;");
                    }

                    writer.WriteLine("void* PluginInstance = nullptr;");
                }
                writer.WriteLine("};");

                counter = 0;
                writer.WriteLine("struct ManagedPointerCollection {");
                using (new IndentContext(writer)) {
                    foreach (var func in _cppClass.CollectFunctions().Where(f => f.Name != "GetVersion")) {
                        writer.WriteLine($"void* {func.Name}_{counter++:D3} = nullptr;");
                    }
                }
                writer.WriteLine("};");

                writer.WriteLine(@"

                UnmanagedPointerCollection  m_sUPC;
                ManagedPointerCollection*   m_pMPC;

                unsigned int m_uManagedInstance = 0;

                void InitUPC();
                ".TrimLines());

                writer.WriteLine($"{ClassName}(ManagedPointerCollection* a_pMPC, unsigned int a_uManagedInstance);");
                writer.WriteLine($"~{ClassName}();");
            }


            base.Render(writer);


            writer.WriteLine($"}}; // class {ClassName}");
        }
    }
}