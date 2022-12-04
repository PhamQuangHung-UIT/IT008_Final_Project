using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Table
    {
        public Table(int idban,double giatien,int trangthai) 
        {
            this.Idban = idban;
            this.Giatien = giatien;
            this.Trangthai = trangthai;
        }
        
          
        private int idban;
        private double giatien;
        private int trangthai;
        public int Idban 
        {
            get { return idban; }
            set { idban = value; }
        }

        public double Giatien 
        {
            get { return giatien; }
            set { giatien = value; }
        }

        public int Trangthai 
        { 
            get { return trangthai; }
            set { trangthai = value; }
        }
     
    }
}
