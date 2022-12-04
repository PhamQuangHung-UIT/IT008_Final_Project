using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace MainForm
{
    public class TableBiDa
    {
        private static TableBiDa? instance;
        public static TableBiDa Instance
        {
            get
            {
                if (instance == null) instance = new TableBiDa();
                return TableBiDa.instance;
            }
            private set { TableBiDa.instance = value; }
        }
        private TableBiDa() { }
        string connectionString = $"Data Source={Environment.MachineName}\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";
        
        public List<Table> LoadTableList()
        {   
            List<Table> tablelist  = new List<Table>();
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select * from BAN";            
            SqlDataAdapter adapter = new(command);           
            adapter.Fill(data);                                               
            connection.Close();            
                                                     
            foreach(DataRow item in data.Rows)
            {
                int idban =Convert.ToInt32(item["idban"]);
                int money= Convert.ToInt32(item["giatien"]);
                int trangthai = Convert.ToInt32(item["trangthai"]);
                Table table = new Table(idban,money,trangthai);
                tablelist.Add(table);                                                          
            }
           
            return tablelist;                      
            
        }
        public void UpdateDataTable(Table table,int i)
        {
            DataTable data = new DataTable();
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"update Ban set trangthai={i} where idban= {table.Idban}";
            SqlDataAdapter adapter = new(command);
            adapter.Fill(data);
        }    

    }
}
