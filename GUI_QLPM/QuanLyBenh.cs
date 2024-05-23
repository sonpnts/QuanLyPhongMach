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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPM
{
    public partial class QuanLyBenh : Form
    {
        public DataTable db1 = new DataTable("tblBENH");
        BenhBUS beBus = new BenhBUS();
        BenhDTO be = new BenhDTO();

        private string temp;

        public QuanLyBenh()
        {
            InitializeComponent();
            load_data();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tenBenh.Text = " ";
        }
        private void load()
        {
            db1.Clear();
        }
        public void load_data()
        {
            List<BenhDTO> listBenh = beBus.select();
            this.loadData_Vao_GridView(listBenh);
            tenBenh.Text = " ";
            maBenh.Text=beBus.autogenerate_mabenh().ToString(); 

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
            string sKeyword = ma.Text;
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
            this.Close();
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
            if (string.IsNullOrEmpty(maBenh.Text) || string.IsNullOrEmpty(tenBenh.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BenhDTO be = new BenhDTO();
                be.TenBenh = tenBenh.Text;

                bool kq = beBus.them(be);
                if (!kq)
                    System.Windows.Forms.MessageBox.Show("Thêm bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                {
                    System.Windows.Forms.MessageBox.Show("Thêm bệnh thành công", "Result");
                    load_data();
                    load();
                }
            }
        }
        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                DataGridViewRow row = grid.Rows[e.RowIndex];
                maBenh.Text = row.Cells[0].Value.ToString();
                tenBenh.Text = row.Cells[1].Value.ToString();
                temp = row.Cells[0].Value.ToString();
            }
        }
        private void Sua_Click(object sender, EventArgs e)
        {
            be.MaBenh = maBenh.Text;
            be.TenBenh = tenBenh.Text;

            bool kq = beBus.sua(be, temp);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Update loại bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Update loại bệnh thành công", "Result");
                load_data();
                load();
            }
        }
        private void Xoa_Click(object sender, EventArgs e)
        {
            be.MaBenh = temp;
            beBus = new BenhBUS();
            bool kq = beBus.xoa(be);
            if (kq == false)
                System.Windows.Forms.MessageBox.Show("Xóa loại bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            else
                System.Windows.Forms.MessageBox.Show("Xóa loại bệnh thành công", "Result");
            load_data();
            load();
        }
    }
}
