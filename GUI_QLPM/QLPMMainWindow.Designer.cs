namespace GUI_QLPM
{
    partial class QLPMMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLPMMainWindow));
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.QuanLyDichVu = new System.Windows.Forms.Button();
            this.BaoCao = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BaoCaoDoanhThu = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DanhSachHD = new System.Windows.Forms.Button();
            this.DanhSachBenhNhan = new System.Windows.Forms.Button();
            this.QuanLyTaiKhoan = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuanLyBenhNhan = new System.Windows.Forms.Button();
            this.QuanLyThuoc = new System.Windows.Forms.Button();
            this.QuanLyLoaiBenh = new System.Windows.Forms.Button();
            this.LapHoaDon = new System.Windows.Forms.Button();
            this.LapPhieuKham = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TraCuuBN = new System.Windows.Forms.Button();
            this.tentaikhoandangnhap = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BaoCao.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.LightCyan;
            this.btnDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Black;
            this.btnDangXuat.Location = new System.Drawing.Point(46, 21);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(281, 45);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // QuanLyDichVu
            // 
            this.QuanLyDichVu.BackColor = System.Drawing.Color.LightCyan;
            this.QuanLyDichVu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuanLyDichVu.BackgroundImage")));
            this.QuanLyDichVu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuanLyDichVu.Location = new System.Drawing.Point(46, 454);
            this.QuanLyDichVu.Name = "QuanLyDichVu";
            this.QuanLyDichVu.Size = new System.Drawing.Size(281, 45);
            this.QuanLyDichVu.TabIndex = 3;
            this.QuanLyDichVu.Text = "     Quản lý dịch vụ";
            this.QuanLyDichVu.UseVisualStyleBackColor = false;
            this.QuanLyDichVu.Click += new System.EventHandler(this.QuanLyDichVu_Click);
            // 
            // BaoCao
            // 
            this.BaoCao.BackColor = System.Drawing.Color.Transparent;
            this.BaoCao.Controls.Add(this.button1);
            this.BaoCao.Controls.Add(this.BaoCaoDoanhThu);
            this.BaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaoCao.ForeColor = System.Drawing.Color.Black;
            this.BaoCao.Location = new System.Drawing.Point(26, 177);
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Size = new System.Drawing.Size(360, 173);
            this.BaoCao.TabIndex = 11;
            this.BaoCao.TabStop = false;
            this.BaoCao.Text = "Báo cáo";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(40, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "     Báo cáo sử dụng thuốc\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BaoCaoSuDungThuoc_Click);
            // 
            // BaoCaoDoanhThu
            // 
            this.BaoCaoDoanhThu.BackColor = System.Drawing.Color.LightCyan;
            this.BaoCaoDoanhThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BaoCaoDoanhThu.BackgroundImage")));
            this.BaoCaoDoanhThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BaoCaoDoanhThu.Location = new System.Drawing.Point(40, 33);
            this.BaoCaoDoanhThu.Name = "BaoCaoDoanhThu";
            this.BaoCaoDoanhThu.Size = new System.Drawing.Size(281, 45);
            this.BaoCaoDoanhThu.TabIndex = 3;
            this.BaoCaoDoanhThu.Text = "Báo cáo doanh thu\r\n\r\n";
            this.BaoCaoDoanhThu.UseVisualStyleBackColor = false;
            this.BaoCaoDoanhThu.Click += new System.EventHandler(this.BaoCaoDoanhThu_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.DanhSachHD);
            this.groupBox3.Controls.Add(this.DanhSachBenhNhan);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(26, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 149);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách";
            // 
            // DanhSachHD
            // 
            this.DanhSachHD.BackColor = System.Drawing.Color.LightCyan;
            this.DanhSachHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DanhSachHD.BackgroundImage")));
            this.DanhSachHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DanhSachHD.Location = new System.Drawing.Point(40, 82);
            this.DanhSachHD.Name = "DanhSachHD";
            this.DanhSachHD.Size = new System.Drawing.Size(281, 45);
            this.DanhSachHD.TabIndex = 4;
            this.DanhSachHD.Text = "     Danh sách hóa đơn";
            this.DanhSachHD.UseVisualStyleBackColor = false;
            this.DanhSachHD.Click += new System.EventHandler(this.danhsachhoadon_Click);
            // 
            // DanhSachBenhNhan
            // 
            this.DanhSachBenhNhan.BackColor = System.Drawing.Color.LightCyan;
            this.DanhSachBenhNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DanhSachBenhNhan.BackgroundImage")));
            this.DanhSachBenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DanhSachBenhNhan.Location = new System.Drawing.Point(40, 21);
            this.DanhSachBenhNhan.Name = "DanhSachBenhNhan";
            this.DanhSachBenhNhan.Size = new System.Drawing.Size(281, 45);
            this.DanhSachBenhNhan.TabIndex = 2;
            this.DanhSachBenhNhan.Text = "Danh sách bệnh nhân\r\n\r\n đã khám";
            this.DanhSachBenhNhan.UseVisualStyleBackColor = false;
            this.DanhSachBenhNhan.Click += new System.EventHandler(this.DanhSachBenhNhan_Click);
            // 
            // QuanLyTaiKhoan
            // 
            this.QuanLyTaiKhoan.BackColor = System.Drawing.Color.LightCyan;
            this.QuanLyTaiKhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuanLyTaiKhoan.BackgroundImage")));
            this.QuanLyTaiKhoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuanLyTaiKhoan.Location = new System.Drawing.Point(46, 385);
            this.QuanLyTaiKhoan.Name = "QuanLyTaiKhoan";
            this.QuanLyTaiKhoan.Size = new System.Drawing.Size(281, 45);
            this.QuanLyTaiKhoan.TabIndex = 3;
            this.QuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.QuanLyTaiKhoan.UseVisualStyleBackColor = false;
            this.QuanLyTaiKhoan.Click += new System.EventHandler(this.QuanLyTaiKhoan_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.QuanLyTaiKhoan);
            this.groupBox2.Controls.Add(this.QuanLyDichVu);
            this.groupBox2.Controls.Add(this.QuanLyBenhNhan);
            this.groupBox2.Controls.Add(this.QuanLyThuoc);
            this.groupBox2.Controls.Add(this.QuanLyLoaiBenh);
            this.groupBox2.Controls.Add(this.LapHoaDon);
            this.groupBox2.Controls.Add(this.LapPhieuKham);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(423, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 539);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục";
            // 
            // QuanLyBenhNhan
            // 
            this.QuanLyBenhNhan.BackColor = System.Drawing.Color.LightCyan;
            this.QuanLyBenhNhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuanLyBenhNhan.BackgroundImage")));
            this.QuanLyBenhNhan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuanLyBenhNhan.Location = new System.Drawing.Point(46, 316);
            this.QuanLyBenhNhan.Name = "QuanLyBenhNhan";
            this.QuanLyBenhNhan.Size = new System.Drawing.Size(281, 45);
            this.QuanLyBenhNhan.TabIndex = 6;
            this.QuanLyBenhNhan.Text = "Quản lý bệnh nhân";
            this.QuanLyBenhNhan.UseVisualStyleBackColor = false;
            this.QuanLyBenhNhan.Click += new System.EventHandler(this.QuanLyBenhNhan_Click);
            // 
            // QuanLyThuoc
            // 
            this.QuanLyThuoc.BackColor = System.Drawing.Color.LightCyan;
            this.QuanLyThuoc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuanLyThuoc.BackgroundImage")));
            this.QuanLyThuoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuanLyThuoc.Location = new System.Drawing.Point(46, 178);
            this.QuanLyThuoc.Name = "QuanLyThuoc";
            this.QuanLyThuoc.Size = new System.Drawing.Size(281, 45);
            this.QuanLyThuoc.TabIndex = 5;
            this.QuanLyThuoc.Text = "Quản lý thuốc";
            this.QuanLyThuoc.UseVisualStyleBackColor = false;
            this.QuanLyThuoc.Click += new System.EventHandler(this.QuanLyThuoc_Click);
            // 
            // QuanLyLoaiBenh
            // 
            this.QuanLyLoaiBenh.BackColor = System.Drawing.Color.LightCyan;
            this.QuanLyLoaiBenh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuanLyLoaiBenh.BackgroundImage")));
            this.QuanLyLoaiBenh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuanLyLoaiBenh.Location = new System.Drawing.Point(46, 247);
            this.QuanLyLoaiBenh.Name = "QuanLyLoaiBenh";
            this.QuanLyLoaiBenh.Size = new System.Drawing.Size(281, 45);
            this.QuanLyLoaiBenh.TabIndex = 4;
            this.QuanLyLoaiBenh.Text = "Quản lý loại bệnh";
            this.QuanLyLoaiBenh.UseVisualStyleBackColor = false;
            this.QuanLyLoaiBenh.Click += new System.EventHandler(this.QuanLyLoaiBenh_Click);
            // 
            // LapHoaDon
            // 
            this.LapHoaDon.BackColor = System.Drawing.Color.LightCyan;
            this.LapHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LapHoaDon.BackgroundImage")));
            this.LapHoaDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LapHoaDon.Location = new System.Drawing.Point(46, 109);
            this.LapHoaDon.Name = "LapHoaDon";
            this.LapHoaDon.Size = new System.Drawing.Size(281, 45);
            this.LapHoaDon.TabIndex = 3;
            this.LapHoaDon.Text = "Lập hóa đơn";
            this.LapHoaDon.UseVisualStyleBackColor = false;
            this.LapHoaDon.Click += new System.EventHandler(this.LapHoaDon_Click_1);
            // 
            // LapPhieuKham
            // 
            this.LapPhieuKham.BackColor = System.Drawing.Color.LightCyan;
            this.LapPhieuKham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LapPhieuKham.BackgroundImage")));
            this.LapPhieuKham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LapPhieuKham.Location = new System.Drawing.Point(46, 40);
            this.LapPhieuKham.Name = "LapPhieuKham";
            this.LapPhieuKham.Size = new System.Drawing.Size(281, 45);
            this.LapPhieuKham.TabIndex = 1;
            this.LapPhieuKham.Text = "Lập phiếu khám";
            this.LapPhieuKham.UseVisualStyleBackColor = false;
            this.LapPhieuKham.Click += new System.EventHandler(this.LapPhieuKham_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TraCuuBN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu";
            // 
            // TraCuuBN
            // 
            this.TraCuuBN.BackColor = System.Drawing.Color.LightCyan;
            this.TraCuuBN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TraCuuBN.BackgroundImage")));
            this.TraCuuBN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TraCuuBN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TraCuuBN.Location = new System.Drawing.Point(40, 46);
            this.TraCuuBN.Name = "TraCuuBN";
            this.TraCuuBN.Size = new System.Drawing.Size(299, 44);
            this.TraCuuBN.TabIndex = 1;
            this.TraCuuBN.Text = " Tra cứu bệnh nhân";
            this.TraCuuBN.UseVisualStyleBackColor = false;
            this.TraCuuBN.Click += new System.EventHandler(this.TraCuuBN_Click);
            // 
            // tentaikhoandangnhap
            // 
            this.tentaikhoandangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tentaikhoandangnhap.Location = new System.Drawing.Point(972, 12);
            this.tentaikhoandangnhap.Multiline = true;
            this.tentaikhoandangnhap.Name = "tentaikhoandangnhap";
            this.tentaikhoandangnhap.Size = new System.Drawing.Size(224, 28);
            this.tentaikhoandangnhap.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnDangXuat);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(26, 540);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(360, 87);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChucVu.Location = new System.Drawing.Point(972, 64);
            this.txtChucVu.Multiline = true;
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(224, 28);
            this.txtChucVu.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(865, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Họ và tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(865, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Chức vụ";
            // 
            // QLPMMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtChucVu);
            this.Controls.Add(this.tentaikhoandangnhap);
            this.Controls.Add(this.BaoCao);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QLPMMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.BaoCao.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button QuanLyDichVu;
        private System.Windows.Forms.GroupBox BaoCao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BaoCaoDoanhThu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button DanhSachBenhNhan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button QuanLyThuoc;
        private System.Windows.Forms.Button QuanLyLoaiBenh;
        private System.Windows.Forms.Button LapHoaDon;
        private System.Windows.Forms.Button LapPhieuKham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TraCuuBN;
        private System.Windows.Forms.Button QuanLyTaiKhoan;
        private System.Windows.Forms.TextBox tentaikhoandangnhap;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button QuanLyBenhNhan;
        private System.Windows.Forms.Button DanhSachHD;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}