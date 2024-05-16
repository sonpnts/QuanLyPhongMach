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
    public partial class ThayDoiThongTinBenhNhan : Form
    {
        BenhNhanBUS bnBus = new BenhNhanBUS();
        public string temp;
        public ThayDoiThongTinBenhNhan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(mabenhnhan.Text) || string.IsNullOrEmpty(hoten.Text) || (radio1.Checked == false && radio2.Checked == false) || ngaysinh.Value == null || string.IsNullOrEmpty(diachi.Text))
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin bệnh nhân", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BenhNhanDTO bn = new BenhNhanDTO();
                bn.MaBN = mabenhnhan.Text;
                bn.TenBN = hoten.Text;
                if (radio1.Checked == true)
                {
                    bn.GtBN = "Nam";
                }
                else
                {
                    bn.GtBN = "Nữ";
                }
                bn.NgsinhBN = ngaysinh.Value;
                bn.DiachiBN = diachi.Text;
                bnBus = new BenhNhanBUS();
                bool kq = bnBus.sua(bn, temp);
                if (kq == false)
                    System.Windows.Forms.MessageBox.Show("Sửa Bệnh nhân thất bại. Vui lòng kiểm tra lại dũ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                    System.Windows.Forms.MessageBox.Show("Sửa Bệnh nhân thành công", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
