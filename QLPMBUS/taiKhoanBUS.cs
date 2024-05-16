using QLPMDAL;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMBUS
{
    public class taiKhoanBUS
    {
        private taiKhoanDAL tkDAL;
        public taiKhoanBUS()
        {
            tkDAL = new taiKhoanDAL ();
        }
        public bool them(taiKhoanDTO tk)
        {
            bool re = tkDAL.them(tk);
            return re;
        }


        public List<taiKhoanDTO> select()
        {
            return tkDAL.select();
        }
        public int autogenerate_maTaiKhoan()
        {
            return tkDAL.autogenerate_maTaiKhoan();
        }

    }
}
