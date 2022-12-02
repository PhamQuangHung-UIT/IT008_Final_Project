using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class DichVu
    {
        public DichVu(int iddv,string tenDV,double giatien) 
        {
            this.IDdv = iddv;
            this.TenDV = tenDV;
            this.Giatien = giatien;
        }
        private int iddv;
        private string tenDV;
        private double giatien;
        public int IDdv
        {
            get { return iddv; }
            set { iddv = value; }
        }
        public string TenDV
        {
            get { return tenDV; }
            set { tenDV = value; }
        }
        public double Giatien
        {
            get { return giatien; }
            set { giatien = value; }
        }


    }
}
