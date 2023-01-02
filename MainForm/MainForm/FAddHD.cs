namespace MainForm
{
    public partial class FAddHD : Form
    {
        void LoadDataDV()
        {
            string commandText = $"SELECT TENDV [Tên dịch vụ], GIATIEN [Giá tiền], SOLUONG [Số lượng] FROM DICHVU, HOADONDV WHERE DICHVU.IDDV = HOADONDV.IDDV and HOADONDV.IDHD = '{FMain.IDHD}'";
            dgvHDDV.DataSource = FMain.GetSqlData(commandText);
        }
        public FAddHD()
        {
            InitializeComponent();
        }

        private void FAddHD_Load(object sender, EventArgs e)
        {
            LoadDataDV();
            LoadTable();
            LoadDichVu();
        }

        private void ButtonAddHD_Click(object sender, EventArgs e)
        {
            string commandText = $"INSERT INTO KHACHHANG VALUES ('{tbMaKH.Text}', '{tbTenKH.Text}', '{ tbDC.Text}', '{tbSDT.Text}')";
            FMain.SendSqlCommand(commandText);
            //thêm hóa đơn bàn
            List<Table> listTable = TableBiDa.LoadTableList();
            foreach (Table item in listTable)
            {
                foreach (Control ct in flpBan.Controls)
                {
                    if (ct.Text == "Bàn " + item.Idban + Environment.NewLine + "đang chọn")
                    {                        
                        commandText = $"INSERT INTO HOADONBAN(IDHD,IDBAN) VALUES ('{FMain.IDHD}', '{item.Idban}')";
                        FMain.SendSqlCommand(commandText);
                    }
                }
            }
            FMain.IDKH = Convert.ToInt32(tbMaKH.Text);
            commandText = $"INSERT INTO HOADON(IDHD, MAKH, TRANGTHAI) VALUES ('{FMain.IDHD}', '{tbMaKH.Text}', '0')";
            FMain.SendSqlCommand(commandText);
            DialogResult = DialogResult.OK;
        }
        void LoadTable()
        {
            flpBan.Controls.Clear();
            List<Table> tableList = TableBiDa.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new() { Width = 160, Height = 120 };
                if (item.Trangthai == 0)
                {
                    btn.Text = $"Bàn {item.Idban}{Environment.NewLine}trống";
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
            List<Table> tablelist = TableBiDa.LoadTableList();
            foreach (Table item in tablelist)
            {

                if (button?.BackColor == Color.Green)
                {
                    MessageBox.Show(item.Idban.ToString());
                    button.BackColor = Color.Red;
                    TableBiDa.UpdateDataTable(item, 1);
                    button.BackColor = Color.Red;
                    button.Text = "Bàn " + item.Idban + Environment.NewLine + "đang chọn";
                    item.Trangthai = 1;
                    break;
                }
                else if (button != null)
                {
                    TableBiDa.UpdateDataTable(item, 0);
                    button.BackColor = Color.Green;
                    button.Text = "Bàn " + item.Idban + Environment.NewLine + "trống";
                    item.Trangthai = 0;
                    break;
                }
            }  
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddDV_Click(object sender, EventArgs e)
        {
            List<DichVu> dichvulist = DichVuBiDa.LoadDichVuList();
            

            foreach (Control ct in flpDV.Controls)
            {
                foreach (DichVu item in dichvulist)
                {
                    if (ct.Text == item.TenDV)
                    {
                        if (ct.BackColor == Color.Red)
                        {
                            string commandText = $"INSERT INTO HOADONDV VALUES ('{FMain.IDHD}', '{item.IDdv}', '{nud.Value}')";
                            FMain.SendSqlCommand(commandText);
                        }
                    }                        
                }
                
            }
            LoadDataDV();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
