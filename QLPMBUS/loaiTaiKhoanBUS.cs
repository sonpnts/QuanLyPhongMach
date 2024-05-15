using QLPMDAL;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMBUS
{
    public class loaiTaiKhoanBUS
    {
        private loaiTaiKhoanDAL loaitkDAL;
        public loaiTaiKhoanBUS()
        {
            loaitkDAL = new loaiTaiKhoanDAL();
        }
        public bool them(loaiTaiKhoanDTO loaitk)
        {
            bool re = loaitkDAL.them(loaitk);
            return re;
        }

        public List<loaiTaiKhoanDTO> select()
        {
            return loaitkDAL.select();
        }
    }
}
