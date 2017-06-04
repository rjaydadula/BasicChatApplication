using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicChatApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Server server { get; set; } = new Server();
        private Client client { get; set; } = new Client();
        private TcpClient tcpClient = new TcpClient();

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Select();
            server.StartListening();

            timer1.Start();

            string[] ipandport = ConfigurationManager.AppSettings["IpandPort"].Split(':');
            lblServerInfo.Text = "Listening: " + ipandport[0] + ":" + ipandport[1];

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
            if (txtInput.Text.Trim().Count() > 0)
            {
                if (!tcpClient.Connected)
                    tcpClient = client.Connect(txtIpAddress.Text.Trim(), int.Parse(txtPort.Text.Trim()));
                else
                {
                    tcpClient.Close();
                    tcpClient = client.Connect(txtIpAddress.Text.Trim(), int.Parse(txtPort.Text.Trim()));
                }


                    client.SendMessage(tcpClient, txtInput.Text.Trim());

                    if (txtOuput.Text.Trim().Count() == 0)
                    {
                        txtOuput.AppendText("Me: " + txtInput.Text.Trim());
                    }
                    else
                    {
                        txtOuput.AppendText(System.Environment.NewLine+"Me: "+ txtInput.Text.Trim());
                    }

                    txtInput.Text = string.Empty;
                

                txtInput.Select();
            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {
            string sdad = string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(server.ReceivedMessage != null)
            {
               
                if (txtOuput.Text.Trim().Count() > 0)
                    txtOuput.AppendText(System.Environment.NewLine + "Server: " + server.ReceivedMessage);
                else
                    txtOuput.AppendText("Server: " + server.ReceivedMessage);

                server.ReceivedMessage = null;
            }

            

        }
    }
}
