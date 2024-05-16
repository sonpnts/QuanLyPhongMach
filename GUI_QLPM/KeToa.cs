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
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI_QLPM
{
    public partial class KeToa : Form
    {


        public DataTable db1 = new DataTable();
        ToathuocBUS ttBus = new ToathuocBUS();
        KethuocBUS ktBus = new KethuocBUS();
        ThuocBUS thBus = new ThuocBUS();
        string id;
        public KeToa(string ma)
        {
            InitializeComponent();
            load_data();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            mapkb.Text = (int.Parse(ma)-1).ToString();
            
        }
        

        public void load_data()
        {
            db1.Clear();
            db1.Columns.Add("Mã thuốc", typeof(string));
            db1.Columns.Add("tenThuoc", typeof(string));
            db1.Columns.Add("DonVi", typeof(string));
            db1.Columns.Add("Dongia", typeof(float));
            db1.Columns.Add("CachDung", typeof(string));
            db1.Columns.Add("soLuong", typeof(System.Int32));
            ThuocBUS thBus = new ThuocBUS();
            List<ThuocDTO> listThuoc = thBus.select();
            this.loadData_Vao_Combobox(listThuoc);
            ttBus = new ToathuocBUS();
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

            table.Columns.Add("tenThuoc", typeof(string));
            foreach (ThuocDTO th in listThuoc)
            {
                DataRow row = table.NewRow();
                row["tenThuoc"] = th.TenThuoc;
                table.Rows.Add(row);
            }
            TenThuoc.DataSource = table.DefaultView;
            TenThuoc.DisplayMember = "tenThuoc";
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
                    row["tenThuoc"] = th.TenThuoc;
                    row["DonVi"] = th.DonVi;
                    row["Dongia"] = th.DonGia;
                    row["CachDung"] = th.CachDung;
                    row["soLuong"] = soluong;
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
                        if (rows[i]["tenThuoc"].ToString() == TenThuoc.Text.ToString())
                        {
                            int sl = 0;
                            sl = int.Parse(rows[i]["soLuong"].ToString());
                            db1.Rows[i][0] = sl + int.Parse(soLuong.Text.ToString());
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

        private void grid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            DataGridViewRow row_selected = dataGridView.CurrentRow;

            if (row_selected != null)
            {
                string id = row_selected.Cells["maThuoc"].Value.ToString();
            }

        }

        private void grid_Click(object sender, EventArgs e)
        {
            DataRow[] drr = db1.Select("maThuoc='" + id + "'");
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
            }

           

        }
    }
}
