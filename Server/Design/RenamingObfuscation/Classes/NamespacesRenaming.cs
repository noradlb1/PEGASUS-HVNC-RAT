using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
    public class NamespacesRenaming : IRenaming
    {
        private static readonly Dictionary<string, string> _names = new Dictionary<string, string>();

        public ModuleDefMD Rename(ModuleDefMD module)
        {
            var moduleToRename = module;
            moduleToRename.Name = Utils.GenerateRandomString();

            foreach (var type in moduleToRename.GetTypes())
            {
                if (type.IsGlobalModuleType)
                    continue;

                if (type.Namespace == "")
                    continue;

                string nameValue;
                if (_names.TryGetValue(type.Namespace, out nameValue))
                {
                    type.Namespace = nameValue;
                }
                else
                {
                    var newName = Utils.GenerateRandomString();

                    _names.Add(type.Namespace, newName);
                    type.Namespace = newName;
                }
            }

            return ApplyChangesToResources(moduleToRename);
        }

        private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
        {
            var moduleToRename = module;

            foreach (var resource in moduleToRename.Resources)
            foreach (var item in _names)
                if (resource.Name.Contains(item.Key))
                    resource.Name = resource.Name.Replace(item.Key, item.Value);

            foreach (var type in moduleToRename.GetTypes())
            foreach (var property in type.Properties)
            {
                if (property.Name != "ResourceManager")
                    continue;

                var instr = property.GetMethod.Body.Instructions;

                for (var i = 0; i < instr.Count; i++)
                    if (instr[i].OpCode == OpCodes.Ldstr)
                        foreach (var item in _names)
                            if (instr[i].ToString().Contains(item.Key))
                                instr[i].Operand = instr[i].Operand.ToString().Replace(item.Key, item.Value);
            }

            return moduleToRename;
        }
    }
}