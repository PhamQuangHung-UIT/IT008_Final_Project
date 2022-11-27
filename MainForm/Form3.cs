using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;

namespace MainForm
{
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=HOADON;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table=new DataTable();

        void loaddata()
        {
            command =connection.CreateCommand();
            command.CommandText = "select *from KHACHHANG";
            adapter.SelectCommand= command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource= table;
        }    
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection=new SqlConnection(str);
            connection.Open();
            loaddata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            tbTenKH.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbCCCD.Text= dgv.Rows[i].Cells[1].Value.ToString();
            tbSDT.Text= dgv.Rows[i].Cells[2].Value.ToString();
            tbDC.Text= dgv.Rows[i].Cells[3].Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into KHACHHANG values ('" + tbTenKH.Text + "','" + tbCCCD.Text + "','" + tbSDT.Text + "','" + tbDC.Text + "')";

            command.ExecuteNonQuery();
            loaddata();
        }
    }
}
