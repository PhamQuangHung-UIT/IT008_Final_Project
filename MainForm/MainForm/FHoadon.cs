using System.Data;
namespace MainForm
{
    public partial class FHoadon : Form
    {
        private int idhd;
        private int idkh;
        private double thanhtien;

        public int IDHD 
        {
            get { return idhd; }
            set { idhd = value; }
        }
        public int IDKH
        {
            get { return idkh; }
            set { idkh = value; }
        }

        public FHoadon()
        {
            InitializeComponent();
        }
        public FHoadon(int idhd) : this()
        {
            this.idhd = idhd;
        }

        private void FHoadon_Load(object sender, EventArgs e)
        {
            LoadHD();
            LoadKH();
            LoadHDBan();
            LoadHDDV();
            LoadDichVu();
        }
        void LoadDichVu()
        {
            List<DichVu> dichvulist = DichVuBiDa.LoadDichVuList();
            foreach (DichVu item in dichvulist)
            {
                Button btn = new()
                {
                    Width = 120,
                    Height = 40,
                    Text = item.TenDV,
                    BackColor = Color.LightGray
                };
                flpDichVu.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Cursor = Cursors.Hand;
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor == Color.LightGray) btn.BackColor = Color.DarkGray;
                else btn.BackColor = Color.LightGray;
            }

        }
        void LoadHDBan()
        {          
            string commandText = "SELECT BAN.IDBAN [ID Bàn], " +
                "GIATIEN [Giá tiền], " +
                "GIOBATDAU [Giờ bắt đầu], " +
                "GIOKETTHUC [Giờ kết thúc] " +
                "FROM BAN, HOADONBAN, HOADON " +
                $"WHERE HOADONBAN.IDHD =  {Convert.ToInt32(tbIdhd.Text)} and BAN.IDBAN = HOADONBAN.IDBAN";
            dgvHDBan.DataSource = FMain.GetSqlData(commandText);
        }
        void LoadHDDV()
        {
            string commandText = "SELECT DICHVU.TENDV [Tên dịch vụ], GIATIEN [Giá tiền], SOLUONG [Số lượng] " +
                "FROM DICHVU, HOADONDV, HOADON " +
                $"WHERE HOADONDV.IDDV = {Convert.ToInt32(tbIdhd.Text)} and DICHVU.IDDV = HOADONDV.IDDV";
            dgvHDDV.DataSource = FMain.GetSqlData(commandText);
        }
        void LoadHD()
        {
            Bill bill = BillBiDa.GetUnCheckBill(idhd);
            tbIdhd.Text = bill.Idhd.ToString();
            tbIdkh.Text = bill.Idkh.ToString();
        }
        void LoadKH()
        {
            Khachhang? khachhang = KhachhangBiDa.GetKhachhang(idkh);
            tbTenKh.Text = khachhang?.Hoten == null ? "" : khachhang.Hoten.ToString();
            tbSodt.Text = khachhang?.Sodt == null ? "" : khachhang.Sodt.ToString();
            tbDchi.Text = khachhang?.Dchi == null ? "" : khachhang.Dchi.ToString();
        }

        private void BtnEndhd_Click(object sender, EventArgs e)
        {
            TinhThanhTien();
            string commandText = $"INSERT INTO HOADON VALUES ('{tbIdhd.Text}', '{tbIdkh.Text}', '{DateTime.Now}', '{thanhtien}', 1)";
            FMain.SendSqlCommand(commandText);
        }
        private double SumMoneyOfDV = 0;
        private double SumMoneyOfTable = 0;
        void TinhThanhTien()
        {
            string commandText = $"SELECT * FROM HOADONBAN where IDHD = '{tbIdhd.Text}'";
            var table = FMain.GetSqlData(commandText);

            List<Table> tablelist=TableBiDa.LoadTableList();
            foreach(Table item in tablelist)
            {
                foreach(DataRow row in table.Rows)
                {
                    if (item.Idban == Convert.ToInt32(row["idban"]))
                    {
                        SumMoneyOfTable += Convert.ToDouble(row["sogio"])*item.Giatien;
                    }
                }
            }
            commandText = $"SELECT * FROM HOADONDV WHERE HOADONDV.IDHD= '{tbIdhd}'";
            table = FMain.GetSqlData(commandText);
            List<DichVu> dichvulist = DichVuBiDa.LoadDichVuList();
            foreach (DichVu item in dichvulist)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (item.IDdv == Convert.ToInt32(row["iddv"]))
                    {
                        SumMoneyOfTable += Convert.ToInt32(row["soluong"]) * item.Giatien;
                    }
                }
            }

            thanhtien = SumMoneyOfTable + SumMoneyOfDV;
        }
    }
}
