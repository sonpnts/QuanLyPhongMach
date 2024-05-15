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

namespace GUI_QLPM
{
    public partial class DanhSachThuoc : Form
    {
        public DataTable db1 = new DataTable("Thuoc");
        ThuocBUS thBus= new ThuocBUS();
        ThuocDTO th = new ThuocDTO();
        private string temp;

        public DanhSachThuoc()
        {
            InitializeComponent();
            load_data();
        }
        private void load()
        {
            db1.Clear();
        }

        public void load_data()
        {
            thBus = new ThuocBUS();
            List<ThuocDTO> listThuoc = thBus.select();
            this.loadData_Vao_GridView(listThuoc);

        }
        private void loadData_Vao_GridView(List<ThuocDTO> listThuoc)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("maThuoc", typeof(string));
            table.Columns.Add("tenThuoc", typeof(string));
            table.Columns.Add("DVT", typeof(string));
            table.Columns.Add("Dongia", typeof(float));
            table.Columns.Add("CachDung", typeof(string));
            foreach (ThuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["maThuoc"] = th.MaThuoc;
                row["tenThuoc"] = th.TenThuoc;
                row["DVT"] = th.DonVi;
                row["Dongia"] = th.DonGia;
                row["CachDung"] = th.CachDung;
                table.Rows.Add(row);
            }
            grid.DataSource = table.DefaultView;
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            thBus = new ThuocBUS();
            string sKeyword = maThuoc.Text;
            if (string.IsNullOrEmpty(sKeyword)) // Tìm tất cả nếu không có từ khóa
            {
                List<ThuocDTO> listThuoc = thBus.select();
                this.loadData_Vao_GridView(listThuoc);
            }
            else
            {
                List<ThuocDTO> listThuoc = thBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listThuoc);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemThuocMoi thm = new ThemThuocMoi();
            thm.Show();
            load_data();
        }
    }
}
