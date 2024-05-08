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
using System.Windows.Controls;
using System.Windows;
using System.Windows.Forms;

namespace GUI_QLPM
{
    public partial class BaoCaoDoanhThu : Form
    {
        HoadonBUS hdBus = new HoadonBUS();
        public int stt;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }
        public void load_data()
        {
            stt = 1;
            string month = thang.Text.ToString();
            string year = nam.Text.ToString();
            hdBus = new HoadonBUS();
            List<HoadonDTO> listHoadon = hdBus.selectByMonth(month, year);
            this.loadData_Vao_GridView(listHoadon);
        }
        private void loadData_Vao_GridView(List<HoadonDTO> listhoadon)
        {
            if (listhoadon == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            float tongdoanhthu = 0;
            DataTable table = new DataTable();
            table.Columns.Add("Ngày Lập Hóa Đơn", typeof(string));
            table.Columns.Add("Số Bệnh Nhân", typeof(int));
            table.Columns.Add("Doanh Thu", typeof(float));
            table.Columns.Add("Số Thứ Tự", typeof(int));
            table.Columns.Add("Trạng Thái", typeof(string));
            foreach (HoadonDTO hd in listhoadon)
            {
                string ngkham;
                ngkham = String.Format("{0:M/d/yyyy}", hd.NgayHd);
                tongdoanhthu += float.Parse(hdBus.doanhthu(ngkham).ToString());
            }
            foreach (HoadonDTO hd in listhoadon)
            {
                DataRow row = table.NewRow();
                row["Ngày Lập Hóa Đơn"] = hd.NgayHd.ToString();
                string ngkham;
                ngkham = String.Format("{0:M/d/yyyy}", hd.NgayHd);
                row["Số Bệnh Nhân"] = int.Parse(hdBus.sobenhnhan(ngkham).ToString());
                row["Doanh Thu"] = float.Parse(hdBus.doanhthu(ngkham).ToString());
                row["Ty Le"] = Math.Round(((double)float.Parse(hdBus.doanhthu(ngkham).ToString()) / (double)tongdoanhthu) * 100, 2).ToString() + "%";
                row["Số Thứ Tự"] = stt;
                table.Rows.Add(row);
                stt += 1;
            }

            grid.DataSource = table.DefaultView;
        }

        private void Xem_Click(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
