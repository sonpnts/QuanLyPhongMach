using QLPMDAL;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLPMBUS
{
    public class BenhNhanBUS
    {
        private BenhNhanDAL bnDAL;
        public BenhNhanBUS()
        {
            bnDAL = new BenhNhanDAL();
        }
        public bool them(BenhNhanDTO bn)
        {
            bool re = bnDAL.Them(bn);
            return re;
        }
        public bool sua(BenhNhanDTO bn,string maBNold)
        {
            bool re = bnDAL.Sua(bn,maBNold);
            return re;
        }
        public bool xoa(BenhNhanDTO bn)
        {
            bool re = bnDAL.Xoa(bn);
            return re;
        }
        public List<BenhNhanDTO> select()
        {
            return bnDAL.Select();
        }
        public List<BenhNhanDTO> selectByKeyWord(string sKeyword)
        {
            return bnDAL.SelectByKeyWord(sKeyword);
        }
        public int autogenerate_mabn()
        {
            return bnDAL.AutoGenerateMaBN();
        }

    }
}
