﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMDTO
{
    public class DichvuDTO
    {
        private int maDichVu;
        private string tenDichVu;
        private float tienDichVu;

        public int MaDichVu { get => maDichVu; set => maDichVu = value; }
        public string TenDichVu { get => tenDichVu; set => tenDichVu = value; }
        public float TienDichVu { get => tienDichVu; set => tienDichVu = value; }
    }
}
