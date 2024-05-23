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
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;

namespace GUI_QLPM
{
    public partial class QuanLyBN : Form
    {
        public DataTable db1 = new DataTable("BenhNhan");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        BenhNhanDTO bn = new BenhNhanDTO();
        PhieukhambenhBUS pkbBUS = new PhieukhambenhBUS();
        private string temp_ma;

        public QuanLyBN()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    
        private void load()
        {
            db1.Clear();
            db1.Columns.Add("MaHD", typeof(System.Int32));
        }
        public void load_data()
        { 
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            this.loadData_Vao_GridView(listBenhNhan);
            hoten.Text = "";
            ngaySinh.Text = "";
            gioiTinh.Text = "";
            diaChi.Text = "";
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
    
        private void gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                hoten.Text = row.Cells[1].Value.ToString();
                ngaySinh.Text = row.Cells[2].Value.ToString();
                diaChi.Text = row.Cells[3].Value.ToString();
                gioiTinh.Text = row.Cells[4].Value.ToString();
                temp_ma = row.Cells[0].Value.ToString();
            }    
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bn.TenBN=hoten.Text;
            bn.DiachiBN=diaChi.Text;
            bn.NgsinhBN= DateTime.Parse(ngaySinh.Text);
            bn.GtBN=gioiTinh.Text;

            bool kq = bnBus.sua(bn, temp_ma);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Update bênh nhân thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Update bệnh nhân thành công", "Result");
                load_data();
            }
        }
        private void xoabenhnhan_Click(object sender, EventArgs e)
        {
            List<PhieukhambenhDTO> pkb = pkbBUS.select();
            foreach(PhieukhambenhDTO phieukhambenh in pkb)
            {
                if(phieukhambenh.MaBenhNhan==temp_ma)
                {

                    System.Windows.Forms.MessageBox.Show("Xóa bệnh nhân thất bại. Bệnh nhân đã khám", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
            }
            bn.MaBN = temp_ma;
            bool kq = bnBus.xoa(bn);
            if (!kq)
            {
                System.Windows.Forms.MessageBox.Show("Xóa bệnh nhân thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Xóa bệnh nhân thành công", "Result");
                load_data();
            }
        }
        private void btnThembn_Click(object sender, EventArgs e)
        {
            ThemBenhNhanMoi tbnm = new ThemBenhNhanMoi();
            this.Close();
            tbnm.Show();
        }
        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
