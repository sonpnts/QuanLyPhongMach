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
    public partial class ThemLoaiBenh : Form
    {
        BenhBUS beBus = new BenhBUS();
        public ThemLoaiBenh()
        {
            InitializeComponent();
        }
        private void load()
        {
            beBus = new BenhBUS();
            maBenh.Text = beBus.autogenerate_mabenh().ToString();
        }

        private void Thêm_Click(object sender, EventArgs e)
        {
            if (maBenh.Text == null || tenBenh.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin loại bệnh");
            }
            else
            {
                BenhDTO be = new BenhDTO();
                be.MaBenh = maBenh.Text;
                be.TenBenh = tenBenh.Text;

                beBus = new BenhBUS();
                bool kq = beBus.them(be);
                if (kq == false)
                    System.Windows.Forms.MessageBox.Show("Thêm loại bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                else
                    System.Windows.Forms.MessageBox.Show("Thêm loại bệnh thành công", "Result");
            }
        }
    }
}
