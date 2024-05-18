namespace GUI_QLPM
{
    partial class KeToa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeToa));
            this.KeThuoc = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddThuoc_SoLuong = new System.Windows.Forms.Button();
            this.maToa = new System.Windows.Forms.TextBox();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.TenThuoc = new System.Windows.Forms.ComboBox();
            this.mapkb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // KeThuoc
            // 
            this.KeThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeThuoc.BackColor = System.Drawing.Color.RosyBrown;
            this.KeThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeThuoc.ForeColor = System.Drawing.Color.Transparent;
            this.KeThuoc.Location = new System.Drawing.Point(314, 169);
            this.KeThuoc.Name = "KeThuoc";
            this.KeThuoc.Size = new System.Drawing.Size(156, 51);
            this.KeThuoc.TabIndex = 0;
            this.KeThuoc.Text = "Kê Thuốc";
            this.KeThuoc.UseVisualStyleBackColor = false;
            this.KeThuoc.Click += new System.EventHandler(this.KeThuoc_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 245);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(800, 205);
            this.grid.TabIndex = 1;
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Toa :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(346, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = " Mã Phiếu Khám Bệnh :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thuốc :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng :";
            // 
            // AddThuoc_SoLuong
            // 
            this.AddThuoc_SoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddThuoc_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddThuoc_SoLuong.Location = new System.Drawing.Point(674, 97);
            this.AddThuoc_SoLuong.Name = "AddThuoc_SoLuong";
            this.AddThuoc_SoLuong.Size = new System.Drawing.Size(37, 44);
            this.AddThuoc_SoLuong.TabIndex = 6;
            this.AddThuoc_SoLuong.Text = "+";
            this.AddThuoc_SoLuong.UseVisualStyleBackColor = true;
            this.AddThuoc_SoLuong.Click += new System.EventHandler(this.AddThuoc_SoLuong_Click);
            // 
            // maToa
            // 
            this.maToa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maToa.Location = new System.Drawing.Point(136, 51);
            this.maToa.Name = "maToa";
            this.maToa.Size = new System.Drawing.Size(185, 30);
            this.maToa.TabIndex = 7;
            // 
            // soLuong
            // 
            this.soLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.Location = new System.Drawing.Point(483, 105);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(176, 30);
            this.soLuong.TabIndex = 10;
            // 
            // TenThuoc
            // 
            this.TenThuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TenThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenThuoc.FormattingEnabled = true;
            this.TenThuoc.Location = new System.Drawing.Point(136, 102);
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Size = new System.Drawing.Size(185, 33);
            this.TenThuoc.TabIndex = 11;
            // 
            // mapkb
            // 
            this.mapkb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mapkb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapkb.FormattingEnabled = true;
            this.mapkb.Location = new System.Drawing.Point(581, 48);
            this.mapkb.Name = "mapkb";
            this.mapkb.Size = new System.Drawing.Size(140, 33);
            this.mapkb.TabIndex = 13;
            // 
            // KeToa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mapkb);
            this.Controls.Add(this.TenThuoc);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.maToa);
            this.Controls.Add(this.AddThuoc_SoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.KeThuoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeToa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kê toa";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KeThuoc;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddThuoc_SoLuong;
        private System.Windows.Forms.TextBox maToa;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.ComboBox TenThuoc;
        private System.Windows.Forms.ComboBox mapkb;
    }
}