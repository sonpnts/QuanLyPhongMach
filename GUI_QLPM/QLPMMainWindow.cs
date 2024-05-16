using QLPMBUS;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class QLPMMainWindow : Form

    {
        public int mataikhoan;
        taiKhoanBUS tkBus = new taiKhoanBUS();
        taiKhoanDTO tk = new taiKhoanDTO();
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();
        loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();
        public QLPMMainWindow(int mataikhoanlogin)
        {
            mataikhoan = mataikhoanlogin;
            List<taiKhoanDTO> listTK = tkBus.select();
            List<loaiTaiKhoanDTO> listLoaiTK = loaitkBUS.select();
            InitializeComponent();
            foreach (taiKhoanDTO taiKhoan in listTK)
            {
                if (taiKhoan.MaTK == mataikhoanlogin)
                {
                    tentaikhoandangnhap.Text += taiKhoan.Name;
                    tentaikhoandangnhap.Text += "| ";
                    foreach (loaiTaiKhoanDTO loaiTaiKhoan in listLoaiTK)
                    {
                        if (loaiTaiKhoan.MaRole == taiKhoan.MaLoai)
                        {
                            tentaikhoandangnhap.Text += loaiTaiKhoan.TenLoaiTaiKhoan;
                        }

                    }
                    if (taiKhoan.MaLoai == 1)
                    {
                        TaiKhoan.Enabled = false;
                        DichVu.Enabled = false;
                        BaoCao.Enabled = false;
                        QuanLyLoaiBenh.Enabled = false;
                        QuanLyThuoc.Enabled = false;
                        LapHoaDon.Enabled = false;

                    }
                    else if (taiKhoan.MaLoai == 2)
                    {
                        TaiKhoan.Enabled = false;
                        DichVu.Enabled = false;
                        BaoCao.Enabled = false;
                        QuanLyLoaiBenh.Enabled = false;
                        QuanLyThuoc.Enabled = false;
                    }
                }

                
            }
         
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraCuuBN_Click(object sender, EventArgs e)
        {
            TraCuuBenhNhan tcbn = new TraCuuBenhNhan();
            tcbn.StartPosition = FormStartPosition.CenterParent; 
            tcbn.Show();
        }

        private void ThemBenhNhan_Click(object sender, EventArgs e)
        {
            ThemBenhNhanMoi tbn = new ThemBenhNhanMoi();
            tbn.StartPosition = FormStartPosition.CenterParent;
            tbn.Show();
        }

        private void LapPhieuKham_Click(object sender, EventArgs e)
        {
            ThemPhieuKhamBenh lpkb = new ThemPhieuKhamBenh(mataikhoan);
            lpkb.StartPosition = FormStartPosition.CenterParent;
            lpkb.Show();
        }

        private void LapHoaDon_Click_1(object sender, EventArgs e)
        {
            LapHoaDon lhd = new LapHoaDon(mataikhoan);
            lhd.StartPosition = FormStartPosition.CenterParent;
            lhd.Show();
        }


        private void QuanLyThuoc_Click(object sender, EventArgs e)
        {
            DanhSachThuoc dst = new DanhSachThuoc();
            dst.StartPosition = FormStartPosition.CenterParent;
            dst.Show();
        }

        private void QuanLyLoaiBenh_Click(object sender, EventArgs e)
        {
            DanhSachBenh dsb = new DanhSachBenh();
            dsb.StartPosition = FormStartPosition.CenterParent;
            dsb.Show();
        }

        private void DanhSachBenhNhan_Click(object sender, EventArgs e)
        {
            DanhSachBenhNhan dsbn = new DanhSachBenhNhan();
            dsbn.StartPosition = FormStartPosition.CenterParent;
            dsbn.Show();
        }

        private void BaoCaoDoanhThu_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu bcdt = new BaoCaoDoanhThu();
            bcdt.StartPosition = FormStartPosition.CenterParent;
            bcdt.Show();
        }

        private void BaoCaoSuDungThuoc_Click(object sender, EventArgs e)
        {
            BaoCaoSuDungThuoc bcsdt = new BaoCaoSuDungThuoc();
            bcsdt.StartPosition = FormStartPosition.CenterParent;
            bcsdt.Show();
        }

        private void DanhSachDichVu_Click(object sender, EventArgs e)
        {
            DanhSachDichVu dsdv = new DanhSachDichVu();
            dsdv.StartPosition = FormStartPosition.CenterParent;
            dsdv.Show();
        }

        private void DanhSachTaiKhoan_Click(object sender, EventArgs e)
        {
            DanhSachTaiKhoan tk = new DanhSachTaiKhoan();
            tk.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Login lg = new Login();
            lg.Show();
        }

        private void danhsachhoadon_Click(object sender, EventArgs e)
        {
            DanhSachHoaDon dshd = new DanhSachHoaDon();
            dshd.Show();
        }

        private void QLPMMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
