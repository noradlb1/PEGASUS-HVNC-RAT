using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils.Analyzer
{
    public class MethodDefAnalyzer : DefAnalyzer
    {
        public override bool Execute(object context)
        {
            var method = (MethodDef) context;
            if (method.IsRuntimeSpecialName)
                return false;
            if (method.DeclaringType.IsForwarder)
                return false;
            if (method.IsConstructor || method.IsStaticConstructor)
                return false;
            return true;
        }
    }
}