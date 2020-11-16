namespace local_chat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Friend = new System.Windows.Forms.GroupBox();
            this.textRemotePort = new Guna.UI2.WinForms.Guna2TextBox();
            this.textRemoteIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Me = new System.Windows.Forms.GroupBox();
            this.textLocalPort = new Guna.UI2.WinForms.Guna2TextBox();
            this.textLocalIP = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.buttonConnect = new Guna.UI2.WinForms.Guna2Button();
            this.textMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.List_Message = new System.Windows.Forms.ListBox();
            this.buttonSent = new Guna.UI2.WinForms.Guna2Button();
            this.Friend.SuspendLayout();
            this.Me.SuspendLayout();
            this.SuspendLayout();
            // 
            // Friend
            // 
            this.Friend.Controls.Add(this.textRemotePort);
            this.Friend.Controls.Add(this.textRemoteIP);
            this.Friend.Controls.Add(this.guna2HtmlLabel2);
            this.Friend.Controls.Add(this.guna2HtmlLabel1);
            this.Friend.Location = new System.Drawing.Point(382, 21);
            this.Friend.Name = "Friend";
            this.Friend.Size = new System.Drawing.Size(293, 100);
            this.Friend.TabIndex = 2;
            this.Friend.TabStop = false;
            this.Friend.Text = "Friend";
            // 
            // textRemotePort
            // 
            this.textRemotePort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRemotePort.DefaultText = "";
            this.textRemotePort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textRemotePort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textRemotePort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRemotePort.DisabledState.Parent = this.textRemotePort;
            this.textRemotePort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRemotePort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRemotePort.FocusedState.Parent = this.textRemotePort;
            this.textRemotePort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textRemotePort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRemotePort.HoverState.Parent = this.textRemotePort;
            this.textRemotePort.Location = new System.Drawing.Point(95, 55);
            this.textRemotePort.Name = "textRemotePort";
            this.textRemotePort.PasswordChar = '\0';
            this.textRemotePort.PlaceholderText = "";
            this.textRemotePort.SelectedText = "";
            this.textRemotePort.ShadowDecoration.Parent = this.textRemotePort;
            this.textRemotePort.Size = new System.Drawing.Size(183, 27);
            this.textRemotePort.TabIndex = 6;
            // 
            // textRemoteIP
            // 
            this.textRemoteIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textRemoteIP.DefaultText = "";
            this.textRemoteIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textRemoteIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textRemoteIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRemoteIP.DisabledState.Parent = this.textRemoteIP;
            this.textRemoteIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textRemoteIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRemoteIP.FocusedState.Parent = this.textRemoteIP;
            this.textRemoteIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textRemoteIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textRemoteIP.HoverState.Parent = this.textRemoteIP;
            this.textRemoteIP.Location = new System.Drawing.Point(95, 19);
            this.textRemoteIP.Name = "textRemoteIP";
            this.textRemoteIP.PasswordChar = '\0';
            this.textRemoteIP.PlaceholderText = "";
            this.textRemoteIP.SelectedText = "";
            this.textRemoteIP.ShadowDecoration.Parent = this.textRemoteIP;
            this.textRemoteIP.Size = new System.Drawing.Size(183, 27);
            this.textRemoteIP.TabIndex = 5;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(21, 55);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(22, 15);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Port";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(21, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(13, 15);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "IP";
            // 
            // Me
            // 
            this.Me.Controls.Add(this.textLocalPort);
            this.Me.Controls.Add(this.textLocalIP);
            this.Me.Controls.Add(this.guna2HtmlLabel3);
            this.Me.Controls.Add(this.guna2HtmlLabel4);
            this.Me.Location = new System.Drawing.Point(12, 21);
            this.Me.Name = "Me";
            this.Me.Size = new System.Drawing.Size(293, 100);
            this.Me.TabIndex = 7;
            this.Me.TabStop = false;
            this.Me.Text = "Me";
            // 
            // textLocalPort
            // 
            this.textLocalPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLocalPort.DefaultText = "";
            this.textLocalPort.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLocalPort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLocalPort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLocalPort.DisabledState.Parent = this.textLocalPort;
            this.textLocalPort.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLocalPort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLocalPort.FocusedState.Parent = this.textLocalPort;
            this.textLocalPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textLocalPort.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLocalPort.HoverState.Parent = this.textLocalPort;
            this.textLocalPort.Location = new System.Drawing.Point(95, 55);
            this.textLocalPort.Name = "textLocalPort";
            this.textLocalPort.PasswordChar = '\0';
            this.textLocalPort.PlaceholderText = "";
            this.textLocalPort.SelectedText = "";
            this.textLocalPort.ShadowDecoration.Parent = this.textLocalPort;
            this.textLocalPort.Size = new System.Drawing.Size(183, 27);
            this.textLocalPort.TabIndex = 6;
            // 
            // textLocalIP
            // 
            this.textLocalIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textLocalIP.DefaultText = "";
            this.textLocalIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textLocalIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textLocalIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLocalIP.DisabledState.Parent = this.textLocalIP;
            this.textLocalIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textLocalIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLocalIP.FocusedState.Parent = this.textLocalIP;
            this.textLocalIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textLocalIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textLocalIP.HoverState.Parent = this.textLocalIP;
            this.textLocalIP.Location = new System.Drawing.Point(95, 19);
            this.textLocalIP.Name = "textLocalIP";
            this.textLocalIP.PasswordChar = '\0';
            this.textLocalIP.PlaceholderText = "";
            this.textLocalIP.SelectedText = "";
            this.textLocalIP.ShadowDecoration.Parent = this.textLocalIP;
            this.textLocalIP.Size = new System.Drawing.Size(183, 27);
            this.textLocalIP.TabIndex = 5;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(21, 55);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(22, 15);
            this.guna2HtmlLabel3.TabIndex = 3;
            this.guna2HtmlLabel3.Text = "Port";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(21, 20);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(13, 15);
            this.guna2HtmlLabel4.TabIndex = 2;
            this.guna2HtmlLabel4.Text = "IP";
            // 
            // buttonConnect
            // 
            this.buttonConnect.BorderRadius = 15;
            this.buttonConnect.CheckedState.Parent = this.buttonConnect;
            this.buttonConnect.CustomImages.Parent = this.buttonConnect;
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.HoverState.Parent = this.buttonConnect;
            this.buttonConnect.Location = new System.Drawing.Point(699, 46);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.ShadowDecoration.Parent = this.buttonConnect;
            this.buttonConnect.Size = new System.Drawing.Size(89, 45);
            this.buttonConnect.TabIndex = 8;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // textMessage
            // 
            this.textMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textMessage.DefaultText = "";
            this.textMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.DisabledState.Parent = this.textMessage;
            this.textMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.FocusedState.Parent = this.textMessage;
            this.textMessage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textMessage.HoverState.Parent = this.textMessage;
            this.textMessage.Location = new System.Drawing.Point(22, 374);
            this.textMessage.Name = "textMessage";
            this.textMessage.PasswordChar = '\0';
            this.textMessage.PlaceholderText = "";
            this.textMessage.SelectedText = "";
            this.textMessage.ShadowDecoration.Parent = this.textMessage;
            this.textMessage.Size = new System.Drawing.Size(653, 35);
            this.textMessage.TabIndex = 7;
            // 
            // List_Message
            // 
            this.List_Message.FormattingEnabled = true;
            this.List_Message.Location = new System.Drawing.Point(22, 145);
            this.List_Message.Name = "List_Message";
            this.List_Message.Size = new System.Drawing.Size(653, 212);
            this.List_Message.TabIndex = 9;
            // 
            // buttonSent
            // 
            this.buttonSent.BorderRadius = 15;
            this.buttonSent.CheckedState.Parent = this.buttonSent;
            this.buttonSent.CustomImages.Parent = this.buttonSent;
            this.buttonSent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonSent.ForeColor = System.Drawing.Color.White;
            this.buttonSent.HoverState.Parent = this.buttonSent;
            this.buttonSent.Location = new System.Drawing.Point(699, 364);
            this.buttonSent.Name = "buttonSent";
            this.buttonSent.ShadowDecoration.Parent = this.buttonSent;
            this.buttonSent.Size = new System.Drawing.Size(89, 45);
            this.buttonSent.TabIndex = 10;
            this.buttonSent.Text = "Send";
            this.buttonSent.Click += new System.EventHandler(this.buttonSent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSent);
            this.Controls.Add(this.List_Message);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.Me);
            this.Controls.Add(this.Friend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Friend.ResumeLayout(false);
            this.Friend.PerformLayout();
            this.Me.ResumeLayout(false);
            this.Me.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox Friend;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textRemotePort;
        private Guna.UI2.WinForms.Guna2TextBox textRemoteIP;
        private System.Windows.Forms.GroupBox Me;
        private Guna.UI2.WinForms.Guna2TextBox textLocalPort;
        private Guna.UI2.WinForms.Guna2TextBox textLocalIP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button buttonConnect;
        private Guna.UI2.WinForms.Guna2TextBox textMessage;
        private System.Windows.Forms.ListBox List_Message;
        private Guna.UI2.WinForms.Guna2Button buttonSent;
    }
}

