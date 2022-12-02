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
        private static TableBiDa instance;
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
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str1 = "Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";
        
        public List<Table> LoadTableList()
        {   
            List<Table> tablelist  = new List<Table>();
            DataTable data = new DataTable();
            connection = new SqlConnection(str1);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select *from BAN";            
            adapter.SelectCommand = command;           
            adapter.Fill(data);                                               
            connection.Close();            
                                                     
            foreach(DataRow item in data.Rows)
            {
                int idban =Convert.ToInt32(item["idban"]);
                double money= Convert.ToDouble(item["giatien"]);
                int trangthai = Convert.ToInt32(item["trangthai"]);
                Table table = new Table(idban,money,trangthai);
                tablelist.Add(table);                                                          
            }
           
            return tablelist;                      
            
        }
        public void UpdateDataTable(Table table,int i)
        {
            DataTable data = new DataTable();
            connection = new SqlConnection(str1);
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "update Ban set trangthai="+i+" where idban=" + table.Idban +"";
            adapter.SelectCommand = command;
            adapter.Fill(data);
        }    

    }
}
