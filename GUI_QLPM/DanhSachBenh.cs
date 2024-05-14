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
    public partial class DanhSachBenh : Form
    {
        public DataTable db1 = new DataTable("tblBENH");
        BenhBUS beBus = new BenhBUS();
        BenhDTO be = new BenhDTO();
        private string temp;

        public DanhSachBenh()
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
            beBus = new BenhBUS();
            List<BenhDTO> listBenh = beBus.select();
            this.loadData_Vao_GridView(listBenh);

        }
        private void loadData_Vao_GridView(List<BenhDTO> listBenh)
        {

            if (listBenh == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            DataTable table = new DataTable();
            table.Columns.Add("maBenh", typeof(string));
            table.Columns.Add("tenBenh", typeof(string));
            foreach (BenhDTO be in listBenh)
            {
                DataRow row = table.NewRow();
                row["maBenh"] = be.MaBenh;
                row["tenBenh"] = be.TenBenh;

                table.Rows.Add(row);
            }
            grid.DataSource = table.DefaultView;
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            beBus = new BenhBUS();
            string sKeyword = maBenh.Text;
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0) // tìm tất cả
            {
                List<BenhDTO> listBenh = beBus.select();
                this.loadData_Vao_GridView(listBenh);
            }
            else
            {
                List<BenhDTO> listBenh = beBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listBenh);
            }
        }

        private void QuayLai_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void grid_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv.SelectedRows[0];

                // Lấy dữ liệu từ hàng được chọn và gán vào đối tượng BenhDTO
                be = new BenhDTO();
                be.TenBenh = selectedRow.Cells["tenBenh"].Value.ToString();
                be.MaBenh = selectedRow.Cells["maBenh"].Value.ToString();
                temp = be.MaBenh;
            }
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemLoaiBenh tlb = new ThemLoaiBenh();
            tlb.Show();
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện mới của form ThayDoiLoaiBenh
            ThayDoiLoaiBenh thaydoi = new ThayDoiLoaiBenh();

            // Lấy dữ liệu từ hàng được chọn trong DataGridView và gán cho các trường tương ứng của form ThayDoiLoaiBenh
            DataGridViewRow selectedRow = grid.CurrentRow;
            thaydoi.temp = selectedRow.Cells["MaBenh"].Value.ToString();
            thaydoi.MaBenh= selectedRow.Cells["MaBenh"].Value.ToString();
            thaydoi.TenBenh = selectedRow.Cells["TenBenh"].Value.ToString();

            // Hiển thị form ThayDoiLoaiBenh
            thaydoi.Show();
        }


        private void Xoa_Click(object sender, EventArgs e)
        {
            be = new BenhDTO();
            be.MaBenh = temp;
            beBus = new BenhBUS();
            bool kq = beBus.xoa(be);
            if (kq == false)
                System.Windows.Forms.MessageBox.Show("Xóa loại bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            else
                System.Windows.Forms.MessageBox.Show("Xóa loại bệnh thành công", "Result");
            load_data();
        }
    }
}
