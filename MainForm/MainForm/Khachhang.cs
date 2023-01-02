using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Khachhang
    {
        public Khachhang(int idkh, string? hoten, string? dchi, string? sodt) 
        {
            Idkh = idkh;
            Hoten = hoten;
            Dchi = dchi;
            Sodt = sodt;
        }

        public int Idkh { get; set; }
        public string? Hoten { get; set; }
        public string? Dchi { get; set; }
        public string? Sodt { get; set; }
    }
}
