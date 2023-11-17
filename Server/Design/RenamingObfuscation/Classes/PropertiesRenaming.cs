using dnlib.DotNet;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
    public class PropertiesRenaming : IRenaming
    {
        public ModuleDefMD Rename(ModuleDefMD module)
        {
            var moduleToRename = module;

            foreach (var type in moduleToRename.GetTypes())
            {
                if (type.IsGlobalModuleType)
                    continue;

                foreach (var property in type.Properties) property.Name = Utils.GenerateRandomString();
            }

            return moduleToRename;
        }
    }
}