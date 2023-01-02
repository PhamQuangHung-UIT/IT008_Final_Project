namespace MainForm
{
    partial class AccountToApproveDlg
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYENADMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Duyet = new System.Windows.Forms.Button();
            this.button_DuyetTatCa = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_XoaTatCa = new System.Windows.Forms.Button();
            this.label_ZeroAccount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_NhanVien
            // 
            this.dataGridView_NhanVien.AllowUserToAddRows = false;
            this.dataGridView_NhanVien.AllowUserToDeleteRows = false;
            this.dataGridView_NhanVien.AllowUserToResizeRows = false;
            this.dataGridView_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDNV,
            this.HOTENNV,
            this.NGAYSINH,
            this.CCCD,
            this.MATKHAU,
            this.QUYENADMIN,
            this.TENDANGNHAP});
            this.dataGridView_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_NhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.RowHeadersWidth = 62;
            this.dataGridView_NhanVien.RowTemplate.Height = 25;
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(744, 410);
            this.dataGridView_NhanVien.TabIndex = 1;
            this.dataGridView_NhanVien.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DataGridView_NhanVien_RowsRemoved);
            this.dataGridView_NhanVien.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView_NhanVien_RowStateChanged);
            // 
            // IDNV
            // 
            this.IDNV.HeaderText = "Mã NV";
            this.IDNV.MinimumWidth = 8;
            this.IDNV.Name = "IDNV";
            this.IDNV.Width = 102;
            // 
            // HOTENNV
            // 
            this.HOTENNV.HeaderText = "Họ tên NV";
            this.HOTENNV.MinimumWidth = 8;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.Width = 131;
            // 
            // NGAYSINH
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.NGAYSINH.DefaultCellStyle = dataGridViewCellStyle1;
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 8;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 127;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "Số CCCD/CMND";
            this.CCCD.MinimumWidth = 8;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 180;
            // 
            // MATKHAU
            // 
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.MinimumWidth = 8;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Visible = false;
            this.MATKHAU.Width = 122;
            // 
            // QUYENADMIN
            // 
            this.QUYENADMIN.HeaderText = "Quyền QTV";
            this.QUYENADMIN.MinimumWidth = 8;
            this.QUYENADMIN.Name = "QUYENADMIN";
            this.QUYENADMIN.Visible = false;
            this.QUYENADMIN.Width = 138;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.HeaderText = "Tên đăng nhập";
            this.TENDANGNHAP.MinimumWidth = 8;
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.Width = 165;
            // 
            // button_Duyet
            // 
            this.button_Duyet.Enabled = false;
            this.button_Duyet.Location = new System.Drawing.Point(110, 437);
            this.button_Duyet.Name = "button_Duyet";
            this.button_Duyet.Size = new System.Drawing.Size(152, 46);
            this.button_Duyet.TabIndex = 2;
            this.button_Duyet.Text = "Duyệt";
            this.button_Duyet.UseVisualStyleBackColor = true;
            // 
            // button_DuyetTatCa
            // 
            this.button_DuyetTatCa.Location = new System.Drawing.Point(470, 437);
            this.button_DuyetTatCa.Name = "button_DuyetTatCa";
            this.button_DuyetTatCa.Size = new System.Drawing.Size(152, 46);
            this.button_DuyetTatCa.TabIndex = 3;
            this.button_DuyetTatCa.Text = "Duyệt tất cả";
            this.button_DuyetTatCa.UseVisualStyleBackColor = true;
            // 
            // button_Xoa
            // 
            this.button_Xoa.Enabled = false;
            this.button_Xoa.Location = new System.Drawing.Point(110, 508);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(152, 46);
            this.button_Xoa.TabIndex = 4;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_XoaTatCa
            // 
            this.button_XoaTatCa.Location = new System.Drawing.Point(470, 508);
            this.button_XoaTatCa.Name = "button_XoaTatCa";
            this.button_XoaTatCa.Size = new System.Drawing.Size(152, 46);
            this.button_XoaTatCa.TabIndex = 5;
            this.button_XoaTatCa.Text = "Xóa tất cả";
            this.button_XoaTatCa.UseVisualStyleBackColor = true;
            // 
            // label_ZeroAccount
            // 
            this.label_ZeroAccount.AutoSize = true;
            this.label_ZeroAccount.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label_ZeroAccount.Location = new System.Drawing.Point(187, 178);
            this.label_ZeroAccount.Name = "label_ZeroAccount";
            this.label_ZeroAccount.Size = new System.Drawing.Size(356, 25);
            this.label_ZeroAccount.TabIndex = 6;
            this.label_ZeroAccount.Text = "Không có tài khoản nào để chờ được duyệt";
            this.label_ZeroAccount.Visible = false;
            // 
            // AccountToApproveDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 585);
            this.Controls.Add(this.label_ZeroAccount);
            this.Controls.Add(this.button_XoaTatCa);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_DuyetTatCa);
            this.Controls.Add(this.button_Duyet);
            this.Controls.Add(this.dataGridView_NhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccountToApproveDlg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách tài khoản chờ được duyệt";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView_NhanVien;
        private DataGridViewTextBoxColumn IDNV;
        private DataGridViewTextBoxColumn HOTENNV;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn MATKHAU;
        private DataGridViewTextBoxColumn QUYENADMIN;
        private DataGridViewTextBoxColumn TENDANGNHAP;
        private Button button_Duyet;
        private Button button_DuyetTatCa;
        private Button button_Xoa;
        private Button button_XoaTatCa;
        private Label label_ZeroAccount;
    }
}