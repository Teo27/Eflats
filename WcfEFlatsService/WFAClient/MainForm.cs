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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm usersFrom = new UsersForm();
            usersFrom.ShowDialog();
        }

        private void btnFlats_Click(object sender, EventArgs e)
        {
            this.Hide();
            FlatsForm flatFrom = new FlatsForm();
            flatFrom.ShowDialog();
        }

        private void btnApplications_Click(object sender, EventArgs e)
        {
            this.Hide();
            ApplicationsForm applicationsForm = new ApplicationsForm();
            applicationsForm.ShowDialog();
        }
    }
}
