namespace MainForm
{
    partial class AdminMenu
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
            this.panel_AdminControl = new System.Windows.Forms.Panel();
            this.button_AdminBack = new System.Windows.Forms.Button();
            this.button_AdminThongKe = new System.Windows.Forms.Button();
            this.button_AdminBan = new System.Windows.Forms.Button();
            this.button_AdminDV = new System.Windows.Forms.Button();
            this.button_AdminNV = new System.Windows.Forms.Button();
            this.panel_AdminNhanVien = new System.Windows.Forms.Panel();
            this.button_NVSave = new System.Windows.Forms.Button();
            this.checkBox_QuyenAdmin = new System.Windows.Forms.CheckBox();
            this.label_QuyenAdmin = new System.Windows.Forms.Label();
            this.label_MatKhauNV = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label_idNV = new System.Windows.Forms.Label();
            this.textBox_idNV = new System.Windows.Forms.TextBox();
            this.label_CCCDNV = new System.Windows.Forms.Label();
            this.textBox_CCCDNV = new System.Windows.Forms.TextBox();
            this.label_NgaySinhNV = new System.Windows.Forms.Label();
            this.textBox_NgaySinhNV = new System.Windows.Forms.TextBox();
            this.label_TenNV = new System.Windows.Forms.Label();
            this.textBox_TenNhanVien = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_AdminDichVu = new System.Windows.Forms.Panel();
            this.button_DVSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_GiaTienDV = new System.Windows.Forms.Label();
            this.textBox_TenDV = new System.Windows.Forms.TextBox();
            this.label_TenDV = new System.Windows.Forms.Label();
            this.textBox_idDV = new System.Windows.Forms.TextBox();
            this.label1_idDV = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel_AdminBan = new System.Windows.Forms.Panel();
            this.button_BanSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_GiaTienBan = new System.Windows.Forms.Label();
            this.textBox_idBan = new System.Windows.Forms.TextBox();
            this.label_idBan = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel_AdminControl.SuspendLayout();
            this.panel_AdminNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_AdminDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel_AdminBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AdminControl
            // 
            this.panel_AdminControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_AdminControl.AutoSize = true;
            this.panel_AdminControl.Controls.Add(this.button_AdminBack);
            this.panel_AdminControl.Controls.Add(this.button_AdminThongKe);
            this.panel_AdminControl.Controls.Add(this.button_AdminBan);
            this.panel_AdminControl.Controls.Add(this.button_AdminDV);
            this.panel_AdminControl.Controls.Add(this.button_AdminNV);
            this.panel_AdminControl.Location = new System.Drawing.Point(11, 11);
            this.panel_AdminControl.Margin = new System.Windows.Forms.Padding(2);
            this.panel_AdminControl.Name = "panel_AdminControl";
            this.panel_AdminControl.Size = new System.Drawing.Size(236, 539);
            this.panel_AdminControl.TabIndex = 0;
            // 
            // button_AdminBack
            // 
            this.button_AdminBack.Location = new System.Drawing.Point(17, 413);
            this.button_AdminBack.Name = "button_AdminBack";
            this.button_AdminBack.Size = new System.Drawing.Size(199, 54);
            this.button_AdminBack.TabIndex = 4;
            this.button_AdminBack.Text = "TRỞ VỀ";
            this.button_AdminBack.UseVisualStyleBackColor = true;
            this.button_AdminBack.Click += new System.EventHandler(this.button_AdminBack_Click);
            // 
            // button_AdminThongKe
            // 
            this.button_AdminThongKe.Location = new System.Drawing.Point(17, 314);
            this.button_AdminThongKe.Name = "button_AdminThongKe";
            this.button_AdminThongKe.Size = new System.Drawing.Size(199, 93);
            this.button_AdminThongKe.TabIndex = 3;
            this.button_AdminThongKe.Text = "THỐNG KÊ";
            this.button_AdminThongKe.UseVisualStyleBackColor = true;
            this.button_AdminThongKe.Click += new System.EventHandler(this.button_AdminThongKe_Click);
            // 
            // button_AdminBan
            // 
            this.button_AdminBan.Location = new System.Drawing.Point(17, 215);
            this.button_AdminBan.Name = "button_AdminBan";
            this.button_AdminBan.Size = new System.Drawing.Size(199, 93);
            this.button_AdminBan.TabIndex = 2;
            this.button_AdminBan.Text = "CHỈNH SỬA BÀN";
            this.button_AdminBan.UseVisualStyleBackColor = true;
            this.button_AdminBan.Click += new System.EventHandler(this.button_AdminBan_Click);
            // 
            // button_AdminDV
            // 
            this.button_AdminDV.Location = new System.Drawing.Point(17, 116);
            this.button_AdminDV.Name = "button_AdminDV";
            this.button_AdminDV.Size = new System.Drawing.Size(199, 93);
            this.button_AdminDV.TabIndex = 1;
            this.button_AdminDV.Text = "CHỈNH SỬA DỊCH VỤ";
            this.button_AdminDV.UseVisualStyleBackColor = true;
            this.button_AdminDV.Click += new System.EventHandler(this.button_AdminDV_Click);
            // 
            // button_AdminNV
            // 
            this.button_AdminNV.Location = new System.Drawing.Point(17, 17);
            this.button_AdminNV.Name = "button_AdminNV";
            this.button_AdminNV.Size = new System.Drawing.Size(199, 93);
            this.button_AdminNV.TabIndex = 0;
            this.button_AdminNV.Text = "CHỈNH SỬA NHÂN VIÊN";
            this.button_AdminNV.UseVisualStyleBackColor = true;
            this.button_AdminNV.Click += new System.EventHandler(this.button_AdminNV_Click);
            // 
            // panel_AdminNhanVien
            // 
            this.panel_AdminNhanVien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_AdminNhanVien.BackColor = System.Drawing.Color.White;
            this.panel_AdminNhanVien.Controls.Add(this.button_NVSave);
            this.panel_AdminNhanVien.Controls.Add(this.checkBox_QuyenAdmin);
            this.panel_AdminNhanVien.Controls.Add(this.label_QuyenAdmin);
            this.panel_AdminNhanVien.Controls.Add(this.label_MatKhauNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_MatKhau);
            this.panel_AdminNhanVien.Controls.Add(this.label_idNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_idNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_CCCDNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_CCCDNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_NgaySinhNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_NgaySinhNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_TenNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_TenNhanVien);
            this.panel_AdminNhanVien.Controls.Add(this.dataGridView1);
            this.panel_AdminNhanVien.Location = new System.Drawing.Point(295, 11);
            this.panel_AdminNhanVien.Name = "panel_AdminNhanVien";
            this.panel_AdminNhanVien.Size = new System.Drawing.Size(865, 480);
            this.panel_AdminNhanVien.TabIndex = 1;
            this.panel_AdminNhanVien.Visible = false;
            // 
            // button_NVSave
            // 
            this.button_NVSave.BackColor = System.Drawing.Color.White;
            this.button_NVSave.Location = new System.Drawing.Point(539, 396);
            this.button_NVSave.Name = "button_NVSave";
            this.button_NVSave.Size = new System.Drawing.Size(131, 44);
            this.button_NVSave.TabIndex = 14;
            this.button_NVSave.Text = "Lưu";
            this.button_NVSave.UseVisualStyleBackColor = false;
            // 
            // checkBox_QuyenAdmin
            // 
            this.checkBox_QuyenAdmin.AutoSize = true;
            this.checkBox_QuyenAdmin.Location = new System.Drawing.Point(518, 300);
            this.checkBox_QuyenAdmin.Name = "checkBox_QuyenAdmin";
            this.checkBox_QuyenAdmin.Size = new System.Drawing.Size(15, 14);
            this.checkBox_QuyenAdmin.TabIndex = 13;
            this.checkBox_QuyenAdmin.UseVisualStyleBackColor = true;
            // 
            // label_QuyenAdmin
            // 
            this.label_QuyenAdmin.AutoSize = true;
            this.label_QuyenAdmin.Location = new System.Drawing.Point(426, 301);
            this.label_QuyenAdmin.Name = "label_QuyenAdmin";
            this.label_QuyenAdmin.Size = new System.Drawing.Size(84, 15);
            this.label_QuyenAdmin.TabIndex = 12;
            this.label_QuyenAdmin.Text = "Quyền Admin:";
            // 
            // label_MatKhauNV
            // 
            this.label_MatKhauNV.AutoSize = true;
            this.label_MatKhauNV.Location = new System.Drawing.Point(426, 243);
            this.label_MatKhauNV.Name = "label_MatKhauNV";
            this.label_MatKhauNV.Size = new System.Drawing.Size(63, 15);
            this.label_MatKhauNV.TabIndex = 10;
            this.label_MatKhauNV.Text = "Mật khẩu: ";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(518, 240);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(294, 23);
            this.textBox_MatKhau.TabIndex = 9;
            // 
            // label_idNV
            // 
            this.label_idNV.AutoSize = true;
            this.label_idNV.Location = new System.Drawing.Point(426, 38);
            this.label_idNV.Name = "label_idNV";
            this.label_idNV.Size = new System.Drawing.Size(24, 15);
            this.label_idNV.TabIndex = 8;
            this.label_idNV.Text = "ID: ";
            // 
            // textBox_idNV
            // 
            this.textBox_idNV.Enabled = false;
            this.textBox_idNV.Location = new System.Drawing.Point(518, 35);
            this.textBox_idNV.Name = "textBox_idNV";
            this.textBox_idNV.Size = new System.Drawing.Size(294, 23);
            this.textBox_idNV.TabIndex = 7;
            // 
            // label_CCCDNV
            // 
            this.label_CCCDNV.AutoSize = true;
            this.label_CCCDNV.Location = new System.Drawing.Point(426, 188);
            this.label_CCCDNV.Name = "label_CCCDNV";
            this.label_CCCDNV.Size = new System.Drawing.Size(45, 15);
            this.label_CCCDNV.TabIndex = 6;
            this.label_CCCDNV.Text = "CCCD: ";
            // 
            // textBox_CCCDNV
            // 
            this.textBox_CCCDNV.Location = new System.Drawing.Point(518, 185);
            this.textBox_CCCDNV.Name = "textBox_CCCDNV";
            this.textBox_CCCDNV.Size = new System.Drawing.Size(294, 23);
            this.textBox_CCCDNV.TabIndex = 5;
            // 
            // label_NgaySinhNV
            // 
            this.label_NgaySinhNV.AutoSize = true;
            this.label_NgaySinhNV.Location = new System.Drawing.Point(426, 139);
            this.label_NgaySinhNV.Name = "label_NgaySinhNV";
            this.label_NgaySinhNV.Size = new System.Drawing.Size(66, 15);
            this.label_NgaySinhNV.TabIndex = 4;
            this.label_NgaySinhNV.Text = "Ngày sinh: ";
            // 
            // textBox_NgaySinhNV
            // 
            this.textBox_NgaySinhNV.Location = new System.Drawing.Point(518, 136);
            this.textBox_NgaySinhNV.Name = "textBox_NgaySinhNV";
            this.textBox_NgaySinhNV.Size = new System.Drawing.Size(294, 23);
            this.textBox_NgaySinhNV.TabIndex = 3;
            // 
            // label_TenNV
            // 
            this.label_TenNV.AutoSize = true;
            this.label_TenNV.Location = new System.Drawing.Point(426, 89);
            this.label_TenNV.Name = "label_TenNV";
            this.label_TenNV.Size = new System.Drawing.Size(86, 15);
            this.label_TenNV.TabIndex = 2;
            this.label_TenNV.Text = "Tên nhân viên: ";
            // 
            // textBox_TenNhanVien
            // 
            this.textBox_TenNhanVien.Location = new System.Drawing.Point(518, 86);
            this.textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            this.textBox_TenNhanVien.Size = new System.Drawing.Size(294, 23);
            this.textBox_TenNhanVien.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(385, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel_AdminDichVu
            // 
            this.panel_AdminDichVu.BackColor = System.Drawing.Color.White;
            this.panel_AdminDichVu.Controls.Add(this.button_DVSave);
            this.panel_AdminDichVu.Controls.Add(this.textBox1);
            this.panel_AdminDichVu.Controls.Add(this.label_GiaTienDV);
            this.panel_AdminDichVu.Controls.Add(this.textBox_TenDV);
            this.panel_AdminDichVu.Controls.Add(this.label_TenDV);
            this.panel_AdminDichVu.Controls.Add(this.textBox_idDV);
            this.panel_AdminDichVu.Controls.Add(this.label1_idDV);
            this.panel_AdminDichVu.Controls.Add(this.dataGridView2);
            this.panel_AdminDichVu.Location = new System.Drawing.Point(256, 11);
            this.panel_AdminDichVu.Name = "panel_AdminDichVu";
            this.panel_AdminDichVu.Size = new System.Drawing.Size(842, 481);
            this.panel_AdminDichVu.TabIndex = 2;
            this.panel_AdminDichVu.Visible = false;
            // 
            // button_DVSave
            // 
            this.button_DVSave.Location = new System.Drawing.Point(535, 385);
            this.button_DVSave.Name = "button_DVSave";
            this.button_DVSave.Size = new System.Drawing.Size(167, 60);
            this.button_DVSave.TabIndex = 7;
            this.button_DVSave.Text = "Lưu";
            this.button_DVSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(526, 177);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 23);
            this.textBox1.TabIndex = 6;
            // 
            // label_GiaTienDV
            // 
            this.label_GiaTienDV.AutoSize = true;
            this.label_GiaTienDV.Location = new System.Drawing.Point(427, 185);
            this.label_GiaTienDV.Name = "label_GiaTienDV";
            this.label_GiaTienDV.Size = new System.Drawing.Size(50, 15);
            this.label_GiaTienDV.TabIndex = 5;
            this.label_GiaTienDV.Text = "Giá tiền:";
            // 
            // textBox_TenDV
            // 
            this.textBox_TenDV.Location = new System.Drawing.Point(526, 104);
            this.textBox_TenDV.Name = "textBox_TenDV";
            this.textBox_TenDV.Size = new System.Drawing.Size(294, 23);
            this.textBox_TenDV.TabIndex = 4;
            // 
            // label_TenDV
            // 
            this.label_TenDV.AutoSize = true;
            this.label_TenDV.Location = new System.Drawing.Point(427, 112);
            this.label_TenDV.Name = "label_TenDV";
            this.label_TenDV.Size = new System.Drawing.Size(70, 15);
            this.label_TenDV.TabIndex = 3;
            this.label_TenDV.Text = "Tên dịch vụ:";
            // 
            // textBox_idDV
            // 
            this.textBox_idDV.Location = new System.Drawing.Point(526, 40);
            this.textBox_idDV.Name = "textBox_idDV";
            this.textBox_idDV.Size = new System.Drawing.Size(294, 23);
            this.textBox_idDV.TabIndex = 2;
            // 
            // label1_idDV
            // 
            this.label1_idDV.AutoSize = true;
            this.label1_idDV.Location = new System.Drawing.Point(427, 48);
            this.label1_idDV.Name = "label1_idDV";
            this.label1_idDV.Size = new System.Drawing.Size(21, 15);
            this.label1_idDV.TabIndex = 1;
            this.label1_idDV.Text = "ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(381, 446);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel_AdminBan
            // 
            this.panel_AdminBan.BackColor = System.Drawing.Color.White;
            this.panel_AdminBan.Controls.Add(this.button_BanSave);
            this.panel_AdminBan.Controls.Add(this.textBox2);
            this.panel_AdminBan.Controls.Add(this.label_GiaTienBan);
            this.panel_AdminBan.Controls.Add(this.textBox_idBan);
            this.panel_AdminBan.Controls.Add(this.label_idBan);
            this.panel_AdminBan.Controls.Add(this.dataGridView3);
            this.panel_AdminBan.Location = new System.Drawing.Point(252, 8);
            this.panel_AdminBan.Name = "panel_AdminBan";
            this.panel_AdminBan.Size = new System.Drawing.Size(865, 481);
            this.panel_AdminBan.TabIndex = 3;
            this.panel_AdminBan.Visible = false;
            // 
            // button_BanSave
            // 
            this.button_BanSave.Location = new System.Drawing.Point(542, 385);
            this.button_BanSave.Name = "button_BanSave";
            this.button_BanSave.Size = new System.Drawing.Size(131, 60);
            this.button_BanSave.TabIndex = 5;
            this.button_BanSave.Text = "Lưu";
            this.button_BanSave.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(530, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(285, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label_GiaTienBan
            // 
            this.label_GiaTienBan.AutoSize = true;
            this.label_GiaTienBan.Location = new System.Drawing.Point(429, 119);
            this.label_GiaTienBan.Name = "label_GiaTienBan";
            this.label_GiaTienBan.Size = new System.Drawing.Size(50, 15);
            this.label_GiaTienBan.TabIndex = 3;
            this.label_GiaTienBan.Text = "Giá tiền:";
            // 
            // textBox_idBan
            // 
            this.textBox_idBan.Location = new System.Drawing.Point(530, 53);
            this.textBox_idBan.Name = "textBox_idBan";
            this.textBox_idBan.Size = new System.Drawing.Size(285, 23);
            this.textBox_idBan.TabIndex = 2;
            // 
            // label_idBan
            // 
            this.label_idBan.AutoSize = true;
            this.label_idBan.Location = new System.Drawing.Point(429, 56);
            this.label_idBan.Name = "label_idBan";
            this.label_idBan.Size = new System.Drawing.Size(21, 15);
            this.label_idBan.TabIndex = 1;
            this.label_idBan.Text = "ID:";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(374, 446);
            this.dataGridView3.TabIndex = 0;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 562);
            this.Controls.Add(this.panel_AdminBan);
            this.Controls.Add(this.panel_AdminDichVu);
            this.Controls.Add(this.panel_AdminNhanVien);
            this.Controls.Add(this.panel_AdminControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminMenu";
            this.panel_AdminControl.ResumeLayout(false);
            this.panel_AdminNhanVien.ResumeLayout(false);
            this.panel_AdminNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_AdminDichVu.ResumeLayout(false);
            this.panel_AdminDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel_AdminBan.ResumeLayout(false);
            this.panel_AdminBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_AdminControl;
        private Button button_AdminThongKe;
        private Button button_AdminBan;
        private Button button_AdminDV;
        private Button button_AdminNV;
        private Panel panel_AdminNhanVien;
        private Button button_AdminBack;
        private Label label_NgaySinhNV;
        private TextBox textBox_NgaySinhNV;
        private Label label_TenNV;
        private TextBox textBox_TenNhanVien;
        private DataGridView dataGridView1;
        private Label label_idNV;
        private TextBox textBox_idNV;
        private Label label_CCCDNV;
        private TextBox textBox_CCCDNV;
        private Label label_MatKhauNV;
        private TextBox textBox_MatKhau;
        private Button button_NVSave;
        private CheckBox checkBox_QuyenAdmin;
        private Label label_QuyenAdmin;
        private Panel panel_AdminDichVu;
        private TextBox textBox_TenDV;
        private Label label_TenDV;
        private TextBox textBox_idDV;
        private Label label1_idDV;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Label label_GiaTienDV;
        private Button button_DVSave;
        private Panel panel_AdminBan;
        private DataGridView dataGridView3;
        private TextBox textBox_idBan;
        private Label label_idBan;
        private TextBox textBox2;
        private Label label_GiaTienBan;
        private Button button_BanSave;
    }
}