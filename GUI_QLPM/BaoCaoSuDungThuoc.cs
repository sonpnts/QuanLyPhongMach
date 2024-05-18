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
    public partial class BaoCaoSuDungThuoc : Form
    {
        ThuocBUS thBus = new ThuocBUS();
        KethuocBUS ktBus = new KethuocBUS();
        public int stt;
        public BaoCaoSuDungThuoc()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void load_data()
        {
            stt = 1;
            string month = thang.Text.ToString();
            string year = nam.Text.ToString();
            thBus = new ThuocBUS();
            ktBus = new KethuocBUS();
            List<ThuocDTO> listThuoc = thBus.baocaobymonth(month, year);
            List<KethuocDTO> listkethuoc = ktBus.baocaobymonth(month, year);
            this.loadData_Vao_GridView(listThuoc, listkethuoc, month, year);
        }
        private void loadData_Vao_GridView(List<ThuocDTO> listThuoc, List<KethuocDTO> listkethuoc, string month, string year)
        {
            if (listThuoc == null || listkethuoc == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }

            DataTable table = new DataTable();
            table.Columns.Add("Tên Thuốc", typeof(string));
            table.Columns.Add("Đơn Vị Tính", typeof(string));
            table.Columns.Add("Số Thứ Tự", typeof(int));
            table.Columns.Add("Số Lần Dùng", typeof(int));
            table.Columns.Add("Số Lượng", typeof(int));
            foreach (ThuocDTO th in listThuoc)
            {
                foreach (KethuocDTO kt in listkethuoc)
                {
                    if (th.MaThuoc == kt.MaThuoc)
                    {

                        DataRow row = table.NewRow();
                        row["Tên Thuốc"] = th.TenThuoc;
                        row["Đơn Vị Tính"] = th.MaDonVi;
                        row["Số Lượng"] = kt.SoLuong;
                        row["Số Lần Dùng"] = ktBus.solandungbymonth(th.MaThuoc, month, year);
                        row["Số Thứ Tự"] = stt;
                        table.Rows.Add(row);
                        stt += 1;
                    }
                }
            }
            grid.DataSource = table.DefaultView;
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
