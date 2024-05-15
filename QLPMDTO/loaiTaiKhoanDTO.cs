using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMDTO
{
    public class loaiTaiKhoanDTO
    {
        private string tenLoaiTaiKhoan;
        private int maRole;
        public string TenLoaiTaiKhoan { get => tenLoaiTaiKhoan; set => tenLoaiTaiKhoan = value; }
        public int MaRole { get => maRole; set => maRole = value; }
    }
}
