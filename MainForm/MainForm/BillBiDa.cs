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
        private static BillBiDa? instance;

        public static BillBiDa Instance
        {
            get 
            { 
                instance ??= new BillBiDa() ;
                return instance; 
            }
            private set { instance = value;}
        }
        private BillBiDa() { }
        internal SqlConnection? connection;
        internal SqlCommand? command;
        internal SqlDataAdapter adapter = new();
        readonly string connectionString = $"Data Source = {Environment.MachineName}\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";
        /*
        public Bill GetUnCheckBillIDbyMaKH(int makh)
        {
            Bill bill = new Bill();

            return bill;
        }
        */

        
        public List<Bill> GetListUnCheckBillID()
        {
            List<Bill> billlist=new();
            DataTable data = new();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where trangthai = 0";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            connection.Close();
            foreach(DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int makh= Convert.ToInt32(row["makh"]);
                
                Bill bill = new(idhd, makh);
                billlist.Add(bill);
            }
            return billlist;
        }
        public List<Bill> GetListCheckedBill()
        {
            List<Bill> billlist = new();
            DataTable data = new();
            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HoaDon where trangthai = 1";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            connection.Close();
            foreach (DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int makh = Convert.ToInt32(row["makh"]);
                Bill bill = new(idhd, makh);
                billlist.Add(bill);
            }
            return billlist;
        }

    }
}
