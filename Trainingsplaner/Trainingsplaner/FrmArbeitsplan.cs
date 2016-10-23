using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace Trainingsplaner
{
    public partial class FrmArbeitsplan : Form
    {
        public FrmArbeitsplan()
        {
            InitializeComponent();
        }

        private void FrmArbeitsplan_Load(object sender, EventArgs e)
        {
            txtVon.Text = "06643961339";
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string from = txtVon.Text;
            string to = txtTo.Text;
            string msg = richTextBox1.Text;

            WhatsApp wa = new WhatsApp(from, "","",false, false);
            wa.OnConnectSuccess += () =>
            {
                MessageBox.Show("Verbindet mit WhatsApp...");
                wa.OnLoginSuccess += (phoneNumber, data) =>
                {
                    wa.SendMessage(to, msg);
                    MessageBox.Show("Message sent...");
                };

                wa.OnLoginFailed += (data) =>
                {
                    MessageBox.Show("Login failed : {0}", data);
                };

                wa.Login();
            };
            wa.OnConnectFailed += (exc) =>
            {
                MessageBox.Show("Connection failed...");
            };
            wa.Connect();
        }
    }
}
