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
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class LapHoaDon : Form
    {
        HoadonBUS hdBus = new HoadonBUS();
        ThuocBUS thBus = new ThuocBUS();
        KethuocBUS ktBus = new KethuocBUS();
        DichvuBUS dvBus = new DichvuBUS();
        cachDungBUS cdBUS = new cachDungBUS();
        donViBUS donViBUS = new donViBUS();
        List<cachdungDTO> listcd;
        List<donViDTO> listdv;

        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS();
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");

        public float tt;
        public float tkham;
        public int maNV;
        public int stt;
        public LapHoaDon(int mataikhoan)
        {
            maNV = mataikhoan;
            InitializeComponent();
            listcd = cdBUS.select();
            listdv = donViBUS.select();
            load();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void load()
        {
            PhieukhambenhBUS pkb = new PhieukhambenhBUS();
            hdBus = new HoadonBUS();
            ngayhd.Text = DateTime.UtcNow.Date.ToString();
            
            mahd.Text=hdBus.autogenerate_mahd().ToString();
            load_combobox();
            loadtiendichvu();
            load_TenBN();
            load_data(mapkb.Text);
        }
        public void load_combobox()
        {
            BenhNhanBUS bnBus = new BenhNhanBUS();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            List<HoadonDTO> listhd = hdBus.select();
            List<DichvuDTO> listdv = dvBus.select();
            this.loadData_Vao_Combobox(listpkb, listhd, listdv);
        }
        public void load_TenBN()
        {
            BenhNhanBUS bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhnhan = bnBus.select();
            List<PhieukhambenhDTO> listpkb = pkbBus.select();
            this.loadData_TenBN(listBenhnhan, listpkb);

        }
        private void loadData_Vao_Combobox(List<PhieukhambenhDTO> listpkb, List<HoadonDTO> listhd, List<DichvuDTO> listdv)
        {
            mapkb.Items.Clear();
            
            comboDichVu.Items.Clear();
            if (listpkb == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin nạp vào combox pkb từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
            foreach (PhieukhambenhDTO pkb in listpkb)
            {
                bool exists = false;
                foreach (HoadonDTO hd in listhd)
                {
                    if (hd.MaPKB == pkb.MaPKB)
                    {
                        exists = true;
                        break; // Nếu tìm thấy khớp, thoát khỏi vòng lặp
                    }
                }

                if (!exists)
                {
                    mapkb.Items.Add(pkb.MaPKB);
                }
                
            }
            if(mapkb.Items.Count > 0)
            { mapkb.SelectedIndex = 0; }
           
            foreach (DichvuDTO dichvu in listdv)
            {
                
                comboDichVu.Items.Add(dichvu.TenDichVu);
                comboDichVu.SelectedIndex = 0;
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

  
        private void btnLuu_Click(object sender, EventArgs e)
        {
            HoadonDTO hd = new HoadonDTO();
            hd.MaNVTN = maNV;
            hd.TongTien = tt;
            hd.MaPKB = mapkb.Text;
            hd.NgayLapHoaDon = DateTime.UtcNow.Date;
            hd.TienKham = tkham;
            hd.TienThuoc = hdBus.tienthuoc(hd, mapkb.Text);
            hdBus = new HoadonBUS();
            bool kq = hdBus.them(hd);
            if (kq == false)
                System.Windows.Forms.MessageBox.Show("Lưu hóa đơn thất bại. Vui lòng kiểm tra lại dũ liệu", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            else
            {
                System.Windows.Forms.MessageBox.Show("Lưu hóa đơn thành công", "Result");
                load();
            }
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
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Tên thuốc", typeof(string));
            table.Columns.Add("Đơn vị tính", typeof(string));
            table.Columns.Add("Đơn giá", typeof(string));
            table.Columns.Add("Số lượng", typeof(string));
            table.Columns.Add("Thành tiền", typeof(string));
            foreach (ThuocDTO th in listThuoc)
            {
                foreach (KethuocDTO kt in listkethuoc)
                {
                    if (th.MaThuoc == kt.MaThuoc)
                    {

                        DataRow row = table.NewRow();
                        row["Tên thuốc"] = th.TenThuoc;
                      
                        foreach (donViDTO donvi in listdv)
                        {
                            if (donvi.MaDonVi == th.MaDonVi)
                            {
                                row["Đơn vị tính"] = donvi.TenDonVi;
                            }

                        }
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

        private void comboDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadtiendichvu();

        }
        public void loadtiendichvu()
        {


            int selectedIndex = comboDichVu.SelectedIndex;
            List<DichvuDTO> listdv = dvBus.select();
            foreach (DichvuDTO d in listdv)
            {
                if (selectedIndex + 1 == d.MaDichVu)
                {
                    tienkham.Text = d.TienDichVu.ToString();
                    tkham = d.TienDichVu;
                    decimal valueTienkham;
                    if (decimal.TryParse(tienkham.Text, System.Globalization.NumberStyles.AllowThousands, culture, out valueTienkham))
                    {
                        tienkham.Text = String.Format(culture, "{0:N0}", valueTienkham);
                        tienkham.Select(tienkham.Text.Length, 0);
                    }
                    HoadonDTO hd = new HoadonDTO();
                    // Lấy tiền thuốc và chuyển đổi sang kiểu decimal
                    string tthuoc = hdBus.tienthuoc(hd, mapkb.Text).ToString();

                    // Chuyển đổi tiền thuốc sang kiểu decimal và định dạng lại chuỗi
                    decimal valueTthuoc;
                    if (decimal.TryParse(tthuoc, System.Globalization.NumberStyles.AllowThousands, culture, out valueTthuoc))
                    {
                        tienthuoc.Text = String.Format(culture, "{0:N0}", valueTthuoc);
                        tienthuoc.Select(tienthuoc.Text.Length, 0);
                    }

                    // Tính tổng tiền và chuyển đổi sang chuỗi
                    tt = (float)valueTthuoc + (float)valueTienkham;
                    decimal valueTongtien = (decimal)tt;

                    // Định dạng tổng tiền
                    tongtien.Text = String.Format(culture, "{0:N0}", valueTongtien);
                    tongtien.Select(tongtien.Text.Length, 0);
                }

            }
        }

        private void mapkb_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data(mapkb.Text);
            load_TenBN();


            tt = 0;
            stt = 1;
            hdBus = new HoadonBUS();

            HoadonDTO hd = new HoadonDTO();
            load_TenBN();
            load_data(mapkb.Text);

            // Lấy tiền thuốc và chuyển đổi sang kiểu decimal
            string tthuoc = hdBus.tienthuoc(hd, mapkb.Text).ToString();

            // Chuyển đổi tiền thuốc sang kiểu decimal và định dạng lại chuỗi
            decimal valueTthuoc;
            if (decimal.TryParse(tthuoc, System.Globalization.NumberStyles.AllowThousands, culture, out valueTthuoc))
            {
                tienthuoc.Text = String.Format(culture, "{0:N0}", valueTthuoc);
                tienthuoc.Select(tienthuoc.Text.Length, 0);
            }


            // Chuyển đổi tiền khám sang kiểu decimal và định dạng lại chuỗi
            decimal valueTienkham;
            if (decimal.TryParse(tienkham.Text, System.Globalization.NumberStyles.AllowThousands, culture, out valueTienkham))
            {
                tienkham.Text = String.Format(culture, "{0:N0}", valueTienkham);
                tienkham.Select(tienkham.Text.Length, 0);
            }


            // Tính tổng tiền và chuyển đổi sang chuỗi
            tt = (float)valueTthuoc + (float)valueTienkham;
            decimal valueTongtien = (decimal)tt;

            // Định dạng tổng tiền
            tongtien.Text = String.Format(culture, "{0:N0}", valueTongtien);
            tongtien.Select(tongtien.Text.Length, 0);
        }
    }
}
