using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill
{
    internal class AntiDe4Dot
    {
        public static void Execute()
        {
            foreach (var module in Ovelkill.Module.Assembly.Modules)
            {
                var lol = "PEGASUS.NET";
                for (var i = 0; i < 1; i++)
                {
                    var typeDef1 = new TypeDefUser(string.Empty, lol);
                    var interface1 = new InterfaceImplUser(typeDef1);
                    module.Types.Add(typeDef1);
                    typeDef1.Interfaces.Add(interface1);
                }
            }
        }
    }
}