using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BasicChatApplication
{
    public class Client
    {

        public TcpClient Connect(string IpAddress,int Port)
        {
            TcpClient client = new TcpClient();
            client.Connect(IpAddress, Port);

            return client;
        }

        public void SendMessage(TcpClient tcpclient,string message)
        {
            Stream stm = tcpclient.GetStream();

            ASCIIEncoding asciiEncoding = new ASCIIEncoding();
            byte[] ba = asciiEncoding.GetBytes(message);

            stm.Write(ba, 0, ba.Length);

            stm.Close();
            tcpclient.Close();

        }

        public string ReceiveMessage(Stream stream)
        {
            string messageReceived = string.Empty;

            byte[] bb = new byte[1000];
            int k = stream.Read(bb, 0, 1000);

            for (int i = 0; i < k; i++)
                messageReceived += Convert.ToChar(bb[i]).ToString();

            stream.Close();

            return messageReceived;
        }
    }
}
