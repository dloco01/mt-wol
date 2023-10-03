using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using MikrotikDotNet.Exceptions;
using DanilovSoft.MikroApi;

namespace MT_WOL
{
    public partial class MTWol : Form
    {
        public MTWol()
        {
            InitializeComponent();
        }

        private void conn_mt_Click(object sender, EventArgs e)
        {
            String ipAddress = ipAddressTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            int port = 8728;

            try
            {
                using (var con = new MikroTikConnection())
                {
                    con.Connect(ipAddress,port,username,password);

                    var leases = con.Command("/ip dhcp-server lease print")
                        .Query("disabled", "false") // filter
                        .Proplist("address", "mac-address", "host-name", "status")
                        .Send();

         
                    listAddress.Items.Clear();


                    foreach (var lease in leases)
                    {
                        var item = new ListViewItem(lease["address"].ToString());
                        item.SubItems.Add(lease["mac-address"].ToString());
                        item.SubItems.Add(lease["host-name"].ToString());
                        item.SubItems.Add(lease["status"].ToString());

                        listAddress.Items.Add(item);
                    }



                    con.Quit(1000);
                }
            }
            catch (Exception ex)
            {
                responseTextBox.Text = "Error: " + ex.Message;
            }

        }
    }
}
