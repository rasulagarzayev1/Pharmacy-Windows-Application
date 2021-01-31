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
    public partial class AddMedicine : Form
    {
        private readonly PharmacyEntities2 _db;
        private List<Tag> _medicineTags;

        public AddMedicine()
        {
            InitializeComponent();
            _db = new PharmacyEntities2();
            _medicineTags = new List<Tag>();
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            UpdateMedicineDataGrid();

            cmbUnit.DataSource = _db.Units.Select(u => new Comboitem
            {
                Text = u.Name,
                Value = u.ID
            }).ToList();

            cmbTags.DataSource = _db.Tags.Select(t => new Comboitem()
            {
                Text = t.Name,
                Value = t.ID
            }).ToList();

            //cmbUnit.DataSource = _db.Units.Select(delegate(Unit u) { return u.Name; }).ToList();
        }

        private void UpdateMedicineDataGrid()
        {
            dgwMedicines.DataSource = _db.Medicines.Select(m => new {
                Medicine = m.Name,
                m.Barcode,
                m.Price,
                m.Count,
                m.Volume,
                Unit = m.Unit.Name
            }).ToList();
        }

        private async void btnAddMedicine_Click(object sender, EventArgs e)
        {
            string medicine = txtName.Text.Trim();
            string barcode = txtBarcode.Text.Trim();

            decimal price = nmPrice.Value;
            int count = (int)nmCount.Value;
            bool HasReceipt = chReceipt.Checked;
            int volume = (int)nmVolume.Value;
            Comboitem unit = cmbUnit.SelectedItem as Comboitem;

            Medicine med = new Medicine
            {
                Name = medicine,
                Barcode = barcode,
                Price = price,
                Count = count,
                HasReceipt = HasReceipt,
                Volume = volume,
                UnitID = unit.Value
            };

            if (!CheckMedInput(med))
            {
                MessageBox.Show("Inputs are not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(txtBarcode.Enabled && CheckMedBarcode(txtBarcode.Text))
            {
                MessageBox.Show("This barcode was used by another medicine", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtBarcode.Enabled)
            {
                //add new medicine

                Medicine addedMedicine = null;

                Task newTask = Task.Run(() =>
                {
                    addedMedicine = _db.Medicines.Add(med);
                    _db.SaveChanges();
                });

                await newTask;

                foreach (var tag in _medicineTags)
                {
                    _db.MedicineToTags.Add(new MedicineToTag
                    {
                        MedicineID = addedMedicine.ID,
                        TagID = tag.ID
                    });
                }
                _db.SaveChanges();

                MessageBox.Show("New product was successfully added", "Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //update count of existing medicine
                _db.Medicines.First(m => m.Barcode == txtBarcode.Text).Count += count;
                _db.SaveChanges();

                MessageBox.Show("Product count was successfully updated","Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            UpdateMedicineDataGrid();
            ClearInputs();
        }

        private bool CheckMedInput(Medicine med)
        {
            if(string.IsNullOrEmpty(med.Name) ||
               string.IsNullOrEmpty(med.Barcode) ||
               med.Price <= 0 ||
               med.Count <= 0 ||
               med.Volume <= 0)
            {
                return false;
            }

            return true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string med = txtName.Text.Trim();

            if (!string.IsNullOrEmpty(med))
            {
                Medicine medicine = _db.Medicines.FirstOrDefault(m => m.Name.ToLower() == med.ToLower());

                if(medicine != null)
                {
                    txtBarcode.Text = medicine.Barcode;
                    txtBarcode.Enabled = false;
                }
                else
                {
                    txtBarcode.Text = "";
                    txtBarcode.Enabled = true;
                }
            }
        }

        private bool CheckMedBarcode(string barcode)
        {
            return _db.Medicines.FirstOrDefault(m => m.Barcode == barcode) != null;
        }

        private void ClearInputs()
        {
            foreach (var control in Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if(control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 0;
                }
                else if(control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {

            Comboitem comboitem = cmbTags.SelectedItem as Comboitem;


            if (_medicineTags.FirstOrDefault(t => t.Name == comboitem.Text) != null)
                return;


            Tag newTag = new Tag
            {
                ID = comboitem.Value,
                Name = comboitem.Text
            };
            _medicineTags.Add(newTag);
            UpdateTagsPanelUI();


        }

        private void UpdateTagsPanelUI()
        {
            pnTags.Controls.Clear();

            foreach (var item in _medicineTags)
            {
                Button btn = new Button();
                btn.BackColor = Color.Teal;
                btn.FlatStyle =FlatStyle.Flat;
                btn.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = Color.White;
                btn.Size = new Size(112, 36);
                btn.AutoSize = true;
                btn.Text = $"{item.Name}";
                btn.UseVisualStyleBackColor = false;

                btn.Click += delegate (object sender, EventArgs e)
                {
                    _medicineTags.Remove(item);
                    UpdateTagsPanelUI();
                };

                pnTags.Controls.Add(btn);
            }

            pnTags.Visible = true;
        }

        
    }
}
