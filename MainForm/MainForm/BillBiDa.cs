using System.Data;
using System.Data.SqlClient;

namespace MainForm
{
    public class BillBiDa
    {
        private BillBiDa() { }
        
        public static Bill GetUnCheckBill(int idHD)
        {
            string commandText = $"SELECT * FROM HOADON WHERE IDHD = {idHD}";
            DataTable data = FMain.GetSqlData(commandText);
            Bill bill = new((int)data.Rows[0][0], (int)data.Rows[0][1]);
            return bill;
        }
        

        
        public static List<Bill> GetListUnCheckBillID()
        {
            List<Bill> billlist=new();
            string commandText = "SELECT * FROM HOADON WHERE TRANGTHAI = 0";
            DataTable data = FMain.GetSqlData(commandText);
            foreach(DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int idkh= Convert.ToInt32(row["idkh"]);
                
                Bill bill = new(idhd, idkh);
                billlist.Add(bill);
            }
            return billlist;
        }
        public static List<Bill> GetListCheckedBill()
        {
            List<Bill> billlist = new();
            string commandText = "SELECT * FROM HOADON WHERE TRANGTHAI = 1";
            DataTable data = FMain.GetSqlData(commandText);
            foreach (DataRow row in data.Rows)
            {
                int idhd = Convert.ToInt32(row["idhd"]);
                int makh = Convert.ToInt32(row["idkh"]);
                Bill bill = new(idhd, makh);
                billlist.Add(bill);
            }
            return billlist;
        }

    }
}
