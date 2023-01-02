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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_AdminControl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button_AdminBack = new System.Windows.Forms.Button();
            this.button_AdminNV = new System.Windows.Forms.Button();
            this.button_AdminBan = new System.Windows.Forms.Button();
            this.button_AdminDV = new System.Windows.Forms.Button();
            this.button_AdminThongKe = new System.Windows.Forms.Button();
            this.panel_AdminNhanVien = new System.Windows.Forms.Panel();
            this.linkLabel_AccountToApprove = new System.Windows.Forms.LinkLabel();
            this.button_SuaNhanVien = new System.Windows.Forms.Button();
            this.button_ThemNhanVien = new System.Windows.Forms.Button();
            this.button_XoaNhanVien = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_NVSave = new System.Windows.Forms.Button();
            this.checkBox_QuyenAdmin = new System.Windows.Forms.CheckBox();
            this.label_QuyenAdmin = new System.Windows.Forms.Label();
            this.label_idNV = new System.Windows.Forms.Label();
            this.textBox_idNV = new System.Windows.Forms.TextBox();
            this.label_CCCDNV = new System.Windows.Forms.Label();
            this.textBox_CCCDNV = new System.Windows.Forms.TextBox();
            this.label_NgaySinhNV = new System.Windows.Forms.Label();
            this.label_TenNV = new System.Windows.Forms.Label();
            this.textBox_TenNhanVien = new System.Windows.Forms.TextBox();
            this.dataGridView_NhanVien = new System.Windows.Forms.DataGridView();
            this.IDNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYENADMIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDANGNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_AdminDichVu = new System.Windows.Forms.Panel();
            this.button_ThemDV = new System.Windows.Forms.Button();
            this.button_DVSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_GiaTienDV = new System.Windows.Forms.Label();
            this.textBox_TenDV = new System.Windows.Forms.TextBox();
            this.label_TenDV = new System.Windows.Forms.Label();
            this.textBox_idDV = new System.Windows.Forms.TextBox();
            this.label1_idDV = new System.Windows.Forms.Label();
            this.dataGridView_DichVu = new System.Windows.Forms.DataGridView();
            this.IDDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_AdminBan = new System.Windows.Forms.Panel();
            this.button_BanSave = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_GiaTienBan = new System.Windows.Forms.Label();
            this.textBox_idBan = new System.Windows.Forms.TextBox();
            this.label_idBan = new System.Windows.Forms.Label();
            this.dataGridView_Ban = new System.Windows.Forms.DataGridView();
            this.IDBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRANGTHAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_ThongKe = new System.Windows.Forms.Panel();
            this.panel_AdminControl.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_AdminNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).BeginInit();
            this.panel_AdminDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).BeginInit();
            this.panel_AdminBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AdminControl
            // 
            this.panel_AdminControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_AdminControl.AutoSize = true;
            this.panel_AdminControl.Controls.Add(this.tableLayoutPanel1);
            this.panel_AdminControl.Location = new System.Drawing.Point(16, 18);
            this.panel_AdminControl.Name = "panel_AdminControl";
            this.panel_AdminControl.Size = new System.Drawing.Size(337, 900);
            this.panel_AdminControl.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button_AdminBack, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_AdminNV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_AdminBan, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_AdminDV, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_AdminThongKe, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.99999F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.00001F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 900);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button_AdminBack
            // 
            this.button_AdminBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AdminBack.Location = new System.Drawing.Point(26, 732);
            this.button_AdminBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AdminBack.Name = "button_AdminBack";
            this.button_AdminBack.Size = new System.Drawing.Size(284, 154);
            this.button_AdminBack.TabIndex = 4;
            this.button_AdminBack.Text = "TRỞ VỀ";
            this.button_AdminBack.UseVisualStyleBackColor = true;
            this.button_AdminBack.Click += new System.EventHandler(this.Button_AdminBack_Click);
            // 
            // button_AdminNV
            // 
            this.button_AdminNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AdminNV.Location = new System.Drawing.Point(26, 12);
            this.button_AdminNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AdminNV.Name = "button_AdminNV";
            this.button_AdminNV.Size = new System.Drawing.Size(284, 155);
            this.button_AdminNV.TabIndex = 0;
            this.button_AdminNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.button_AdminNV.UseVisualStyleBackColor = true;
            this.button_AdminNV.Click += new System.EventHandler(this.Button_AdminNV_Click);
            // 
            // button_AdminBan
            // 
            this.button_AdminBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AdminBan.Location = new System.Drawing.Point(26, 371);
            this.button_AdminBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AdminBan.Name = "button_AdminBan";
            this.button_AdminBan.Size = new System.Drawing.Size(284, 155);
            this.button_AdminBan.TabIndex = 2;
            this.button_AdminBan.Text = "QUẢN LÝ BÀN";
            this.button_AdminBan.UseVisualStyleBackColor = true;
            this.button_AdminBan.Click += new System.EventHandler(this.button_AdminBan_Click);
            // 
            // button_AdminDV
            // 
            this.button_AdminDV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AdminDV.Location = new System.Drawing.Point(26, 191);
            this.button_AdminDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AdminDV.Name = "button_AdminDV";
            this.button_AdminDV.Size = new System.Drawing.Size(284, 155);
            this.button_AdminDV.TabIndex = 1;
            this.button_AdminDV.Text = "QUẢN LÝ DỊCH VỤ";
            this.button_AdminDV.UseVisualStyleBackColor = true;
            this.button_AdminDV.Click += new System.EventHandler(this.Button_AdminDV_Click);
            // 
            // button_AdminThongKe
            // 
            this.button_AdminThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_AdminThongKe.Location = new System.Drawing.Point(26, 551);
            this.button_AdminThongKe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_AdminThongKe.Name = "button_AdminThongKe";
            this.button_AdminThongKe.Size = new System.Drawing.Size(284, 155);
            this.button_AdminThongKe.TabIndex = 3;
            this.button_AdminThongKe.Text = "THỐNG KÊ";
            this.button_AdminThongKe.UseVisualStyleBackColor = true;
            this.button_AdminThongKe.Click += new System.EventHandler(this.Button_AdminThongKe_Click);
            // 
            // panel_AdminNhanVien
            // 
            this.panel_AdminNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_AdminNhanVien.BackColor = System.Drawing.Color.White;
            this.panel_AdminNhanVien.Controls.Add(this.linkLabel_AccountToApprove);
            this.panel_AdminNhanVien.Controls.Add(this.button_SuaNhanVien);
            this.panel_AdminNhanVien.Controls.Add(this.button_ThemNhanVien);
            this.panel_AdminNhanVien.Controls.Add(this.button_XoaNhanVien);
            this.panel_AdminNhanVien.Controls.Add(this.dateTimePicker1);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_TenDangNhap);
            this.panel_AdminNhanVien.Controls.Add(this.label1);
            this.panel_AdminNhanVien.Controls.Add(this.button_NVSave);
            this.panel_AdminNhanVien.Controls.Add(this.checkBox_QuyenAdmin);
            this.panel_AdminNhanVien.Controls.Add(this.label_QuyenAdmin);
            this.panel_AdminNhanVien.Controls.Add(this.label_idNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_idNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_CCCDNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_CCCDNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_NgaySinhNV);
            this.panel_AdminNhanVien.Controls.Add(this.label_TenNV);
            this.panel_AdminNhanVien.Controls.Add(this.textBox_TenNhanVien);
            this.panel_AdminNhanVien.Controls.Add(this.dataGridView_NhanVien);
            this.panel_AdminNhanVien.Location = new System.Drawing.Point(360, 18);
            this.panel_AdminNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.panel_AdminNhanVien.Name = "panel_AdminNhanVien";
            this.panel_AdminNhanVien.Size = new System.Drawing.Size(1300, 900);
            this.panel_AdminNhanVien.TabIndex = 1;
            // 
            // linkLabel_AccountToApprove
            // 
            this.linkLabel_AccountToApprove.AutoSize = true;
            this.linkLabel_AccountToApprove.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_AccountToApprove.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel_AccountToApprove.Location = new System.Drawing.Point(615, 681);
            this.linkLabel_AccountToApprove.Name = "linkLabel_AccountToApprove";
            this.linkLabel_AccountToApprove.Size = new System.Drawing.Size(366, 25);
            this.linkLabel_AccountToApprove.TabIndex = 21;
            this.linkLabel_AccountToApprove.TabStop = true;
            this.linkLabel_AccountToApprove.Text = "Hiển thị danh sách tài khoản chờ được duyệt";
            this.linkLabel_AccountToApprove.VisitedLinkColor = System.Drawing.Color.Blue;
            this.linkLabel_AccountToApprove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_AccountToApprove_LinkClicked);
            // 
            // button_SuaNhanVien
            // 
            this.button_SuaNhanVien.Location = new System.Drawing.Point(839, 567);
            this.button_SuaNhanVien.Name = "button_SuaNhanVien";
            this.button_SuaNhanVien.Size = new System.Drawing.Size(181, 52);
            this.button_SuaNhanVien.TabIndex = 20;
            this.button_SuaNhanVien.Text = "Chỉnh sửa nhân viên";
            this.button_SuaNhanVien.UseVisualStyleBackColor = true;
            // 
            // button_ThemNhanVien
            // 
            this.button_ThemNhanVien.Location = new System.Drawing.Point(615, 567);
            this.button_ThemNhanVien.Name = "button_ThemNhanVien";
            this.button_ThemNhanVien.Size = new System.Drawing.Size(160, 52);
            this.button_ThemNhanVien.TabIndex = 19;
            this.button_ThemNhanVien.Text = "Thêm nhân viên";
            this.button_ThemNhanVien.UseVisualStyleBackColor = true;
            // 
            // button_XoaNhanVien
            // 
            this.button_XoaNhanVien.Location = new System.Drawing.Point(1081, 567);
            this.button_XoaNhanVien.Name = "button_XoaNhanVien";
            this.button_XoaNhanVien.Size = new System.Drawing.Size(160, 52);
            this.button_XoaNhanVien.TabIndex = 18;
            this.button_XoaNhanVien.Text = "Xóa nhân viên";
            this.button_XoaNhanVien.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(757, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 31);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 29, 16, 19, 40, 0);
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(762, 465);
            this.textBox_TenDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(413, 31);
            this.textBox_TenDangNhap.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(615, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tên đăng nhập";
            // 
            // button_NVSave
            // 
            this.button_NVSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_NVSave.BackColor = System.Drawing.Color.White;
            this.button_NVSave.Location = new System.Drawing.Point(1081, 771);
            this.button_NVSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_NVSave.Name = "button_NVSave";
            this.button_NVSave.Size = new System.Drawing.Size(174, 84);
            this.button_NVSave.TabIndex = 14;
            this.button_NVSave.Text = "Lưu";
            this.button_NVSave.UseVisualStyleBackColor = false;
            // 
            // checkBox_QuyenAdmin
            // 
            this.checkBox_QuyenAdmin.AutoSize = true;
            this.checkBox_QuyenAdmin.Location = new System.Drawing.Point(762, 395);
            this.checkBox_QuyenAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_QuyenAdmin.Name = "checkBox_QuyenAdmin";
            this.checkBox_QuyenAdmin.Size = new System.Drawing.Size(22, 21);
            this.checkBox_QuyenAdmin.TabIndex = 13;
            this.checkBox_QuyenAdmin.UseVisualStyleBackColor = true;
            // 
            // label_QuyenAdmin
            // 
            this.label_QuyenAdmin.AutoSize = true;
            this.label_QuyenAdmin.Location = new System.Drawing.Point(611, 393);
            this.label_QuyenAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_QuyenAdmin.Name = "label_QuyenAdmin";
            this.label_QuyenAdmin.Size = new System.Drawing.Size(122, 25);
            this.label_QuyenAdmin.TabIndex = 12;
            this.label_QuyenAdmin.Text = "Quyền Admin";
            // 
            // label_idNV
            // 
            this.label_idNV.AutoSize = true;
            this.label_idNV.Location = new System.Drawing.Point(609, 63);
            this.label_idNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idNV.Name = "label_idNV";
            this.label_idNV.Size = new System.Drawing.Size(39, 25);
            this.label_idNV.TabIndex = 8;
            this.label_idNV.Text = "ID: ";
            // 
            // textBox_idNV
            // 
            this.textBox_idNV.Enabled = false;
            this.textBox_idNV.Location = new System.Drawing.Point(757, 57);
            this.textBox_idNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idNV.Name = "textBox_idNV";
            this.textBox_idNV.Size = new System.Drawing.Size(418, 31);
            this.textBox_idNV.TabIndex = 7;
            // 
            // label_CCCDNV
            // 
            this.label_CCCDNV.AutoSize = true;
            this.label_CCCDNV.Location = new System.Drawing.Point(609, 313);
            this.label_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_CCCDNV.Name = "label_CCCDNV";
            this.label_CCCDNV.Size = new System.Drawing.Size(144, 25);
            this.label_CCCDNV.TabIndex = 6;
            this.label_CCCDNV.Text = "Số CCCD/CMND";
            // 
            // textBox_CCCDNV
            // 
            this.textBox_CCCDNV.Location = new System.Drawing.Point(757, 307);
            this.textBox_CCCDNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_CCCDNV.Name = "textBox_CCCDNV";
            this.textBox_CCCDNV.Size = new System.Drawing.Size(418, 31);
            this.textBox_CCCDNV.TabIndex = 5;
            // 
            // label_NgaySinhNV
            // 
            this.label_NgaySinhNV.AutoSize = true;
            this.label_NgaySinhNV.Location = new System.Drawing.Point(609, 232);
            this.label_NgaySinhNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinhNV.Name = "label_NgaySinhNV";
            this.label_NgaySinhNV.Size = new System.Drawing.Size(100, 25);
            this.label_NgaySinhNV.TabIndex = 4;
            this.label_NgaySinhNV.Text = "Ngày sinh: ";
            // 
            // label_TenNV
            // 
            this.label_TenNV.AutoSize = true;
            this.label_TenNV.Location = new System.Drawing.Point(609, 148);
            this.label_TenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenNV.Name = "label_TenNV";
            this.label_TenNV.Size = new System.Drawing.Size(119, 25);
            this.label_TenNV.TabIndex = 2;
            this.label_TenNV.Text = "Tên nhân viên";
            // 
            // textBox_TenNhanVien
            // 
            this.textBox_TenNhanVien.Location = new System.Drawing.Point(757, 142);
            this.textBox_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenNhanVien.Name = "textBox_TenNhanVien";
            this.textBox_TenNhanVien.Size = new System.Drawing.Size(418, 31);
            this.textBox_TenNhanVien.TabIndex = 1;
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
            this.dataGridView_NhanVien.Location = new System.Drawing.Point(20, 27);
            this.dataGridView_NhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_NhanVien.Name = "dataGridView_NhanVien";
            this.dataGridView_NhanVien.ReadOnly = true;
            this.dataGridView_NhanVien.RowHeadersWidth = 62;
            this.dataGridView_NhanVien.RowTemplate.Height = 25;
            this.dataGridView_NhanVien.Size = new System.Drawing.Size(550, 750);
            this.dataGridView_NhanVien.TabIndex = 0;
            this.dataGridView_NhanVien.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView_NhanVien_RowStateChanged);
            // 
            // IDNV
            // 
            this.IDNV.HeaderText = "Mã NV";
            this.IDNV.MinimumWidth = 8;
            this.IDNV.Name = "IDNV";
            this.IDNV.ReadOnly = true;
            this.IDNV.Width = 102;
            // 
            // HOTENNV
            // 
            this.HOTENNV.HeaderText = "Họ tên NV";
            this.HOTENNV.MinimumWidth = 8;
            this.HOTENNV.Name = "HOTENNV";
            this.HOTENNV.ReadOnly = true;
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
            this.NGAYSINH.ReadOnly = true;
            this.NGAYSINH.Width = 127;
            // 
            // CCCD
            // 
            this.CCCD.HeaderText = "Số CCCD/CMND";
            this.CCCD.MinimumWidth = 8;
            this.CCCD.Name = "CCCD";
            this.CCCD.ReadOnly = true;
            this.CCCD.Width = 180;
            // 
            // MATKHAU
            // 
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.MinimumWidth = 8;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Visible = false;
            this.MATKHAU.Width = 150;
            // 
            // QUYENADMIN
            // 
            this.QUYENADMIN.HeaderText = "Quyền QTV";
            this.QUYENADMIN.MinimumWidth = 8;
            this.QUYENADMIN.Name = "QUYENADMIN";
            this.QUYENADMIN.ReadOnly = true;
            this.QUYENADMIN.Width = 138;
            // 
            // TENDANGNHAP
            // 
            this.TENDANGNHAP.HeaderText = "Tên đăng nhập";
            this.TENDANGNHAP.MinimumWidth = 8;
            this.TENDANGNHAP.Name = "TENDANGNHAP";
            this.TENDANGNHAP.ReadOnly = true;
            this.TENDANGNHAP.Width = 165;
            // 
            // panel_AdminDichVu
            // 
            this.panel_AdminDichVu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_AdminDichVu.BackColor = System.Drawing.Color.White;
            this.panel_AdminDichVu.Controls.Add(this.button_ThemDV);
            this.panel_AdminDichVu.Controls.Add(this.button_DVSave);
            this.panel_AdminDichVu.Controls.Add(this.textBox1);
            this.panel_AdminDichVu.Controls.Add(this.label_GiaTienDV);
            this.panel_AdminDichVu.Controls.Add(this.textBox_TenDV);
            this.panel_AdminDichVu.Controls.Add(this.label_TenDV);
            this.panel_AdminDichVu.Controls.Add(this.textBox_idDV);
            this.panel_AdminDichVu.Controls.Add(this.label1_idDV);
            this.panel_AdminDichVu.Controls.Add(this.dataGridView_DichVu);
            this.panel_AdminDichVu.Location = new System.Drawing.Point(360, 18);
            this.panel_AdminDichVu.Margin = new System.Windows.Forms.Padding(0);
            this.panel_AdminDichVu.Name = "panel_AdminDichVu";
            this.panel_AdminDichVu.Size = new System.Drawing.Size(1300, 900);
            this.panel_AdminDichVu.TabIndex = 2;
            this.panel_AdminDichVu.Visible = false;
            // 
            // button_ThemDV
            // 
            this.button_ThemDV.Location = new System.Drawing.Point(744, 414);
            this.button_ThemDV.Name = "button_ThemDV";
            this.button_ThemDV.Size = new System.Drawing.Size(112, 34);
            this.button_ThemDV.TabIndex = 8;
            this.button_ThemDV.Text = "Thêm";
            this.button_ThemDV.UseVisualStyleBackColor = true;
            // 
            // button_DVSave
            // 
            this.button_DVSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_DVSave.Location = new System.Drawing.Point(1065, 755);
            this.button_DVSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_DVSave.Name = "button_DVSave";
            this.button_DVSave.Size = new System.Drawing.Size(190, 100);
            this.button_DVSave.TabIndex = 7;
            this.button_DVSave.Text = "Lưu";
            this.button_DVSave.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(751, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(418, 31);
            this.textBox1.TabIndex = 6;
            // 
            // label_GiaTienDV
            // 
            this.label_GiaTienDV.AutoSize = true;
            this.label_GiaTienDV.Location = new System.Drawing.Point(610, 308);
            this.label_GiaTienDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GiaTienDV.Name = "label_GiaTienDV";
            this.label_GiaTienDV.Size = new System.Drawing.Size(75, 25);
            this.label_GiaTienDV.TabIndex = 5;
            this.label_GiaTienDV.Text = "Giá tiền:";
            // 
            // textBox_TenDV
            // 
            this.textBox_TenDV.Location = new System.Drawing.Point(751, 173);
            this.textBox_TenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenDV.Name = "textBox_TenDV";
            this.textBox_TenDV.Size = new System.Drawing.Size(418, 31);
            this.textBox_TenDV.TabIndex = 4;
            // 
            // label_TenDV
            // 
            this.label_TenDV.AutoSize = true;
            this.label_TenDV.Location = new System.Drawing.Point(610, 187);
            this.label_TenDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenDV.Name = "label_TenDV";
            this.label_TenDV.Size = new System.Drawing.Size(104, 25);
            this.label_TenDV.TabIndex = 3;
            this.label_TenDV.Text = "Tên dịch vụ:";
            // 
            // textBox_idDV
            // 
            this.textBox_idDV.Location = new System.Drawing.Point(751, 67);
            this.textBox_idDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idDV.Name = "textBox_idDV";
            this.textBox_idDV.Size = new System.Drawing.Size(418, 31);
            this.textBox_idDV.TabIndex = 2;
            // 
            // label1_idDV
            // 
            this.label1_idDV.AutoSize = true;
            this.label1_idDV.Location = new System.Drawing.Point(610, 80);
            this.label1_idDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_idDV.Name = "label1_idDV";
            this.label1_idDV.Size = new System.Drawing.Size(99, 25);
            this.label1_idDV.TabIndex = 1;
            this.label1_idDV.Text = "Mã dịch vụ";
            // 
            // dataGridView_DichVu
            // 
            this.dataGridView_DichVu.AllowUserToAddRows = false;
            this.dataGridView_DichVu.AllowUserToDeleteRows = false;
            this.dataGridView_DichVu.AllowUserToResizeRows = false;
            this.dataGridView_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDDV,
            this.TENDV,
            this.GIATIEN});
            this.dataGridView_DichVu.Location = new System.Drawing.Point(26, 27);
            this.dataGridView_DichVu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_DichVu.Name = "dataGridView_DichVu";
            this.dataGridView_DichVu.RowHeadersWidth = 62;
            this.dataGridView_DichVu.RowTemplate.Height = 25;
            this.dataGridView_DichVu.Size = new System.Drawing.Size(544, 743);
            this.dataGridView_DichVu.TabIndex = 0;
            // 
            // IDDV
            // 
            this.IDDV.HeaderText = "Mã dịch vụ";
            this.IDDV.MinimumWidth = 8;
            this.IDDV.Name = "IDDV";
            this.IDDV.Width = 150;
            // 
            // TENDV
            // 
            this.TENDV.HeaderText = "Tên dịch vụ";
            this.TENDV.MinimumWidth = 8;
            this.TENDV.Name = "TENDV";
            this.TENDV.Width = 150;
            // 
            // GIATIEN
            // 
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = "_";
            this.GIATIEN.DefaultCellStyle = dataGridViewCellStyle2;
            this.GIATIEN.HeaderText = "Giá tiền";
            this.GIATIEN.MinimumWidth = 8;
            this.GIATIEN.Name = "GIATIEN";
            this.GIATIEN.Width = 150;
            // 
            // panel_AdminBan
            // 
            this.panel_AdminBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_AdminBan.BackColor = System.Drawing.Color.White;
            this.panel_AdminBan.Controls.Add(this.button_BanSave);
            this.panel_AdminBan.Controls.Add(this.textBox2);
            this.panel_AdminBan.Controls.Add(this.label_GiaTienBan);
            this.panel_AdminBan.Controls.Add(this.textBox_idBan);
            this.panel_AdminBan.Controls.Add(this.label_idBan);
            this.panel_AdminBan.Controls.Add(this.dataGridView_Ban);
            this.panel_AdminBan.Location = new System.Drawing.Point(360, 18);
            this.panel_AdminBan.Margin = new System.Windows.Forms.Padding(0);
            this.panel_AdminBan.Name = "panel_AdminBan";
            this.panel_AdminBan.Size = new System.Drawing.Size(1300, 900);
            this.panel_AdminBan.TabIndex = 3;
            this.panel_AdminBan.Visible = false;
            // 
            // button_BanSave
            // 
            this.button_BanSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_BanSave.Location = new System.Drawing.Point(1065, 755);
            this.button_BanSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_BanSave.Name = "button_BanSave";
            this.button_BanSave.Size = new System.Drawing.Size(190, 100);
            this.button_BanSave.TabIndex = 5;
            this.button_BanSave.Text = "Lưu";
            this.button_BanSave.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(757, 193);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(405, 31);
            this.textBox2.TabIndex = 4;
            // 
            // label_GiaTienBan
            // 
            this.label_GiaTienBan.AutoSize = true;
            this.label_GiaTienBan.Location = new System.Drawing.Point(613, 198);
            this.label_GiaTienBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GiaTienBan.Name = "label_GiaTienBan";
            this.label_GiaTienBan.Size = new System.Drawing.Size(75, 25);
            this.label_GiaTienBan.TabIndex = 3;
            this.label_GiaTienBan.Text = "Giá tiền:";
            // 
            // textBox_idBan
            // 
            this.textBox_idBan.Location = new System.Drawing.Point(757, 88);
            this.textBox_idBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idBan.Name = "textBox_idBan";
            this.textBox_idBan.Size = new System.Drawing.Size(405, 31);
            this.textBox_idBan.TabIndex = 2;
            // 
            // label_idBan
            // 
            this.label_idBan.AutoSize = true;
            this.label_idBan.Location = new System.Drawing.Point(613, 93);
            this.label_idBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idBan.Name = "label_idBan";
            this.label_idBan.Size = new System.Drawing.Size(76, 25);
            this.label_idBan.TabIndex = 1;
            this.label_idBan.Text = "Mã bàn:";
            // 
            // dataGridView_Ban
            // 
            this.dataGridView_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDBAN,
            this.dataGridViewTextBoxColumn1,
            this.TRANGTHAI});
            this.dataGridView_Ban.Location = new System.Drawing.Point(24, 27);
            this.dataGridView_Ban.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_Ban.Name = "dataGridView_Ban";
            this.dataGridView_Ban.RowHeadersWidth = 62;
            this.dataGridView_Ban.RowTemplate.Height = 25;
            this.dataGridView_Ban.Size = new System.Drawing.Size(534, 743);
            this.dataGridView_Ban.TabIndex = 0;
            // 
            // IDBAN
            // 
            this.IDBAN.HeaderText = "Mã bàn";
            this.IDBAN.MinimumWidth = 8;
            this.IDBAN.Name = "IDBAN";
            this.IDBAN.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Giá tiền";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.HeaderText = "Trạng thái";
            this.TRANGTHAI.MinimumWidth = 8;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Width = 150;
            // 
            // panel_ThongKe
            // 
            this.panel_ThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_ThongKe.Location = new System.Drawing.Point(360, 18);
            this.panel_ThongKe.Margin = new System.Windows.Forms.Padding(0);
            this.panel_ThongKe.Name = "panel_ThongKe";
            this.panel_ThongKe.Size = new System.Drawing.Size(1300, 900);
            this.panel_ThongKe.TabIndex = 6;
            this.panel_ThongKe.Visible = false;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 937);
            this.Controls.Add(this.panel_AdminControl);
            this.Controls.Add(this.panel_AdminNhanVien);
            this.Controls.Add(this.panel_ThongKe);
            this.Controls.Add(this.panel_AdminBan);
            this.Controls.Add(this.panel_AdminDichVu);
            this.MinimizeBox = false;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel_AdminControl.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_AdminNhanVien.ResumeLayout(false);
            this.panel_AdminNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_NhanVien)).EndInit();
            this.panel_AdminDichVu.ResumeLayout(false);
            this.panel_AdminDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DichVu)).EndInit();
            this.panel_AdminBan.ResumeLayout(false);
            this.panel_AdminBan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ban)).EndInit();
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
        private Label label_TenNV;
        private TextBox textBox_TenNhanVien;
        private DataGridView dataGridView_NhanVien;
        private Label label_idNV;
        private TextBox textBox_idNV;
        private Label label_CCCDNV;
        private TextBox textBox_CCCDNV;
        private Button button_NVSave;
        private CheckBox checkBox_QuyenAdmin;
        private Label label_QuyenAdmin;
        private Panel panel_AdminDichVu;
        private TextBox textBox_TenDV;
        private Label label_TenDV;
        private TextBox textBox_idDV;
        private Label label1_idDV;
        private DataGridView dataGridView_DichVu;
        private TextBox textBox1;
        private Label label_GiaTienDV;
        private Button button_DVSave;
        private Panel panel_AdminBan;
        private DataGridView dataGridView_Ban;
        private TextBox textBox_idBan;
        private Label label_idBan;
        private TextBox textBox2;
        private Label label_GiaTienBan;
        private Button button_BanSave;
        private Panel panel_ThongKe;
        private TextBox textBox_TenDangNhap;
        private Label label1;
        private DataGridViewTextBoxColumn IDNV;
        private DataGridViewTextBoxColumn HOTENNV;
        private DataGridViewTextBoxColumn NGAYSINH;
        private DataGridViewTextBoxColumn CCCD;
        private DataGridViewTextBoxColumn MATKHAU;
        private DataGridViewTextBoxColumn QUYENADMIN;
        private DataGridViewTextBoxColumn TENDANGNHAP;
        private DataGridViewTextBoxColumn IDDV;
        private DataGridViewTextBoxColumn TENDV;
        private DataGridViewTextBoxColumn GIATIEN;
        private DataGridViewTextBoxColumn IDBAN;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TRANGTHAI;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dateTimePicker1;
        private Button button_ThemDV;
        private Button button_SuaNhanVien;
        private Button button_ThemNhanVien;
        private Button button_XoaNhanVien;
        private LinkLabel linkLabel_AccountToApprove;
    }
}