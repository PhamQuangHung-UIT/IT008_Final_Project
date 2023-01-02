using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class DichVu
    {
        public DichVu(int iddv, string? tenDV, double giatien) 
        {
            IDdv = iddv;
            TenDV = tenDV;
            Giatien = giatien;
        }

        public int IDdv { get; set; }
        public string? TenDV { get; set; }
        public double Giatien { get; set; }


    }
}
