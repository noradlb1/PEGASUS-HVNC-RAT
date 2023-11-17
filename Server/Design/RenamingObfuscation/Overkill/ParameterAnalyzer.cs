using dnlib.DotNet;

namespace PEGASUS.Design.RenamingObfuscation.Overkill.Utils.Analyzer
{
    public class ParameterAnalyzer : DefAnalyzer
    {
        public override bool Execute(object context)
        {
            var param = (Parameter) context;
            if (param.Name == string.Empty)
                return false;
            return true;
        }
    }
}