using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils.Analyzer
{
    public class EventDefAnalyzer : DefAnalyzer
    {
        public override bool Execute(object context)
        {
            var ev = (EventDef) context;
            if (ev.IsRuntimeSpecialName)
                return false;
            return true;
        }
    }
}