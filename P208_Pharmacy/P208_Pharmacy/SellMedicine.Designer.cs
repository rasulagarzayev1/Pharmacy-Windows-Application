namespace P208_Pharmacy
{
    partial class SellMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwMedicines = new System.Windows.Forms.DataGridView();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pnOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFinishHim = new System.Windows.Forms.Button();
            this.txtSearchBarcode = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMedicines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMedicines.Location = new System.Drawing.Point(0, 639);
            this.dgwMedicines.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.Size = new System.Drawing.Size(1613, 406);
            this.dgwMedicines.TabIndex = 17;
            this.dgwMedicines.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwMedicines_RowHeaderMouseDoubleClick);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(311, 75);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.ReadOnly = true;
            this.txtBarcode.Size = new System.Drawing.Size(193, 40);
            this.txtBarcode.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Barcode";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(53, 75);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(215, 40);
            this.txtName.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name";
            // 
            // nmCount
            // 
            this.nmCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCount.Location = new System.Drawing.Point(560, 75);
            this.nmCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmCount.Minimum = new decimal(new int[] {
            15000,
            0,
            0,
            -2147483648});
            this.nmCount.Name = "nmCount";
            this.nmCount.ReadOnly = true;
            this.nmCount.Size = new System.Drawing.Size(249, 40);
            this.nmCount.TabIndex = 23;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nmCount_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(555, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 33);
            this.label4.TabIndex = 22;
            this.label4.Text = "Count";
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.BackColor = System.Drawing.Color.Maroon;
            this.btnAddToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToOrder.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddToOrder.Location = new System.Drawing.Point(1220, 34);
            this.btnAddToOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(377, 108);
            this.btnAddToOrder.TabIndex = 24;
            this.btnAddToOrder.Text = "Add";
            this.btnAddToOrder.UseVisualStyleBackColor = false;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 33);
            this.label3.TabIndex = 25;
            this.label3.Text = "Search by name:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTags);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSearchBarcode);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSearchName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 528);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1613, 111);
            this.panel1.TabIndex = 27;
            // 
            // txtTags
            // 
            this.txtTags.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTags.Location = new System.Drawing.Point(768, 63);
            this.txtTags.Margin = new System.Windows.Forms.Padding(4);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(320, 40);
            this.txtTags.TabIndex = 30;
            this.txtTags.TextChanged += new System.EventHandler(this.txtTags_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(762, 18);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 33);
            this.label7.TabIndex = 29;
            this.label7.Text = "Search by tag:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 33);
            this.label5.TabIndex = 27;
            this.label5.Text = "Search by barcode:";
            // 
            // nmPrice
            // 
            this.nmPrice.DecimalPlaces = 2;
            this.nmPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.Location = new System.Drawing.Point(857, 75);
            this.nmPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmPrice.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.ReadOnly = true;
            this.nmPrice.Size = new System.Drawing.Size(216, 40);
            this.nmPrice.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(852, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 33);
            this.label6.TabIndex = 28;
            this.label6.Text = "Total Price";
            // 
            // pnOrders
            // 
            this.pnOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnOrders.Location = new System.Drawing.Point(53, 197);
            this.pnOrders.Margin = new System.Windows.Forms.Padding(4);
            this.pnOrders.Name = "pnOrders";
            this.pnOrders.Size = new System.Drawing.Size(1020, 262);
            this.pnOrders.TabIndex = 30;
            // 
            // btnFinishHim
            // 
            this.btnFinishHim.BackColor = System.Drawing.Color.Teal;
            this.btnFinishHim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinishHim.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinishHim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFinishHim.Location = new System.Drawing.Point(1220, 197);
            this.btnFinishHim.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishHim.Name = "btnFinishHim";
            this.btnFinishHim.Size = new System.Drawing.Size(377, 364);
            this.btnFinishHim.TabIndex = 31;
            this.btnFinishHim.Text = "Finish Him";
            this.btnFinishHim.UseVisualStyleBackColor = false;
            this.btnFinishHim.Visible = false;
            this.btnFinishHim.Click += new System.EventHandler(this.btnFinishHim_Click);
            // 
            // txtSearchBarcode
            // 
            this.txtSearchBarcode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBarcode.Location = new System.Drawing.Point(411, 63);
            this.txtSearchBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBarcode.Name = "txtSearchBarcode";
            this.txtSearchBarcode.Size = new System.Drawing.Size(320, 40);
            this.txtSearchBarcode.TabIndex = 28;
            this.txtSearchBarcode.TextChanged += new System.EventHandler(this.txtSearchBarcode_TextChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(28, 63);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(320, 40);
            this.txtSearchName.TabIndex = 26;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // SellMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1045);
            this.Controls.Add(this.btnFinishHim);
            this.Controls.Add(this.pnOrders);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddToOrder);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMedicines);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellMedicine";
            this.Text = "SellMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMedicines;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel pnOrders;
        private System.Windows.Forms.Button btnFinishHim;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearchBarcode;
        private System.Windows.Forms.TextBox txtSearchName;
    }
}