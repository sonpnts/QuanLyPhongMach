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
using System.Windows;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class ThemThuocMoi : Form
    {
        ThuocBUS thBus = new ThuocBUS();
        public ThemThuocMoi()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {

            ThuocBUS thBus = new ThuocBUS();
            mathuoc.Text = thBus.autogenerate_mathuoc().ToString();
            List<Cachdung> listcd = thBus.getcachdung();
            List<Donvi> listdv = thBus.getdonvi();
            this.load_combobox(listdv, listcd);
        }
        private void load_combobox(List<Donvi> listdv, List<Cachdung> listcd)
        {
            if (listdv == null || listcd == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }

            DataTable table = new DataTable();
            DataTable table1 = new DataTable();

            table.Columns.Add("donVi", typeof(string));
            table1.Columns.Add("cachDung", typeof(string));
            foreach (Donvi dv in listdv)
            {
                DataRow row = table.NewRow();
                row["donVi"] = dv.DonVi;
                table.Rows.Add(row);
            }
            foreach (Cachdung cd in listcd)
            {
                DataRow row = table1.NewRow();
                row["cachDung"] = cd.CachDung;
                table1.Rows.Add(row);
            }
            // Đặt dữ liệu vào ComboBox donvitinh từ table
            donvitinh.DataSource = table;

            // Đặt trường cần hiển thị trong ComboBox donvitinh là "donVi"
            donvitinh.DisplayMember = "donVi";

            // Đặt dữ liệu vào ComboBox cachdung từ table1
            cachdung.DataSource = table1;

            // Đặt trường cần hiển thị trong ComboBox cachdung là "cachDung"
            cachdung.DisplayMember = "cachDung";

        }

        private void Them_Click(object sender, EventArgs e)
        {
            bool kt;
            try
            {
                float.Parse(dongia.Text);
                kt = true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kt = false;
            }
            if (!kt)
            {
                dongia.Text = "";
                dongia.Focus();
            }
            else if (string.IsNullOrEmpty(mathuoc.Text) || string.IsNullOrEmpty(tenthuoc.Text) || string.IsNullOrEmpty(cachdung.Text) || string.IsNullOrEmpty(donvitinh.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ThuocDTO th = new ThuocDTO();
                th.MaThuoc = mathuoc.Text;
                th.TenThuoc = tenthuoc.Text;
                th.DonGia = float.Parse(dongia.Text);
                th.CachDung = cachdung.Text;
                th.DVT = donvitinh.Text;

                thBus = new ThuocBUS();
                bool kq = thBus.them(th);
                if (!kq)
                    System.Windows.Forms.MessageBox.Show("Thêm Thuốc thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                    System.Windows.Forms.MessageBox.Show("Thêm Thuốc thành công", "Result");
            }
        }

    }
}
