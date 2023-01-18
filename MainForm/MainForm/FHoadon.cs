using Microsoft.VisualBasic;
using System.Data;
namespace MainForm
{
    public partial class FHoadon : Form
    {
        private int idhd;
        private int idkh;
        
        public static int Trangthai { get; set; }

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
        /*
        public FHoadon()
        {
            MessageBox.Show("ok");
            //InitializeComponent();
        }
        */
        public FHoadon(int id_kh)
        {
            InitializeComponent();
            IDKH= id_kh;
            
        }
        

        private void FHoadon_Load(object sender, EventArgs e)
        {
            if (Trangthai == 0)
            {
                LoadUnCheckHD();

            }
            else if(Trangthai == 1)
            {
                LoadCheckedHD();
            }
            
            LoadKH();
            LoadHDBan();
            LoadHDDV();
            LoadDichVu();
        }
        void LoadDichVu()
        {
            List<DichVu> dichVuList = DichVuBiDa.LoadDichVuList();
            foreach (DichVu item in dichVuList)
            {
                Button btn = new()
                {
                    Width = 100,
                    Height = 40,
                    Text = item.TenDV,
                    BackColor = Color.Green
                };
                flpDichVu.Controls.Add(btn);
                btn.Click += Btn_Click;

                btn.Cursor = Cursors.Hand;
            }
        }
        private void Btn_Click(object? sender, EventArgs e)
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
        void LoadHDBan()
        {          
            string commandText = "SELECT BAN.IDBAN [ID Bàn], " +
                "GIATIEN [Giá tiền], " +
                "GIOBATDAU [Giờ bắt đầu], " +
                "GIOKETTHUC [Giờ kết thúc] " +
                "FROM BAN, HOADONBAN, HOADON " +
                $"WHERE HOADONBAN.IDHD = '"+Convert.ToInt32(tbIdhd.Text)+"' and BAN.IDBAN = HOADONBAN.IDBAN";
            dgvHDBan.DataSource = FMain.GetSqlData(commandText);
        }
        void LoadHDDV()
        {
            string commandText = "SELECT DICHVU.TENDV [Tên dịch vụ], GIATIEN [Giá tiền], SOLUONG [Số lượng] " +
                "FROM DICHVU, HOADONDV, HOADON " +
                $"WHERE HOADONDV.IDHD = {Convert.ToInt32(tbIdhd.Text)} and DICHVU.IDDV = HOADONDV.IDDV";
            dgvHDDV.DataSource = FMain.GetSqlData(commandText);
        }
        void LoadUnCheckHD()
        {
            /*
            Bill bill = BillBiDa.GetUnCheckBill(idhd);
            tbIdhd.Text = bill.Idhd.ToString();
            tbIdkh.Text = bill.Idkh.ToString();
            */
            List<Bill> listbill = BillBiDa.GetListUnCheckBillID();
            foreach (Bill item in listbill)
            {
                if (item.Idkh == idkh)
                {
                   
                    tbIdhd.Text = (item.Idhd).ToString();
                    tbIdkh.Text = (item.Idkh).ToString();
                }
            }
        }
        void LoadCheckedHD()
        {
            List<Bill> listbill = BillBiDa.GetListCheckedBill();
            foreach (Bill item in listbill)
            {
                if (item.Idkh == idkh)
                {

                    tbIdhd.Text = (item.Idhd).ToString();
                    tbIdkh.Text = (item.Idkh).ToString();
                }
            }

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
            string commandText = $"UPDATE HOADON SET GIOLAPHD='{DateTime.Now}',TRANGTHAI='{1}'WHERE IDHD='{tbIdhd.Text}'";
            FMain.SendSqlCommand(commandText);
            commandText = $"UPDATE HOADONBAN SET GIOKETTHUC='{DateTime.Now}' WHERE IDHD='{tbIdhd.Text}'";
            FMain.SendSqlCommand(commandText);
            LoadHDBan();

            commandText = $"select * from HoaDon where IDHD='{tbIdhd.Text}'";
            DataTable data = FMain.GetSqlData(commandText);
            foreach (DataRow row in data.Rows)
            {
                tbThanhtien.Text= row["Thanhtien"].ToString();
            }
        }

        private void btnAddDV_FHoadon_Click(object sender, EventArgs e)
        {
            List<DichVu> dichvulist = DichVuBiDa.LoadDichVuList();

            foreach (Control ct in flpDichVu.Controls)
            {
                foreach (DichVu item in dichvulist)
                {
                    if (ct.Text == item.TenDV)
                    {
                        if (ct.BackColor == Color.Red)
                        {
                            string commandText = $"INSERT INTO HOADONDV VALUES ('{FMain.IDHD}', '{item.IDdv}', '{nud_Fhoadon.Value}')";
                            FMain.SendSqlCommand(commandText);
                            break;
                        }
                    }
                }

            }
            LoadHDDV();
        }

        private void btnChangeBan_Click(object sender, EventArgs e)
        {
            FChangeTable a = new(Convert.ToInt32(tbIdhd.Text));
            a.ShowDialog();
        }
    }
}
