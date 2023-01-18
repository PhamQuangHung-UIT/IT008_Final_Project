using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MainForm
{
    public partial class FChangeTable : Form
    {
        public static int idhd;
        
        public FChangeTable(int x)
        {
            InitializeComponent();
            idhd = x;
            LoadComboBox();  
        }

        private void LoadComboBox()
        {
            DataTable data1 = FMain.GetSqlData($"SELECT IDBAN FROM HOADONBAN WHERE IDHD={idhd}");
            cbOldTable.DataSource = data1;
            cbOldTable.DisplayMember = "IDBAN";

            DataTable data2 = FMain.GetSqlData($"SELECT IDBAN FROM BAN WHERE TRANGTHAI=0");
            cbNewTable.DataSource = data2;
            cbNewTable.DisplayMember = "IDBAN";

        }

        private void BtnChangeTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbOldTable.GetItemText(cbOldTable.SelectedValue));
            
            
            string commandText = $"UPDATE HOADONBAN SET GIOKETTHUC ='{DateTime.Now}' WHERE IDHD='{idhd}' AND IDBAN={cbOldTable.GetItemText(cbOldTable.SelectedValue)}";
            FMain.SendSqlCommand(commandText);
           
            commandText = $"INSERT INTO HOADONBAN(IDHD,IDBAN,GIOBATDAU,GIOKETTHUC) VALUES('{idhd}','{cbNewTable.GetItemText(cbNewTable.SelectedValue)}','{DateTime.Now}','{DateTime.Now}')";
            MessageBox.Show(commandText);
            FMain.SendSqlCommand(commandText);
            Close();
        }
    }
}
