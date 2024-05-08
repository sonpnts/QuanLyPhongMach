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
    public partial class ThayDoiQuyDinh : Form
    {
        public ThayDoiQuyDinh()
        {
            InitializeComponent();
          
        }
        private void load()
        {
            ThuocBUS thBus = new ThuocBUS();
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
            cbb_donvi_Sua.DataSource = table.DefaultView;
            cbb_donvi_Sua.DisplayMember = "donVi";
            cbb_cachdung_Sua.DataSource = table1.DefaultView;
            cbb_cachdung_Sua.DisplayMember = "cachDung";
        }

        private void TienKham_Click(object sender, EventArgs e)
        {
        }

        private void btnThayDoiTK_Click(object sender, EventArgs e)
        {

            bool kt;
            try
            {
                float.Parse(txtTienKham.Text);
                kt = true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kt = false;
            }
            if (kt == false)
            {
                txtTienKham.Text = "";
                txtTienKham.Focus();
            }
            else
            {
                PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
                pkbBus.tk();
                float tkmoi = float.Parse(txtTienKham.Text.ToString());
                float tkcu = PhieukhambenhDTO.TienKham;
                bool kq = pkbBus.thaydoiTK(tkmoi, tkcu);
                if (kq == false)
                {
                    System.Windows.Forms.MessageBox.Show("thay đổi thất bại");
                }
                else System.Windows.Forms.MessageBox.Show("thay đổi thành công");
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            ThuocBUS thBus = new ThuocBUS();
            bool kq = thBus.themdv(txtDonVi.Text.ToString());
            if (kq == false)
            {
                System.Windows.Forms.MessageBox.Show("Thêm đơn vị thất bại");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Thêm đơn vị thành công");
            }
            load();
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
        {
            ThuocBUS thBus = new ThuocBUS();
            bool kq = thBus.thaydoiDV(txtSuaDV.Text, cbb_donvi_Sua.Text);
            if (kq == false)
            {
                System.Windows.Forms.MessageBox.Show("Sửa đơn vị thất bại");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Sửa đơn vị thành công");
            }
            load();
        }

    }
}
