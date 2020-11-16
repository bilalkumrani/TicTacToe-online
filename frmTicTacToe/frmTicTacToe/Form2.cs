using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTicTacToe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTicTacToe newTictactoe = new frmTicTacToe(false, textBox1.Text);
            if (newTictactoe.IsDisposed)
                newTictactoe.ShowDialog();
            Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTicTacToe newTictactoe = new frmTicTacToe(true);
            //Visible = false;
            if (!newTictactoe.IsDisposed)
                newTictactoe.ShowDialog();
            //Visible = true;
        }
    }
}
