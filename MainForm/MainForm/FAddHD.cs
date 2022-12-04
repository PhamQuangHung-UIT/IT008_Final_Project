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

namespace MainForm
{
    public partial class FAddHD : Form
    {
        readonly string connectionString = $"Data Source = {Environment.MachineName}\\SQLEXPRESS; Initial Catalog=DoAn_lttq;Integrated Security=True";
        DataTable table = new();


        void LoaddataDV()
        {
            table = new DataTable();
            SqlConnection connection = new(connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"select tenDV, giatien, soluong from DichVu, HDDV where DichVu.iddv = HDDV.iddv and HDDV.idhd = '{FMain.idhd}'";
            SqlDataAdapter adapter = new(command);
            table.Clear();
            adapter.Fill(table);
            dgvHDDV.DataSource = table;
        }
        public FAddHD()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            LoaddataDV();
            loadtable();
            LoadDichVu();
            connection.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into KHACHHANG values ('" + tbMaKH.Text + "','" + tbTenKH.Text + "','" + tbDC.Text + "','" + tbSDT.Text + "')";
            command.ExecuteNonQuery();


            //thêm hóa đơn bàn

            connection = new SqlConnection(connectionString);
            connection.Open();
            command = connection.CreateCommand();
            List<Table> listtable = TableBiDa.Instance.LoadTableList();
            foreach (Table item in listtable)
            {
                foreach (Control ct in flpBan.Controls)
                {
                    if (ct.Text == "Bàn " + item.Idban + Environment.NewLine + "đang chọn")
                    {                        
                        command.CommandText = "insert into HDBan(idhd,idban) values ('" + FMain.idhd + "','" + item.Idban + "')";
                        command.ExecuteNonQuery();                        
                    }

                }
            }
            //
            FMain.MAKH = Convert.ToInt32(tbMaKH.Text);
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon(idhd,MAKH,trangthai) values ('" + FMain.idhd + "','" + tbMaKH.Text + "','"+0+"')";
            command.ExecuteNonQuery();

            DialogResult = DialogResult.OK;




        }
        void loadtable()
        {
            flpBan.Controls.Clear();
            List<Table> tablelist = TableBiDa.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                if (item.Trangthai == 0)
                {
                    btn.Text = "Bàn " + item.Idban + Environment.NewLine + "trống";
                    btn.BackColor = Color.Green;
                    btn.Tag = item.Idban;
                    flpBan.Controls.Add(btn);
                }

                btn.Tag = item.Idban;
                btn.Click += BtnBan_Click;
                btn.Cursor = Cursors.Hand;

            }
        }


        void LoadDichVu()
        {
            List<DichVu> dichvulist = DichVuBiDa.Instance.LoadDichVuList();
            foreach (DichVu item in dichvulist)
            {
                Button btn = new Button() { Width = 100, Height = 40 };
                btn.Text = item.TenDV;
                btn.BackColor = Color.Green;
                flpDV.Controls.Add(btn);
                btn.Click += BtnDV_Click;

                btn.Cursor = Cursors.Hand;
            }
        }
        private void BtnDV_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            if (button?.BackColor == Color.Green)
            {
                button.BackColor = Color.Red;
            }
            else if (button?.BackColor == Color.Red)
            {
                button.BackColor = Color.Green;
            }
        }
        private void BtnBan_Click(object? sender, EventArgs e)
        {
            Button? button = sender as Button;
            List<Table> tablelist = TableBiDa.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                
                if (button?.Text == "Bàn " + item.Idban + Environment.NewLine + "trống")
                {
                    MessageBox.Show(item.Idban.ToString());
                    if (item.Trangthai == 0)
                    {
                        if (button.BackColor == Color.Green) button.BackColor = Color.Red;
                        TableBiDa.Instance.UpdateDataTable(item, 1);
                        button.BackColor = Color.Red;
                        button.Text = "Bàn " + item.Idban + Environment.NewLine + "đang chọn";
                        item.Trangthai = 1;
                        break;
                    }
                }
                else if (button?.Text == "Bàn " + item.Idban + Environment.NewLine + "đang chọn")
                {
                    MessageBox.Show("hmm");
                    TableBiDa.Instance.UpdateDataTable(item, 0);
                    if (button.BackColor == Color.Red) button.BackColor = Color.Green;


                    button.Text = "Bàn " + item.Idban + Environment.NewLine + "trống";
                    item.Trangthai = 0;
                    break;
                }

            }
         
                
                


            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddDV_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new(connectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            List<DichVu> dichvulist = DichVuBiDa.Instance.LoadDichVuList();
            

            foreach (Control ct in flpDV.Controls)
            {
                foreach (DichVu item in dichvulist)
                {
                    if (ct.Text == item.TenDV)
                    {
                        if (ct.BackColor == Color.Red)
                        {
                            command.CommandText = "insert into HDDV values ('" + FMain.idhd + "','" + item.IDdv + "','" + nud.Value + "')";
                            command.ExecuteNonQuery();

                        }
                    }                        
                }
                
            }
            LoaddataDV();
            connection.Close();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
