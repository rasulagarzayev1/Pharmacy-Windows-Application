using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P208_Pharmacy.Model;

namespace P208_Pharmacy
{
    public partial class Report : Form
    {
        private readonly PharmacyEntities2 _db;
        public Report()
        {
            InitializeComponent();
            _db = new PharmacyEntities2();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dgwReport.DataSource = _db.Orders.Select(o => new
            {
                o.ID,
                Medicine = o.Medicine.Name,
                o.OrderDate,
                o.Price,
                o.Count
            }).ToList();
            dgwReport.Columns[0].Visible = false;


        }

        private void nmYear_ValueChanged(object sender, EventArgs e)
        {
            dgwReport.DataSource = _db.Orders.Where(o => o.OrderDate.Value.Year == (int)nmYear.Value).Select(o => new
            {
                o.ID,
                Medicine = o.Medicine.Name,
                o.OrderDate,
                o.Price,
                o.Count
            }).ToList();
            dgwReport.Columns[0].Visible = false;
        }

        private void nmMonth_ValueChanged(object sender, EventArgs e)
        {
            dgwReport.DataSource = _db.Orders.Where(o => o.OrderDate.Value.Month == (int)nmMonth.Value).Select(o => new
            {
                o.ID,
                Medicine = o.Medicine.Name,
                o.OrderDate,
                o.Price,
                o.Count
            }).ToList();
            dgwReport.Columns[0].Visible = false;
        }

        private void nmDay_ValueChanged(object sender, EventArgs e)
        {
            dgwReport.DataSource = _db.Orders.Where(o => o.OrderDate.Value.Day == (int)nmDay.Value).Select(o => new
            {
                o.ID,
                Medicine = o.Medicine.Name,
                o.OrderDate,
                o.Price,
                o.Count
            }).ToList();
            dgwReport.Columns[0].Visible = false;
        }

       
    
    }
}
