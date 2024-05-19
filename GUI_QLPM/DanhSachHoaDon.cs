using QLPMBUS;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class DanhSachHoaDon : Form
    {
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        BenhBUS beBus = new BenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        HoadonBUS hdBus = new HoadonBUS();
        taiKhoanBUS tkBus = new taiKhoanBUS();
        private int stt;
        public DanhSachHoaDon()
        {
            InitializeComponent();
            load_data();
            gird.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void load_data()
        {
            stt = 1;
            bnBus = new BenhNhanBUS();
            beBus = new BenhBUS();
            pkbBus = new PhieukhambenhBUS();
            cdBus = new ChandoanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            List<BenhDTO> listBenh = beBus.select();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            List<ChandoanDTO> listcd = cdBus.select();
            List<HoadonDTO> listhd = hdBus.select();
            List<taiKhoanDTO> listTK = tkBus.select();
            this.loadData_Vao_GridView(listBenhNhan, listBenh, listpkb, listcd, listhd, listTK);

        }

        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<BenhDTO> listBenh, List<PhieukhambenhDTO> listpkb, List<ChandoanDTO> listcd, List<HoadonDTO> listhd, List<taiKhoanDTO> listTK)
        {

            if (listBenhNhan == null || listpkb == null || listBenh == null || listcd == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            
            DataTable table = new DataTable();
            table.Columns.Add("Số thứ tự", typeof(int));
            table.Columns.Add("Tên bệnh nhân", typeof(string));
            table.Columns.Add("Ngày khám", typeof(string));
            table.Columns.Add("Tiền khám", typeof(string));
            table.Columns.Add("Tiền thuốc", typeof(string));
            table.Columns.Add("Tổng tiền", typeof(string));
            table.Columns.Add("Nhân viên thu ngân", typeof(string));
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                foreach (PhieukhambenhDTO pkb in listpkb)
                {
                    if (bn.MaBN == pkb.MaBenhNhan)
                    {
                        foreach (ChandoanDTO cd in listcd)
                        {
                            if (pkb.MaPKB == cd.MaPkb)
                            {
                                foreach (HoadonDTO hd in listhd)
                                {
                                    if (hd.MaPKB == pkb.MaPKB)
                                    {
                                        DataRow row = table.NewRow();
                                        row["Số thứ tự"] = stt;
                                        row["Tên bệnh nhân"] = bn.TenBN;
                                        row["Ngày khám"] = DateTime.Parse(pkb.NgayKham.ToString()).ToString("dd/MM/yyyy");
                                        row["Tiền khám"] = hd.TienKham.ToString("N0", culture);
                                        row["Tiền thuốc"] = hd.TienThuoc.ToString("N0", culture);
                                        row["Tổng tiền"] = hd.TongTien.ToString("N0", culture);
                                        foreach(taiKhoanDTO tk in listTK)
                                        {
                                            if (tk.MaTK == hd.MaNVTN)
                                            {
                                                row["Nhân viên thu ngân"] = tk.Name;

                                            }
                                        }
                                        table.Rows.Add(row);
                                        stt += 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            gird.DataSource = table.DefaultView;
        }

    }
}
