using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = accept;
        }

        private void check_box_changed(object sender, EventArgs e)
        {
            status.Text = ((GunaCheckBox)sender).Name;
            if(checkBox1.Checked)
            {
                
                status.Text += "one is checked";
            }

        }

        private void radio_button_checked(object sender, EventArgs e)
        {
            status.Text = ((Guna2RadioButton)sender).Name;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            status.Text = dateTimePicker1.Value.ToString();

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(name.Text);
            listView1.Items.Add(name.Text);


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            status.Text = "focused button is pressed";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //guna2PictureBox1.Image = Image.FromFile("ok");
            //guna2PictureBox1.ImageLocation = "";
        }

        private void accept_Click(object sender, EventArgs e)
        {
            status.Text = "accept is pressed ";

        }

        private void guna2CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox4.CheckState == CheckState.Checked)
            {
                guna2CheckBox5.Checked = true;
                guna2CheckBox3.Checked = true;
            }
            else if (guna2CheckBox4.CheckState == CheckState.Unchecked)
            {
                guna2CheckBox5.Checked = false;
                guna2CheckBox3.Checked = false;
            }
            else
            {
                status.Text = guna2CheckBox4.CheckedState.ToString();
            }

        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            guna2CheckBox4.CheckState = CheckState.Indeterminate;
        }

        private void guna2CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            guna2CheckBox4.CheckState = CheckState.Indeterminate;


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Contains(name.Text))
            {
                listBox1.Items.Remove(name.Text);
                //listView1.Items.Remove(name.Text);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listView1.Items.Clear();

        }
    }
}
