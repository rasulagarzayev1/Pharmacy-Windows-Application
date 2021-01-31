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
    public partial class AddTags : Form
    {
        private readonly PharmacyEntities2 db;
        public AddTags()
        {
            InitializeComponent();
            db = new PharmacyEntities2();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string tagname = txtTagname.Text;

            Tag tag = new Tag
            {
                Name = tagname
            };

            if (String.IsNullOrEmpty(tagname))
            {
                MessageBox.Show("Inputs are not valid.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (db.Tags.FirstOrDefault(t=>t.Name==tagname)!=null)
            {
                MessageBox.Show("Tag with this name is already exists.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            db.Tags.Add(tag);
            db.SaveChanges();
            txtTagname.Clear();
            MessageBox.Show($"New tag {tagname} added successfully","Success",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
