namespace P208_Pharmacy
{
    partial class AddMedicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmPrice = new System.Windows.Forms.NumericUpDown();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.chReceipt = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nmVolume = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAddMedicine = new System.Windows.Forms.Button();
            this.dgwMedicines = new System.Windows.Forms.DataGridView();
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.pnTags = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(51, 95);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(320, 40);
            this.txtName.TabIndex = 1;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(448, 95);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(320, 40);
            this.txtBarcode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(429, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Barcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // nmPrice
            // 
            this.nmPrice.DecimalPlaces = 2;
            this.nmPrice.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmPrice.Location = new System.Drawing.Point(51, 217);
            this.nmPrice.Margin = new System.Windows.Forms.Padding(4);
            this.nmPrice.Name = "nmPrice";
            this.nmPrice.Size = new System.Drawing.Size(321, 40);
            this.nmPrice.TabIndex = 6;
            // 
            // nmCount
            // 
            this.nmCount.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmCount.Location = new System.Drawing.Point(448, 217);
            this.nmCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(321, 40);
            this.nmCount.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 33);
            this.label4.TabIndex = 7;
            this.label4.Text = "Count";
            // 
            // chReceipt
            // 
            this.chReceipt.AutoSize = true;
            this.chReceipt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chReceipt.Location = new System.Drawing.Point(51, 290);
            this.chReceipt.Margin = new System.Windows.Forms.Padding(4);
            this.chReceipt.Name = "chReceipt";
            this.chReceipt.Size = new System.Drawing.Size(231, 34);
            this.chReceipt.TabIndex = 9;
            this.chReceipt.Text = "Sell with Receipt";
            this.chReceipt.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 33);
            this.label5.TabIndex = 12;
            this.label5.Text = "Unit";
            // 
            // nmVolume
            // 
            this.nmVolume.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmVolume.Location = new System.Drawing.Point(51, 396);
            this.nmVolume.Margin = new System.Windows.Forms.Padding(4);
            this.nmVolume.Name = "nmVolume";
            this.nmVolume.Size = new System.Drawing.Size(321, 40);
            this.nmVolume.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Volume";
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(448, 396);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(320, 40);
            this.cmbUnit.TabIndex = 14;
            // 
            // btnAddMedicine
            // 
            this.btnAddMedicine.BackColor = System.Drawing.Color.Maroon;
            this.btnAddMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMedicine.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMedicine.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMedicine.Location = new System.Drawing.Point(51, 490);
            this.btnAddMedicine.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMedicine.Name = "btnAddMedicine";
            this.btnAddMedicine.Size = new System.Drawing.Size(718, 108);
            this.btnAddMedicine.TabIndex = 15;
            this.btnAddMedicine.Text = "Add Medicine";
            this.btnAddMedicine.UseVisualStyleBackColor = false;
            this.btnAddMedicine.Click += new System.EventHandler(this.btnAddMedicine_Click);
            // 
            // dgwMedicines
            // 
            this.dgwMedicines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwMedicines.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgwMedicines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMedicines.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwMedicines.Location = new System.Drawing.Point(0, 620);
            this.dgwMedicines.Margin = new System.Windows.Forms.Padding(4);
            this.dgwMedicines.Name = "dgwMedicines";
            this.dgwMedicines.Size = new System.Drawing.Size(1914, 406);
            this.dgwMedicines.TabIndex = 16;
            // 
            // cmbTags
            // 
            this.cmbTags.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTags.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(881, 95);
            this.cmbTags.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(331, 40);
            this.cmbTags.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(876, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 33);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tags";
            // 
            // btnAddTag
            // 
            this.btnAddTag.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTag.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTag.Location = new System.Drawing.Point(881, 170);
            this.btnAddTag.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(332, 101);
            this.btnAddTag.TabIndex = 19;
            this.btnAddTag.Text = "Add Tag";
            this.btnAddTag.UseVisualStyleBackColor = false;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // pnTags
            // 
            this.pnTags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTags.Location = new System.Drawing.Point(1267, 95);
            this.pnTags.Margin = new System.Windows.Forms.Padding(4);
            this.pnTags.Name = "pnTags";
            this.pnTags.Size = new System.Drawing.Size(643, 387);
            this.pnTags.TabIndex = 20;
            this.pnTags.Visible = false;
            // 
            // AddMedicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1914, 1026);
            this.Controls.Add(this.pnTags);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbTags);
            this.Controls.Add(this.dgwMedicines);
            this.Controls.Add(this.btnAddMedicine);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chReceipt);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddMedicine";
            this.Text = "AddMedicine";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddMedicine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMedicines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmPrice;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chReceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmVolume;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.DataGridView dgwMedicines;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.FlowLayoutPanel pnTags;
    }
}