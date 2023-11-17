using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using PEGASUS.Design.RenamingObfuscation.Overkill.Utils;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Protections
{
    public class StringEncryption : Randomizer
    {
        private static readonly RandomNumberGenerator csp = RandomNumberGenerator.Create();
        private static int Amount { get; set; }

        public static void Execute()
        {
            var typeModule = ModuleDefMD.Load(typeof(StringDecoder).Module);
            var typeDef = typeModule.ResolveTypeDef(MDToken.ToRID(typeof(StringDecoder).MetadataToken));
            var members = InjectHelper.Inject(typeDef, Ovelkill.Module.GlobalType,
                Ovelkill.Module);
            var init = (MethodDef) members.Single(method => method.Name == "Decrypt");
            init.Rename(GenerateRandomString(MemberRenamer.StringLength()));

            foreach (var method in Ovelkill.Module.GlobalType.Methods)
                if (method.Name.Equals(".ctor"))
                {
                    Ovelkill.Module.GlobalType.Remove(method);
                    break;
                }

            foreach (var type in Ovelkill.Module.Types)
            {
                if (type.IsGlobalModuleType) continue;
                foreach (var method in type.Methods)
                {
                    var cryptoRandom = new CryptoRandom();
                    if (!method.HasBody) continue;
                    for (var i = 0; i < method.Body.Instructions.Count; i++)
                        if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                        {
                            var key = method.Name.Length + Next();

                            var encryptedString =
                                Encrypt(new Tuple<string, int>(method.Body.Instructions[i].Operand.ToString(), key));

                            method.Body.Instructions[i].OpCode = OpCodes.Ldstr;
                            method.Body.Instructions[i].Operand = encryptedString;
                            method.Body.Instructions.Insert(i + 1, OpCodes.Ldc_I4.ToInstruction(key));
                            method.Body.Instructions.Insert(i + 2, OpCodes.Call.ToInstruction(init));
                            Amount++;
                            i += 2;
                        }
                }
            }

            Console.WriteLine($"  Encrypted {Amount} strings.");
        }

        public static int Next()
        {
            return BitConverter.ToInt32(RandomBytes(sizeof(int)), 0);
        }

        private static byte[] RandomBytes(int bytes)
        {
            var buffer = new byte[bytes];
            csp.GetBytes(buffer);
            return buffer;
        }

        public static string Encrypt(Tuple<string, int> values)
        {
            var input = new StringBuilder(values.Item1);
            var output = new StringBuilder(values.Item1.Length);
            char Textch;
            var key = values.Item2;
            for (var iCount = 0; iCount < values.Item1.Length; iCount++)
            {
                Textch = input[iCount];
                Textch = (char) (Textch ^ key);
                output.Append(Textch);
            }

            return output.ToString();
        }
    }
}