using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CppAst;
using GCore.Extensions.ObjectEx;
using GCore.Source.Generators.Extensions;
using WrapperGenerator.CPP.PluginWrapper.Header;
using WrapperGenerator.CPP.PluginWrapper.Impl;
using WrapperGenerator.CS.UnmanagedPointerCollection;
using WrapperGenerator.CS.NativeEnums;
using WrapperGenerator.CS.PluginWrapper;
using WrapperGenerator.CS.ManagedPointerCollection;
using WrapperGenerator.Helper;
using CS_MPC_Document = WrapperGenerator.CS.ManagedPointerCollection.CS_MPC_Document;

namespace WrapperGenerator
{
    class Program
    {

        static void Main(string[] args)
        {

            var repoRoot = Repo.GetRepoRoot();

            var includePath = Path.Combine(repoRoot, "dep/SHADERed/includes/PluginAPI");
            var pluginHeaderFile = Path.Combine(includePath, "Plugin.h");
            var include = Path.Combine(includePath, "PluginData.h");

            var cppOutPath = Path.Join(repoRoot, "src/SHADERedCLR");

            var csOutPath = Path.Join(repoRoot, "src/SHADERedCLR.Wrapper");

            var options = new CppParserOptions()
            {
                IncludeFolders = { includePath }
            };

            // Parse a C++ files
            var compilation = CppParser.ParseFile(pluginHeaderFile, options);
            // Print diagnostic messages
            foreach (var message in compilation.Diagnostics.Messages)
                Console.WriteLine(message);

            var classes = compilation.Namespaces[0].Classes;

            //Console.WriteLine(classes.Dump());

            var cppHeaderCode = new CPP_PW_H_Document(null, compilation).Render();
            var cppImplCode = new CPP_PW_I_Document(null, compilation).Render();

            File.WriteAllText(Path.Combine(cppOutPath, CPP_PW_H_Plugin.ClassName + ".h"), cppHeaderCode);
            File.WriteAllText(Path.Combine(cppOutPath, CPP_PW_H_Plugin.ClassName + ".cpp"), cppImplCode);

            var csMCPCode = new CS.UnmanagedPointerCollection.CS_UPC_Document(null, compilation).Render();
            var csUCPCode = new CS_MPC_Document(null, compilation).Render();

            File.WriteAllText(Path.Combine(csOutPath, "InteropData/" + CS_UPC_Class.ClassName + ".cs"), csMCPCode);
            File.WriteAllText(Path.Combine(csOutPath, "InteropData/" + CS_MPC_Class.ClassName + ".cs"), csUCPCode);

            var csNDCode = new CS_ND_Document(null, compilation).Render();
            File.WriteAllText(Path.Combine(csOutPath, "NativeData.cs"), csNDCode);

            var csPWCode = new CS_PW_Document(null, compilation).Render();
            File.WriteAllText(Path.Combine(csOutPath, CS_PW_Class.ClassName + ".gen.cs"), csPWCode);

            //Console.WriteLine(cppHeaderCode);
            //Console.WriteLine(cppImplCode);
        }
    }
}
