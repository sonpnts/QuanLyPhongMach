using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPMDAL;
using QLPMDTO;

namespace QLPMBUS
{
    public class DichvuBUS
    {
        private DichvuDAL dvDAL;
        public DichvuBUS()
        {
            dvDAL = new DichvuDAL ();
        }
        public bool them(DichvuDTO qd)
        {
            bool re = dvDAL.them(qd);
            return re;
        }
        public bool sua(DichvuDTO dv, int maDichVuOld)
        {
            bool re = dvDAL.sua(dv, maDichVuOld);
            return re;
        }
        public bool xoa(DichvuDTO dv)
        {
            bool re = dvDAL.xoa(dv);
            return re;
        }
        public List<DichvuDTO> select()
        {
            return dvDAL.select();
        }
        public List<DichvuDTO> selectByKeyWord(string sKeyword)
        {
            return dvDAL.selectByKeyWord(sKeyword);
        }
        public int autogenerate_madv()
        {
            return dvDAL.autogenerate_madv();
        }
    }
}
