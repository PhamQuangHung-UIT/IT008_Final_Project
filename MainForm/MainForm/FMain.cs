using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace MainForm
{
    public partial class FMain : Form
    {
        public static int IDKH { get; set; }
        public static int IDHD { get; set; }
        public static int IDNV_Current { get; set; }
        public static bool IsAdminState { get; set; }
        private static readonly string connectionString = $"Data Source = {Environment.MachineName}\\SQLEXPRESS; Initial Catalog = DoAn_lttq; Integrated Security = True";

        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            LoginDlg dlg = new();
            if (dlg.ShowDialog() == DialogResult.Cancel)
                Close();
            Text += $" - Mã nhân viên: {IDNV_Current}";
            if (IsAdminState)
                Text += " - Quản trị viên";
            LoadTable();
            LoadBill_Uncheck();
            LoadBill_Checked();

            tvHD.Nodes.Add(root_XuLi);
            tvHD.Nodes.Add(root_KetThuc);
            root_XuLi.Text = "Hóa đơn đang xử lý";
            root_KetThuc.Text = "Hóa đơn đã kết thúc";
            tvHD.NodeMouseDoubleClick += TvHD_NodeMouseDoubleClick;

            var table = FMain.GetSqlData("SELECT TOP 1 IDKH FROM KHACHHANG ORDER BY (IDKH) DESC");
            int a=table.Rows.Count;
            if (table.Rows.Count == 0)
                IDKH = 1;
            else IDKH = (int)table.Rows[0][0];
            table = FMain.GetSqlData("SELECT TOP 1 IDHD FROM HOADON ORDER BY (IDHD) DESC");
            if (table.Rows.Count == 0)
                IDHD = 1;
            else IDHD = (int)table.Rows[0][0];
        }

        private void TvHD_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {          
            try
            {
               
                
                FHoadon fHoadon = new (Convert.ToInt32(tvHD.SelectedNode.Text));
                if(tvHD.SelectedNode.Parent.Text == "Hóa đơn đang xử lý")
                {
                    FHoadon.Trangthai = 0;
                }
                else if (tvHD.SelectedNode.Parent.Text == "Hóa đơn đã kết thúc")
                {
                    FHoadon.Trangthai = 1;
                }
                fHoadon.ShowDialog();
                
            } catch (Exception) { }
            
        }

        private void BtnCreateHD_Click(object sender, EventArgs e)
        {
            FAddHD dlg = new();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                TreeNode nodex = new()
                {
                    Text = IDKH.ToString()
                };
                
                root_XuLi.Nodes.Add(nodex);
                IDHD++;
            }
            LoadTable();
        }

        private void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableBiDa.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = 240, Height = 180 };
                if (item.Trangthai == 0)
                {
                    btn.Text = "Bàn " + item.Idban + Environment.NewLine + "trống";
                    btn.BackColor = Color.Green;
                }
                else
                {
                    btn.Text = "Bàn " + item.Idban + Environment.NewLine + "có người";
                    btn.BackColor = Color.Red;
                }
                btn.Tag = item.Idban;
                flpTable.Controls.Add(btn);
                btn.Click += Btn_Click;
                btn.Cursor = Cursors.Hand;

            }
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            List<Table> tablelist = TableBiDa.LoadTableList();
            foreach (Table item in tablelist)
            {
                if (Convert.ToInt32((sender as Button)?.Tag) == item.Idban)
                {
                    if (item.Trangthai == 0)
                    {
                        TableBiDa.UpdateDataTable(item, 1);
                        item.Trangthai = 1;                        
                    }
                    else if (item.Trangthai == 1)
                    {
                        TableBiDa.UpdateDataTable(item, 0);
                        item.Trangthai = 0;
                    }
                }


            }
            LoadTable();
        }

        private void LoadBill_Uncheck()
        {
            List<Bill> billist = BillBiDa.GetListUnCheckBillID();
            foreach (Bill item in billist) 
            {
                TreeNode nodebill = new()
                {
                    Text = item.Idkh.ToString()
                };
                root_XuLi.Nodes.Add(nodebill);

            }
        }

        private void LoadBill_Checked()
        {
            List<Bill> billist = BillBiDa.GetListCheckedBill();
            foreach (Bill item in billist)
            {
                TreeNode nodebill = new();
                nodebill.Text = item.Idkh.ToString();
                root_KetThuc.Nodes.Add(nodebill);

            }
        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsAdminState)
            {
                MessageBox.Show("Bạn cần có quyền quản trị viên mới được vào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AdminMenu amf = new();
            amf.FormClosed += (sender, e) => { Show(); };
            amf.Show();
            Hide();
        }

        /// <summary>
        /// Hàm gửi lệnh SQL nhưng không truy xuất Table đến server SQL client
        /// </summary>
        /// <param name="commandString">lệnh cần gửi</param>
        public static void SendSqlCommand(string commandString)
        {
            using (SqlConnection connection = new(connectionString))
            {
                SqlCommand command = new(commandString, connection);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        /// <summary>
        /// Hàm gửi lệnh SQL và trả về Table được phản hồi bời server SQL
        /// </summary>
        /// <param name="queryString">lệnh cần gửi</param>
        /// <returns></returns>
        public static DataTable GetSqlData(string queryString)
        {
            DataTable myDataTable = new();
            using (SqlConnection connection = new(connectionString))
            {
                SqlDataAdapter adapter = new(queryString, connection);
                connection.Open();
                adapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;
        }

        private readonly TreeNode root_XuLi = new();
        private readonly TreeNode root_KetThuc = new();

        // Hàm này chạy hoàn toàn bình thường
        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfoDlg dlg = new();
            dlg.ShowDialog();
        }
    }
}