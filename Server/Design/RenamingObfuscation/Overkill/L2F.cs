using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Protections
{
    internal class L2F
    {
        private static Dictionary<Local, FieldDef> convertedLocals = new Dictionary<Local, FieldDef>();
        private static readonly Random random = new Random();

        public static void Execute()
        {
            foreach (var type in Ovelkill.Module.Types.Where(x => x != Ovelkill.Module.GlobalType))
            foreach (var method2 in type.Methods.Where(x => x.HasBody && x.Body.HasInstructions && !x.IsConstructor))
            {
                convertedLocals = new Dictionary<Local, FieldDef>();
                Process(Ovelkill.Module, method2);
            }
        }

        public static string RandomString(int length)
        {
            const string chars =
                "ΑΒΓΔΕΖΗΘΙΚΛΜΝΞΟΠΡΣΤΥΦΧΨΩαβγδεζηθικλμνξοπρστυφχψωABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyzابتثجحخدذرزسشصضطظعغفقكلمنهويابتثجحخدذرزسشصضطظعغفقكلمنهوي0123456789艾诶比西迪伊弗吉尺杰开勒马娜哦屁吉吾儿丝提伊吾维豆贝尔维克斯吾贼德אבגדהוזחטיכךלמםנןסעפףצץקרשתאבגדהוזחטיכךלמםנןסעפףצץקרשת";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static void Process(ModuleDef Module, MethodDef method)
        {
            method.Body.SimplifyMacros(method.Parameters);
            var instructions = method.Body.Instructions;
            foreach (var t in instructions)
            {
                if (!(t.Operand is Local local)) continue;
                FieldDef def = null;
                if (!convertedLocals.ContainsKey(local))
                {
                    def = new FieldDefUser(RandomString(+30), new FieldSig(local.Type),
                        FieldAttributes.Public | FieldAttributes.Static);
                    Module.GlobalType.Fields.Add(def);
                    convertedLocals.Add(local, def);
                }
                else
                {
                    def = convertedLocals[local];
                }

                OpCode eq = null;
                switch (t.OpCode.Code)
                {
                    case Code.Ldloc:
                        eq = OpCodes.Ldsfld;
                        break;

                    case Code.Ldloca:
                        eq = OpCodes.Ldsflda;
                        break;

                    case Code.Stloc:
                        eq = OpCodes.Stsfld;
                        break;
                }

                t.OpCode = eq;
                t.Operand = def;
            }

            convertedLocals.ToList().ForEach(x => method.Body.Variables.Remove(x.Key));
            convertedLocals = new Dictionary<Local, FieldDef>();
        }
    }
}