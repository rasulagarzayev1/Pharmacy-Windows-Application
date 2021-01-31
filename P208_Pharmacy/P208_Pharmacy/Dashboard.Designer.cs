namespace P208_Pharmacy
{
    partial class Dashboard
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
            this.btnMedicines = new System.Windows.Forms.Button();
            this.btnSell = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAddTags = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMedicines
            // 
            this.btnMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMedicines.AutoSize = true;
            this.btnMedicines.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnMedicines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicines.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMedicines.Location = new System.Drawing.Point(34, 66);
            this.btnMedicines.Name = "btnMedicines";
            this.btnMedicines.Size = new System.Drawing.Size(443, 122);
            this.btnMedicines.TabIndex = 2;
            this.btnMedicines.Text = "MEDICINES";
            this.btnMedicines.UseVisualStyleBackColor = false;
            this.btnMedicines.Click += new System.EventHandler(this.btnMedicines_Click);
            // 
            // btnSell
            // 
            this.btnSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSell.AutoSize = true;
            this.btnSell.BackColor = System.Drawing.Color.DarkRed;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSell.Location = new System.Drawing.Point(34, 386);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(443, 125);
            this.btnSell.TabIndex = 3;
            this.btnSell.Text = "SELL";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReport.AutoSize = true;
            this.btnReport.BackColor = System.Drawing.Color.DarkGreen;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReport.Location = new System.Drawing.Point(34, 578);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(443, 124);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "REPORT";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnAddTags
            // 
            this.btnAddTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddTags.AutoSize = true;
            this.btnAddTags.BackColor = System.Drawing.Color.Gold;
            this.btnAddTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTags.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTags.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddTags.Location = new System.Drawing.Point(34, 231);
            this.btnAddTags.Name = "btnAddTags";
            this.btnAddTags.Size = new System.Drawing.Size(443, 122);
            this.btnAddTags.TabIndex = 5;
            this.btnAddTags.Text = "TAGS";
            this.btnAddTags.UseVisualStyleBackColor = false;
            this.btnAddTags.Click += new System.EventHandler(this.btnAddTags_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 757);
            this.Controls.Add(this.btnAddTags);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnMedicines);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMedicines;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAddTags;
    }
}

