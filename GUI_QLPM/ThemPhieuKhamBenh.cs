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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class ThemPhieuKhamBenh : Form
    {
        BenhNhanBUS bnBus = new BenhNhanBUS();
        BenhBUS beBus = new BenhBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        private int stt;
        public ThemPhieuKhamBenh()
        {
            InitializeComponent();
            load_combobox_mabn();
            load_combobox_benh();
            ngayKham.Text = DateTime.Now.ToString();
            Load_Gird();
        }
        public void load_combobox_mabn()
        {
            bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            this.loadData_Vao_comboboxbn(listBenhNhan);

        }
        private void loadData_Vao_comboboxbn(List<BenhNhanDTO> listBenhNhan)
        {

            if (listBenhNhan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;

            }
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                mabenhnhan.Items.Add(bn.MaBN.ToString());
            }

        }
        private void load_ten(List<BenhNhanDTO> listBenhNhan, string mabn)
        {

            if (listBenhNhan == null)
            {

                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                if (bn.MaBN.ToString() == mabn)
                {
                    hoten.Text = bn.TenBN;
                    maPKB.Text = bn.MaPKB;
                }
            }

        }
        public void load_combobox_benh()
        {
            beBus = new BenhBUS();
            List<BenhDTO> listBenh = beBus.select();
            this.loadData_Vao_comboboxbe(listBenh);

        }
        private void loadData_Vao_comboboxbe(List<BenhDTO> listBenh)
        {

            if (listBenh == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            foreach (BenhDTO be in listBenh)
            {
                benh.Items.Add(be.TenBenh.ToString());
            }
        }

        private void KiemTra_Click(object sender, EventArgs e)
        {
            bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            load_ten(listBenhNhan, mabenhnhan.Text);
        }

        private void LapPhieu_Click(object sender, EventArgs e)
        {
            if (maPKB.Text == null || trieuchung.Text == null)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu khám bệnh");
            }
            else
            {
                PhieukhambenhDTO pkb = new PhieukhambenhDTO();
                ChandoanDTO cd = new ChandoanDTO();
                List<BenhDTO> listBenh = beBus.select();
                cd.MaPkb = maPKB.Text;
                foreach (BenhDTO be in listBenh)
                {
                    if (benh.Text == be.TenBenh)
                    {
                        cd.MaBenh = be.MaBenh;
                    }
                }
                pkb.MaPkb = maPKB.Text;
                pkb.NgayKham = DateTime.UtcNow.Date;
                pkb.TrieuChung = trieuchung.Text;
                PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
                ChandoanBUS cdBus = new ChandoanBUS();
                bool kq1 = cdBus.them(cd);
                bool kq2 = pkbBus.sua(pkb);
                if (kq2 == true && kq1 == true)
                {
                    System.Windows.Forms.MessageBox.Show("Lập phiếu thành công", "Result");
                }
                else System.Windows.Forms.MessageBox.Show("Lập phiếu thất bại", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KeToa_Click(object sender, EventArgs e)
        {
            KeToa toa = new KeToa(maPKB.Text);
            toa.Show();
        }


        public void Load_Gird()
        {
            stt = 1;
            bnBus = new BenhNhanBUS();
            pkbBus = new PhieukhambenhBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                foreach (PhieukhambenhDTO pkb in listpkb)
                {
                    if (bn.MaPKB == pkb.MaPkb)
                    {
                        if (pkb.TrieuChung == "")
                        {
                            Console.WriteLine("có dữ liệu");
                            DataRow row = table.NewRow();
                            row["Số thứ tự"] = stt;
                            row["Mã bệnh nhân"] = bn.MaBN;
                            row["Tên bệnh nhân"] = bn.TenBN;
                            row["Ngày sinh"] = bn.NgsinhBN;
                            row["Địa chỉ"] = bn.DiachiBN;
                            table.Rows.Add(row);
                            stt += 1;
                        }

                    }
                }
            }
            gird.DataSource = table.DefaultView;
        }
    }
        
    
}
