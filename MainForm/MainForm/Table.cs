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
        public Table(int idban, double giatien, int trangthai)
        {
            Idban = idban;
            Giatien = giatien;
            Trangthai = trangthai;
            idhdCurrent = -1;
        }


        private int idban;
        private double giatien;
        private int trangthai;
        private int idhdCurrent;

        public int Idban { get => idban; set => idban = value; }

        public double Giatien { get => giatien; set => giatien = value; }

        public int Trangthai { get => trangthai; set => trangthai = value; }

        public int IdhdCurrent { get => idhdCurrent; set => idhdCurrent = value; }
    }
}
