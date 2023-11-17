using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using PEGASUS.Design.RenamingObfuscation.Classes;
using PEGASUS.Design.RenamingObfuscation.Interfaces;

namespace PEGASUS.Design.RenamingObfuscation
{
    public static class EncryptString
    {
        private static MethodDef InjectMethod(ModuleDef module, string methodName)
        {
            var typeModule = ModuleDefMD.Load(typeof(DecryptionHelper).Module);
            var typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(typeof(DecryptionHelper).MetadataToken));
            var members = InjectHelper.Inject(typeDef, module.GlobalType, module);
            var injectedMethodDef = (MethodDef) members.Single(method => method.Name == methodName);

            foreach (var md in module.GlobalType.Methods)
                if (md.Name == ".ctor")
                {
                    module.GlobalType.Remove(md);
                    break;
                }

            return injectedMethodDef;
        }

        public static void DoEncrypt(ModuleDef inPath)
        {
            EncryptStrings(inPath);
        }

        private static ModuleDef EncryptStrings(ModuleDef inModule)
        {
            var module = inModule;

            ICrypto crypto = new Base64();

            var decryptMethod = InjectMethod(module, "Decrypt_Base64");

            foreach (var type in module.Types)
            {
                if (type.IsGlobalModuleType || type.Name == "Resources" || type.Name == "Settings")
                    continue;

                foreach (var method in type.Methods)
                {
                    if (!method.HasBody)
                        continue;
                    if (method == decryptMethod)
                        continue;

                    method.Body.KeepOldMaxStack = true;

                    for (var i = 0; i < method.Body.Instructions.Count; i++)
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr) // String
                        {
                            var oldString = method.Body.Instructions[i].Operand.ToString(); //Original String

                            method.Body.Instructions[i].Operand = crypto.Encrypt(oldString);
                            method.Body.Instructions.Insert(i + 1, new Instruction(OpCodes.Call, decryptMethod));
                        }

                    method.Body.SimplifyBranches();
                    method.Body.OptimizeBranches();
                }
            }

            return module;
        }
    }
}