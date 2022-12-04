using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MainForm
{
    public partial class FHoadon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = "Data Source=DESKTOP-Q8NOVRR\\SQLEXPRESS;Initial Catalog=DoAn_lttq;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table ;
        private int idhd;
        private int makh;
        private double thanhtien;

        public int Idhd 
        {
            get { return idhd; }
            set { idhd = value; }
        }
        public int Makh
        {
            get { return makh; }
            set { makh = value; }
        }

        public FHoadon()
        {
            InitializeComponent();
        }
        public FHoadon(int MaKH)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FHoadon_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            LoadHD();
            LoadKH();
            LoadHDBan();
            LoadHDDV();
            LoadDichVu();
            connection.Close();
        }
        void LoadDichVu()
        {
            List<DichVu> dichvulist = DichVuBiDa.Instance.LoadDichVuList();
            foreach (DichVu item in dichvulist)
            {
                Button btn = new Button() { Width = 100, Height = 40 };
                btn.Text = item.TenDV;
                btn.BackColor = Color.Green;
                flpDichVu.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Cursor = Cursors.Hand;
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).BackColor == Color.Green) (sender as Button).BackColor = Color.Red;
            else if ((sender as Button).BackColor == Color.Red) (sender as Button).BackColor = Color.Green;
        }
        void LoadHDBan()
        {          
            table =new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select Ban.idban,giatien,sogio from Ban,HDBan,HoaDon where HDBan.idhd=" + Convert.ToInt32(tbIdhd.Text)+" and Ban.idban=HDBan.idban";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHDBan.DataSource = table;
        }
        void LoadHDDV()
        {
            table = new DataTable();
            command = connection.CreateCommand();
            command.CommandText = "select DichVu.tenDV,giatien,soluong from DichVu,HDDV,HoaDon where HDDV.idhd=" + Convert.ToInt32(tbIdhd.Text) + " and DichVu.iddv=HDDV.iddv";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHDDV.DataSource = table;
        }
        void LoadHD()
        {
            List<Bill> listbill = BillBiDa.Instance.GetListUnCheckBillID();
            foreach(Bill item in listbill)
            {
                if (item.Makh == makh)
                {
                    tbIdhd.Text = (item.Idhd).ToString();
                    tbMakh.Text = (item.Makh).ToString();
                }
            }
        }
        void LoadKH()
        {
            List<Khachhang> khachhanglist = KhachhangBiDa.Instance.GetListKhachhang();
            foreach(Khachhang item in khachhanglist)
            {
                if(item.Makh == makh)
                {
                    tbTenKh.Text=item.Hoten.ToString();
                    tbSodt.Text=item.Sodt.ToString();
                    tbDchi.Text=item.Dchi.ToString();
                }
            }
        }

        private void btnEndhd_Click(object sender, EventArgs e)
        {
            TinhThanhTien();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into HoaDon values ('" + tbIdhd.Text + "','" + tbMakh.Text + "','" + DateTime.Now + "','"+thanhtien+"','"+1.ToString()+"')";
            command.ExecuteNonQuery();
            
            connection.Close();
        }
        private double SumMNofDV=0;
        private double SumMNofBan=0;
        void TinhThanhTien()
        {
            table =new DataTable();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HDBan where HDBan.idhd='"+tbIdhd+"'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            List<Table> tablelist=TableBiDa.Instance.LoadTableList();
            foreach(Table item in tablelist)
            {
                foreach(DataRow row in table.Rows)
                {
                    if (item.Idban == Convert.ToInt32(row["idban"]))
                    {
                        SumMNofBan += Convert.ToDouble(row["sogio"])*item.Giatien;
                    }
                }
            }
            table = new DataTable();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select * from HDDV where HDDV.idhd='" + tbIdhd + "'";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            List<DichVu> dichvulist =DichVuBiDa.Instance.LoadDichVuList();
            foreach (DichVu item in dichvulist)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (item.IDdv == Convert.ToInt32(row["iddv"]))
                    {
                        SumMNofBan += Convert.ToInt32(row["soluong"]) * item.Giatien;
                    }
                }
            }

            thanhtien = SumMNofBan + SumMNofDV;
            connection.Close();
        }
    }
}
