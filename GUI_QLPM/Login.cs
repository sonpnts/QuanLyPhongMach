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
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            matkhau.UseSystemPasswordChar=true;
        }

        taiKhoanBUS tkBus = new taiKhoanBUS();
        taiKhoanDTO tk = new taiKhoanDTO();
        loaiTaiKhoanBUS loaitkBUS = new loaiTaiKhoanBUS();
        loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();
   
        Boolean check=false;

        private void dangnhap_Click(object sender, EventArgs e)
        {
            List<taiKhoanDTO> listTk = tkBus.select();
            List<loaiTaiKhoanDTO> listLoaiTK = loaitkBUS.select();
            int TENTK=0;
            foreach (taiKhoanDTO tk in listTk)
            {
                if (tk.Username == username.Text)
                {
                    if (tk.Password == matkhau.Text)
                    {
                        check = true;
                        TENTK = tk.MaTK;
                    }

                }
            }
            if (check)
            {
                this.Hide();
                QLPMMainWindow main = new QLPMMainWindow(TENTK);
                main.Show();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu hoặc tài khoản", "Cảnh báo", MessageBoxButtons.OK);
                username.Text = "";
                matkhau.Text = "";
                username.Focus();
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
