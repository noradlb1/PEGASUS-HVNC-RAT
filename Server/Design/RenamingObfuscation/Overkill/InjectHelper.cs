﻿using System.Collections.Generic;
using System.Linq;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils
{
    /// <summary>
    ///     Provides methods to inject a <see cref="TypeDef" /> into another module.
    /// </summary>
    public static class InjectHelper
    {
        /// <summary>
        ///     Clones the specified origin TypeDef.
        /// </summary>
        /// <param name="origin">The origin TypeDef.</param>
        /// <returns>The cloned TypeDef.</returns>
        public static TypeDefUser Clone(TypeDef origin)
        {
            var ret = new TypeDefUser(origin.Namespace, origin.Name)
            {
                Attributes = origin.Attributes
            };

            if (origin.ClassLayout != null)
                ret.ClassLayout = new ClassLayoutUser(origin.ClassLayout.PackingSize, origin.ClassSize);

            foreach (var genericParam in origin.GenericParameters)
                ret.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags,
                    "-"));

            return ret;
        }

        /// <summary>
        ///     Clones the specified origin MethodDef.
        /// </summary>
        /// <param name="origin">The origin MethodDef.</param>
        /// <returns>The cloned MethodDef.</returns>
        public static MethodDefUser Clone(MethodDef origin)
        {
            var ret = new MethodDefUser(origin.Name, null, origin.ImplAttributes,
                origin.Attributes);

            foreach (var genericParam in origin.GenericParameters)
                ret.GenericParameters.Add(new GenericParamUser(genericParam.Number, genericParam.Flags,
                    "-"));

            return ret;
        }

        /// <summary>
        ///     Clones the specified origin FieldDef.
        /// </summary>
        /// <param name="origin">The origin FieldDef.</param>
        /// <returns>The cloned FieldDef.</returns>
        public static FieldDefUser Clone(FieldDef origin)
        {
            return new FieldDefUser(origin.Name, null, origin.Attributes);
        }

        /// <summary>
        ///     Populates the context mappings.
        /// </summary>
        /// <param name="typeDef">The origin TypeDef.</param>
        /// <param name="ctx">The injection context.</param>
        /// <returns>The new TypeDef.</returns>
        public static TypeDef PopulateContext(TypeDef typeDef, InjectContext ctx)
        {
            TypeDef ret;
            if (!ctx.Map.TryGetValue(typeDef, out var existing))
            {
                ret = Clone(typeDef);
                ctx.Map[typeDef] = ret;
            }
            else
            {
                ret = (TypeDef) existing;
            }

            foreach (var nestedType in typeDef.NestedTypes)
                ret.NestedTypes.Add(PopulateContext(nestedType, ctx));

            foreach (var method in typeDef.Methods)
                ret.Methods.Add((MethodDef) (ctx.Map[method] = Clone(method)));

            foreach (var field in typeDef.Fields)
                ret.Fields.Add((FieldDef) (ctx.Map[field] = Clone(field)));

            return ret;
        }

        /// <summary>
        ///     Copies the information from the origin type to injected type.
        /// </summary>
        /// <param name="typeDef">The origin TypeDef.</param>
        /// <param name="ctx">The injection context.</param>
        public static void CopyTypeDef(TypeDef typeDef, InjectContext ctx)
        {
            var newTypeDef = (TypeDef) ctx.Map[typeDef];
            newTypeDef.BaseType = ctx.Importer.Import(typeDef.BaseType);

            foreach (var iface in typeDef.Interfaces)
                newTypeDef.Interfaces.Add(new InterfaceImplUser(ctx.Importer.Import(iface.Interface)));
        }

        /// <summary>
        ///     Copies the information from the origin method to injected method.
        /// </summary>
        /// <param name="methodDef">The origin MethodDef.</param>
        /// <param name="ctx">The injection context.</param>
        public static void CopyMethodDef(MethodDef methodDef, InjectContext ctx)
        {
            var newMethodDef = (MethodDef) ctx.Map[methodDef];

            newMethodDef.Signature = ctx.Importer.Import(methodDef.Signature);
            newMethodDef.Parameters.UpdateParameterTypes();

            if (methodDef.ImplMap != null)
                newMethodDef.ImplMap =
                    new ImplMapUser(new ModuleRefUser(ctx.TargetModule, methodDef.ImplMap.Module.Name),
                        methodDef.ImplMap.Name, methodDef.ImplMap.Attributes);

            foreach (var ca in methodDef.CustomAttributes)
                newMethodDef.CustomAttributes.Add(
                    new CustomAttribute((ICustomAttributeType) ctx.Importer.Import(ca.Constructor)));

            if (methodDef.HasBody)
            {
                newMethodDef.Body = new CilBody(methodDef.Body.InitLocals, new List<Instruction>(),
                    new List<ExceptionHandler>(), new List<Local>());
                newMethodDef.Body.MaxStack = methodDef.Body.MaxStack;

                var bodyMap = new Dictionary<object, object>();

                foreach (var local in methodDef.Body.Variables)
                {
                    var newLocal = new Local(ctx.Importer.Import(local.Type));
                    newMethodDef.Body.Variables.Add(newLocal);
                    newLocal.Name = local.Name;
                    newLocal.Attributes = local.Attributes;

                    bodyMap[local] = newLocal;
                }

                foreach (var instr in methodDef.Body.Instructions)
                {
                    var newInstr = new Instruction(instr.OpCode, instr.Operand)
                    {
                        SequencePoint = instr.SequencePoint
                    };

                    if (newInstr.Operand is IType)
                        newInstr.Operand = ctx.Importer.Import((IType) newInstr.Operand);

                    else if (newInstr.Operand is IMethod)
                        newInstr.Operand = ctx.Importer.Import((IMethod) newInstr.Operand);

                    else if (newInstr.Operand is IField)
                        newInstr.Operand = ctx.Importer.Import((IField) newInstr.Operand);

                    newMethodDef.Body.Instructions.Add(newInstr);
                    bodyMap[instr] = newInstr;
                }

                foreach (var instr in newMethodDef.Body.Instructions)
                    if (instr.Operand != null && bodyMap.ContainsKey(instr.Operand))
                        instr.Operand = bodyMap[instr.Operand];

                    else if (instr.Operand is Instruction[])
                        instr.Operand = ((Instruction[]) instr.Operand).Select(target => (Instruction) bodyMap[target])
                            .ToArray();

                foreach (var eh in methodDef.Body.ExceptionHandlers)
                    newMethodDef.Body.ExceptionHandlers.Add(new ExceptionHandler(eh.HandlerType)
                    {
                        CatchType = eh.CatchType == null ? null : ctx.Importer.Import(eh.CatchType),
                        TryStart = (Instruction) bodyMap[eh.TryStart],
                        TryEnd = (Instruction) bodyMap[eh.TryEnd],
                        HandlerStart = (Instruction) bodyMap[eh.HandlerStart],
                        HandlerEnd = (Instruction) bodyMap[eh.HandlerEnd],
                        FilterStart = eh.FilterStart == null ? null : (Instruction) bodyMap[eh.FilterStart]
                    });

                newMethodDef.Body.SimplifyMacros(newMethodDef.Parameters);
            }
        }

        /// <summary>
        ///     Copies the information from the origin field to injected field.
        /// </summary>
        /// <param name="fieldDef">The origin FieldDef.</param>
        /// <param name="ctx">The injection context.</param>
        public static void CopyFieldDef(FieldDef fieldDef, InjectContext ctx)
        {
            var newFieldDef = (FieldDef) ctx.Map[fieldDef];
            newFieldDef.Signature = ctx.Importer.Import(fieldDef.Signature);
        }

        /// <summary>
        ///     Copies the information to the injected definitions.
        /// </summary>
        /// <param name="typeDef">The origin TypeDef.</param>
        /// <param name="ctx">The injection context.</param>
        /// <param name="copySelf">if set to <c>true</c>, copy information of <paramref name="typeDef" />.</param>
        public static void Copy(TypeDef typeDef, InjectContext ctx, bool copySelf)
        {
            if (copySelf)
                CopyTypeDef(typeDef, ctx);

            foreach (var nestedType in typeDef.NestedTypes)
                Copy(nestedType, ctx, true);

            foreach (var method in typeDef.Methods)
                CopyMethodDef(method, ctx);

            foreach (var field in typeDef.Fields)
                CopyFieldDef(field, ctx);
        }

        /// <summary>
        ///     Injects the members of specified TypeDef to another module.
        /// </summary>
        /// <param name="typeDef">The source TypeDef.</param>
        /// <param name="newType">The new type.</param>
        /// <param name="target">The target module.</param>
        /// <returns>Injected members.</returns>
        public static IEnumerable<IDnlibDef> Inject(TypeDef typeDef, TypeDef newType, ModuleDef target)
        {
            var ctx = new InjectContext(typeDef.Module, target);
            ctx.Map[typeDef] = newType;
            PopulateContext(typeDef, ctx);
            Copy(typeDef, ctx, false);
            return ctx.Map.Values.Except(new[] {newType});
        }
    }
}