using QLPMDAL;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMBUS
{
    public class donViBUS
    {
        private donViDAL dvDAL;
        public donViBUS()
        {
            dvDAL = new donViDAL();
        }
        public List<donViDTO> select()
        {
            return dvDAL.getdonvi();
        }
    }
}
