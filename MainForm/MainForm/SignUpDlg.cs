using System.ComponentModel;

namespace MainForm
{
    public partial class SignUpDlg : Form
    {
        public List<Control> controlsToFocus = new();
        private Form? lastDlg;
        public SignUpDlg()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            lastDlg = ActiveForm;
            base.OnLoad(e);
            lastDlg?.Hide();
            controlsToFocus.Add(textBox_TenNhanVien);
            controlsToFocus.Add(dateTimePicker_NgaySinh);
            controlsToFocus.Add(textBox_CCCDNV);
            controlsToFocus.Add(textBox_TenDangNhap);
            controlsToFocus.Add(textBox_MatKhau);
            controlsToFocus.Add(textBox_NhapLaiMatKhau);
            dateTimePicker_NgaySinh.MaxDate = DateTime.Now;
            dateTimePicker_NgaySinh.Value = dateTimePicker_NgaySinh.MaxDate;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            lastDlg?.Show();
        }

        private void ControlToFocus_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra xem người dùng có dùng nút Enter để chuyển sang nhập TextBox kế tiếp
            // hoặc lưu thông tin nếu ở TextBox cuối cùng
            if (e.KeyCode == Keys.Enter && sender is Control control) 
            {
                int controlsIndex = controlsToFocus.IndexOf(control);
                controlsIndex++;
                if (controlsIndex == controlsToFocus.Count)
                    Button_DangKy_Click(sender, e);
                else controlsToFocus[controlsIndex].Focus();
            }
        }

        private void CheckBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = !checkBox_ShowPassword.Checked;
        }

        private void Button_DangKy_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
                return;
            var table = FMain.GetSqlData("SELECT TOP 1 IDNV FROM NHANVIEN ORDER BY IDNV DESC");
            int idNV = 1;
            // Lấy id chính bằng id của nhân viên cuối cùng cộng 1. Nếu không tìm
            // thấy (bảng NHANVIEN trống), lấy id = 1
            if (table.Rows.Count > 0)
                idNV = Convert.ToInt32(table.Rows[0][0]) + 1;
            string tenNV = textBox_TenNhanVien.Text;
            DateTime ngaySinh = dateTimePicker_NgaySinh.Value;
            string CCCD = textBox_CCCDNV.Text;
            string tenDangNhap = textBox_TenDangNhap.Text;
            string matKhau = textBox_MatKhau.Text;
            // Kiểm tra xem liệu quản trị viên có đang thêm nhân viên hay đăng ký ở ngoài
            if (FMain.IsAdminState)
            {
                FMain.SendSqlCommand($"INSERT INTO NHANVIEN VALUES " +
                        $"({idNV},N'{tenNV}','{ngaySinh:yyyy-MM-dd}'," +
                        $"'{CCCD}','{matKhau.Trim()}'," +
                        $" 0,'{tenDangNhap}')");
                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                FMain.SendSqlCommand($"INSERT INTO NHANVIEN VALUES " +
                        $"({idNV},N'{tenNV}','{ngaySinh:yyyy-MM-dd}'," +
                        $"'{CCCD}','{matKhau.Trim()}'," +
                        // Mặc định tài khoản đầu tiên được tạo sẽ được cấp quyền quản trị viên
                        $"{(idNV == 1 ? 1 : "null")},'{tenDangNhap}')");
                MessageBox.Show("Đăng ký thành công. Vui lòng chờ thông tin đăng ký được duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        /// <summary>
        /// Hàm kiểm tra xem thông tin nhập có hợp lệ không
        /// </summary>
        /// <returns>True nếu thông tin nhập trong các TextBox hợp lệ, false nếu không thỏa</returns>
        private bool CheckValid()
        {
            try
            {
                if (textBox_TenNhanVien.Text == "")
                    throw new("Mục \"Họ tên\" không được để trống.");
                if (textBox_TenNhanVien.Text.Length > 50)
                    throw new("Độ dài họ tên tối đa chỉ 50 kí tự.");
                if (textBox_CCCDNV.Text == "")
                    throw new("Mục \"Số CCCD/CMND\" không được để trống.");
                if (textBox_CCCDNV.Text.Length > 15)
                    throw new("Độ dài số CCCD/CMND tối đa chỉ 15 kí tự.");
                if (string.IsNullOrWhiteSpace(textBox_TenDangNhap.Text))
                    throw new("Mục \"Tên đăng nhập\" không được để trống.");
                if (textBox_TenDangNhap.Text.Length > 32)
                    throw new("Độ dài tên đăng nhập tối đa chỉ 32 kí tự");
                if (textBox_MatKhau.Text.Length < 8)
                    throw new("Độ dài mật khẩu phải tối thiểu 8 kí tự.");
                if (textBox_MatKhau.Text.Length > 32)
                    throw new("Độ dài mật khẩu tối đa chỉ 32 kí tự.");
                if (textBox_MatKhau.Text != textBox_NhapLaiMatKhau.Text)
                    throw new("Mật khẩu bạn vừa nhập lại không trùng khớp với mật khẩu bạn đặt.");
                var commandText = $"SELECT * FROM NHANVIEN WHERE CCCD = '{textBox_CCCDNV.Text}'";
                if (FMain.GetSqlData(commandText).Rows.Count > 0)
                    throw new("Mã số CCCD/CMND mà bạn vừa nhập tồn tại ở một tài khoản khác. " +
                        "Vui lòng thông báo cho quản trị viên để khắc phục sự cố.");
                commandText = $"SELECT * FROM NHANVIEN WHERE TENDANGNHAP = '{textBox_TenDangNhap.Text}'";
                if (FMain.GetSqlData(commandText).Rows.Count > 0)
                    throw new("Tên đăng nhập bị trùng. Vui lòng chọn tên đăng nhập khác");
                return true;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
