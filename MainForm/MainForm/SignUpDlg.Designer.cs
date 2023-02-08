namespace MainForm
{
    partial class SignUpDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label_CCCDNV = new System.Windows.Forms.Label();
            this.textBox_CCCDNV = new System.Windows.Forms.TextBox();
            this.label_NgaySinhNV = new System.Windows.Forms.Label();
            this.label_TenNV = new System.Windows.Forms.Label();
            this.textBox_TenNhanVien = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_NhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_DangKy = new System.Windows.Forms.Button();
            this.checkBox_ShowPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(217, 141);
            this.dateTimePicker_NgaySinh.MaxDate = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(179, 31);
            this.dateTimePicker_NgaySinh.TabIndex = 27;
            this.dateTimePicker_NgaySinh.Value = new System.DateTime(2023, 1, 27, 0, 0, 0, 0);
            // 
            // label_CCCDNV
            // 
            this.label_CCCDNV.AutoSize = true;
            this.label_CCCDNV.Location = new System.Drawing.Point(55, 224);
            this.label_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CCCDNV.Name = "label_CCCDNV";
            this.label_CCCDNV.Size = new System.Drawing.Size(144, 25);
            this.label_CCCDNV.TabIndex = 26;
            this.label_CCCDNV.Text = "Số CCCD/CMND";
            // 
            // textBox_CCCDNV
            // 
            this.textBox_CCCDNV.Location = new System.Drawing.Point(217, 221);
            this.textBox_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CCCDNV.Name = "textBox_CCCDNV";
            this.textBox_CCCDNV.Size = new System.Drawing.Size(397, 31);
            this.textBox_CCCDNV.TabIndex = 25;
            this.textBox_CCCDNV.WordWrap = false;
            // 
            // label_NgaySinhNV
            // 
            this.label_NgaySinhNV.AutoSize = true;
            this.label_NgaySinhNV.Location = new System.Drawing.Point(55, 146);
            this.label_NgaySinhNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinhNV.Name = "label_NgaySinhNV";
            this.label_NgaySinhNV.Size = new System.Drawing.Size(95, 25);
            this.label_NgaySinhNV.TabIndex = 24;
            this.label_NgaySinhNV.Text = "Ngày sinh:";
            // 
            // label_TenNV
            // 
            this.label_TenNV.AutoSize = true;
            this.label_TenNV.Location = new System.Drawing.Point(55, 71);
            this.label_TenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenNV.Name = "label_TenNV";
            this.label_TenNV.Size = new System.Drawing.Size(71, 25);
            this.label_TenNV.TabIndex = 23;
            this.label_TenNV.Text = "Họ tên ";
            // 
            // textBox_TenNhanVien
            // 
            this.textBox_TenNhanVien.Location = new System.Drawing.Point(217, 68);
            this.textBox_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            this.textBox_TenNhanVien.Size = new System.Drawing.Size(333, 31);
            this.textBox_TenNhanVien.TabIndex = 22;
            this.textBox_TenNhanVien.WordWrap = false;
            this.textBox_TenNhanVien.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ControlToFocus_KeyDown);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(612, 531);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 38);
            this.buttonExit.TabIndex = 30;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(217, 304);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(302, 31);
            this.textBox_TenDangNhap.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Mật khẩu";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(217, 379);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(302, 31);
            this.textBox_MatKhau.TabIndex = 35;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            // 
            // textBox_NhapLaiMatKhau
            // 
            this.textBox_NhapLaiMatKhau.Location = new System.Drawing.Point(217, 449);
            this.textBox_NhapLaiMatKhau.Name = "textBox_NhapLaiMatKhau";
            this.textBox_NhapLaiMatKhau.Size = new System.Drawing.Size(302, 31);
            this.textBox_NhapLaiMatKhau.TabIndex = 36;
            this.textBox_NhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // button_DangKy
            // 
            this.button_DangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DangKy.Location = new System.Drawing.Point(455, 531);
            this.button_DangKy.Name = "button_DangKy";
            this.button_DangKy.Size = new System.Drawing.Size(112, 38);
            this.button_DangKy.TabIndex = 38;
            this.button_DangKy.Text = "Đăng ký";
            this.button_DangKy.UseVisualStyleBackColor = true;
            this.button_DangKy.Click += new System.EventHandler(this.Button_DangKy_Click);
            // 
            // checkBox_ShowPassword
            // 
            this.checkBox_ShowPassword.AutoSize = true;
            this.checkBox_ShowPassword.Location = new System.Drawing.Point(568, 381);
            this.checkBox_ShowPassword.Name = "checkBox_ShowPassword";
            this.checkBox_ShowPassword.Size = new System.Drawing.Size(153, 29);
            this.checkBox_ShowPassword.TabIndex = 39;
            this.checkBox_ShowPassword.Text = "Hiện mật khẩu";
            this.checkBox_ShowPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShowPassword.CheckedChanged += new System.EventHandler(this.CheckBox_ShowPassword_CheckedChanged);
            // 
            // SignUpDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 581);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_ShowPassword);
            this.Controls.Add(this.button_DangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_NhapLaiMatKhau);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_TenDangNhap);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.label_CCCDNV);
            this.Controls.Add(this.textBox_CCCDNV);
            this.Controls.Add(this.label_NgaySinhNV);
            this.Controls.Add(this.label_TenNV);
            this.Controls.Add(this.textBox_TenNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUpDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng ký";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateTimePicker_NgaySinh;
        private Label label_CCCDNV;
        private TextBox textBox_CCCDNV;
        private Label label_NgaySinhNV;
        private Label label_TenNV;
        private TextBox textBox_TenNhanVien;
        private Button buttonExit;
        private TextBox textBox_TenDangNhap;
        private Label label1;
        private Label label2;
        private TextBox textBox_MatKhau;
        private TextBox textBox_NhapLaiMatKhau;
        private Label label3;
        private Button button_DangKy;
        private CheckBox checkBox_ShowPassword;
    }
}