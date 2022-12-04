using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Khachhang
    {
        public Khachhang(int makh, string? hoten, string? dchi, int sodt) 
        {
            Makh = makh;
            Hoten = hoten;
            Dchi = dchi;
            Sodt = sodt;
        }

        public int Makh { get; set; }
        public string? Hoten { get; set; }
        public string? Dchi { get; set; }
        public int Sodt { get; set; }
    }
}
