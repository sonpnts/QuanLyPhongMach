﻿using QLPMBUS;
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
    public partial class QuanLyTaiKhoan : Form
    {   
        public DataTable db1 = new DataTable("TaiKhoan");
        taiKhoanBUS tkBus = new taiKhoanBUS();
        taiKhoanDTO tk = new taiKhoanDTO();
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();
        loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();
        private string temp;
        private string temp_ma;

        public QuanLyTaiKhoan()
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
            List<taiKhoanDTO> listTK = tkBus.select();
            List<loaiTaiKhoanDTO> listLoaiTK = loaitkBUS.select();
            this.loadData_Vao_GridView(listTK, listLoaiTK);
            load_combobox();
        }
        private void loadData_Vao_GridView(List<taiKhoanDTO> listTk, List<loaiTaiKhoanDTO> listLoaiTK)
        {

            if (listTk == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            DataTable table = new DataTable();
            table.Columns.Add("Mã tài khoản", typeof(int));
            table.Columns.Add("Tên tài khoản", typeof(string));
            table.Columns.Add("Mật khẩu", typeof(string));
            table.Columns.Add("Họ và tên", typeof(string));
            table.Columns.Add("Loại tài khoản", typeof(string));

            foreach (taiKhoanDTO tk in listTk)
            {
                DataRow row = table.NewRow();
                row["Mã tài khoản"] = tk.MaTK;
                row["Tên tài khoản"] = tk.Username;
                row["Mật khẩu"] = tk.Password;
                row["Họ và tên"] = tk.Name;
                foreach (loaiTaiKhoanDTO loaitk in listLoaiTK)
                {
                    if (tk.MaLoai == loaitk.MaRole)
                    {
                        row["Loại tài khoản"] = loaitk.TenLoaiTaiKhoan;
                    }
                }
                table.Rows.Add(row);
            }
            gird.DataSource = table.DefaultView;
        }
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadRole();
        }
        private void loadRole()
        {
            int selectedIndex = comboBoxRole.SelectedIndex;
            List<loaiTaiKhoanDTO> listRole = loaitkBUS.select();
        }

        private void Them_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan ttk = new ThemTaiKhoan();
            this.Close();
            ttk.Show();
            load_data();
        }

        private void TimKiem_Click(object sender, EventArgs e)
        {
            tkBus = new taiKhoanBUS();
            loaitkBUS = new loaiTaiKhoanBUS();
            string sKeyword = search.Text;
            if (string.IsNullOrEmpty(sKeyword)) // Tìm tất cả nếu không có từ khóa
            {
                List<taiKhoanDTO> listTaiKhoan = tkBus.select();
                List<loaiTaiKhoanDTO> listLoaiTaiKhoan = loaitkBUS.select();
                this.loadData_Vao_GridView(listTaiKhoan, listLoaiTaiKhoan);
            }
            else
            {
                List<taiKhoanDTO> listTaiKhoan = tkBus.selectByKeyWord(sKeyword);
                List<loaiTaiKhoanDTO> listLoaiTaiKhoan = loaitkBUS.select();
                this.loadData_Vao_GridView(listTaiKhoan, listLoaiTaiKhoan);
            }
        }
        public void load_combobox()
        {
            List<loaiTaiKhoanDTO> listRole = loaitkBUS.select();
            this.loadData_Vao_Combobox(listRole);
        }
        private void loadData_Vao_Combobox(List<loaiTaiKhoanDTO> listRole)
        {
            comboBoxRole.Items.Clear();
            if (listRole == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin nạp vào combox pkb từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            foreach (loaiTaiKhoanDTO role in listRole)
            {
                comboBoxRole.Items.Add(role.TenLoaiTaiKhoan);
                comboBoxRole.SelectedIndex = 0;
            }
        }
  
        private void Sua_Click(object sender, EventArgs e)
        {
            tk.Username = username.Text;
            tk.Password = password.Text;
            tk.Name = hoten.Text;
            tk.MaLoai = comboBoxRole.SelectedIndex + 1;

            bool kq = tkBus.sua(tk, temp_ma);
            if (!kq)
                System.Windows.Forms.MessageBox.Show("Update tài khoản thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            else
            {
                System.Windows.Forms.MessageBox.Show("Update tài khoản thành công", "Result");
                load_data();
            }
        }
        private void gird_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                temp_ma = row.Cells[0].Value.ToString();
                username.Text = row.Cells[1].Value.ToString();
                password.Text = row.Cells[2].Value.ToString();
                hoten.Text = row.Cells[3].Value.ToString();
                if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count && e.ColumnIndex == 4)
                {
                    string cellValue = row.Cells[4].Value?.ToString();
                    int roleIndex;
                    if (int.TryParse(cellValue, out roleIndex))
                    {
                        comboBoxRole.SelectedIndex = roleIndex;
                    }
                }
            }
        }
        private void Xoa_Click(object sender, EventArgs e)
        {

        }
        private void QuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
