using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace local_chat
{
    public partial class Form1 : Form
    {
        Socket socket;
        EndPoint endPoint_Local, endPoint_Remote;
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set up the socket 
            socket = new Socket(AddressFamily.InterNetwork,SocketType.Dgram,ProtocolType.Udp);
            socket.SetSocketOption(SocketOptionLevel.Socket,SocketOptionName.ReuseAddress, true);

            // get user ip

            textLocalIP.Text = GetLocalIP();
            textRemoteIP.Text = GetLocalIP();

        }

        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily== AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                 }
            }
            return "127.0.0.1";
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            // binding socket 
            endPoint_Local = new IPEndPoint(IPAddress.Parse(textLocalIP.Text),Convert.ToInt32(textLocalPort.Text));

            socket.Bind(endPoint_Local);

            // connecting with remote ip
            endPoint_Remote = new IPEndPoint(IPAddress.Parse(textRemoteIP.Text),Convert.ToInt32(textRemotePort.Text));
            socket.Connect(endPoint_Remote);
            //listening the specific port 
            buffer = new byte[1200];
            socket.BeginReceiveFrom(buffer,0,buffer.Length,SocketFlags.None,ref endPoint_Remote, new AsyncCallback(MessageCallBack),buffer);



        }

        private void buttonSent_Click(object sender, EventArgs e)
        {
            ASCIIEncoding a_Encoding = new ASCIIEncoding();
            byte[] sending_message = new byte[1200];
            sending_message = a_Encoding.GetBytes(textMessage.Text);

            socket.Send(sending_message);

            List_Message.Items.Add(" Me : "+textMessage.Text);

            textMessage.Text = "";
        }

        private void MessageCallBack(IAsyncResult ar)
        {
            try
            {
                byte[] receive_data = new byte[1200];
                receive_data = (byte[])ar.AsyncState;
                ASCIIEncoding a_Encoding = new ASCIIEncoding();
                String rec_message = a_Encoding.GetString(receive_data);

                //adding to list box
                List_Message.Items.Add("Friend : " + rec_message);

                buffer = new byte[1200];
                socket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref endPoint_Remote, new AsyncCallback(MessageCallBack), buffer);

            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }



        }
    }
}
