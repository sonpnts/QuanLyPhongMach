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
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GUI_QLPM
{
    public partial class BaoCaoDoanhThu : Form
    {
        HoadonBUS hdBus = new HoadonBUS();
        public int stt;
        System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            nam.SelectedItem = "2024";
            thang.SelectedItem = "5";
        }
        public void load_data()
        {
            stt = 1;
            string month = thang.Text.ToString();
            string year = nam.Text.ToString();
            hdBus = new HoadonBUS();
            List<HoadonDTO> listHoadonMonth = hdBus.selectByMonth(month, year);
            this.loadData_Vao_GridView(listHoadonMonth);

            Dictionary<string, float> dataByMonth = new Dictionary<string, float>();
            for (int mon = 1; mon <= 12; mon++)
            {
                string monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mon);
                float revenue = hdBus.doanhthuMonth(mon.ToString(), year);
                if (revenue > 0)
                {
                    dataByMonth.Add(monthName, revenue);
                }
            }

            chart1.Series.Clear();
            chart1.ChartAreas.Clear();
            ChartArea chartArea = chart1.ChartAreas.Add("chartArea");
            Series series = chart1.Series.Add("Doanh thu năm " + year);
            series.ChartType = SeriesChartType.Column;

            foreach (var item in dataByMonth)
            {
                series.Points.AddXY(item.Key, item.Value);
            }



            Dictionary<string, float> dataByDate = new Dictionary<string, float>();
            for (int day = 1; day <= DateTime.DaysInMonth(int.Parse(year), int.Parse(month)); day++)
            {
                string ngayLapHD = new DateTime(int.Parse(year), int.Parse(month), day).ToString("yyyy-MM-dd");
                float doanhThu = float.Parse(hdBus.doanhthu(ngayLapHD).ToString());

                if (doanhThu > 0)
                {
                    dataByDate.Add(ngayLapHD, doanhThu);
                }
            }

            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            ChartArea chartArea2 = chart2.ChartAreas.Add("chartArea");
            Series series2 = chart2.Series.Add("Doanh thu tháng " + month);
            series2.ChartType = SeriesChartType.Column;

            foreach (var item in dataByDate)
            {
                series2.Points.AddXY(item.Key, item.Value);
            }

        }
        private void loadData_Vao_GridView(List<HoadonDTO> listhoadon)
        {
            if (listhoadon == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }
            decimal tongdoanhthu = 0;
            DataTable table = new DataTable();
            table.Columns.Add("Số Thứ Tự", typeof(int));
            table.Columns.Add("Ngày Lập Hóa Đơn", typeof(string));
            table.Columns.Add("Số Bệnh Nhân", typeof(int));
            table.Columns.Add("Doanh Thu", typeof(string));
            table.Columns.Add("Tỷ Lệ", typeof(string));
            foreach (HoadonDTO hd in listhoadon)
            {
                string ngkham = DateTime.Parse(hd.NgayLapHoaDon.ToString()).ToString("yyyy-MM-dd");
                tongdoanhthu += decimal.Parse(hdBus.doanhthu(ngkham).ToString());
            }
            foreach (HoadonDTO hd in listhoadon)
            {
                DataRow row = table.NewRow();
                string ngkham = DateTime.Parse(hd.NgayLapHoaDon.ToString()).ToString("yyyy-MM-dd");
                row["Ngày Lập Hóa Đơn"] = DateTime.Parse(ngkham.ToString()).ToString("dd-MM-yyyy");
                row["Số Bệnh Nhân"] = int.Parse(hdBus.sobenhnhan(ngkham).ToString());
                string valueDoanhthu = hdBus.doanhthu(ngkham).ToString(CultureInfo.InvariantCulture);
                decimal parsedDoanhthu;

                // Try to parse the string value to a decimal using "en-US" culture and allowing thousands separators
                if (decimal.TryParse(valueDoanhthu, NumberStyles.Number, culture, out parsedDoanhthu))
                {
                    // Format the parsed decimal value with "en-US" culture and no decimal places
                    row["Doanh Thu"] = parsedDoanhthu.ToString("N0", culture);
                }

                //row["Doanh Thu"] = valueDoanhthu.ToString("N0", culture);
                row["Tỷ Lệ"] = Math.Round(((double)float.Parse(hdBus.doanhthu(ngkham).ToString()) / (double)tongdoanhthu) * 100, 2).ToString() + "%";
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
