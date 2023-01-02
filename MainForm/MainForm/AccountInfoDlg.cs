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
            textBox_TenNhanVien.Text = dataTable.Rows[0][1].ToString();
            dateTimePicker_NgàySinh.Value = (DateTime)dataTable.Rows[0][2];
            textBox_CCCDNV.Text = dataTable.Rows[0][3].ToString();
            textBox_MatKhau.Text = dataTable.Rows[0][4].ToString();
        }

        private void CheckBox_HiệnMậtKhẩu_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MatKhau.UseSystemPasswordChar = !checkBox_HiệnMậtKhẩu.Checked;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string commandText = $"UPDATE NHANVIEN SET " +
                                $"TENNV = N'{textBox_TenNhanVien.Text}', " +
                                $"NGAYSINH = '{dateTimePicker_NgàySinh.Value:yyyy-MM-dd}'" +
                                $"CCCD = '{textBox_CCCDNV.Text}', " +
                                $"MATKHAU = '{textBox_MatKhau.Text}' " +
                                $"WHERE IDNV = '{FMain.IDNV_Current}'";
        }
    }
}
