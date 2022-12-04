using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class BillBiDa
    {
        private static BillBiDa instance;

        public static BillBiDa Instance
        {
            get 
            { 
                if (instance == null) instance = new BillBiDa() ;
                return BillBiDa.instance; 
            }
            private set { BillBiDa.instance = value;}
        }
        private BillBiDa() { }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str1 = "Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";
        /*
        public Bill GetUnCheckBillIDbyMaKH(int makh)
        {
            Bill bill = new Bill();

            return bill;
        }
        */

        
        public List<Bill> GetListUnCheckBillID()
        {
            List<Bill> billlist=new List<Bill>();
            DataTable data = new DataTable();
            connection = new SqlConnection(str1);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select *from HoaDon where trangthai=0";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            connection.Close();
            foreach(DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int makh= Convert.ToInt32(row["makh"]);
                
                Bill bill = new Bill(idhd,makh);
                billlist.Add(bill);
            }
            return billlist;
        }
        public List<Bill> GetListCheckedBill()
        {
            List<Bill> billlist = new List<Bill>();
            DataTable data = new DataTable();
            connection = new SqlConnection(str1);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select *from HoaDon where trangthai=1";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            connection.Close();
            foreach (DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int makh = Convert.ToInt32(row["makh"]);

                Bill bill = new Bill(idhd, makh);
                billlist.Add(bill);
            }
            return billlist;
        }

    }
}
