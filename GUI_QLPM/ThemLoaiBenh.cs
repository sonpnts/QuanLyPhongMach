using QLPMDTO;
using System;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class ThemLoaiBenh : Form
    {
        public ThemLoaiBenh()
        {
            InitializeComponent();
        }

        public BenhDTO GetBenh()
        {
            return new BenhDTO
            {
                MaBenh = maBenh.Text,
                TenBenh = tenBenh.Text
            };
        }
    
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Perform validation if needed
            if (string.IsNullOrEmpty(maBenh.Text) || string.IsNullOrEmpty(tenBenh.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
