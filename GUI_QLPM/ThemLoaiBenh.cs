using QLPMBUS;
using QLPMDTO;
using System;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class ThemLoaiBenh : Form
    {
        BenhBUS bnBUS = new BenhBUS();
        public ThemLoaiBenh()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            maBenh.Text = bnBUS.autogenerate_mabenh().ToString();
            tenBenh.Text = "";
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Perform validation if needed
            if (string.IsNullOrEmpty(maBenh.Text) || string.IsNullOrEmpty(tenBenh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                BenhDTO be = new BenhDTO();
                be.TenBenh = tenBenh.Text;
                
                bool kq = bnBUS.them(be);
                if (!kq)
                    System.Windows.Forms.MessageBox.Show("Thêm bệnh thất bại. Vui lòng kiểm tra lại dữ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                else
                {
                    System.Windows.Forms.MessageBox.Show("Thêm bệnh thành công", "Result");
                    this.Close();

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
