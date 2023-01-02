﻿namespace MainForm
{
    partial class AccountInfoDlg
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
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label_MatKhauNV = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label_idNV = new System.Windows.Forms.Label();
            this.textBox_idNV = new System.Windows.Forms.TextBox();
            this.label_CCCDNV = new System.Windows.Forms.Label();
            this.textBox_CCCDNV = new System.Windows.Forms.TextBox();
            this.label_NgaySinhNV = new System.Windows.Forms.Label();
            this.label_TenNV = new System.Windows.Forms.Label();
            this.textBox_TenNhanVien = new System.Windows.Forms.TextBox();
            this.dateTimePicker_NgàySinh = new System.Windows.Forms.DateTimePicker();
            this.checkBox_HiệnMậtKhẩu = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(521, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 43);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(698, 479);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 43);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Hủy";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // label_MatKhauNV
            // 
            this.label_MatKhauNV.AutoSize = true;
            this.label_MatKhauNV.Location = new System.Drawing.Point(128, 398);
            this.label_MatKhauNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MatKhauNV.Name = "label_MatKhauNV";
            this.label_MatKhauNV.Size = new System.Drawing.Size(95, 25);
            this.label_MatKhauNV.TabIndex = 20;
            this.label_MatKhauNV.Text = "Mật khẩu: ";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(259, 393);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(322, 31);
            this.textBox_MatKhau.TabIndex = 19;
            this.textBox_MatKhau.UseSystemPasswordChar = true;
            this.textBox_MatKhau.WordWrap = false;
            // 
            // label_idNV
            // 
            this.label_idNV.AutoSize = true;
            this.label_idNV.Location = new System.Drawing.Point(128, 56);
            this.label_idNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idNV.Name = "label_idNV";
            this.label_idNV.Size = new System.Drawing.Size(39, 25);
            this.label_idNV.TabIndex = 18;
            this.label_idNV.Text = "ID: ";
            // 
            // textBox_idNV
            // 
            this.textBox_idNV.Enabled = false;
            this.textBox_idNV.Location = new System.Drawing.Point(259, 51);
            this.textBox_idNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idNV.Name = "textBox_idNV";
            this.textBox_idNV.Size = new System.Drawing.Size(203, 31);
            this.textBox_idNV.TabIndex = 17;
            this.textBox_idNV.WordWrap = false;
            // 
            // label_CCCDNV
            // 
            this.label_CCCDNV.AutoSize = true;
            this.label_CCCDNV.Location = new System.Drawing.Point(128, 306);
            this.label_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CCCDNV.Name = "label_CCCDNV";
            this.label_CCCDNV.Size = new System.Drawing.Size(67, 25);
            this.label_CCCDNV.TabIndex = 16;
            this.label_CCCDNV.Text = "CCCD: ";
            // 
            // textBox_CCCDNV
            // 
            this.textBox_CCCDNV.Location = new System.Drawing.Point(259, 301);
            this.textBox_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CCCDNV.Name = "textBox_CCCDNV";
            this.textBox_CCCDNV.Size = new System.Drawing.Size(418, 31);
            this.textBox_CCCDNV.TabIndex = 15;
            this.textBox_CCCDNV.WordWrap = false;
            // 
            // label_NgaySinhNV
            // 
            this.label_NgaySinhNV.AutoSize = true;
            this.label_NgaySinhNV.Location = new System.Drawing.Point(128, 225);
            this.label_NgaySinhNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinhNV.Name = "label_NgaySinhNV";
            this.label_NgaySinhNV.Size = new System.Drawing.Size(100, 25);
            this.label_NgaySinhNV.TabIndex = 14;
            this.label_NgaySinhNV.Text = "Ngày sinh: ";
            // 
            // label_TenNV
            // 
            this.label_TenNV.AutoSize = true;
            this.label_TenNV.Location = new System.Drawing.Point(128, 141);
            this.label_TenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenNV.Name = "label_TenNV";
            this.label_TenNV.Size = new System.Drawing.Size(128, 25);
            this.label_TenNV.TabIndex = 12;
            this.label_TenNV.Text = "Tên nhân viên: ";
            // 
            // textBox_TenNhanVien
            // 
            this.textBox_TenNhanVien.Location = new System.Drawing.Point(259, 136);
            this.textBox_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            this.textBox_TenNhanVien.Size = new System.Drawing.Size(418, 31);
            this.textBox_TenNhanVien.TabIndex = 11;
            this.textBox_TenNhanVien.WordWrap = false;
            // 
            // dateTimePicker_NgàySinh
            // 
            this.dateTimePicker_NgàySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_NgàySinh.Location = new System.Drawing.Point(259, 225);
            this.dateTimePicker_NgàySinh.Name = "dateTimePicker_NgàySinh";
            this.dateTimePicker_NgàySinh.Size = new System.Drawing.Size(179, 31);
            this.dateTimePicker_NgàySinh.TabIndex = 21;
            this.dateTimePicker_NgàySinh.Value = new System.DateTime(2022, 12, 20, 20, 24, 3, 0);
            // 
            // checkBox_HiệnMậtKhẩu
            // 
            this.checkBox_HiệnMậtKhẩu.AutoSize = true;
            this.checkBox_HiệnMậtKhẩu.Location = new System.Drawing.Point(617, 395);
            this.checkBox_HiệnMậtKhẩu.Name = "checkBox_HiệnMậtKhẩu";
            this.checkBox_HiệnMậtKhẩu.Size = new System.Drawing.Size(153, 29);
            this.checkBox_HiệnMậtKhẩu.TabIndex = 22;
            this.checkBox_HiệnMậtKhẩu.Text = "Hiện mật khẩu";
            this.checkBox_HiệnMậtKhẩu.UseVisualStyleBackColor = true;
            this.checkBox_HiệnMậtKhẩu.CheckedChanged += new System.EventHandler(this.CheckBox_HiệnMậtKhẩu_CheckedChanged);
            // 
            // AccountInfoDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 534);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox_HiệnMậtKhẩu);
            this.Controls.Add(this.dateTimePicker_NgàySinh);
            this.Controls.Add(this.label_MatKhauNV);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.label_idNV);
            this.Controls.Add(this.textBox_idNV);
            this.Controls.Add(this.label_CCCDNV);
            this.Controls.Add(this.textBox_CCCDNV);
            this.Controls.Add(this.label_NgaySinhNV);
            this.Controls.Add(this.label_TenNV);
            this.Controls.Add(this.textBox_TenNhanVien);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "AccountInfoDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.AccountInfoDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonSave;
        private Button buttonCancel;
        private Label label_MatKhauNV;
        private TextBox textBox_MatKhau;
        private Label label_idNV;
        private TextBox textBox_idNV;
        private Label label_CCCDNV;
        private TextBox textBox_CCCDNV;
        private Label label_NgaySinhNV;
        private Label label_TenNV;
        private TextBox textBox_TenNhanVien;
        private DateTimePicker dateTimePicker_NgàySinh;
        private CheckBox checkBox_HiệnMậtKhẩu;
    }
}