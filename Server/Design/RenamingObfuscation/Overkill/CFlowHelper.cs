using System;
using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace PEGASUS.Design.RenamingObfuscation.Overkill
{
    public class CFHelper
    {
        private static readonly Random generator = new Random();

        public bool HasUnsafeInstructions(MethodDef methodDef)
        {
            bool result;
            if (methodDef.HasBody && methodDef.Body.HasVariables)
                result = methodDef.Body.Variables.Any(x => x.Type.IsPointer);
            else
                result = false;
            return result;
        }

        public Blocks GetBlocks(MethodDef method)
        {
            var blocks = new Blocks();
            var block = new Block();
            var num = 0;
            block.ID = 0;
            var num2 = 1;
            block.nextBlock = block.ID + 1;
            block.instructions.Add(Instruction.Create(OpCodes.Nop));
            blocks.blocks.Add(block);
            block = new Block();
            foreach (var instruction in method.Body.Instructions)
            {
                var num3 = 0;
                int num4;
                instruction.CalculateStackUsage(out num4, out num3);
                block.instructions.Add(instruction);
                num += num4 - num3;
                if (num4 == 0 && instruction.OpCode != OpCodes.Nop && (num == 0 || instruction.OpCode == OpCodes.Ret))
                {
                    block.ID = num2;
                    num2++;
                    block.nextBlock = block.ID + 1;
                    blocks.blocks.Add(block);
                    block = new Block();
                }
            }

            return blocks;
        }

        public List<Instruction> Calc(int value)
        {
            var list = new List<Instruction>();
            var num = generator.Next(0, 2147483647);
            var flag = Convert.ToBoolean(generator.Next(2147483647));
            var num2 = generator.Next(2147483647);
            list.Add(Instruction.Create(OpCodes.Ldc_I4, value - num + (flag ? 0 - num2 : num2)));
            list.Add(Instruction.Create(OpCodes.Ldc_I4, num));
            list.Add(Instruction.Create(OpCodes.Add));
            list.Add(Instruction.Create(OpCodes.Ldc_I4, num2));
            list.Add(Instruction.Create(flag ? OpCodes.Add : OpCodes.Sub));
            return list;
        }

        public class Blocks
        {
            private static readonly Random generator = new Random();

            public List<Block> blocks = new List<Block>();

            public Block getBlock(int id)
            {
                return blocks.Single(block => block.ID == id);
            }

            public void Scramble(out Blocks incGroups)
            {
                var blocks = new Blocks();
                foreach (var item in this.blocks) blocks.blocks.Insert(generator.Next(0, blocks.blocks.Count), item);
                incGroups = blocks;
            }
        }

        public class Block
        {
            public int ID;

            public List<Instruction> instructions = new List<Instruction>();

            public int nextBlock;
        }
    }
}