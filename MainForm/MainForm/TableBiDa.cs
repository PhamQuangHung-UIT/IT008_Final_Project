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
                return instance;
            }
            private set { instance = value; }
        }
        private TableBiDa() { }
        
        public static List<Table> LoadTableList()
        {   
            List<Table> tablelist  = new();
            string commandText = "SELECT * FROM BAN WHERE TRANGTHAI is not null";
            var data = FMain.GetSqlData(commandText);
            
            foreach(DataRow item in data.Rows)
            {
                int idban =Convert.ToInt32(item["idban"]);
                int money= Convert.ToInt32(item["giatien"]);
                int trangthai = Convert.ToInt32(item["trangthai"]);
                Table table = new(idban,money,trangthai);
                tablelist.Add(table);                                                          
            }
           
            return tablelist;                      
            
        }
        public static void UpdateDataTable(Table table,int i)
        {
            string commandText = $"update Ban set trangthai={i} where idban= {table.Idban}";
            FMain.SendSqlCommand(commandText);
        }    

    }
}
