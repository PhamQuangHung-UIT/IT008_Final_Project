using System.ComponentModel;

namespace MainForm
{
    public partial class LoginDlg : Form
    {
        private Form? previousDlg;

        public LoginDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            previousDlg = ActiveForm;
            base.OnLoad(e);
            previousDlg?.Hide();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            previousDlg?.Show();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string commandText = $"SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '{textBox_TenDangNhap.Text}'";
                var tableResult = FMain.GetSqlData(commandText);
                if (tableResult.Rows.Count == 0)
                    throw new Exception("Tên đăng nhập không tồn tại. Vui lòng nhập lại");
                if (tableResult.Rows[0]["MATKHAU"].ToString() != textBox_MatKhau.Text)
                    throw new Exception("Mật khẩu sai. Vui lòng nhập lại");
                if (tableResult.Rows[0]["QUYENADMIN"] == Convert.DBNull)
                throw new Exception("Thông tin đăng ký chưa được phê duyệt. Vui lòng thông báo cho quản trị viên để khắc phục");
                FMain.IDNV_Current = (int)tableResult.Rows[0]["IDNV"];
                FMain.IsAdminState = (bool)tableResult.Rows[0]["QUYENADMIN"];
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
