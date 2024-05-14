﻿
using System.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLPMBUS;
using QLPMDTO;

namespace GUI_QLPM
{
    public partial class DanhSachBenhNhan : Form
    {

        BenhNhanBUS bnBus = new BenhNhanBUS();
        PhieukhambenhBUS pkbBus= new PhieukhambenhBUS();
        BenhBUS beBus = new BenhBUS();
        ChandoanBUS cdBus = new ChandoanBUS();
        private int stt;

        public DanhSachBenhNhan()
        {
            InitializeComponent();
            load_data();
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
            this.loadData_Vao_GridView(listBenhNhan, listBenh, listpkb, listcd);

        }

        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan, List<BenhDTO> listBenh, List<PhieukhambenhDTO> listpkb, List<ChandoanDTO> listcd)
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
            table.Columns.Add("Triệu chứng", typeof(string));
            table.Columns.Add("Tên bệnh", typeof(string));
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
                                foreach (BenhDTO be in listBenh)
                                {
                                    if (cd.MaBenh == be.MaBenh)
                                    {
                                        DataRow row = table.NewRow();
                                        row["Số thứ tự"] = stt;
                                        row["Tên bệnh nhân"] = bn.TenBN;
                                        row["Ngày khám"] = pkb.NgayKham;
                                        row["Triệu chứng"] = pkb.TrieuChung;
                                        row["Tên bệnh"] = be.TenBenh;
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
