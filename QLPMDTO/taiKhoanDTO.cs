﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QLPMDTO
{
    public class taiKhoanDTO
    {
        private string name;
        private string username;
        private string password;
        private int maLoai;
        private int maTK;

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public int MaLoai { get => maLoai; set => maLoai = value; }
        public int MaTK { get => maTK; set => maTK = value; }
    }
}
