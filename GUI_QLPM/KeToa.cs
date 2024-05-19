﻿using QLPMBUS;
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
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPM
{
    public partial class KeToa : Form
    {

        PhieukhambenhBUS pkbBus = new PhieukhambenhBUS(); 
        public DataTable db1 = new DataTable();
        ToathuocBUS ttBus = new ToathuocBUS();
        KethuocBUS ktBus = new KethuocBUS();
        ThuocBUS thBus = new ThuocBUS();
        cachDungBUS cdBUS = new cachDungBUS();
        donViBUS donViBUS = new donViBUS();
        List<cachdungDTO> listcd;
        List<donViDTO> listdv;
        string id;
        public KeToa()
        {
            InitializeComponent();
            load_data();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            listcd = cdBUS.select();
            listdv = donViBUS.select();

        }
        

        public void load_data()
        {
            db1.Clear();
            db1.Columns.Add("Mã thuốc", typeof(string));
            db1.Columns.Add("Tên thuốc", typeof(string));
            db1.Columns.Add("Đơn vị", typeof(string));
            db1.Columns.Add("Đơn giá", typeof(float));
            db1.Columns.Add("Cách dùng", typeof(string));
            db1.Columns.Add("Số lượng", typeof(System.Int32));
            ThuocBUS thBus = new ThuocBUS();
            List<ThuocDTO> listThuoc = thBus.select();
            this.loadData_Vao_Combobox(listThuoc);
            ttBus = new ToathuocBUS();
           
            List<PhieukhambenhDTO> listPKB = pkbBus.select();
            List<ToathuocDTO> listToaThuoc = ttBus.select();
            this.loadData_Vao_Combobox(listThuoc, listPKB, listToaThuoc);

            maToa.Text = ttBus.autogenerate_matoa().ToString();

        }
        public void reset()
        {
            db1.Clear();
            mapkb.Text = "";
            soLuong.Text = "";
            TenThuoc.Text = "";
            maToa.Text = ttBus.autogenerate_matoa().ToString();
        }
        private void loadData_Vao_Combobox(List<ThuocDTO> listThuoc)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            DataTable table = new DataTable();

            table.Columns.Add("Tên thuốc", typeof(string));
            foreach (ThuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["Tên thuốc"] = th.TenThuoc;
                table.Rows.Add(row);
            }
            TenThuoc.DataSource = table.DefaultView;
            TenThuoc.DisplayMember = "Tên thuốc";
            TenThuoc.SelectedIndex = -1;

        }

        private void loadData_Vao_GridView(List<ThuocDTO> listThuoc, string soluong)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            foreach (ThuocDTO th in listThuoc)
            {
                if (th.TenThuoc == TenThuoc.Text)
                {
                    DataRow row = db1.NewRow();
                    row["Mã thuốc"] = th.MaThuoc;
                    row["Tên thuốc"] = th.TenThuoc;
                    foreach (donViDTO donvi in listdv)
                    {
                        if (donvi.MaDonVi == th.MaDonVi)
                        {
                            row["Đơn vị"] = donvi.TenDonVi;
                        }

                    }

                    row["Đơn giá"] = th.DonGia;
                    foreach (cachdungDTO cd in listcd)
                    {
                        if (cd.MaCachDung == th.MaCachDung)
                        {
                            row["Cách dùng"] = cd.TenCachDung;
                        }

                    }
                    
                    
                    
                    row["Số lượng"] = soluong;
                    db1.Rows.Add(row);
                }
            }
        }

        private void AddThuoc_SoLuong_Click(object sender, EventArgs e)
        {
            bool kt;
            try
            {
                int.Parse(soLuong.Text);
                kt = true;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Vui lòng nhập số và không được để trống", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                kt = false;

            }
            if (kt == false)
            {
                soLuong.Text = "";
                soLuong.Focus();
            }
            else
            {
                bool notExist = true;
                DataRow[] rows = db1.Select();
                if (rows.Length == 0)
                {
                    thBus = new ThuocBUS();
                    List<ThuocDTO> listThuoc = thBus.select();
                    this.loadData_Vao_GridView(listThuoc, soLuong.Text);
                    grid.DataSource = db1.DefaultView;

                }
                else
                {
                    for (int i = 0; i < rows.Length; i++)
                    {
                        if (rows[i]["Tên thuốc"].ToString() == TenThuoc.Text.ToString())
                        {
                            int sl = 0;
                            sl = int.Parse(rows[i]["Số lượng"].ToString());
                            db1.Rows[i][5] = sl + int.Parse(soLuong.Text.ToString());
                            notExist = false;
                            break;
                        }
                    }
                    if (notExist == true)
                    {
                        thBus = new ThuocBUS();
                        List<ThuocDTO> listThuoc = thBus.select();
                        this.loadData_Vao_GridView(listThuoc, soLuong.Text);
                        grid.DataSource = db1.DefaultView;

                    }
                }
            }
        }

        private void loadData_Vao_Combobox(List<ThuocDTO> listThuoc, List<PhieukhambenhDTO> listPKB, List<ToathuocDTO> listToaThuoc)
        {

            if (listThuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }

            if (listPKB == null)
            {
                System.Windows.Forms.MessageBox.Show("Không có phiếu khám bệnh nào cần kê thuốc !!!", "Result", System.Windows.Forms.MessageBoxButtons.OKCancel, System.Windows.Forms.MessageBoxIcon.Error);
                return;
            }
            DataTable table = new DataTable();

            table.Columns.Add("Tên thuốc", typeof(string));
            foreach (ThuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["Tên thuốc"] = th.TenThuoc;
                table.Rows.Add(row);
            }
            TenThuoc.DataSource = table.DefaultView;
            TenThuoc.DisplayMember = "Tên thuốc";
            TenThuoc.SelectedIndex = -1;

            HashSet<string> maPKBDaCoTrongToaThuoc = new HashSet<string>();

            foreach (ToathuocDTO tt in listToaThuoc)
            {
                maPKBDaCoTrongToaThuoc.Add(tt.MaPkb);
            }

            foreach (PhieukhambenhDTO pkb in listPKB)
            {
                if (!maPKBDaCoTrongToaThuoc.Contains(pkb.MaPKB))
                {
                    mapkb.Items.Add(pkb.MaPKB);

                }
            }
        }

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewRow row_selected = dataGridView.CurrentRow;

            if (row_selected != null)
            {
                string id = row_selected.Cells["Mã thuốc"].Value.ToString();
            }

        }

        private void grid_Click(object sender, EventArgs e)
        {
            DataRow[] drr = db1.Select("Mã thuốc='" + id + "'");
            for (int i = 0; i < drr.Length; i++)
                drr[i].Delete();
            db1.AcceptChanges();
            grid.DataSource = db1.DefaultView;
        }

        private void KeThuoc_Click(object sender, EventArgs e)
        {
            int row = db1.Rows.Count;
            ToathuocDTO tt = new ToathuocDTO();
            tt.MaToa = maToa.Text.ToString();
            tt.MaPkb = mapkb.Text.ToString();
            tt.NgayKetoa = DateTime.UtcNow.Date;
            ttBus = new ToathuocBUS();
            bool kq = ttBus.them(tt);
            KethuocDTO kt = new KethuocDTO();
            for (int i = 0; i < row; i++)
            {
                kt.MaToa = maToa.Text;
                kt.MaThuoc = grid.Rows[i].Cells[0].Value.ToString();
                int val = int.Parse(grid.Rows[i].Cells[5].Value.ToString());

                bool check = int.TryParse(grid.Rows[i].Cells[5].Value.ToString(), out val);
                if (!check)
                {
                    return;
                }
                else
                {
                    kt.SoLuong = val;
                }
                ktBus = new KethuocBUS();
                bool kq1 = ktBus.kethuoc(kt);
            }
           

            if (kq == false)
            {
                System.Windows.Forms.MessageBox.Show("Kê toa thất bại", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Kê toa thành công", "Result");
                reset();
            }

           

        }
    }
}
