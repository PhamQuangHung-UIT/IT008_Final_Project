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
        public static List<DichVu> LoadDichVuList()
        {
            List<DichVu> dichvulist = new();
            string commandText = "SELECT * FROM DICHVU";
            DataTable data = FMain.GetSqlData(commandText);
            DataGridView dataGridView = new()
            {
                DataSource = data
            };
            dataGridView.Show();

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
