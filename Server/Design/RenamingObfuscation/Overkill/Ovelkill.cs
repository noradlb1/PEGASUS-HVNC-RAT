using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Writer;
using PEGASUS.Design.RenamingObfuscation.Overkill.Protections;

namespace PEGASUS.Design.RenamingObfuscation.Overkill
{
    internal class Ovelkill
    {
#pragma warning disable CS0649 // Field 'Ovelkill.ManifestModule' is never assigned to, and will always have its default value null
        public ModuleDef ManifestModule;
#pragma warning restore CS0649 // Field 'Ovelkill.ManifestModule' is never assigned to, and will always have its default value null
        public static ModuleDefMD Module { get; set; }

        public static string FileExtension { get; set; }

        public static bool DontRename { get; set; }

        public static bool ForceWinForms { get; set; }

        public static string FilePath { get; set; }

        public static void fatality(string path)
        {
            Console.WriteLine("Drag n drop your file : ");
            Module = ModuleDefMD.Load(path);
            FileExtension = Path.GetExtension(path);

            Console.WriteLine("Encrypting strings..."); //works
            StringEncryption.Execute();


            Console.WriteLine("Renaming..."); //works
            Renamer.Execute();


            //Console.WriteLine("Adding ints...");
            //AddInteger.Execute();


            Console.WriteLine("Encoding ints..."); //works
            IntEncoding.Execute();


            Console.WriteLine("Injecting ControlFlow..."); //works
            ControlFlow.Execute();


            Console.WriteLine("Injecting local to fields..."); //works
            L2F.Execute();


            Console.WriteLine("Adding Proxys..."); //works
            ProxyInts.Execute();


            Console.WriteLine("Injecting AntiDe4Dot..."); //works
            AntiDe4Dot.Execute();


            Console.WriteLine("Saving file...");
            var pathez = $"{path}-Obfuscated.exe";
            var opts = new ModuleWriterOptions(Module) {Logger = DummyLogger.NoThrowInstance};
            Module.Write(pathez, opts);


            // Console.WriteLine("Done! Press any key to exit...");
            // Console.ReadKey();
        }
    }
}