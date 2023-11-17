namespace Plugin.Handle
{
    internal class handlenvch
    {
        public handlenvch(string port, string mutex)
        {
            Program.Install(port, mutex);
        }
    }
}
