using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Bill
    {
        public Bill(int idhd,int makh) 
        {
            this.Idhd = idhd;
            this.Makh = makh;
            this.Trangthai= 0;            
        }
        private int idhd;
        private int makh;
        private DateTime giolaphoadon;
        private double thanhtien;
        private int trangthai;
        public int Idhd
        {
            get { return idhd; }
            set { idhd = value; }
        }
        public int Makh
        {
            get { return makh; }
            set { makh=value; }
        }
        public DateTime Giolaphoadon
        {
            get { return giolaphoadon; }
            set { giolaphoadon = value; }
        }
        public double Thanhtien
        {
            get { return thanhtien; }
            set { thanhtien = value; }
        }
        public int Trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
    }
}
