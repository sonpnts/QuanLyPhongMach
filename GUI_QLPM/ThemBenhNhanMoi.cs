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
            hoten.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            diachi.Text = "";
            
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
                bn.MaBN = mabenhnhan.Text;
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
                bn.MaBN = bnBus.autogenerate_mabn().ToString();

                bool kq = bnBus.them(bn);
                if (kq == true)
                { 
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thành công", "Result");
                    QuanLyBN qlbn = new QuanLyBN();
                    this.Close();
                    qlbn.Show();
                } 
                else
                    System.Windows.Forms.MessageBox.Show("Thêm Bệnh nhân thất bại", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Warning);

            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuanLyBN qlbn = new QuanLyBN();
            this.Close();
            qlbn.Show();
        }

        private void ThemBenhNhanMoi_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
