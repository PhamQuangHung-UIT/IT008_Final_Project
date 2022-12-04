using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class KhachhangBiDa
    {
        private static KhachhangBiDa? instance;

        public static KhachhangBiDa Instance
        {
            get
            {
                instance ??= new KhachhangBiDa();
                return instance;
            }
            private set { KhachhangBiDa.instance = value; }
        }
        public KhachhangBiDa() { }

        string connectionString = $"Data Source = {Environment.MachineName}\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";

        public List<Khachhang> GetListKhachhang()
        {
            List<Khachhang> khachhanglist = new List<Khachhang>();

            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select *from khachhang";
            SqlDataAdapter adapter = new(command);
            adapter.Fill(data);
            connection.Close();
            foreach (DataRow row in data.Rows)
            {                
                int makh = Convert.ToInt32(row["makh"]);
                string? hoten = row["hoten"].ToString();
                string? dchi = row["dchi"].ToString();
                int sodt = Convert.ToInt32(row["sodt"]);

                Khachhang khachhang = new(makh, hoten, dchi, sodt);
                khachhanglist.Add(khachhang);
            }

            return khachhanglist;
        }
    }
}
