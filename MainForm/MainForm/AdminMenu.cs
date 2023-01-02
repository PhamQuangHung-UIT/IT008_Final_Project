using System.Data;

namespace MainForm
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            //Thêm UserControl tên là StatisticsControl vào Panel thống kê
            StatisticsControl control = new()
            {
                Dock = DockStyle.Fill
            };
            panel_ThongKe.Controls.Add(control);
            control.Show();
            UpdateNhanVien();
            UpdateDichVu();
            UpdateBan();
        }

        private void Button_AdminNV_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = true;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = false;
            panel_ThongKe.Visible = false;
        }

        private void Button_AdminDV_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = true;
            panel_AdminBan.Visible = false;
            panel_ThongKe.Visible = false;
        }

        private void button_AdminBan_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = true;
            panel_ThongKe.Visible = true;
        }

        private void Button_AdminThongKe_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = false;
            panel_ThongKe.Visible = true;
        }

        private void Button_AdminBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UpdateBan()
        {
            string commandString = "SELECT * FROM BAN";
            var table = FMain.GetSqlData(commandString);
            foreach (DataRow row in table.Rows)
                dataGridView_Ban.Rows.Add(row);
        }

        private void UpdateDichVu()
        {
            string commandString = "SELECT * FROM DICHVU";
            var table = FMain.GetSqlData(commandString);
            foreach (DataRow row in table.Rows)
                dataGridView_DichVu.Rows.Add(row);
        }

        private void UpdateNhanVien()
        {
            string commandString = "SELECT * FROM NHANVIEN WHERE QUYENADMIN is not null";
            var table = FMain.GetSqlData(commandString);
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["IDNV"];
                string tenNV = (string)row["HOTENNV"];
                DateTime ngaySinh = (DateTime)row["NGAYSINH"];
                string CCCD = (string)row["CCCD"];
                string matKhau = (string)row["MATKHAU"];
                string quyenAdmin = (bool)row["QUYENADMIN"] ? "Có" : "Không";
                string tenDangNhap = (string)row["TENDANGNHAP"];
                dataGridView_NhanVien.Rows.Add(id, tenNV, ngaySinh, CCCD, matKhau, quyenAdmin, tenDangNhap);
            }
        }

        private void LinkLabel_AccountToApprove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountToApproveDlg dlg = new();
            dlg.ShowDialog();
        }

        private void DataGridView_NhanVien_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {

        }
    }
}
