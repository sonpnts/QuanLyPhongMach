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
    public partial class QuanLyDichVu : Form
    {
        public DataTable db1 = new DataTable("DichVu");
        DichvuBUS dvBus = new DichvuBUS();
        DichvuDTO dv = new DichvuDTO();
        public int temp_ma;

        public QuanLyDichVu()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void load()
        {
            db1.Clear();
        }
        public void load_data()
        {
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
            gird.DataSource = table.DefaultView;
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
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
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                txtTenDV.Text = row.Cells[1].Value.ToString();
                txtTienDV.Text = row.Cells[2].Value.ToString();
                temp_ma = int.Parse(row.Cells[0].Value.ToString());
                
            }
        }
        private void suadichvu_Click(object sender, EventArgs e)
        {
            dv.TenDichVu = txtTenDV.Text;
            dv.TienDichVu = int.Parse(txtTienDV.Text);
           

            bool kq = dvBus.sua(dv, temp_ma);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Update dịch vụ thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Update dịch vụ thành công", "Result");
                load_data();
            }
        }
        private void xoadv_Click(object sender, EventArgs e)
        {
            dv.MaDichVu = temp_ma;
            bool kq = dvBus.xoa(dv);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Xóa dịch vụ thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Xóa dịch vụ thành công", "Result");
                load_data();
            }
        }
    }
}
