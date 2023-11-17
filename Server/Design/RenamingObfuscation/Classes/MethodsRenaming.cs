using dnlib.DotNet;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
    public class MethodsRenaming : IRenaming
    {
        public ModuleDefMD Rename(ModuleDefMD module)
        {
            var moduleToRename = module;

            foreach (var type in moduleToRename.Types)
            {
                if (type.IsGlobalModuleType)
                    continue;
                type.Name = Utils.GenerateRandomString();
                foreach (var method in type.Methods)
                {
                    if (!method.IsSpecialName && !method.IsConstructor && !method.HasCustomAttributes &&
                        !method.IsAbstract && !method.IsVirtual && method.Name != "Main")
                        method.Name = Utils.GenerateRandomString();

                    foreach (var paramDef in method.ParamDefs) paramDef.Name = Utils.GenerateRandomString();
                }
            }

            return moduleToRename;
        }
    }
}