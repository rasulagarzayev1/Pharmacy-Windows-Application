namespace P208_Pharmacy
{
    partial class Report
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
            this.dgwReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmYear = new System.Windows.Forms.NumericUpDown();
            this.nmMonth = new System.Windows.Forms.NumericUpDown();
            this.nmDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDay)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwReport
            // 
            this.dgwReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwReport.Location = new System.Drawing.Point(0, 328);
            this.dgwReport.Name = "dgwReport";
            this.dgwReport.RowTemplate.Height = 24;
            this.dgwReport.Size = new System.Drawing.Size(1176, 439);
            this.dgwReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1176, 101);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 33);
            this.label5.TabIndex = 29;
            this.label5.Text = "Search by year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 33);
            this.label2.TabIndex = 31;
            this.label2.Text = "Search by month:";
            // 
            // nmYear
            // 
            this.nmYear.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmYear.Location = new System.Drawing.Point(19, 258);
            this.nmYear.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmYear.Name = "nmYear";
            this.nmYear.Size = new System.Drawing.Size(320, 41);
            this.nmYear.TabIndex = 33;
            this.nmYear.ValueChanged += new System.EventHandler(this.nmYear_ValueChanged);
            // 
            // nmMonth
            // 
            this.nmMonth.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmMonth.Location = new System.Drawing.Point(403, 258);
            this.nmMonth.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmMonth.Name = "nmMonth";
            this.nmMonth.Size = new System.Drawing.Size(320, 41);
            this.nmMonth.TabIndex = 34;
            this.nmMonth.ValueChanged += new System.EventHandler(this.nmMonth_ValueChanged);
            // 
            // nmDay
            // 
            this.nmDay.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmDay.Location = new System.Drawing.Point(798, 258);
            this.nmDay.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nmDay.Name = "nmDay";
            this.nmDay.Size = new System.Drawing.Size(320, 41);
            this.nmDay.TabIndex = 36;
            this.nmDay.ValueChanged += new System.EventHandler(this.nmDay_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(792, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 33);
            this.label3.TabIndex = 35;
            this.label3.Text = "Search by day:";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 767);
            this.Controls.Add(this.nmDay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmMonth);
            this.Controls.Add(this.nmYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwReport);
            this.Name = "Report";
            this.Text = "Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmYear;
        private System.Windows.Forms.NumericUpDown nmMonth;
        private System.Windows.Forms.NumericUpDown nmDay;
        private System.Windows.Forms.Label label3;
    }
}