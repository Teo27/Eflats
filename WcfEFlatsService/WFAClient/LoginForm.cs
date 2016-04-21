using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAClient
{
    public partial class LoginForm : Form
    {
        //global variables
        EFlatsServiceReference.WcfEFlatsServiceAdminClient clientAdmin;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            //check if fields are empty
            if(String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                lblOutput.Text = "Please enter username and password";
                return;
            }

            try
            {
                clientAdmin = new EFlatsServiceReference.WcfEFlatsServiceAdminClient("NetTcpBinding_IWcfEFlatsServiceAdmin");
                switch (clientAdmin.AdminLogin(username, password))
                {
                    //1 - success, 2 - passwords dont match, 3 - emails dont match, else - not connected to wcf or db
                    case 1: { this.Hide(); MainForm mainForm = new MainForm(); mainForm.ShowDialog(); break; }
                    case 2: { lblOutput.Text = "Incorrect Username or Password"; break; }
                    case 3: { lblOutput.Text = "Incorrect Username or Password"; break; }
                    default: { lblOutput.Text = "Unable to connect - Try again"; break; }
                }
            }
            catch
            {
                lblOutput.Text = "Unable to connect - Restart application and Try again";
                return;
            }
        }
    }
}
