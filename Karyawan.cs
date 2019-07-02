using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanAsosiasi
{
    public class Karyawan
    {
        public string Nama { get; set; }
        public bool Status { get; set; }

        public bool Login(Kartu kartu)
        {
            //hubungan Associaton
            return kartu.IsValid(this);
        }
    }
    public class Kartu
    {
        public bool IsValid(Karyawan karyawan)
        {
            return karyawan.Status == true;
        }
    }
}
