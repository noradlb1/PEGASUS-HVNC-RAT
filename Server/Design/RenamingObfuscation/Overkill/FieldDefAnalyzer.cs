using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils.Analyzer
{
    public class FieldDefAnalyzer : DefAnalyzer
    {
        public override bool Execute(object context)
        {
            var field = (FieldDef) context;
            if (field.IsRuntimeSpecialName)
                return false;
            if (field.IsLiteral && field.DeclaringType.IsEnum)
                return false;
            return true;
        }
    }
}