namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tvHD.Nodes.Add(root1);           
            tvHD.Nodes.Add(root2);
            root1.Text = "Hóa đơn đang xử lý";
            root2.Text = "Hóa đơn đã kết thúc";
            tvHD.NodeMouseDoubleClick += TvHD_NodeMouseDoubleClick;
        }

        private void TvHD_NodeMouseDoubleClick(object? sender, TreeNodeMouseClickEventArgs e)
        {
            FHoadon x = new FHoadon();
            x.Show();
        }

       

        TreeNode root1=new TreeNode();  
        TreeNode root2 = new TreeNode();


        
       

        private void btnCreateHD_Click(object sender, EventArgs e)
        {
            TreeNode nodex= new TreeNode();
            nodex.Text = "Hóa đơn 1";
            root1.Nodes.Add(nodex);           
            Form3 a=new Form3();
            a.Show();
            
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}