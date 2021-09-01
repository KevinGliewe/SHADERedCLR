using System.Linq;
using CppAst;
using GCore.Source;
using GCore.Source.CodeContexts;
using GCore.Source.Generators;
using GCore.Source.Generators.CSharp;
using GCore.Source.Generators.CSharp.Elements;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.Helper;

namespace WrapperGenerator.CS.PluginWrapper
{
    public class CS_PW_Class : SourceElement
    {
        private CppClass _cppClass;

        public static readonly string ClassName = "PluginWrapper";
        public static readonly string DelegatesClassName = "Delegates";

        public CS_PW_Class(SourceElement? parent, CppClass cppClass) : base(parent, cppClass.Name) {
            _cppClass = cppClass;
            Indent = 4;

            var delegates = new CSharpClass(this, DelegatesClassName, null)
            {
                Modifier = CSharpModifier.Public
            };

            this.Add(delegates);

            int counter = 0;
            foreach (var field in _cppClass.CollectFields())
            {
                delegates.Add(new CS_PW_Delegates_Field(delegates, field, counter));
                this.Add(new CS_PW_Field(this, field, counter++));
            }

            counter = 0;
            foreach (var cppFunction in cppClass.CollectFunctions())
            {
                delegates.Add(new CS_PW_Delegates_Function(delegates, cppFunction, counter));
                this.Add(new CS_PW_Function(this, cppFunction, counter++));
            }
        }

        public override void Render(CodeWriter writer)
        {
            writer.WriteLine($"public partial class {ClassName} {{");
            base.Render(writer);

            using (new IndentContext(writer))
            {
                writer.WriteLine(
                    "protected void __SetDelegates(SHADERedCLR.Wrapper.InteropData.UnmanagedPointerCollection a_UPC) {");

                using (new IndentContext(writer))
                {
                    var counter = 0;
                    foreach (var field in _cppClass.CollectFields())
                    {
                        var typedefType = field.Type as CppTypedef;
                        if (typedefType != null)
                        {


                            var ptrType = typedefType.ElementType as CppPointerType;
                            if (ptrType.ElementType is CppFunctionType funcType)
                            {
                                var upcMember = $"a_UPC.{field.Name}_{counter:D3}";
                                var delegateType = $"{CS_PW_Class.DelegatesClassName}.{field.Name}Delegate";
                                writer.WriteLine($"if({upcMember} != IntPtr.Zero)");
                                writer.Write("    ");
                                writer.Write($"this.{field.Name} = ({delegateType})");
                                writer.Write("Marshal.GetDelegateForFunctionPointer(");
                                writer.WriteLine($"{upcMember},typeof({delegateType}));");
                            }
                        }

                        counter++;
                    }
                }

                writer.WriteLine("}");

                writer.WriteLine(
                    "protected SHADERedCLR.Wrapper.InteropData.ManagedPointerCollection __GetFunctionPointers() {");

                using (new IndentContext(writer))
                {
                    writer.WriteLine("var mpc = new SHADERedCLR.Wrapper.InteropData.ManagedPointerCollection();");

                    var counter = 0;
                    foreach (var function in _cppClass.CollectFunctions()) {
                        if(function.Name == "GetVersion")
                            continue;

                        //if (this.GetType().GetMethod("Init", new Type[] { typeof(bool), typeof(Int32) }).DeclaringType != typeof(PluginWrapper))
                        //{
                        //    __delegates.Init_000 = new Delegates.InitDelegate_000(this.Init);
                        //    mpc.Init_000 = Marshal.GetFunctionPointerForDelegate(__delegates.Init_000);
                        //}
                        //else mpc.Init_000 = IntPtr.Zero;

                        var delegateType = $"{DelegatesClassName}.{function.Name}Delegate_{counter:D3}";
                        var delegateField = $"__delegates.{function.Name}_{counter:D3}";
                        var upcMember = $"{function.Name}_{counter:D3}";

                        writer.Write($"if (this.GetType().GetMethod(\"{function.Name}\", new Type[] {{");
                        writer.Write(string.Join(", ", function.Parameters.Select(p => $"typeof({p.Type.GetFullyQualifiedCS()})")));
                        writer.WriteLine(" }).DeclaringType != typeof(PluginWrapper)) {");

                        using (new IndentContext(writer))
                        {
                            writer.WriteLine($"{delegateField} = new {delegateType}(this.{function.Name});");

                            writer.Write("mpc.");
                            writer.Write(upcMember);
                            writer.WriteLine($" = Marshal.GetFunctionPointerForDelegate({delegateField});");
                        }

                        writer.WriteLine($"}} else mpc.{upcMember} = IntPtr.Zero;");
                        writer.WriteLine();

                        counter++;
                    }
                    writer.WriteLine("return mpc;");
                }

                writer.WriteLine("}");
            }


            writer.WriteLine("}");
        }
    }
}