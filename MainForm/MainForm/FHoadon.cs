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
        DataTable table = new DataTable();
        private int idhd;
        private int makh;

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
            
            LoadHDBan();
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
            int MAKH=FMain.MAKH;
            command = connection.CreateCommand();
            command.CommandText = "select Ban.idBan,giatien,sogio from Ban,HDBan,HoaDon where HoaDon.MAKH="+MAKH+" and Ban.idBan=HDBan.idBan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvHDBan.DataSource = table;
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
            
    }
}
