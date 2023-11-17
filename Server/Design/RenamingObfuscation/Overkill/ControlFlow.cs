using dnlib.DotNet;
using dnlib.DotNet.Emit;
using static PEGASUS.Design.RenamingObfuscation.Overkill.CFHelper;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Protections
{
    public static class ControlFlow
    {
        public static void Execute()
        {
            var cfhelper = new CFHelper();
            foreach (var typeDef in Ovelkill.Module.Types)
                if (!typeDef.IsGlobalModuleType)
                    foreach (var methodDef in typeDef.Methods)
                        if (methodDef.HasBody && methodDef.Body.Instructions.Count > 0 && !methodDef.IsConstructor &&
                            !cfhelper.HasUnsafeInstructions(methodDef))
                        {
                            if (Simplify(methodDef))
                            {
                                var blocks = cfhelper.GetBlocks(methodDef);
                                if (blocks.blocks.Count != 1) toDoBody(cfhelper, methodDef, blocks, typeDef);
                            }

                            Optimize(methodDef);
                        }
        }

        public static bool Optimize(MethodDef methodDef)
        {
            bool result;
            if (methodDef.Body == null)
            {
                result = false;
            }
            else
            {
                methodDef.Body.OptimizeMacros();
                methodDef.Body.OptimizeBranches();
                result = true;
            }

            return result;
        }

        public static bool Simplify(MethodDef methodDef)
        {
            bool result;
            if (methodDef.Parameters == null)
            {
                result = false;
            }
            else
            {
                methodDef.Body.SimplifyMacros(methodDef.Parameters);
                result = true;
            }

            return result;
        }

        private static void toDoBody(CFHelper cFHelper, MethodDef method, Blocks blocks, TypeDef typeDef)
        {
            blocks.Scramble(out blocks);
            method.Body.Instructions.Clear();
            var local = new Local(Ovelkill.Module.CorLibTypes.Int32);
            method.Body.Variables.Add(local);
            var instruction = Instruction.Create(OpCodes.Nop);
            var instruction2 = Instruction.Create(OpCodes.Br, instruction);
            foreach (var item in cFHelper.Calc(0)) method.Body.Instructions.Add(item);
            method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
            method.Body.Instructions.Add(Instruction.Create(OpCodes.Br, instruction2));
            method.Body.Instructions.Add(instruction);
            foreach (var block in blocks.blocks)
                if (block != blocks.getBlock(blocks.blocks.Count - 1))
                {
                    method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
                    foreach (var item2 in cFHelper.Calc(block.ID)) method.Body.Instructions.Add(item2);
                    method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
                    var instruction3 = Instruction.Create(OpCodes.Nop);
                    method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction3));
                    foreach (var item3 in block.instructions) method.Body.Instructions.Add(item3);
                    foreach (var item4 in cFHelper.Calc(block.nextBlock)) method.Body.Instructions.Add(item4);
                    method.Body.Instructions.Add(Instruction.Create(OpCodes.Stloc, local));
                    method.Body.Instructions.Add(instruction3);
                }

            method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldloc, local));
            foreach (var item5 in cFHelper.Calc(blocks.blocks.Count - 1)) method.Body.Instructions.Add(item5);
            method.Body.Instructions.Add(Instruction.Create(OpCodes.Ceq));
            method.Body.Instructions.Add(Instruction.Create(OpCodes.Brfalse, instruction2));
            method.Body.Instructions.Add(Instruction.Create(OpCodes.Br,
                blocks.getBlock(blocks.blocks.Count - 1).instructions[0]));
            method.Body.Instructions.Add(instruction2);
            foreach (var item6 in blocks.getBlock(blocks.blocks.Count - 1).instructions)
                method.Body.Instructions.Add(item6);
        }
    }
}