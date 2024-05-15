using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class QLPMMainWindow : Form
    {
        public QLPMMainWindow()
        {
            InitializeComponent();
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            TraCuuBenhNhan tcbn = new TraCuuBenhNhan();
            tcbn.StartPosition = FormStartPosition.CenterParent; // Đặt form ở giữa form cha
            tcbn.MdiParent = this;
            tcbn.Show();

        }

        private void ThemBenhNhan_Click(object sender, EventArgs e)
        {
            ThemBenhNhanMoi tbn = new ThemBenhNhanMoi();
            tbn.StartPosition = FormStartPosition.CenterParent;
            tbn.MdiParent = this;
            tbn.Show();
        }

        private void LapPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            ThemPhieuKhamBenh lpkb = new ThemPhieuKhamBenh();
            lpkb.StartPosition = FormStartPosition.CenterParent;
            lpkb.MdiParent = this;
            lpkb.Show();
        }

        private void LapHoaDon_Click(object sender, EventArgs e)
        {
            LapHoaDon lhd = new LapHoaDon();
            lhd.StartPosition = FormStartPosition.CenterParent;
            lhd.MdiParent = this;
            lhd.Show();
        }

        private void DanhSachBenhNhan_Click(object sender, EventArgs e)
        {
            DanhSachBenhNhan dsbn = new DanhSachBenhNhan();
            dsbn.StartPosition = FormStartPosition.CenterParent;
            dsbn.MdiParent = this;
            dsbn.Show();
        }

        private void BaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu bcdt = new BaoCaoDoanhThu();
            bcdt.StartPosition = FormStartPosition.CenterParent;
            bcdt.MdiParent = this;
            bcdt.Show();
        }

        private void BaoCaoSuDungThuoc_Click(object sender, EventArgs e)
        {
            BaoCaoSuDungThuoc bcsdt = new BaoCaoSuDungThuoc();
            bcsdt.StartPosition = FormStartPosition.CenterParent;
            bcsdt.MdiParent = this;
            bcsdt.Show();
        }

        private void QuanLyThuoc_Click(object sender, EventArgs e)
        {
            DanhSachThuoc dst = new DanhSachThuoc();
            dst.StartPosition = FormStartPosition.CenterParent;
            dst.MdiParent = this;
            dst.Show();
        }

        private void QuanLyLoaiThuoc_Click(object sender, EventArgs e)
        {
            DanhSachBenh dsb = new DanhSachBenh();
            dsb.StartPosition = FormStartPosition.CenterParent;
            dsb.MdiParent = this;
            dsb.Show();
        }

        private void DanhSachKhamBenh_Click(object sender, EventArgs e)
        {
            DanhSachKhamBenh dsbn = new DanhSachKhamBenh();
            dsbn.StartPosition = FormStartPosition.CenterParent;
            dsbn.MdiParent = this;
            dsbn.Show();
        }

        private void QuyDinh_Click(object sender, EventArgs e)
        {
            DanhSachDichVu dsdv = new DanhSachDichVu();
            dsdv.StartPosition = FormStartPosition.CenterParent;
            dsdv.MdiParent = this;
            dsdv.Show();
        }
    }
}
