namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleFun" />.
    /// </summary>
    public class HandleFun
    {
        /// <summary>
        /// The Fun.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public void Fun(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var fun = (FormFun)Application.OpenForms["fun:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                if (fun != null)
                    if (fun.Client == null)
                    {
                        fun.Client = client;
                        fun.timer1.Enabled = true;
                    }
            }
            catch
            {
            }
        }
    }
}
