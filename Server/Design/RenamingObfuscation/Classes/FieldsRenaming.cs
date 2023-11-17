using System.Collections.Generic;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation.Classes
{
    public class FieldsRenaming : IRenaming
    {
        private static readonly Dictionary<string, string> _names = new Dictionary<string, string>();

        public ModuleDefMD Rename(ModuleDefMD module)
        {
            var moduleToRename = module;

            foreach (var type in moduleToRename.GetTypes())
            {
                if (type.IsGlobalModuleType)
                    continue;

                foreach (var field in type.Fields)
                {
                    string nameValue;
                    if (_names.TryGetValue(field.Name, out nameValue))
                    {
                        field.Name = nameValue;
                    }
                    else
                    {
                        if (!field.IsSpecialName && !field.HasCustomAttributes)
                        {
                            var newName = Utils.GenerateRandomString();
                            _names.Add(field.Name, newName);
                            field.Name = newName;
                        }
                    }
                }
            }

            return ApplyChangesToResources(moduleToRename);
        }

        private static ModuleDefMD ApplyChangesToResources(ModuleDefMD module)
        {
            var moduleToRename = module;

            foreach (var type in moduleToRename.GetTypes())
            {
                if (type.IsGlobalModuleType)
                    continue;

                foreach (var method in type.Methods)
                {
                    if (method.Name != "InitializeComponent")
                        continue;

                    var instr = method.Body.Instructions;

                    for (var i = 0; i < instr.Count - 3; i++)
                        if (instr[i].OpCode == OpCodes.Ldstr)
                            foreach (var item in _names)
                                if (item.Key == instr[i].Operand.ToString())
                                    instr[i].Operand = item.Value;
                }
            }

            return moduleToRename;
        }
    }
}