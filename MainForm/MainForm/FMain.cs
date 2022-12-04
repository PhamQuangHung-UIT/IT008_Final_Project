using System.Reflection;

namespace MainForm
{
    public partial class FMain : Form
    {
        public static int MAKH = 0;
        public static int idhd = 1;
        public FMain()
        {
            InitializeComponent();
            loadtable();
            loadbill_Uncheck();
            loadbill_checked();


            tvHD.Nodes.Add(root1);
            tvHD.Nodes.Add(root2);
            root1.Text = "Hóa đơn đang xử lý";
            root2.Text = "Hóa đơn đã kết thúc";
            tvHD.NodeMouseDoubleClick += TvHD_NodeMouseDoubleClick;
        }
        private void TvHD_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FHoadon x = new FHoadon();
            x.Makh = Convert.ToInt32(e.Node.Text);
            
            x.ShowDialog();
            
        }
        public TreeNode root1 = new TreeNode();
        public TreeNode root2 = new TreeNode();
        TreeNode nodex;

        private void btnCreateHD_Click(object sender, EventArgs e)
        {
            FAddHD a = new FAddHD();
            if (a.ShowDialog() == DialogResult.OK)
            {
                nodex = new TreeNode();
                nodex.Text = MAKH.ToString();
                root1.Nodes.Add(nodex);
                idhd++;
            }
            loadtable();
        }

        void loadtable()
        {
            flpTable.Controls.Clear();
            List<Table> tablelist = TableBiDa.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                Button btn = new Button() { Width = 100, Height = 100 };
                if (item.Trangthai == 0)
                {
                    btn.Text = "Bàn " + item.Idban + Environment.NewLine + "trống";
                    btn.BackColor = Color.Green;

                }
                else if (item.Trangthai == 1)
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

        private void Btn_Click(object sender, EventArgs e)
        {
            List<Table> tablelist = TableBiDa.Instance.LoadTableList();
            foreach (Table item in tablelist)
            {
                if (Convert.ToInt32((sender as Button).Tag) == item.Idban)
                {
                    if (item.Trangthai == 0)
                    {
                        TableBiDa.Instance.UpdateDataTable(item, 1);
                        item.Trangthai = 1;                        
                    }
                    else if (item.Trangthai == 1)
                    {
                        TableBiDa.Instance.UpdateDataTable(item, 0);
                        item.Trangthai = 0;
                    }
                }


            }
            loadtable();
        }
        void loadbill_Uncheck()
        {
            List<Bill> billist = BillBiDa.Instance.GetListUnCheckBillID();
            foreach (Bill item in billist) 
            {
                TreeNode nodebill = new TreeNode();
                nodebill.Text = item.Makh.ToString();
                root1.Nodes.Add(nodebill);

            }
        }
        void loadbill_checked()
        {
            List<Bill> billist = BillBiDa.Instance.GetListCheckedBill();
            foreach (Bill item in billist)
            {
                TreeNode nodebill = new TreeNode();
                nodebill.Text = item.Makh.ToString();
                root2.Nodes.Add(nodebill);

            }
        }

        private  void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
            {

            }

            private  void FMain_Load(object sender, EventArgs e)
            {
                
            }
        
            
    }
        

    
}