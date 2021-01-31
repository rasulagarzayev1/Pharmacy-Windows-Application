using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P208_Pharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string pass = txtPassword.Text.Trim();
            string adminPass = Properties.Settings.Default.Password;

            if(string.IsNullOrEmpty(pass) ||
                pass != adminPass)
            {
                MessageBox.Show("Password is wrong.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            txtPassword.Text = "";
            Hide();
            new Dashboard(this).ShowDialog();
        }
    }
}
