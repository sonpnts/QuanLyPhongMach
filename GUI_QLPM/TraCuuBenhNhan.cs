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
    public partial class TraCuuBenhNhan : Form
    {
        public DataTable db1 = new DataTable("BenhNhan");
        BenhNhanBUS bnBus = new BenhNhanBUS();
        BenhNhanDTO bn = new BenhNhanDTO();
        private string temp;
        public TraCuuBenhNhan()
        {
            InitializeComponent();
            load_data();
        }
        private void load()
        {
            db1.Clear();
            db1.Columns.Add("MaHD", typeof(System.Int32));
        }
        public void load_data()
        {
            bnBus = new BenhNhanBUS();
            List<BenhNhanDTO> listBenhNhan = bnBus.select();
            this.loadData_Vao_GridView(listBenhNhan);
        }
        private void loadData_Vao_GridView(List<BenhNhanDTO> listBenhNhan)
        {

            if (listBenhNhan == null)
            {
                System.Windows.Forms.MessageBox.Show("Có lỗi khi lấy thông tin từ DB", "Result", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;

            }

            DataTable table = new DataTable();
            table.Columns.Add("maBN", typeof(int));
            table.Columns.Add("tenBN", typeof(string));
            table.Columns.Add("NgaySinh", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("GioiTinh", typeof(string));
            table.Columns.Add("maPKB", typeof(string));
            foreach (BenhNhanDTO bn in listBenhNhan)
            {
                DataRow row = table.NewRow();
                row["maBN"] = int.Parse(bn.MaBN.ToString());
                row["tenBN"] = bn.TenBN;
                row["NgaySinh"] = bn.NgsinhBN;
                row["DiaChi"] = bn.DiachiBN;
                row["GioiTinh"] = bn.GtBN;
                //row["maPKB"] = ;
                table.Rows.Add(row);
            }
            gird.DataSource = table.DefaultView;
        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            bnBus = new BenhNhanBUS();
            string sKeyword = nhaptukhoa.Text;
            if (sKeyword == null || sKeyword == string.Empty || sKeyword.Length == 0) // tìm tất cả
            {
                List<BenhNhanDTO> listBenhNhan = bnBus.select();
                this.loadData_Vao_GridView(listBenhNhan);
            }
            else
            {
                List<BenhNhanDTO> listBenhNhan = bnBus.selectByKeyWord(sKeyword);
                this.loadData_Vao_GridView(listBenhNhan);
            }
        }

        private void quaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
