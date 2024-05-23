namespace GUI_QLPM
{
    partial class QuanLyDichVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyDichVu));
            this.gird = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.maDichVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.suadichvu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTienDV = new System.Windows.Forms.TextBox();
            this.xoadv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 255);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(1582, 398);
            this.gird.TabIndex = 23;
            this.gird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(1094, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 44);
            this.button3.TabIndex = 22;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(877, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.RosyBrown;
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.TimKiem.Location = new System.Drawing.Point(1084, 23);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(171, 44);
            this.TimKiem.TabIndex = 20;
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.UseVisualStyleBackColor = false;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // maDichVu
            // 
            this.maDichVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maDichVu.Location = new System.Drawing.Point(577, 32);
            this.maDichVu.Multiline = true;
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.Size = new System.Drawing.Size(459, 34);
            this.maDichVu.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // suadichvu
            // 
            this.suadichvu.BackColor = System.Drawing.Color.RosyBrown;
            this.suadichvu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suadichvu.ForeColor = System.Drawing.Color.Transparent;
            this.suadichvu.Location = new System.Drawing.Point(651, 161);
            this.suadichvu.Name = "suadichvu";
            this.suadichvu.Size = new System.Drawing.Size(187, 44);
            this.suadichvu.TabIndex = 21;
            this.suadichvu.Text = "Sửa dịch vụ";
            this.suadichvu.UseVisualStyleBackColor = false;
            this.suadichvu.Click += new System.EventHandler(this.suadichvu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên dịch vụ:";
            // 
            // txtTenDV
            // 
            this.txtTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDV.Location = new System.Drawing.Point(443, 127);
            this.txtTenDV.Multiline = true;
            this.txtTenDV.Name = "txtTenDV";
            this.txtTenDV.Size = new System.Drawing.Size(202, 36);
            this.txtTenDV.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(317, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tiền dịch vụ:";
            // 
            // txtTienDV
            // 
            this.txtTienDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienDV.Location = new System.Drawing.Point(443, 169);
            this.txtTienDV.Multiline = true;
            this.txtTienDV.Name = "txtTienDV";
            this.txtTienDV.Size = new System.Drawing.Size(202, 36);
            this.txtTienDV.TabIndex = 19;
            // 
            // xoadv
            // 
            this.xoadv.BackColor = System.Drawing.Color.RosyBrown;
            this.xoadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoadv.ForeColor = System.Drawing.Color.Transparent;
            this.xoadv.Location = new System.Drawing.Point(651, 114);
            this.xoadv.Name = "xoadv";
            this.xoadv.Size = new System.Drawing.Size(187, 44);
            this.xoadv.TabIndex = 21;
            this.xoadv.Text = "Xóa dịch vụ";
            this.xoadv.UseVisualStyleBackColor = false;
            this.xoadv.Click += new System.EventHandler(this.xoadv_Click);
            // 
            // DanhSachDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.suadichvu);
            this.Controls.Add(this.xoadv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.txtTienDV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maDichVu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gird;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.TextBox maDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button suadichvu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTienDV;
        private System.Windows.Forms.Button xoadv;
    }
}