using QLPMDAL;
using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMBUS
{
    public class cachDungBUS
    {
        private cachDungDAL cdDAL;
        public cachDungBUS()
        {
            cdDAL = new cachDungDAL();
        }
        public List<cachdungDTO> select()
        {
            return cdDAL.getcachdung();
        }
    }
}
