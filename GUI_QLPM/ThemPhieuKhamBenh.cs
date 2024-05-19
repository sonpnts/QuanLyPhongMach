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
using System.Xml.Linq;

namespace GUI_QLPM
{
    public partial class ThemPhieuKhamBenh : Form
    {
        public int maBS;
        BenhNhanBUS bnBus = new BenhNhanBUS();
        BenhBUS beBus = new BenhBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        private int stt;
        public ThemPhieuKhamBenh(int mabs)
        {
            maBS=mabs;
            InitializeComponent();
            load_combobox_mabn();
            load_combobox_benh();
            ngayKham.Text = DateTime.Now.ToString();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Load_Gird();
            load_data();
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
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin bệnh nhân từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;

            }
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                mabenhnhan.Items.Add(bn.MaBN.ToString());
            }

        }

        public void load_data()
        {
            maPKB.Text = pkbBus.autogenerate_mapkb().ToString();
            mabenhnhan.Text = "";
            hoten.Text = "";
            trieuchung.Text = "";
            benh.Text = "";
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
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin bệnh từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                pkb.MaPKB = maPKB.Text;
                pkb.NgayKham = DateTime.UtcNow.Date;
                pkb.TrieuChung = trieuchung.Text;
                pkb.MaBenhNhan = mabenhnhan.Text;
                pkb.MBS = maBS;
                PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
                ChandoanBUS cdBus = new ChandoanBUS();
                bool kq2 = pkbBus.them(pkb);
                bool kq1 = cdBus.them(cd);
                if (kq2 == true && kq1 == true)
                {
                    System.Windows.Forms.MessageBox.Show("Lập phiếu thành công", "Result");
                    load_data();
                    Load_Gird();
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
            KeToa toa = new KeToa();
            toa.Show();
        }


        public void Load_Gird()
        {
            int stt = 1;
            
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Mã bệnh nhân", typeof(string));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Địa chỉ", typeof(string));

            // Tạo HashSet để lưu mã bệnh nhân đã có phiếu khám bệnh
            HashSet<string> maBenhNhanDaCoPhieu = new HashSet<string>();

            // Thêm mã bệnh nhân từ danh sách phiếu khám bệnh vào HashSet
            foreach (PhieukhambenhDTO pkb in listpkb)
            {
                maBenhNhanDaCoPhieu.Add(pkb.MaBenhNhan);
            }

            // Duyệt qua danh sách bệnh nhân và chỉ thêm những bệnh nhân không có trong HashSet vào DataTable
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                if (!maBenhNhanDaCoPhieu.Contains(bn.MaBN))
                {
                    DataRow row = table.NewRow();
                    row["Số thứ tự"] = stt;
                    row["Mã bệnh nhân"] = bn.MaBN;
                    row["Tên bệnh nhân"] = bn.TenBN;
                    row["Ngày sinh"] = DateTime.Parse(bn.NgsinhBN.ToString()).ToString("dd/MM/yyyy"); ;
                    row["Địa chỉ"] = bn.DiachiBN;
                    table.Rows.Add(row);
                    stt += 1;
                }
            }
            gird.DataSource = table.DefaultView;
        }

        private void gird_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < gird.Rows.Count)
            {
                DataGridViewRow row = gird.Rows[e.RowIndex];
                hoten.Text = row.Cells[2].Value.ToString();
                mabenhnhan.Text = row.Cells[1].Value.ToString();
            }
        }
    }
        
    
}
