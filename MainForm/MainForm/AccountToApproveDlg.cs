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

        private void Button_DuyetTatCa_Click(object sender, EventArgs e)
        {
            string commandText = $"UPDATE NHANVIEN SET QUYENADMIN = 0 WHERE QUYENADMIN is null";
            FMain.SendSqlCommand(commandText);
            button_Duyet.Enabled = button_DuyetTatCa.Enabled = button_Xoa.Enabled = button_XoaTatCa.Enabled = false;
            dataGridView_NhanVien.Rows.Clear();
        }

        private void Button_XoaTatCa_Click(object sender, EventArgs e)
        {
            string commandText = $"DELETE FROM NHANVIEN WHERE QUYENADMIN is null";
            FMain.SendSqlCommand(commandText);
            button_Duyet.Enabled = button_DuyetTatCa.Enabled = button_Xoa.Enabled = button_XoaTatCa.Enabled = false;
            dataGridView_NhanVien.Rows.Clear();
        }

        private void Button_Duyet_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView_NhanVien.SelectedRows[0].Cells[0].Value;
            string commandText = $"UPDATE NHANVIEN SET QUYENADMIN = 0 WHERE IDNV = {id}";
            FMain.SendSqlCommand(commandText);
            dataGridView_NhanVien.Rows.RemoveAt(dataGridView_NhanVien.SelectedRows[0].Index);
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView_NhanVien.SelectedRows[0].Cells[0].Value;
            string commandText = $"DELETE FROM NHANVIEN WHERE IDNV = {id}";
            FMain.SendSqlCommand(commandText);
            dataGridView_NhanVien.Rows.RemoveAt(dataGridView_NhanVien.SelectedRows[0].Index);
        }
    }
}
