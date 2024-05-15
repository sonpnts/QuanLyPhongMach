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
            this.DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
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
            this.nhaptukhoa = new System.Windows.Forms.TextBox();
            this.thembenhnhan = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.timkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gird = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThong,
            this.DanhMuc,
            this.DanhSach,
            this.BaoCao,
            this.QuyDinh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
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
            // DanhMuc
            // 
            this.DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LapPhieuKhamBenh,
            this.LapHoaDon,
            this.QuanLyThuoc,
            this.QuanLyLoaiThuoc});
            this.DanhMuc.Name = "DanhMuc";
            this.DanhMuc.Size = new System.Drawing.Size(90, 24);
            this.DanhMuc.Text = "Danh mục";
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
            this.QuyDinh.Size = new System.Drawing.Size(142, 24);
            this.QuyDinh.Text = "Danh sách dịch vụ";
            this.QuyDinh.Click += new System.EventHandler(this.QuyDinh_Click);
            // 
            // nhaptukhoa
            // 
            this.nhaptukhoa.Location = new System.Drawing.Point(164, 74);
            this.nhaptukhoa.Multiline = true;
            this.nhaptukhoa.Name = "nhaptukhoa";
            this.nhaptukhoa.Size = new System.Drawing.Size(288, 28);
            this.nhaptukhoa.TabIndex = 8;
            // 
            // thembenhnhan
            // 
            this.thembenhnhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.thembenhnhan.Location = new System.Drawing.Point(492, 62);
            this.thembenhnhan.Name = "thembenhnhan";
            this.thembenhnhan.Size = new System.Drawing.Size(143, 40);
            this.thembenhnhan.TabIndex = 6;
            this.thembenhnhan.Text = "Thêm bệnh nhân";
            this.thembenhnhan.UseVisualStyleBackColor = false;
            this.thembenhnhan.Click += new System.EventHandler(this.ThemBenhNhan_Click);
            // 
            // quaylai
            // 
            this.quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quaylai.Location = new System.Drawing.Point(784, 62);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(108, 40);
            this.quaylai.TabIndex = 7;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timkiem.Location = new System.Drawing.Point(657, 62);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(108, 40);
            this.timkiem.TabIndex = 5;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 140);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(1047, 661);
            this.gird.TabIndex = 9;
            // 
            // QLPMMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1047, 801);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.nhaptukhoa);
            this.Controls.Add(this.thembenhnhan);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLPMMainWindow";
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HeThong;
        private System.Windows.Forms.ToolStripMenuItem Dong;
        private System.Windows.Forms.ToolStripMenuItem DanhMuc;
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
        private System.Windows.Forms.TextBox nhaptukhoa;
        private System.Windows.Forms.Button thembenhnhan;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gird;
    }
}