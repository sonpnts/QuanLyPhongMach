using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMDTO
{
    public class HoadonDTO
    {
        private int maHoaDon;
        private DateTime ngayLapHoaDon;
		private float tienThuoc;
        private float tienKham;
        private float tongTien;
        private int maPKB;
		



        public int MaPKB { get => maPKB; set => maPKB = value; }
		
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public DateTime NgayLapHoaDon { get => ngayLapHoaDon; set => ngayLapHoaDon = value; }
		public float TienThuoc { get => tienThuoc; set => tienThuoc = value; }
        public float TienKham { get => tienKham; set => tienKham = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
    }
}
