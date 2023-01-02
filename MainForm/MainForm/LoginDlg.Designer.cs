namespace MainForm
{
    partial class LoginDlg
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
            this.checkBox_HiệnMậtKhẩu = new System.Windows.Forms.CheckBox();
            this.label_MatKhauNV = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label_idNV = new System.Windows.Forms.Label();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_HiệnMậtKhẩu
            // 
            this.checkBox_HiệnMậtKhẩu.AutoSize = true;
            this.checkBox_HiệnMậtKhẩu.Location = new System.Drawing.Point(580, 236);
            this.checkBox_HiệnMậtKhẩu.Name = "checkBox_HiệnMậtKhẩu";
            this.checkBox_HiệnMậtKhẩu.Size = new System.Drawing.Size(153, 29);
            this.checkBox_HiệnMậtKhẩu.TabIndex = 27;
            this.checkBox_HiệnMậtKhẩu.Text = "Hiện mật khẩu";
            this.checkBox_HiệnMậtKhẩu.UseVisualStyleBackColor = true;
            this.checkBox_HiệnMậtKhẩu.CheckedChanged += new System.EventHandler(this.CheckBox_HiệnMậtKhẩu_CheckedChanged);
            // 
            // label_MatKhauNV
            // 
            this.label_MatKhauNV.AutoSize = true;
            this.label_MatKhauNV.Location = new System.Drawing.Point(85, 240);
            this.label_MatKhauNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MatKhauNV.Name = "label_MatKhauNV";
            this.label_MatKhauNV.Size = new System.Drawing.Size(95, 25);
            this.label_MatKhauNV.TabIndex = 26;
            this.label_MatKhauNV.Text = "Mật khẩu: ";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(222, 236);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(322, 31);
            this.textBox_MatKhau.TabIndex = 25;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            this.textBox_MatKhau.WordWrap = false;
            // 
            // label_idNV
            // 
            this.label_idNV.AutoSize = true;
            this.label_idNV.Location = new System.Drawing.Point(85, 171);
            this.label_idNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idNV.Name = "label_idNV";
            this.label_idNV.Size = new System.Drawing.Size(129, 25);
            this.label_idNV.TabIndex = 24;
            this.label_idNV.Text = "Tên đăng nhập";
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(222, 168);
            this.textBox_TenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(203, 31);
            this.textBox_TenDangNhap.TabIndex = 23;
            this.textBox_TenDangNhap.WordWrap = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.Location = new System.Drawing.Point(327, 339);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(129, 38);
            this.buttonLogin.TabIndex = 28;
            this.buttonLogin.Text = "Đăng nhập";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.Location = new System.Drawing.Point(640, 339);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(129, 38);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSignUp.Location = new System.Drawing.Point(482, 339);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(129, 38);
            this.buttonSignUp.TabIndex = 30;
            this.buttonSignUp.Text = "Đăng ký";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // LoginDlg
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(792, 389);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBox_HiệnMậtKhẩu);
            this.Controls.Add(this.label_MatKhauNV);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label_idNV);
            this.Controls.Add(this.textBox_TenDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "LoginDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBox_HiệnMậtKhẩu;
        private Label label_MatKhauNV;
        private TextBox textBox_MatKhau;
        private Label label_idNV;
        private TextBox textBox_TenDangNhap;
        private Button buttonLogin;
        private Button buttonExit;
        private Button buttonSignUp;
    }
}