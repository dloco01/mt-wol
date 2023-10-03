
namespace MT_WOL
{
    partial class MTWol
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
            System.Windows.Forms.ColumnHeader columnIP;
            System.Windows.Forms.ColumnHeader columnMAC;
            System.Windows.Forms.ColumnHeader columnHostname;
            System.Windows.Forms.ColumnHeader columnStatus;
            this.conn_mt = new System.Windows.Forms.Button();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ip = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.responseTextBox = new System.Windows.Forms.Label();
            this.listAddress = new System.Windows.Forms.ListView();
            columnIP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHostname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // conn_mt
            // 
            this.conn_mt.Location = new System.Drawing.Point(310, 89);
            this.conn_mt.Name = "conn_mt";
            this.conn_mt.Size = new System.Drawing.Size(130, 40);
            this.conn_mt.TabIndex = 1;
            this.conn_mt.Text = "Connet To Mikrotik";
            this.conn_mt.UseVisualStyleBackColor = true;
            this.conn_mt.Click += new System.EventHandler(this.conn_mt_Click);
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(188, 42);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.ipAddressTextBox.TabIndex = 2;
            this.ipAddressTextBox.Text = "10.10.11.1";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(365, 42);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
            this.usernameTextBox.TabIndex = 3;
            this.usernameTextBox.Text = "admin";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(537, 45);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "Denideni10!";
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(121, 45);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(58, 13);
            this.ip.TabIndex = 5;
            this.ip.Text = "IP Address";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(301, 45);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(55, 13);
            this.user.TabIndex = 6;
            this.user.Text = "Username";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(475, 48);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(53, 13);
            this.pass.TabIndex = 7;
            this.pass.Text = "Password";
            // 
            // responseTextBox
            // 
            this.responseTextBox.AutoSize = true;
            this.responseTextBox.Location = new System.Drawing.Point(341, 9);
            this.responseTextBox.Name = "responseTextBox";
            this.responseTextBox.Size = new System.Drawing.Size(32, 13);
            this.responseTextBox.TabIndex = 8;
            this.responseTextBox.Text = "INFO";
            // 
            // listAddress
            // 
            this.listAddress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnIP,
            columnMAC,
            columnHostname,
            columnStatus});
            this.listAddress.HideSelection = false;
            this.listAddress.Location = new System.Drawing.Point(57, 135);
            this.listAddress.Name = "listAddress";
            this.listAddress.Size = new System.Drawing.Size(676, 303);
            this.listAddress.TabIndex = 13;
            this.listAddress.UseCompatibleStateImageBehavior = false;
            this.listAddress.View = System.Windows.Forms.View.Details;
            // 
            // columnIP
            // 
            columnIP.Text = "IP";
            columnIP.Width = 143;
            // 
            // columnMAC
            // 
            columnMAC.Text = "MAC";
            columnMAC.Width = 151;
            // 
            // columnHostname
            // 
            columnHostname.Text = "Host Name";
            columnHostname.Width = 181;
            // 
            // columnStatus
            // 
            columnStatus.Text = "Status";
            columnStatus.Width = 132;
            // 
            // MTWol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listAddress);
            this.Controls.Add(this.responseTextBox);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.conn_mt);
            this.MaximizeBox = false;
            this.Name = "MTWol";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button conn_mt;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label responseTextBox;
        private System.Windows.Forms.ListView listAddress;
    }
}

