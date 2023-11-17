using Microsoft.VisualBasic;
using System.CodeDom.Compiler;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace Plugin.Other
{
    class Compiler
    {
        public static bool Compile(string EXE_Name, string Source, bool obfuscator)
        {
            CodeDomProvider Compiler = CodeDomProvider.CreateProvider("CSharp");
            CompilerParameters Parameters = new CompilerParameters();
            CompilerResults cResults = default(CompilerResults);

            Parameters.GenerateExecutable = true;
            Parameters.OutputAssembly = EXE_Name;
            Parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll");
            Parameters.ReferencedAssemblies.Add("System.dll");
            Parameters.ReferencedAssemblies.Add("System.Data.dll");
            Parameters.ReferencedAssemblies.Add("System.Xml.dll");
            Parameters.CompilerOptions = " /target:winexe";
            Parameters.TreatWarningsAsErrors = false;
            cResults = Compiler.CompileAssemblyFromSource(Parameters, Source);

            if (cResults.Errors.Count > 0)
            {
                foreach (CompilerError CompilerError_loopVariable in cResults.Errors)
                {
                    CompilerError error = CompilerError_loopVariable;
                    MessageBox.Show("Error: " + error.ErrorText + " Line : " + error.Line, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            else if (cResults.Errors.Count == 0)
            {
               // if (obfuscator == true)
               // {
               //     Confuser(EXE_Name, EXE_Name);
               // }

                MessageBox.Show("Build Successfully " + EXE_Name, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Build Successfully " + EXE_Name, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }


    }
}
