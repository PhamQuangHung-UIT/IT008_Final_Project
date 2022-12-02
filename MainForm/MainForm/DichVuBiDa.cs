using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MainForm
{
    public class DichVuBiDa
    {
        private static DichVuBiDa instance;

        public static DichVuBiDa Instance
        {
            get
            {
                if (instance == null) instance = new DichVuBiDa();
                return DichVuBiDa.instance;
            }
            private set { DichVuBiDa.instance = value; }
        }
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        string str1 = "Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";


        public List<DichVu> LoadDichVuList()
        {
            List<DichVu> dichvulist = new List<DichVu>();
            DataTable data = new DataTable();
            connection = new SqlConnection(str1);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select *from DICHVU";
            adapter.SelectCommand = command;
            adapter.Fill(data);
            DataGridView dataGridView = new DataGridView();
            dataGridView.DataSource = data;
            dataGridView.Show();
            connection.Close();

            foreach (DataRow item in data.Rows)
            {
                int iddv = Convert.ToInt32(item["iddv"]);
                string tenDV = item["tenDV"].ToString();
                double money = Convert.ToDouble(item["giatien"]);
               
                DichVu dichvu = new DichVu(iddv,tenDV,money);
                dichvulist.Add(dichvu);
            }

            return dichvulist;



        }
    }
}
