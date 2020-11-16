using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace frmTicTacToe
{
    public partial class frmTicTacToe : Form
    {
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        ClassTicTacToe obj = new ClassTicTacToe();
        public frmTicTacToe(bool isHost, string ip=null)
        {
            InitializeComponent();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                
                server = new TcpListener(System.Net.IPAddress.Any, 5732);
                server.Start();
                sock = server.AcceptSocket();
            }
            else
            {
                obj.set_userOne("O");
                obj.set_userTwo("X");
                try
                {
                    client = new TcpClient(ip, 5732);
                    sock = client.Client;
                    MessageReceiver.RunWorkerAsync();
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                    Close();
                }
            }
        }

        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            if (checkForWinner())
              return;
            block_all();
            this.lblInfo.Text = "PlayerTwo's Turn!";
            receiveMove();
            lblInfo.Text = "Your Turn!";
            if (!checkForWinner())
            {
                unFreez();
            }
        }

        public bool checkForWinner()
        {

            if (this.btnOne.Text == obj.get_userOne())
            {
                if (this.btnTwo.Text == obj.get_userOne() && this.btnThree.Text == obj.get_userOne())
                {
                    return true;
                }
                else if (this.btnFive.Text == obj.get_userOne() && this.btnNine.Text == obj.get_userOne())
                {
                    return true;
                }
                else if (this.btnFour.Text == obj.get_userOne() && this.btnSeven.Text == obj.get_userOne())
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

            else if (this.btnFour.Text == obj.get_userOne())
            {
                if (this.btnFive.Text == obj.get_userOne() && this.btnSix.Text == obj.get_userOne())
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

            else if (this.btnSeven.Text == obj.get_userOne())
            {
                if (this.btnEight.Text == obj.get_userOne() && this.btnNine.Text == obj.get_userOne())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
           

        }




        private void btnOne_Click(object sender, EventArgs e)
        {

            byte[] num = { 1 };
            sock.Send(num);

            btnOne.Text = obj.get_userOne();
            this.btnOne.Enabled = false;
            MessageReceiver.RunWorkerAsync();
            
            
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {

            byte[] num = { 2 };
            sock.Send(num);
            btnTwo.Text = obj.get_userOne();
            this.btnTwo.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void btnThree_Click(object sender, EventArgs e)
        {

            byte[] num = { 3 };
            sock.Send(num);
            MessageReceiver.RunWorkerAsync();
            btnThree.Text  = obj.get_userOne();
            this.btnThree.Enabled = false;
            
        }

        private void btnFour_Click(object sender, EventArgs e)
        {


            byte[] num = { 4 };
            sock.Send(num);
            
            btnFour.Text = obj.get_userOne();
            this.btnFour.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void btnFive_Click(object sender, EventArgs e)
        {


            byte[] num = { 5 };
            sock.Send(num);
            
            btnFive.Text = obj.get_userOne();
            this.btnFive.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void btnSix_Click(object sender, EventArgs e)
        {


            byte[] num = { 6 };
            sock.Send(num);
            
            btnSix.Text = obj.get_userOne();
            this.btnSix.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {


            byte[] num = { 7 };
            sock.Send(num);
            
            btnSeven.Text = obj.get_userOne();
            this.btnSeven.Enabled = false;
            MessageReceiver.RunWorkerAsync();


        }

        private void btnEight_Click(object sender, EventArgs e)
        {


            byte[] num = { 8 };
            sock.Send(num);
            
            btnEight.Text = obj.get_userOne();
            this.btnEight.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            byte[] num = { 9 };
            sock.Send(num);
            

            btnNine.Text = obj.get_userOne();
            this.btnNine.Enabled = false;
            MessageReceiver.RunWorkerAsync();

        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            this.btnOne.Text = "";
            this.btnOne.Enabled = true;


            this.btnTwo.Text = "";
            this.btnTwo.Enabled = true;


            this.btnThree.Text = "";
            this.btnThree.Enabled = true;


            this.btnFour.Text = "";
            this.btnFour.Enabled = true;


            this.btnFive.Text = "";
            this.btnFive.Enabled = true;


            this.btnSix.Text = "";
            this.btnSix.Enabled = true;


            this.btnSeven.Text = "";
            this.btnSeven.Enabled = true;


            this.btnEight.Text = "";
            this.btnEight.Enabled = true;


            this.btnNine.Text = "";
            this.btnNine.Enabled = true;

        }


        public void block_all()
        { 
            this.btnOne.Enabled = false;

            this.btnTwo.Enabled = false;

            this.btnThree.Enabled = false;

            this.btnFour.Enabled = false;

            this.btnFive.Enabled = false;

            this.btnSix.Enabled = false;

            this.btnSeven.Enabled = false;

            this.btnEight.Enabled = false;

            this.btnNine.Enabled = false;
        }
       
        public void unFreez()
        { 
            this.btnOne.Enabled = true;

            this.btnTwo.Enabled = true;

            this.btnThree.Enabled = true;

            this.btnFour.Enabled = true;

            this.btnFive.Enabled = true;

            this.btnSix.Enabled = true;

            this.btnSeven.Enabled = true;

            this.btnEight.Enabled = true;

            this.btnNine.Enabled = true;
        }


        private void receiveMove()
        {
            byte[] buffer = new byte[1];
            sock.Receive(buffer);
            if (buffer[0]==1)
            {
                btnOne.Text = obj.get_userTwo();
            }
            if (buffer[0] == 2)
            {
                btnTwo.Text = obj.get_userTwo();
            }
            if (buffer[0]==3)
            {
                btnThree.Text = obj.get_userTwo();
            }
            if (buffer[0]==4)
            {
                btnFour.Text = obj.get_userTwo();
            }
            if (buffer[0]==5)
            {
                btnFive.Text = obj.get_userTwo();
            }
            if (buffer[0]==6)
            {
                btnSix.Text = obj.get_userTwo();
            }
            if (buffer[0]==7)
            {
                btnSeven.Text = obj.get_userTwo();
            }
            if (buffer[0]==8)
            {
                btnEight.Text = obj.get_userTwo();
            }
            if (buffer[0]==9)
            {
                btnNine.Text = obj.get_userTwo();
            }
            


        }

        private void frmTicTacToe_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageReceiver.WorkerSupportsCancellation = true;
            MessageReceiver.CancelAsync();
            if (server != null)
            {
                server.Stop();
            }
        }
    }

    class ClassTicTacToe
    {
        bool toogleValue = true;
        String userOne = "O";
        String userTwo = "X";
        public void set_userOne(string value)
        {
            userOne = value; 
        }

        public String get_userOne()
        {
            return userOne;
        }



        public void set_userTwo(string value)
        {
            userTwo = value;
        }

        public String get_userTwo()
        {
            return userTwo;
        }


        

        


    }
}
