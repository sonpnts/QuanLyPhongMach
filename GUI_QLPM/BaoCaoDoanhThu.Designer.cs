namespace GUI_QLPM
{
    partial class BaoCaoDoanhThu
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
            this.thang = new System.Windows.Forms.ComboBox();
            this.nam = new System.Windows.Forms.ComboBox();
            this.Xem = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // thang
            // 
            this.thang.FormattingEnabled = true;
            this.thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.thang.Location = new System.Drawing.Point(256, 63);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(121, 24);
            this.thang.TabIndex = 0;
            this.thang.Text = "Tháng";
            // 
            // nam
            // 
            this.nam.FormattingEnabled = true;
            this.nam.Items.AddRange(new object[] {
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "",
            ""});
            this.nam.Location = new System.Drawing.Point(423, 63);
            this.nam.Name = "nam";
            this.nam.Size = new System.Drawing.Size(121, 24);
            this.nam.TabIndex = 1;
            this.nam.Text = "Năm";
            // 
            // Xem
            // 
            this.Xem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Xem.Location = new System.Drawing.Point(336, 112);
            this.Xem.Name = "Xem";
            this.Xem.Size = new System.Drawing.Size(129, 45);
            this.Xem.TabIndex = 2;
            this.Xem.Text = "XEM";
            this.Xem.UseVisualStyleBackColor = false;
            this.Xem.Click += new System.EventHandler(this.Xem_Click);
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 185);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(800, 265);
            this.grid.TabIndex = 3;
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Xem);
            this.Controls.Add(this.nam);
            this.Controls.Add(this.thang);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "BaoCaoDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox thang;
        private System.Windows.Forms.ComboBox nam;
        private System.Windows.Forms.Button Xem;
        private System.Windows.Forms.DataGridView grid;
    }
}