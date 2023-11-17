using dnlib.DotNet;
using PEGASUS.Design.RenamingObfuscation.Classes;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation
{
    public class Renaming
    {
        public static ModuleDefMD DoRenaming(ModuleDefMD inPath)
        {
            var module = inPath;
            return RenamingObfuscation(inPath);
        }

        private static ModuleDefMD RenamingObfuscation(ModuleDefMD inModule)
        {
            var module = inModule;

            IRenaming rnm = new NamespacesRenaming();

            module = rnm.Rename(module);

            rnm = new ClassesRenaming();

            module = rnm.Rename(module);

            rnm = new MethodsRenaming();

            module = rnm.Rename(module);

            rnm = new PropertiesRenaming();

            module = rnm.Rename(module);

            rnm = new FieldsRenaming();

            module = rnm.Rename(module);

            return module;
        }
    }
}