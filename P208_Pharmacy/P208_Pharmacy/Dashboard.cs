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
    public partial class Dashboard : Form
    {
        private readonly Login _loginForm;
        public Dashboard(Login login)
        {
            InitializeComponent();
            _loginForm = login;
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.Show();
        }

        private void btnMedicines_Click(object sender, EventArgs e)
        {
            new AddMedicine().ShowDialog();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            new SellMedicine().ShowDialog();
        }

        private void btnAddTags_Click(object sender, EventArgs e)
        {
            new AddTags().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new Report().ShowDialog();
        }
    }
}
