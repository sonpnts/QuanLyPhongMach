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
        public QLPMMainWindow()
        {
            InitializeComponent();
            load_data();
        }

        private void Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TraCuuBenhNhan_Click(object sender, EventArgs e)
        {
            TraCuuBenhNhan tcbn = new TraCuuBenhNhan();
            tcbn.StartPosition = FormStartPosition.CenterParent; // Đặt form ở giữa form cha
           
            tcbn.Show();

        }

        private void ThemBenhNhan_Click(object sender, EventArgs e)
        {
            ThemBenhNhanMoi tbn = new ThemBenhNhanMoi();
            tbn.StartPosition = FormStartPosition.CenterParent;
            
            tbn.Show();
        }

        private void LapPhieuKhamBenh_Click(object sender, EventArgs e)
        {
            ThemPhieuKhamBenh lpkb = new ThemPhieuKhamBenh();
            lpkb.StartPosition = FormStartPosition.CenterParent;
           
            lpkb.Show();
        }

        private void LapHoaDon_Click(object sender, EventArgs e)
        {
            LapHoaDon lhd = new LapHoaDon();
            lhd.StartPosition = FormStartPosition.CenterParent;
            
            lhd.Show();
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

        private void QuanLyThuoc_Click(object sender, EventArgs e)
        {
            DanhSachThuoc dst = new DanhSachThuoc();
            dst.StartPosition = FormStartPosition.CenterParent;
            
            dst.Show();
        }

        private void QuanLyLoaiThuoc_Click(object sender, EventArgs e)
        {
            DanhSachBenh dsb = new DanhSachBenh();
            dsb.StartPosition = FormStartPosition.CenterParent;
          
            dsb.Show();
        }

        private void DanhSachKhamBenh_Click(object sender, EventArgs e)
        {
            DanhSachKhamBenh dsbn = new DanhSachKhamBenh();
            dsbn.StartPosition = FormStartPosition.CenterParent;
            
            dsbn.Show();
        }

        private void QuyDinh_Click(object sender, EventArgs e)
        {
            DanhSachDichVu dsdv = new DanhSachDichVu();
            dsdv.StartPosition = FormStartPosition.CenterParent;
          
            dsdv.Show();
        }


        public DataTable db1 = new DataTable("BenhNhan");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        BenhNhanDTO bn = new BenhNhanDTO();
        private string temp;
     
        private void load()
        {
            db1.Clear();
            db1.Columns.Add("MaHD", typeof(System.Int32));
        }
        public void load_data()
        {
            bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            this.loadData_Vao_GridView(listBenhNhan);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan)
        {

            if (listBenhNhan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }

            DataTable table = new DataTable();
            table.Columns.Add("Mã bệnh nhân", typeof(int));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            table.Columns.Add("Giới tính", typeof(string));

            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                DataRow row = table.NewRow();
                row["Mã bệnh nhân"] = int.Parse(bn.MaBN.ToString());
                row["Tên bệnh nhân"] = bn.TenBN;
                row["Ngày sinh"] = DateTime.Parse(bn.NgsinhBN.ToString()).ToString("dd/MM/yyyy");
                row["Địa chỉ"] = bn.DiachiBN;
                row["Giới tính"] = bn.GtBN;

                table.Rows.Add(row);
            }
            gird.DataSource = table.DefaultView;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            bnBus = new BenhNhanBUS();
            string sKeyword = nhaptukhoa.Text;
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0) // tìm tất cả
            {
                List<BenhNhanDTO> listBenhNhan = bnBus.select();
                this.loadData_Vao_GridView(listBenhNhan);
            }
            else
            {
                List<BenhNhanDTO> listBenhNhan = bnBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listBenhNhan);
            }
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thembenhnhan_Click(object sender, EventArgs e)
        {
            ThemBenhNhanMoi tbn = new ThemBenhNhanMoi();
            tbn.StartPosition = FormStartPosition.CenterParent;
            tbn.MdiParent = this;
            tbn.Show();
        }
    }
}
