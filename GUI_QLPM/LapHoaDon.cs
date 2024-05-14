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
    public partial class LapHoaDon : Form
    {
        HoadonBUS hdBus = new HoadonBUS();
        ThuocBUS thBus = new ThuocBUS();
        KethuocBUS ktBus = new KethuocBUS();
        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        public float tkham ;
        public float tt;
        
        public int stt;
        public LapHoaDon()
        {
            InitializeComponent();
            load();
        }
        public void load()
        {
            PhieukhambenhBUS pkb = new PhieukhambenhBUS();
            hdBus = new HoadonBUS();
            ngayhd.Text = DateTime.UtcNow.Date.ToString();
            tkham = hdBus.tienkham();
            tienkham.Text = tkham.ToString();
            load_combobox();
        }
        public void load_combobox()
        {
            BenhNhanBUS bnBus = new BenhNhanBUS();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            this.loadData_Vao_Combobox(listpkb);
        }
        public void load_TenBN()
        {
            BenhNhanBUS bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhnhan = bnBus.select();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            this.loadData_TenBN(listBenhnhan, listpkb);

        }
        private void loadData_Vao_Combobox(List<PhieukhambenhDTO> listpkb)
        {

            if (listpkb == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin nạp vào combox pkb từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            foreach (PhieukhambenhDTO pkb in listpkb)
            {
                if (pkb.MaPKB != null)
                {
                    mapkb.Items.Add(pkb.MaPKB);
                }
            }
        }
        private void loadData_TenBN(List<BenhNhanDTO> listBenhnhan, List<PhieukhambenhDTO> listpkb)
        {
            foreach (PhieukhambenhDTO pkb in listpkb)
            {
                if (pkb.MaPKB == mapkb.Text)
                {
                    if (listBenhnhan == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin tên bn từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        return;
                    }
                    foreach (BenhNhanDTO bn in listBenhnhan)
                    {
                        if (bn.MaBN == pkb.MaBenhNhan)
                        {
                            tenbn.Text = bn.TenBN;
                        }
                    }
                }
            }

           
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            tt = 0;
            stt = 1;
            hdBus = new HoadonBUS();

            HoadonDTO hd = new HoadonDTO();
            load_TenBN();
            load_data(mapkb.Text);
            string tthuoc = hdBus.tienthuoc(hd, mapkb.Text).ToString();
           
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            decimal value = decimal.Parse(tthuoc, System.Globalization.NumberStyles.AllowThousands);
            tienthuoc.Text = String.Format(culture, "{0:N0}", value);
            tienthuoc.Select(tienthuoc.Text.Length, 0);
            decimal value1 = decimal.Parse(tkham.ToString(), System.Globalization.NumberStyles.AllowThousands);
            tienkham.Text = String.Format(culture, "{0:N0}", value1);
            tienkham.Select(tienkham.Text.Length, 0);
            string ttien = (float.Parse(tthuoc) + tkham).ToString();
            tt = float.Parse(tthuoc) + tkham;
            decimal value2 = decimal.Parse(ttien, System.Globalization.NumberStyles.AllowThousands);
            tongtien.Text = String.Format(culture, "{0:N0}", value2);
            tongtien.Select(tongtien.Text.Length, 0);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoadonDTO hd = new HoadonDTO();
            
            hd.TongTien = tt;
            hd.MaPKB = int.Parse(mapkb.Text);
            hd.NgayLapHoaDon = DateTime.UtcNow.Date;
            hd.TienKham= tkham;
            hd.TienThuoc = hdBus.tienthuoc(hd, mapkb.Text);
            hdBus = new HoadonBUS();
            bool kq = hdBus.them(hd);
            if (kq == false)
                System.Windows.Forms.MessageBox.Show("Lưu hóa đơn thất bại. Vui lòng kiểm tra lại dũ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
                System.Windows.Forms.MessageBox.Show("Lưu hóa đơn thành công", "Result");
        }
        public void load_data(string mapkb)
        {
            thBus = new ThuocBUS();
            ktBus = new KethuocBUS();
            List<ThuocDTO> listThuoc = thBus.selectbypkb(mapkb);
            List<KethuocDTO> listkethuoc = ktBus.selectbypkb(mapkb);
            this.loadData_Vao_GridView(listThuoc, listkethuoc);

        }
        private void loadData_Vao_GridView(List<ThuocDTO> listThuoc, List<KethuocDTO> listkethuoc)
        {

            if (listThuoc == null || listkethuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin load thông tin thuốc từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();
            table.Columns.Add("Tên thuốc", typeof(string));
            table.Columns.Add("Đơn vị tính", typeof(string));
            table.Columns.Add("Đơn giá", typeof(string));
            table.Columns.Add("Số lượng", typeof(string));
            table.Columns.Add("Thành tiền", typeof(string));
            table.Columns.Add("STT", typeof(int));
            foreach (ThuocDTO th in listThuoc)
            {
                foreach (KethuocDTO kt in listkethuoc)
                {
                    if (th.MaThuoc == kt.MaThuoc)
                    {

                        DataRow row = table.NewRow();
                        row["Tên thuốc"] = th.TenThuoc;
                        row["Đơn vị tính"] = th.DonVi;
                        row["Đơn giá"] = th.DonGia;
                        row["Số lượng"] = kt.SoLuong;
                        row["Thành tiền"] = (kt.SoLuong * th.DonGia).ToString();
                        row["STT"] = stt;
                        table.Rows.Add(row);
                        stt += 1;
                    }
                }
            }
            grid.DataSource = table.DefaultView;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
