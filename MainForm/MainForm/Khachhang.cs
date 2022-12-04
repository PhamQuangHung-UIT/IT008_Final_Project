using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Khachhang
    {
        public Khachhang(int makh,string hoten,string dchi,int sodt) 
        {
            this.Makh= makh;
            this.Hoten= hoten;
            this.Dchi= dchi;
            this.Sodt= sodt;
        }
        private int makh;
        private string hoten;
        private string dchi;
        private int sodt;

        public int Makh 
        {
            get { return makh; }
            set { makh = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public string Dchi
        {
            get { return dchi; }
            set { dchi = value; }
        }
        public int Sodt
        {
            get { return sodt; }
            set { sodt = value; }
        }
    }
}
