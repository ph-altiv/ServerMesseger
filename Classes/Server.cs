using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace ServerMesseger.Classes
{
    class Server
    {
        private int port;
        private TcpListener listener;
        private NetworkStream ns;

        private int SetAuthorizationDemon()
        {
            byte[] bstr = new byte[256];
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            TcpClient tc = listener.AcceptTcpClient();
            ns = tc.GetStream();
            ns.Read(bstr, 0, bstr.Length);
            string str = System.Text.Encoding.ASCII.GetString(bstr);
            Console.WriteLine(str);
            return 0;
        }

        public Server(int port)
        {
            this.port = port;
            this.SetAuthorizationDemon();
        }

        ~Server()
        {
            listener?.Stop();
        }
    }
}
