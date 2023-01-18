using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace MainForm
{
    public partial class AccountInfoDlg : Form
    {
        public AccountInfoDlg()
        {
            InitializeComponent();
        }

        private void AccountInfoDlg_Load(object sender, EventArgs e)
        {
            string commandString = $"SELECT * FROM NHANVIEN WHERE IDNV = '{FMain.IDNV_Current}'";
            DataTable dataTable = FMain.GetSqlData(commandString);
            textBox_idNV.Text = FMain.IDNV_Current.ToString();
            textBox_TenNhanVien.Text = dataTable.Rows[0]["HOTENNV"].ToString();
            dateTimePicker_NgaySinh.Value = (DateTime)dataTable.Rows[0]["NGAYSINH"];
            textBox_CCCDNV.Text = dataTable.Rows[0]["CCCD"].ToString();
            textBox_TenDangNhap.Text = dataTable.Rows[0]["TENDANGNHAP"].ToString();
            textBox_MatKhau.Text = dataTable.Rows[0]["MATKHAU"].ToString();
            checkBox_QuyenAdmin.Checked = (bool)dataTable.Rows[0]["QUYENADMIN"];
        }

        private void CheckBox_HiệnMậtKhẩu_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = !checkBox_HiệnMậtKhẩu.Checked;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (!CheckValid()) return;
            string commandText = $"UPDATE NHANVIEN SET " +
                                $"TENNV = N'{textBox_TenNhanVien.Text}', " +
                                $"NGAYSINH = '{dateTimePicker_NgaySinh.Value:yyyy-MM-dd}', " +
                                $"CCCD = '{textBox_CCCDNV.Text}', " +
                                $"MATKHAU = '{textBox_MatKhau.Text}', " +
                                $"QUYENADMIN = {(checkBox_QuyenAdmin.Checked ? 1 : 0)}" +
                                $"WHERE IDNV = '{FMain.IDNV_Current}'";
            FMain.SendSqlCommand(commandText);
            MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (textBox_MatKhau.Text.Length < 8)
                    throw new("Độ dài mật khẩu phải tối thiểu 8 kí tự.");
                if (textBox_MatKhau.Text.Length > 32)
                    throw new("Độ dài mật khẩu tối đa chỉ 32 kí tự");

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lưu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
