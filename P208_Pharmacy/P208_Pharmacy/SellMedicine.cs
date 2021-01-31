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
    public partial class SellMedicine : Form
    {
        private readonly PharmacyEntities2 _db;
        private Medicine OrderedMedicine;
        private List<OrderedMedicine> orderedMedicines;
        
        public SellMedicine()
        {
            InitializeComponent();
            _db = new PharmacyEntities2();
            orderedMedicines = new List<OrderedMedicine>();
        }

        private void SellMedicine_Load(object sender, EventArgs e)
        {
            UpdateMedicineDataGrid();
        }

        private void UpdateMedicineDataGrid(string med = "", string barcode = "",string tag="")
        {
            #region Comment Search by intersect
            //List<Medicine> byName = _db.Medicines.Where(m => m.Name.Contains(med)).ToList(); 
            //List<Medicine> byBarcode = _db.Medicines.Where(m => m.Barcode.Contains(barcode)).ToList();

            //dgwMedicines.DataSource = byName.Intersect(byBarcode).Select(m => new
            //{
            //    Medicine = m.Name,
            //    m.Barcode,
            //    m.Price,
            //    m.Count,
            //    m.Volume,
            //    Unit = m.Unit.Name
            //}).ToList();
            #endregion

            //Search by AND

            dgwMedicines.DataSource = _db.Medicines
            .Where(m => m.Name.Contains(med) && m.Barcode.Contains(barcode))
            .Select(m => new
            {
                m.ID,
                Medicine = m.Name,
                m.Barcode,
                m.Price,
                m.Count,
                m.Volume,
                Unit = m.Unit.Name
            }).ToList();

            dgwMedicines.DataSource = _db.MedicineToTags.Where(m => m.Tag.Name.Contains(tag)).Select(
                m => new
                {
                    m.ID,
                    m.Medicine.Name,
                    m.Medicine.Barcode,
                    m.Medicine.Price,
                    m.Medicine.Count,
                    m.Medicine.Volume,
                    Unit = m.Medicine.Unit.Name
                }).ToList();

            dgwMedicines.Columns[0].Visible = false;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            string medicine = txtSearchName.Text.Trim();
            UpdateMedicineDataGrid(med: medicine);
        }

        private void txtSearchBarcode_TextChanged(object sender, EventArgs e)
        {
            string barcode = txtSearchBarcode.Text.Trim();
            UpdateMedicineDataGrid(barcode: barcode);
        }
        private void txtTags_TextChanged(object sender, EventArgs e)
        {
            string tag = txtTags.Text.Trim();
            UpdateMedicineDataGrid(tag:tag);
        }
        private void dgwMedicines_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nmCount.Value = 1;
            int id = (int)dgwMedicines.Rows[e.RowIndex].Cells[0].Value;

            OrderedMedicine = _db.Medicines.Find(id); //

            txtName.Text = OrderedMedicine.Name;
            txtBarcode.Text = OrderedMedicine.Barcode;
            nmCount.ReadOnly = false;

            nmCount.Maximum = Convert.ToDecimal(OrderedMedicine.Count);
        }

        private void nmCount_KeyUp(object sender, KeyEventArgs e)
        {
            int count = Convert.ToInt32(nmCount.Value);
            //decimal sum = (decimal)(count * OrderedMedicine.Price);
            //nmPrice.Value = sum < 0 ? 0 : sum;

            nmPrice.Value = Math.Max((decimal)(count * OrderedMedicine.Price), 0);
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            bool exists = false;

            //UPDATE MEDICINE IF EXISTS IN THE LIST
            foreach (var item in orderedMedicines)
            {
                if(item.Medicine == OrderedMedicine)
                {
                    if(item.OrderCount + (int)nmCount.Value > item.Medicine.Count)
                    {
                        MessageBox.Show($"There is not enough medicine of {item.Medicine.Name}." +
                            $" Maximum count: {item.Medicine.Count - item.OrderCount}");
                        return;
                    }

                    item.OrderCount += (int)nmCount.Value;
                    exists = true;
                    break;
                }
            }

            //ADD NEW MEDICINE TO ORDER LIST
            if (!exists)
            {
                OrderedMedicine ordMed = new OrderedMedicine
                {
                    Medicine = OrderedMedicine,
                    OrderCount = (int)nmCount.Value
                };
                orderedMedicines.Add(ordMed);
            }
            
            FillOrdersUI();
        }

        private void FillOrdersUI()
        {
            pnOrders.Controls.Clear();

            foreach (OrderedMedicine ordMed in orderedMedicines)
            {
                Button btn = new Button();
                btn.BackColor = System.Drawing.Color.Teal;
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.White;
                btn.Size = new System.Drawing.Size(112, 36);
                btn.AutoSize = true;
                btn.Text = $"{ordMed.Medicine.Name} - {ordMed.OrderCount}";
                btn.UseVisualStyleBackColor = false;

                btn.Click += delegate (object sender, EventArgs e)
                {
                    DialogResult result = 
                        MessageBox.Show($"Are you sure to delete {ordMed.Medicine.Name}?",
                    "Caution! Warning! Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if(result == DialogResult.Yes)
                    {
                        pnOrders.Controls.Remove(btn);
                        orderedMedicines.Remove(ordMed);
                        FillOrdersUI();
                    }
                    
                };

                pnOrders.Controls.Add(btn);
            }

            if (orderedMedicines.Count > 0)
                btnFinishHim.Visible = true;
            else
                btnFinishHim.Visible = false;
        }

        private void btnFinishHim_Click(object sender, EventArgs e)
        {
            foreach (OrderedMedicine ordMed in orderedMedicines)
            {
                _db.Orders.Add(new Order
                {
                    MedicineID = ordMed.Medicine.ID,
                    Count = ordMed.OrderCount,
                    OrderDate = DateTime.Now,
                    Price = ordMed.Medicine.Price
                });

                _db.Medicines.Find(ordMed.Medicine.ID).Count -= ordMed.OrderCount;
            }
            _db.SaveChanges();

            UpdateMedicineDataGrid();

            MessageBox.Show("All ordered added successfully","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        
    }
}
