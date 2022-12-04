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
        private static DichVuBiDa? instance;

        public static DichVuBiDa Instance
        {
            get
            {
                instance ??= new();
                return instance;
            }
            private set { instance = value; }
        }

        readonly string connectionString = $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";


        public List<DichVu> LoadDichVuList()
        {
            List<DichVu> dichvulist = new();
            DataTable data = new();
            SqlConnection connection = new(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from DICHVU";
            SqlDataAdapter adapter = new(command);
            adapter.Fill(data);
            DataGridView dataGridView = new()
            {
                DataSource = data
            };
            dataGridView.Show();
            connection.Close();

            foreach (DataRow item in data.Rows)
            {
                try 
                {
                    int iddv = Convert.ToInt32(item["iddv"]);
                    string? tenDV = item["tenDV"].ToString();
                    double money = Convert.ToDouble(item["giatien"]);
                    DichVu dichvu = new(iddv, tenDV, money);
                    dichvulist.Add(dichvu);
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dichvulist;



        }
    }
}
