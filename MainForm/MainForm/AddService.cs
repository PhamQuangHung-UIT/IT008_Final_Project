using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            textBox_idDV.Text = FMain.GetSqlData("SELECT IDDV + 1 FROM DICHVU ORDER BY IDDV DESC").Rows[0][0].ToString();
            textBox_GiaTienDV.Text = "0";
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string commandText = $"INSERT INTO DICHVU VALUES({textBox_idDV.Text}, N'{textBox_TenDV.Text}', {textBox_GiaTienDV.Text}, 1)";
            try
            {
                FMain.SendSqlCommand(commandText);
            }
            catch (SqlException ex)
            {
                var errors = ex.Errors.Cast<SqlException>().ToList();
                foreach (var error in errors)
                {
                    string message = error.Number switch
                    {
                        207 => "Giá trị bạn vừa nhập không đúng định dạng.",
                        2627 => "Mã dịch vụ trùng lặp.",
                        2628 => "Độ dài chuỗi kí tự vượt quá giới hạn",
                        _ => $"Lỗi không xác định. Chi tiết lỗi như dưới:\n{error.Message}",
                    };
                    MessageBox.Show(message, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
