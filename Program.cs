using LumiSoft.Net.STUN.Client;
using System;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket
         (AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(new IPEndPoint(IPAddress.Any, 0));

            // Query STUN server
            STUN_Result result = STUN_Client.Query("stun.sipgate.net", 3478, socket);
            if (result.NetType != STUN_NetType.UdpBlocked)
            {
                // UDP blocked or !!!! bad STUN server
            }
            else
            {
                IPEndPoint publicEP = result.PublicEndPoint;
                // Do your stuff
            }
            Console.ReadLine();
        }
    }
}
