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
    public partial class ThayDoiThongTinThuoc : Form
    {
        public string temp;
        private ThuocBUS thBus;
        public ThayDoiThongTinThuoc()
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
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB");
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
            // For 'Donvi' ComboBox
            DonVi.DataSource = table; // Set the DataSource to the DataTable
            DonVi.DisplayMember = "donVi"; // Set the DisplayMember to the column name

            // For 'cachdung' ComboBox
            cachDung.DataSource = table1; // Set the DataSource to the DataTable
            cachDung.DisplayMember = "cachDung"; // Set the DisplayMember to the column name
        }

        private void btnSua_Click(object sender, EventArgs e)
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
            if (kt == false)
            {
                dongia.Text = "";
                dongia.Focus();
            }
            else if (mathuoc.Text == null || tenthuoc.Text == null || cachDung.Text == "" || DonVi.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại thuốc");
            }
            else
            {
                ThuocDTO th = new ThuocDTO();
                th.MaThuoc = mathuoc.Text;
                th.TenThuoc = tenthuoc.Text;
                th.DonGia = float.Parse(dongia.Text);
                th.DonVi = DonVi.Text;
                th.CachDung = cachDung.Text;

                thBus = new ThuocBUS();
                bool kq = thBus.sua(th, temp);
                if (kq == false)
                    System.Windows.Forms.MessageBox.Show("Sửa Thuốc thất bại. Vui lòng kiểm tra lại dũ liệu", "Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    System.Windows.Forms.MessageBox.Show("Sửa Thuốc thành công", "Result");
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
