using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Bill
    {
        public Bill(int idhd,int idkh) 
        {
            Idhd = idhd;
            Idkh = idkh;
            Trangthai = 0;            
        }

        public int Idhd { get; set; }
        public int Idkh { get; set; }
        public DateTime Giolaphoadon { get; set; }
        public double Thanhtien { get; set; }
        public int Trangthai { get; set; }
    }
}
