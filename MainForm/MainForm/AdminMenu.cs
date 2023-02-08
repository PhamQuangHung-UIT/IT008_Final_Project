using System.Data;
using System.Data.SqlClient;

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
            FMain.SetDoubleBuffered(this);
            UpdateNhanVien();
            UpdateDichVu();
            UpdateBan();
            Button_AdminNV_Click(sender, e);
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

        private void Button_AdminBan_Click(object sender, EventArgs e)
        {
            panel_AdminNhanVien.Visible = false;
            panel_AdminDichVu.Visible = false;
            panel_AdminBan.Visible = true;
            panel_ThongKe.Visible = false;
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

        #region Update Data Grid View

        // Đồng bộ danh sách bàn với CSDL
        private void UpdateBan()
        {
            string commandString = "SELECT * FROM BAN";
            var table = FMain.GetSqlData(commandString);
            dataGridView_Ban.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                var id = row["IDBAN"];
                var giaTien = row["GIATIEN"];
                var trangThai = comboBox_TrangThai.Items[(row["TRANGTHAI"] is null ? 2 : Convert.ToInt32(row["TRANGTHAI"]))];
                dataGridView_Ban.Rows.Add(id, giaTien, trangThai);
            }
        }

        // Đồng bộ danh sách các dịch vụ từ CSDL
        private void UpdateDichVu()
        {
            string commandString = "SELECT * FROM DICHVU";
            var table = FMain.GetSqlData(commandString);
            dataGridView_DichVu.Rows.Clear();
            foreach (DataRow row in table.Rows)
            {
                int id = (int)row["IDDV"];
                string tenDV = (string)row["TENDV"];
                decimal giaTien = (decimal)row["GIATIEN"];
                string hienThi = (bool)row["HIENTHI"] ? "Có" : "Không";
                dataGridView_DichVu.Rows.Add(id, tenDV, giaTien, hienThi);
            }
        }

        // Đồng bộ danh sách nhân viên với CSDL
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
                string quyenAdmin = (bool)row["QUYENADMIN"] ? "Có" : "Không";
                string tenDangNhap = (string)row["TENDANGNHAP"];
                string tuyenDung = (bool)row["HIENTHI"] ? "Có" : "Không";
                dataGridView_NhanVien.Rows.Add(id, tenNV, ngaySinh, CCCD, quyenAdmin, tenDangNhap, tuyenDung);
            }
        }

        #endregion

        #region RowStateChanged Event

        private void DataGridView_Ban_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            button_ChinhSuaBan.Enabled = false;
            if (dataGridView_Ban.SelectedRows.Count > 1) 
            {
                textBox_idBan.Clear();
                var value = dataGridView_Ban.SelectedRows[0].Cells[1].Value;
                var selectedRows = dataGridView_Ban.SelectedRows.Cast<DataGridViewRow>();
                textBox_GiaTienBan.Text = (selectedRows.All(x => Math.Abs((decimal)x.Cells[1].Value -(decimal)value) < 0.000001m) ? ((decimal)value).ToString("G0") : "");
                value = dataGridView_Ban.SelectedRows[0].Cells[2].Value;
                comboBox_TrangThai.SelectedIndex = comboBox_TrangThai.Items.IndexOf(dataGridView_Ban.SelectedRows.Cast<DataGridViewRow>().All(x => x.Cells[2].Value == value) ? value.ToString() : "");
            }
            if (dataGridView_Ban.SelectedRows.Count == 1)
            {
                textBox_idBan.Text = dataGridView_Ban.SelectedRows[0].Cells[0].Value.ToString();
                textBox_GiaTienBan.Text = $"{dataGridView_Ban.SelectedRows[0].Cells[1].Value:G0}";
                comboBox_TrangThai.SelectedIndex = comboBox_TrangThai.Items.IndexOf(dataGridView_Ban.SelectedRows[0].Cells[2].Value.ToString());
            }
            textBox_GiaTienBan.Tag = null;
        }

        private void DataGridView_NhanVien_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            var selectedRows = dataGridView_NhanVien.SelectedRows.Cast<DataGridViewRow>().ToArray();
            button_XoaNhanVien.Enabled = selectedRows.Length > 0;
            button_ChinhSuaNhanVien.Enabled = false;
            if (selectedRows.Length > 1)
            {
                textBox_idNV.Clear();
                var value = selectedRows[0].Cells[1].Value;
                textBox_TenNhanVien.Text = (selectedRows.All(x => x.Cells[1].Value == value) ? value.ToString() : "");
                value = selectedRows[0].Cells[2].Value;
                if (selectedRows.All(x => x.Cells[2].Value == value))
                {
                    dateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
                    dateTimePicker_NgaySinh.Value = (DateTime)value;
                }
                else
                {
                    dateTimePicker_NgaySinh.CustomFormat = " ";
                }
                textBox_CCCDNV.Clear();
                value = selectedRows[0].Cells[5].Value;
                checkBox_QuyenAdmin.CheckState = (selectedRows.All(x => x.Cells[5].Value == value) ? (CheckState)(value.ToString() == "Có" ? 1 : 0) : CheckState.Indeterminate);
                textBox_TenDangNhap.Clear();
            }
            if (selectedRows.Length == 1)
            {
                textBox_idNV.Text = selectedRows[0].Cells[0].Value.ToString();
                textBox_TenNhanVien.Text = selectedRows[0].Cells[1].Value.ToString();
                dateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
                dateTimePicker_NgaySinh.Value = (DateTime)selectedRows[0].Cells[2].Value;
                textBox_CCCDNV.Text = selectedRows[0].Cells[3].Value.ToString();
                checkBox_QuyenAdmin.Checked = selectedRows[0].Cells[5].Value.ToString() == "Có";
                textBox_TenDangNhap.Text = selectedRows[0].Cells[6].Value.ToString();
            }
            // Bỏ thuộc tính Tag do sự kiện ValueChanged được kích hoạt làm thay đổi thuộc tính Tag
            textBox_TenNhanVien.Tag = null;
            dateTimePicker_NgaySinh.Tag = null;
            checkBox_QuyenAdmin.Tag = null;
        }

        private void DataGridView_DichVu_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            button_BoHienThiDV.Enabled = dataGridView_DichVu.SelectedRows.Count > 0;
            button_ChinhSuaBan.Enabled = false;
            if (dataGridView_DichVu.SelectedRows.Count > 1)
            {
                textBox_idDV.Clear();
                var value = dataGridView_DichVu.SelectedRows[0].Cells[1].Value;
                var selectedRows = dataGridView_DichVu.SelectedRows.Cast<DataGridViewRow>();
                textBox_TenDV.Text = (selectedRows.All(x => x.Cells[0].Value == value) ? value.ToString() : "");
                value = dataGridView_DichVu.SelectedRows[0].Cells[2].Value;
                textBox_GiaTienDV.Text = (selectedRows.All(x => Math.Abs((decimal)x.Cells[1].Value - (decimal)value) < 0.000001m) ? ((decimal)value).ToString("G0") : "");
            }
            if (dataGridView_DichVu.SelectedRows.Count == 1)
            {
                textBox_idDV.Text = dataGridView_DichVu.SelectedRows[0].Cells[0].Value.ToString();
                textBox_TenDV.Text = dataGridView_DichVu.SelectedRows[0].Cells[1].Value.ToString();
                textBox_GiaTienDV.Text = $"{dataGridView_DichVu.SelectedRows[0].Cells[0].Value:G0}";
            }
            textBox_TenDV.Tag = null;
            textBox_GiaTienBan.Tag = null;
        }
        #endregion

        #region Button_NhanVien_Click Event

        private void Button_ThemNhanVien_Click(object sender, EventArgs e)
        {
            SignUpDlg signUpDlg = new()
            {
                Text = "Thêm nhân viên mới"
            };
            if (signUpDlg.ShowDialog() == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                UpdateNhanVien();
                Cursor = Cursors.Default;
            }
        }

        private void Button_ChinhSuaNhanVien_Click(object sender, EventArgs e)
        {
            int count = panel_AdminNhanVien.Controls.Cast<Control>().Count(x => x.Tag is int);
            if (count == 0) return;
            foreach (DataGridViewRow row in dataGridView_NhanVien.SelectedRows)
            {
                string commandText = "UPDATE NHANVIEN SET ";
                if (textBox_TenNhanVien.Tag is int)
                    commandText += $"TENNV = N'{textBox_TenNhanVien.Text}',";
                if (dateTimePicker_NgaySinh.Tag is int)
                    commandText += $"NGAYSINH = '{dateTimePicker_NgaySinh.Value:yyyy-MM-dd},'";
                if (textBox_CCCDNV.Tag is int)
                    commandText += $"CCCD = '{textBox_CCCDNV.Text}',";
                if (checkBox_QuyenAdmin.Tag is int)
                    commandText += $"QUYENADMIN = '{checkBox_QuyenAdmin.Checked}',";
                //Bỏ dấu phẩy ở cuối
                commandText = commandText[..^1];
                commandText += $" WHERE IDNV = {row.Cells[0].Value}";
                try
                {
                    FMain.SendSqlCommand(commandText);
                    MessageBox.Show("Chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_XoaNhanVien_Click(object sender, EventArgs e)
        {
            string message;
            int count = dataGridView_NhanVien.SelectedRows.Count;
            if (count > 1)
                message = $"Bạn có chắc muốn cho nghỉ việc {dataGridView_NhanVien.SelectedRows.Count} nhân viên không?";
            else message = $"Bạn có chắc muốn cho nghỉ việc nhân viên \"{dataGridView_NhanVien.SelectedRows[0].Cells[1].Value}\" không?";
            if (MessageBox.Show(message, " nhân viên", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (DataGridViewRow row in dataGridView_NhanVien.SelectedRows)
                {
                    string commandText = $"UPDATE NHANVIEN SET HIENTHI = 0 WHERE IDNV = {row.Cells[0].Value}";
                    try
                    {
                        FMain.SendSqlCommand(commandText);
                    } catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                UpdateNhanVien();
                Cursor = Cursors.Default;
            }
        }


        private void Button_TuyenDungLai_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_NhanVien.SelectedRows)
            {
                if (row.Cells["TUYENDUNG"].Value.ToString() == "Không")
                {
                    string commandText = $"UPDATE NHANVIEN SET HIENTHI = 1 WHERE IDNV = {row.Cells[0].Value}";
                    FMain.SendSqlCommand(commandText);
                }
            }
            UpdateNhanVien();
        }

        private void LinkLabel_AccountToApprove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountToApproveDlg dlg = new();
            dlg.ShowDialog();
        }

        #endregion

        #region Button_Ban_Click Event

        private void Button_ThemBan_Click(object sender, EventArgs e)
        {
            AddTableDlg dlg = new();
            if (dlg.ShowDialog() == DialogResult.OK)
                UpdateBan();
        }

        private void Button_ChinhSuaBan_Click(object sender, EventArgs e)
        {
            int count = panel_AdminBan.Controls.Cast<Control>().Count(x => x.Tag is int);
            if (count == 0) return;
            foreach (DataGridViewRow row in dataGridView_Ban.SelectedRows)
            {
                string commandText = "UPDATE BAN SET ";
                if (textBox_GiaTienBan.Tag is int)
                    commandText += $"GIATIEN = {textBox_GiaTienBan.Text},";
                if (comboBox_TrangThai.Tag is int)
                    commandText += $"TRANGTHAI = {(comboBox_TrangThai.SelectedIndex == 2 ? null : comboBox_TrangThai.SelectedIndex)} ";
                commandText = commandText[..^1];
                commandText += $" WHERE IDBAN = {row.Cells[0].Value}";
                try
                {
                    FMain.SendSqlCommand(commandText);
                    MessageBox.Show("Chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBan();
                }
                catch (SqlException ex)
                {
                    string message = ex.Number switch
                    {
                        207 => "Giá trị bạn vừa nhập không đúng định dạng.",
                        _ => $"Lỗi không xác định. Chi tiết lỗi như dưới:\n{ex.Message}",
                    };
                    MessageBox.Show(message, "Lỗi bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Button_DichVu_Click Event

        private void Button_ThemDichVu_Click(object sender, EventArgs e)
        {
            AddService dlg = new();
            if (dlg.ShowDialog() == DialogResult.OK)
                UpdateDichVu();
        }

        private void Button_ChinhSuaDichVu_Click(object sender, EventArgs e)
        {
            int count = panel_AdminDichVu.Controls.Cast<Control>().Count(x => x.Tag is int);
            if (count == 0) return;
            foreach (DataGridViewRow row in dataGridView_DichVu.SelectedRows)
            {
                string commandText = "UPDATE BAN SET ";
                if (textBox_GiaTienDV.Tag is int)
                    commandText += $"GIATIEN = {textBox_GiaTienBan.Text},";
                if (textBox_TenDV.Tag is int)
                    commandText += $"TENDV = N'{textBox_TenDV.Text}' ";
                commandText = commandText[..^1];
                commandText += $" WHERE IDDV = {row.Cells[0].Value}";
                try
                {
                    FMain.SendSqlCommand(commandText);
                    MessageBox.Show("Chỉnh sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateBan();
                }
                catch (SqlException ex)
                {
                    string message = ex.Number switch
                    {
                        207 => "Giá trị bạn vừa nhập không đúng định dạng.",
                        _ => $"Lỗi không xác định. Chi tiết lỗi như dưới:\n{ex.Message}",
                    };
                    MessageBox.Show(message, "Lỗi bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_BoHienThiDV_Click(object sender, EventArgs e)
        {
            string message;
            int count = dataGridView_Ban.SelectedRows.Count;
            if (count == 0) return;
            if (count > 1)
                message = $"Bạn có chắc muốn bỏ hiển thị {count} dịch vụ không?";
            else message = $"Bạn có chắc muốn bỏ hiển thị \"{dataGridView_DichVu.SelectedRows[0].Cells[1].Value}\" không?";
            if (MessageBox.Show(message, "Xóa dịch vụ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Cursor = Cursors.WaitCursor;
                foreach (DataGridViewRow row in dataGridView_Ban.SelectedRows)
                {
                    string commandText = $"UPDATE DICHVU SET HIENTHI = 0 WHERE IDDV = {row.Cells[0].Value}";
                    try
                    {
                        FMain.SendSqlCommand(commandText);
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                UpdateBan();
                Cursor = Cursors.Default;
            }
        }

        private void Button_HienThiLaiDV_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            foreach (DataGridViewRow row in dataGridView_DichVu.SelectedRows)
            {
                if (row.Cells["HIENTHI"].Value.ToString() == "Không")
                {
                    string commandText = $"UPDATE DICHVU SET HIENTHI = 1 WHERE IDDV = {row.Cells[0].Value}";
                    FMain.SendSqlCommand(commandText);
                }
            }
            UpdateDichVu();
            Cursor = Cursors.Default;
        }
        #endregion


        private void Ban_Control_ValueChanged(object sender, EventArgs e)
        {
            button_ChinhSuaBan.Enabled = true;
            Control_ValueChanged(sender, e);
        }

        private void DichVu_Control_ValueChanged(object sender, EventArgs e)
        {
            button_ThemDichVu.Enabled = true;
            Control_ValueChanged(sender, e);
        }

        private void NhanVien_Control_ValueChanged(object sender, EventArgs e)
        {
            button_ChinhSuaNhanVien.Enabled = true;
            Control_ValueChanged(sender, e);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                (sender as Control)?.Parent?.Focus();
        }

        private void DateTimePicker_NgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
            NhanVien_Control_ValueChanged(sender, e);
        }

        // Đánh dấu Control đó có thay đổi dữ liệu (dùng trong thao tác lưu chỉnh sửa)
        private void Control_ValueChanged(object sender, EventArgs e)
        {
            if (sender is Control control)
                control.Tag = 1;
        }
    }
}
