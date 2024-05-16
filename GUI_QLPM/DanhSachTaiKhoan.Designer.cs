namespace GUI_QLPM
{
    partial class DanhSachTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachTaiKhoan));
            this.QuayLai = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.maThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gird = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // QuayLai
            // 
            this.QuayLai.BackColor = System.Drawing.Color.RosyBrown;
            this.QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuayLai.ForeColor = System.Drawing.Color.Transparent;
            this.QuayLai.Location = new System.Drawing.Point(513, 114);
            this.QuayLai.Name = "QuayLai";
            this.QuayLai.Size = new System.Drawing.Size(130, 49);
            this.QuayLai.TabIndex = 15;
            this.QuayLai.Text = "Quay lại";
            this.QuayLai.UseVisualStyleBackColor = false;
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.RosyBrown;
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.Transparent;
            this.Them.Location = new System.Drawing.Point(335, 114);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(130, 49);
            this.Them.TabIndex = 14;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.RosyBrown;
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.TimKiem.Location = new System.Drawing.Point(157, 114);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(130, 49);
            this.TimKiem.TabIndex = 13;
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.UseVisualStyleBackColor = false;
            // 
            // maThuoc
            // 
            this.maThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThuoc.Location = new System.Drawing.Point(322, 33);
            this.maThuoc.Multiline = true;
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Size = new System.Drawing.Size(313, 36);
            this.maThuoc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 192);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(800, 258);
            this.gird.TabIndex = 16;
            // 
            // DanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.QuayLai);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.maThuoc);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachTaiKhoan";
            this.Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuayLai;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.TextBox maThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gird;
    }
}