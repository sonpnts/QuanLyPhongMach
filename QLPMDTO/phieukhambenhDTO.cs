using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMDTO
{
    public class PhieukhambenhDTO
    {
        private string maPKB;
        private DateTime ngayKham;
        private string trieuChung;
        private string maBenhNhan;

        public string MaPKB { get => maPKB; set => maPKB = value; }
        public string TrieuChung { get => trieuChung; set => trieuChung = value; }
        public DateTime NgayKham { get => ngayKham; set => ngayKham = value; }
        public string MaBenhNhan { get => maBenhNhan; set => maBenhNhan = value; }
    }
}
