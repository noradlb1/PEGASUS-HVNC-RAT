namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandlePowerShell" />.
    /// </summary>
    public class HandlePowerShell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandlePowerShell"/> class.
        /// </summary>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        public HandlePowerShell(MsgPack unpack_msgpack, Clients client)
        {
            var powershell =
                (FormPowerShell)Application.OpenForms["powershell:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
            if (powershell != null)
            {
                if (powershell.Client == null)
                {
                    powershell.Client = client;
                    powershell.timer1.Enabled = true;
                }

                powershell.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("ReadInput").AsString);
                powershell.richTextBox1.SelectionStart = powershell.richTextBox1.TextLength;
                powershell.richTextBox1.ScrollToCaret();
            }
        }
    }
}
