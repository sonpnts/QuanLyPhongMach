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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.Dong = new System.Windows.Forms.ToolStripMenuItem();
            this.TraCuu = new System.Windows.Forms.ToolStripMenuItem();
            this.TraCuuBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.LapPhieuKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.LapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyLoaiThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSach = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachKhamBenh = new System.Windows.Forms.ToolStripMenuItem();
            this.DanhSachBenhNhan = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.BaoCaoSuDungThuoc = new System.Windows.Forms.ToolStripMenuItem();
            this.QuyDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.TraCuu,
            this.DanhMuc,
            this.DanhSach,
            this.BaoCao,
            this.QuyDinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // HeThong
            // 
            this.HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Dong});
            this.HeThong.Name = "HeThong";
            this.HeThong.Size = new System.Drawing.Size(85, 24);
            this.HeThong.Text = "Hệ thống";
            // 
            // Dong
            // 
            this.Dong.Name = "Dong";
            this.Dong.Size = new System.Drawing.Size(129, 26);
            this.Dong.Text = "Đóng";
            this.Dong.Click += new System.EventHandler(this.Dong_Click);
            // 
            // TraCuu
            // 
            this.TraCuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TraCuuBenhNhan});
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.Size = new System.Drawing.Size(71, 24);
            this.TraCuu.Text = "Tra cứu";
            // 
            // TraCuuBenhNhan
            // 
            this.TraCuuBenhNhan.Name = "TraCuuBenhNhan";
            this.TraCuuBenhNhan.Size = new System.Drawing.Size(247, 26);
            this.TraCuuBenhNhan.Text = "Tra cứu theo bệnh nhân";
            this.TraCuuBenhNhan.Click += new System.EventHandler(this.TraCuuBenhNhan_Click);
            // 
            // DanhMuc
            // 
            this.DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemBenhNhan,
            this.LapPhieuKhamBenh,
            this.LapHoaDon,
            this.QuanLyThuoc,
            this.QuanLyLoaiThuoc});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Size = new System.Drawing.Size(90, 24);
            this.DanhMuc.Text = "Danh mục";
            // 
            // ThemBenhNhan
            // 
            this.ThemBenhNhan.Name = "ThemBenhNhan";
            this.ThemBenhNhan.Size = new System.Drawing.Size(234, 26);
            this.ThemBenhNhan.Text = "Thêm bệnh nhân";
            this.ThemBenhNhan.Click += new System.EventHandler(this.ThemBenhNhan_Click);
            // 
            // LapPhieuKhamBenh
            // 
            this.LapPhieuKhamBenh.Name = "LapPhieuKhamBenh";
            this.LapPhieuKhamBenh.Size = new System.Drawing.Size(234, 26);
            this.LapPhieuKhamBenh.Text = "Lập phiếu khám bệnh";
            this.LapPhieuKhamBenh.Click += new System.EventHandler(this.LapPhieuKhamBenh_Click);
            // 
            // LapHoaDon
            // 
            this.LapHoaDon.Name = "LapHoaDon";
            this.LapHoaDon.Size = new System.Drawing.Size(234, 26);
            this.LapHoaDon.Text = "Lập hóa đơn";
            this.LapHoaDon.Click += new System.EventHandler(this.LapHoaDon_Click);
            // 
            // QuanLyThuoc
            // 
            this.QuanLyThuoc.Name = "QuanLyThuoc";
            this.QuanLyThuoc.Size = new System.Drawing.Size(234, 26);
            this.QuanLyThuoc.Text = "Quản lý thuốc";
            this.QuanLyThuoc.Click += new System.EventHandler(this.QuanLyThuoc_Click);
            // 
            // QuanLyLoaiThuoc
            // 
            this.QuanLyLoaiThuoc.Name = "QuanLyLoaiThuoc";
            this.QuanLyLoaiThuoc.Size = new System.Drawing.Size(234, 26);
            this.QuanLyLoaiThuoc.Text = "Quản lý loại bệnh";
            this.QuanLyLoaiThuoc.Click += new System.EventHandler(this.QuanLyLoaiThuoc_Click);
            // 
            // DanhSach
            // 
            this.DanhSach.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DanhSachKhamBenh,
            this.DanhSachBenhNhan});
            this.DanhSach.Name = "DanhSach";
            this.DanhSach.Size = new System.Drawing.Size(91, 24);
            this.DanhSach.Text = "Danh sách";
            // 
            // DanhSachKhamBenh
            // 
            this.DanhSachKhamBenh.Name = "DanhSachKhamBenh";
            this.DanhSachKhamBenh.Size = new System.Drawing.Size(237, 26);
            this.DanhSachKhamBenh.Text = "Danh sách khám bệnh";
            this.DanhSachKhamBenh.Click += new System.EventHandler(this.DanhSachKhamBenh_Click);
            // 
            // DanhSachBenhNhan
            // 
            this.DanhSachBenhNhan.Name = "DanhSachBenhNhan";
            this.DanhSachBenhNhan.Size = new System.Drawing.Size(237, 26);
            this.DanhSachBenhNhan.Text = "Danh sách bệnh nhân";
            this.DanhSachBenhNhan.Click += new System.EventHandler(this.DanhSachBenhNhan_Click);
            // 
            // BaoCao
            // 
            this.BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BaoCaoDoanhThu,
            this.BaoCaoSuDungThuoc});
            this.BaoCao.Name = "BaoCao";
            this.BaoCao.Size = new System.Drawing.Size(77, 24);
            this.BaoCao.Text = "Báo cáo";
            // 
            // BaoCaoDoanhThu
            // 
            this.BaoCaoDoanhThu.Name = "BaoCaoDoanhThu";
            this.BaoCaoDoanhThu.Size = new System.Drawing.Size(244, 26);
            this.BaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            this.BaoCaoDoanhThu.Click += new System.EventHandler(this.BaoCaoDoanhThu_Click);
            // 
            // BaoCaoSuDungThuoc
            // 
            this.BaoCaoSuDungThuoc.Name = "BaoCaoSuDungThuoc";
            this.BaoCaoSuDungThuoc.Size = new System.Drawing.Size(244, 26);
            this.BaoCaoSuDungThuoc.Text = "Báo cáo sử dụng thuốc";
            this.BaoCaoSuDungThuoc.Click += new System.EventHandler(this.BaoCaoSuDungThuoc_Click);
            // 
            // QuyDinh
            // 
            this.QuyDinh.Name = "QuyDinh";
            this.QuyDinh.Size = new System.Drawing.Size(82, 24);
            this.QuyDinh.Text = "Quy định";
            this.QuyDinh.Click += new System.EventHandler(this.QuyDinh_Click);
            // 
            // QLPMMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1023, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLPMMainWindow";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem TraCuu;
        private System.Windows.Forms.ToolStripMenuItem Dong;
        private System.Windows.Forms.ToolStripMenuItem TraCuuBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ThemBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem LapPhieuKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem LapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem QuanLyThuoc;
        private System.Windows.Forms.ToolStripMenuItem QuanLyLoaiThuoc;
        private System.Windows.Forms.ToolStripMenuItem DanhSach;
        private System.Windows.Forms.ToolStripMenuItem DanhSachKhamBenh;
        private System.Windows.Forms.ToolStripMenuItem DanhSachBenhNhan;
        private System.Windows.Forms.ToolStripMenuItem BaoCao;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem BaoCaoSuDungThuoc;
        private System.Windows.Forms.ToolStripMenuItem QuyDinh;
    }
}