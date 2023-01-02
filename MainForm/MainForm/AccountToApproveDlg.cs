using System.Data;


namespace MainForm
{
    public partial class AccountToApproveDlg : Form
    {
        public AccountToApproveDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            string commandString = "SELECT * FROM NHANVIEN WHERE QUYENADMIN is null";
            var table = FMain.GetSqlData(commandString);
            if (table.Rows.Count > 0)
                foreach (DataRow row in table.Rows)
                {
                    int id = (int)row["IDNV"];
                    string tenNV = (string)row["HOTENNV"];
                    DateTime ngaySinh = (DateTime)row["NGAYSINH"];
                    string CCCD = (string)row["CCCD"];
                    string matKhau = (string)row["MATKHAU"];
                    string quyenAdmin = "Không";
                    string tenDangNhap = (string)row["TENDANGNHAP"];
                    dataGridView_NhanVien.Rows.Add(id, tenNV, ngaySinh, CCCD, matKhau, quyenAdmin, tenDangNhap);
                }
            else label_ZeroAccount.Visible = true;
        }

        private void DataGridView_NhanVien_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            button_Duyet.Enabled = button_Xoa.Enabled = dataGridView_NhanVien.SelectedRows.Count > 0;
        }

        private void DataGridView_NhanVien_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataGridView_NhanVien.Rows.Count == 0)
                label_ZeroAccount.Visible = true;
        }       
    }
}
