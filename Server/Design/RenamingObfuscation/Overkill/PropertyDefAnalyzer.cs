using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils.Analyzer
{
    public class PropertyDefAnalyzer : DefAnalyzer
    {
        public override bool Execute(object context)
        {
            var propertyDef = (PropertyDef) context;
            var isRuntimeSpecialName = propertyDef.IsRuntimeSpecialName;
            bool result;
            if (isRuntimeSpecialName)
            {
                result = false;
            }
            else
            {
                var isEmpty = propertyDef.IsEmpty;
                if (isEmpty)
                {
                    result = false;
                }
                else
                {
                    var isSpecialName = propertyDef.IsSpecialName;
                    result = !isSpecialName;
                }
            }

            return result;
        }
    }
}