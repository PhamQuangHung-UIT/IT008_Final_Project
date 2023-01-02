using System.Runtime.CompilerServices;

namespace MainForm
{
    public partial class LoginDlg : Form
    {
        public static LoginDlg Instance { get; set; }
        public LoginDlg()
        {
            InitializeComponent();
            Instance = this;
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string commandText = $"SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '{textBox_TenDangNhap.Text}'";
            var tableResult = FMain.GetSqlData(commandText);
            if (tableResult.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập không tồn tại. Vui lòng nhập lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tableResult.Rows[0]["MATKHAU"].ToString() != textBox_MatKhau.Text)
            {
                MessageBox.Show("Mật khẩu sai. Vui lòng nhập lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tableResult.Rows[0]["QUYENADMIN"] == Convert.DBNull)
            {
                MessageBox.Show("Thông tin đăng ký chưa được phê duyệt. Vui lòng thông báo cho quản trị viên để khắc phục", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            FMain.IDNV_Current = (int)tableResult.Rows[0]["IDNV"];
            FMain.IsAdminState = (bool)tableResult.Rows[0]["QUYENADMIN"];
            DialogResult = DialogResult.OK;
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            SignUpDlg dlg = new();
            dlg.ShowDialog();
        }

        private void CheckBox_HiệnMậtKhẩu_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = !checkBox_HiệnMậtKhẩu.Checked;
        }
    }
}
