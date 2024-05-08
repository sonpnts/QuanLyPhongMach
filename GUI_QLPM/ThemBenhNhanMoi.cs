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
    public partial class ThemBenhNhanMoi : Form
    {
        BenhNhanBUS bnBus = new BenhNhanBUS();

        public ThemBenhNhanMoi()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            bnBus = new BenhNhanBUS();
            mabenhnhan.Text = bnBus.autogenerate_mabn().ToString();
        }

        private void them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mabenhnhan.Text) || string.IsNullOrEmpty(hoten.Text) || (!radioButton1.Checked && !radioButton2.Checked) || ngaysinh.Value == null || string.IsNullOrEmpty(diachi.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân");
            }
            else
            {
                BenhNhanDTO bn = new BenhNhanDTO();
                PhieukhambenhDTO pkb = new PhieukhambenhDTO();
                PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
                bn.MaBN = int.Parse(mabenhnhan.Text);
                bn.TenBN = hoten.Text;
                if (radioButton1.Checked == true)
                {
                    bn.GtBN = "Nam";
                }
                else
                {
                    bn.GtBN = "Nữ";
                }
                bn.NgsinhBN = ngaysinh.Value;
                bn.DiachiBN = diachi.Text;
                bn.MaPKB = pkbBus.autogenerate_mapkb().ToString();
                pkb.MaPkb = pkbBus.autogenerate_mapkb().ToString();
                pkb.NgayKham = DateTime.UtcNow.Date;
                bnBus = new BenhNhanBUS();
                bool kq1 = pkbBus.them(pkb);
                bool kq2 = bnBus.them(bn);
                if (kq1 == true && kq2 == true)
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thành công", "Result");
                else
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thất bại", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);

            }
        }
    }
}
