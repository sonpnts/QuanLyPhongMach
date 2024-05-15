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
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class DanhSachDichVu : Form
    {
        public DataTable db1 = new DataTable("DichVu");
        DichvuBUS dvBus = new DichvuBUS();
        DichvuDTO dv = new DichvuDTO();

        public DanhSachDichVu()
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
            dvBus = new DichvuBUS();
            List<DichvuDTO> listDichVu = dvBus.select();
            this.loadData_Vao_GridView(listDichVu);
        }
        private void loadData_Vao_GridView(List<DichvuDTO> listDichVu)
        {

            if (listDichVu == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Mã dịch vụ", typeof(string));
            table.Columns.Add("Tên dịch vụ", typeof(string));
            table.Columns.Add("Tiền dịch vụ", typeof(string));
            foreach (DichvuDTO dv in listDichVu)
            {
                DataRow row = table.NewRow();
                row["Mã dịch vụ"] = dv.MaDichVu;
                row["Tên dịch vụ"] = dv.TenDichVu;
                row["Tiền dịch vụ"] = dv.TienDichVu;
                table.Rows.Add(row);
            }
            grid.DataSource = table.DefaultView;
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            dvBus = new DichvuBUS();
            string sKeyword = maDichVu.Text;
            if (string.IsNullOrEmpty(sKeyword)) // Tìm tất cả nếu không có từ khóa
            {
                List<DichvuDTO> listDichVu = dvBus.select();
                this.loadData_Vao_GridView(listDichVu);
            }
            else
            {
                List<DichvuDTO> listDichVu = dvBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listDichVu);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDichVuMoi themdvm = new ThemDichVuMoi();
            themdvm.ShowDialog();
            load_data();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
