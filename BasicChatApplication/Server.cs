using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicChatApplication
{
    public class Server
    {
        public string ReceivedMessage { get; set; }



        public void StartListening()
        {
            Thread thread = new Thread(delegate ()
            {
                while (true)
                {
                    try
                    {
                        string[] ipandport = ConfigurationManager.AppSettings["IpandPort"].Split(':');
                        IPAddress ipAddress = IPAddress.Parse(ipandport[0]);
                        TcpListener listener = new TcpListener(ipAddress, int.Parse(ipandport[1]));

                        listener.Start();

                        Socket socket = listener.AcceptSocket();

                        byte[] mbyte = new byte[1000];
                        int k = socket.Receive(mbyte);

                        for (int i = 0; i < k; i++)
                            ReceivedMessage += Convert.ToChar(mbyte[i]).ToString();

                        socket.Close();
                        listener.Stop();
                    }
                    catch { }
                }

                      });
                    thread.Start();
                    thread.IsBackground = true;
           
           
        }
    }
}
