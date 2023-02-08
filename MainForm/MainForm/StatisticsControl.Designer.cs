namespace MainForm
{
    partial class StatisticsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsControl));
            this.splitContainer_Main = new System.Windows.Forms.SplitContainer();
            this.splitContainer_Top = new System.Windows.Forms.SplitContainer();
            this.groupBox_Info = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_AxisColor = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_GroupBy = new System.Windows.Forms.ComboBox();
            this.button_BarBorderColor = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.button_BarColor = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TableType = new System.Windows.Forms.ComboBox();
            this.groupBox_KetQua = new System.Windows.Forms.GroupBox();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_AverageValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MinValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaxValue = new System.Windows.Forms.TextBox();
            this.groupBox_Chart = new System.Windows.Forms.GroupBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.button_PageDecrease = new System.Windows.Forms.Button();
            this.label_Page = new System.Windows.Forms.Label();
            this.button_PageIncrease = new System.Windows.Forms.Button();
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.imageList32x32 = new System.Windows.Forms.ImageList(this.components);
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.checkBox_ValueLabel = new System.Windows.Forms.CheckBox();
            this.panel_Chart = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Top)).BeginInit();
            this.splitContainer_Top.Panel1.SuspendLayout();
            this.splitContainer_Top.Panel2.SuspendLayout();
            this.splitContainer_Top.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox_KetQua.SuspendLayout();
            this.groupBox_Chart.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.AutoScroll = true;
            this.splitContainer_Main.Panel1.Controls.Add(this.splitContainer_Top);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.groupBox_Chart);
            this.splitContainer_Main.Size = new System.Drawing.Size(1346, 1035);
            this.splitContainer_Main.SplitterDistance = 520;
            this.splitContainer_Main.TabIndex = 0;
            // 
            // splitContainer_Top
            // 
            this.splitContainer_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Top.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_Top.IsSplitterFixed = true;
            this.splitContainer_Top.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Top.Name = "splitContainer_Top";
            this.splitContainer_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Top.Panel1
            // 
            this.splitContainer_Top.Panel1.AutoScroll = true;
            this.splitContainer_Top.Panel1.Controls.Add(this.groupBox_Info);
            // 
            // splitContainer_Top.Panel2
            // 
            this.splitContainer_Top.Panel2.Controls.Add(this.groupBox_KetQua);
            this.splitContainer_Top.Panel2Collapsed = true;
            this.splitContainer_Top.Size = new System.Drawing.Size(1346, 520);
            this.splitContainer_Top.SplitterDistance = 410;
            this.splitContainer_Top.TabIndex = 0;
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Info.Controls.Add(this.groupBox1);
            this.groupBox_Info.Controls.Add(this.label_Name);
            this.groupBox_Info.Controls.Add(this.comboBox_Name);
            this.groupBox_Info.Controls.Add(this.dateTimePicker_EndDate);
            this.groupBox_Info.Controls.Add(this.dateTimePicker_StartDate);
            this.groupBox_Info.Controls.Add(this.label2);
            this.groupBox_Info.Controls.Add(this.label1);
            this.groupBox_Info.Controls.Add(this.label_ID);
            this.groupBox_Info.Controls.Add(this.comboBox_ID);
            this.groupBox_Info.Controls.Add(this.label4);
            this.groupBox_Info.Controls.Add(this.comboBox_TableType);
            this.groupBox_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Info.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(1346, 520);
            this.groupBox_Info.TabIndex = 6;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Thông tin hiển thị";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1340, 288);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy chỉnh biểu đồ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.button_AxisColor);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_GroupBy);
            this.panel1.Controls.Add(this.button_BarBorderColor);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.button_BarColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1334, 258);
            this.panel1.TabIndex = 13;
            // 
            // button_AxisColor
            // 
            this.button_AxisColor.Location = new System.Drawing.Point(252, 115);
            this.button_AxisColor.Name = "button_AxisColor";
            this.button_AxisColor.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.button_AxisColor.Size = new System.Drawing.Size(39, 34);
            this.button_AxisColor.TabIndex = 14;
            this.button_AxisColor.UseVisualStyleBackColor = true;
            this.button_AxisColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(67, 120);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label11.Size = new System.Drawing.Size(82, 45);
            this.label11.TabIndex = 13;
            this.label11.Text = "Màu trục";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Màu cột";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hiển thị doanh thu từng cột theo";
            // 
            // comboBox_GroupBy
            // 
            this.comboBox_GroupBy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_GroupBy.FormattingEnabled = true;
            this.comboBox_GroupBy.Items.AddRange(new object[] {
            "Mã số",
            "Thời gian - Ngày",
            "Thời gian - Tháng"});
            this.comboBox_GroupBy.Location = new System.Drawing.Point(889, 22);
            this.comboBox_GroupBy.Name = "comboBox_GroupBy";
            this.comboBox_GroupBy.Size = new System.Drawing.Size(177, 33);
            this.comboBox_GroupBy.TabIndex = 11;
            this.comboBox_GroupBy.SelectedIndexChanged += new System.EventHandler(this.ComboBox_GroupBy_SelectedIndexChanged);
            // 
            // button_BarBorderColor
            // 
            this.button_BarBorderColor.Location = new System.Drawing.Point(252, 66);
            this.button_BarBorderColor.Name = "button_BarBorderColor";
            this.button_BarBorderColor.Size = new System.Drawing.Size(39, 34);
            this.button_BarBorderColor.TabIndex = 3;
            this.button_BarBorderColor.UseVisualStyleBackColor = true;
            this.button_BarBorderColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(67, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Màu viền";
            // 
            // button_BarColor
            // 
            this.button_BarColor.Location = new System.Drawing.Point(252, 17);
            this.button_BarColor.Name = "button_BarColor";
            this.button_BarColor.Size = new System.Drawing.Size(39, 34);
            this.button_BarColor.TabIndex = 1;
            this.button_BarColor.UseVisualStyleBackColor = true;
            this.button_BarColor.Click += new System.EventHandler(this.ButtonColor_Click);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(598, 118);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 25);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "Tên";
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(895, 104);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(168, 33);
            this.comboBox_Name.Sorted = true;
            this.comboBox_Name.TabIndex = 13;
            this.comboBox_Name.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Name_SelectedIndexChanged);
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_EndDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(895, 175);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(258, 175);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_StartDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thời điểm kết thúc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thời điểm bắt đầu";
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(73, 118);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(61, 25);
            this.label_ID.TabIndex = 11;
            this.label_ID.Text = "Mã số";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(258, 110);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(168, 33);
            this.comboBox_ID.Sorted = true;
            this.comboBox_ID.TabIndex = 10;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Loại đối tượng";
            // 
            // comboBox_TableType
            // 
            this.comboBox_TableType.FormattingEnabled = true;
            this.comboBox_TableType.Items.AddRange(new object[] {
            "Hóa đơn",
            "Dịch vụ",
            "Khách hàng",
            "Nhân viên",
            "Bàn"});
            this.comboBox_TableType.Location = new System.Drawing.Point(258, 50);
            this.comboBox_TableType.Name = "comboBox_TableType";
            this.comboBox_TableType.Size = new System.Drawing.Size(168, 33);
            this.comboBox_TableType.TabIndex = 8;
            this.comboBox_TableType.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_TableType_SelectionChangeCommitted);
            // 
            // groupBox_KetQua
            // 
            this.groupBox_KetQua.Controls.Add(this.textBox_Total);
            this.groupBox_KetQua.Controls.Add(this.label8);
            this.groupBox_KetQua.Controls.Add(this.label7);
            this.groupBox_KetQua.Controls.Add(this.textBox_AverageValue);
            this.groupBox_KetQua.Controls.Add(this.label6);
            this.groupBox_KetQua.Controls.Add(this.textBox_MinValue);
            this.groupBox_KetQua.Controls.Add(this.label5);
            this.groupBox_KetQua.Controls.Add(this.textBox_MaxValue);
            this.groupBox_KetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_KetQua.Location = new System.Drawing.Point(0, 0);
            this.groupBox_KetQua.Name = "groupBox_KetQua";
            this.groupBox_KetQua.Size = new System.Drawing.Size(150, 46);
            this.groupBox_KetQua.TabIndex = 0;
            this.groupBox_KetQua.TabStop = false;
            this.groupBox_KetQua.Text = "Kết quả";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Location = new System.Drawing.Point(154, 59);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(150, 31);
            this.textBox_Total.TabIndex = 7;
            this.textBox_Total.WordWrap = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tổng cộng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1002, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trung bình:";
            // 
            // textBox_AverageValue
            // 
            this.textBox_AverageValue.Location = new System.Drawing.Point(1108, 53);
            this.textBox_AverageValue.Name = "textBox_AverageValue";
            this.textBox_AverageValue.ReadOnly = true;
            this.textBox_AverageValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_AverageValue.TabIndex = 4;
            this.textBox_AverageValue.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(694, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thấp nhất:";
            // 
            // textBox_MinValue
            // 
            this.textBox_MinValue.Location = new System.Drawing.Point(795, 53);
            this.textBox_MinValue.Name = "textBox_MinValue";
            this.textBox_MinValue.ReadOnly = true;
            this.textBox_MinValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_MinValue.TabIndex = 2;
            this.textBox_MinValue.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(393, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cao nhất:";
            // 
            // textBox_MaxValue
            // 
            this.textBox_MaxValue.Location = new System.Drawing.Point(486, 56);
            this.textBox_MaxValue.Name = "textBox_MaxValue";
            this.textBox_MaxValue.ReadOnly = true;
            this.textBox_MaxValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_MaxValue.TabIndex = 0;
            this.textBox_MaxValue.WordWrap = false;
            // 
            // groupBox_Chart
            // 
            this.groupBox_Chart.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox_Chart.Controls.Add(this.buttonShow);
            this.groupBox_Chart.Controls.Add(this.button_PageDecrease);
            this.groupBox_Chart.Controls.Add(this.label_Page);
            this.groupBox_Chart.Controls.Add(this.button_PageIncrease);
            this.groupBox_Chart.Controls.Add(this.button_ZoomOut);
            this.groupBox_Chart.Controls.Add(this.button_ZoomIn);
            this.groupBox_Chart.Controls.Add(this.checkBox_ValueLabel);
            this.groupBox_Chart.Controls.Add(this.panel_Chart);
            this.groupBox_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Chart.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Chart.Name = "groupBox_Chart";
            this.groupBox_Chart.Size = new System.Drawing.Size(1346, 511);
            this.groupBox_Chart.TabIndex = 5;
            this.groupBox_Chart.TabStop = false;
            this.groupBox_Chart.Text = "Biểu đồ";
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShow.BackColor = System.Drawing.Color.White;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.ImageKey = "play-button-green-icon.png";
            this.buttonShow.ImageList = this.imageListSmall;
            this.buttonShow.Location = new System.Drawing.Point(986, 36);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(122, 32);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Hiển thị";
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "play-button-green-icon.png");
            // 
            // button_PageDecrease
            // 
            this.button_PageDecrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PageDecrease.BackColor = System.Drawing.Color.White;
            this.button_PageDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PageDecrease.Enabled = false;
            this.button_PageDecrease.FlatAppearance.BorderSize = 0;
            this.button_PageDecrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_PageDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PageDecrease.Image = global::MainForm.Properties.Resources.LeftCap;
            this.button_PageDecrease.Location = new System.Drawing.Point(1122, 36);
            this.button_PageDecrease.Name = "button_PageDecrease";
            this.button_PageDecrease.Size = new System.Drawing.Size(26, 32);
            this.button_PageDecrease.TabIndex = 15;
            this.button_PageDecrease.UseVisualStyleBackColor = false;
            this.button_PageDecrease.Click += new System.EventHandler(this.Button_PageDecrease_Click);
            // 
            // label_Page
            // 
            this.label_Page.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Page.AutoEllipsis = true;
            this.label_Page.BackColor = System.Drawing.Color.White;
            this.label_Page.Location = new System.Drawing.Point(1152, 36);
            this.label_Page.Name = "label_Page";
            this.label_Page.Size = new System.Drawing.Size(125, 32);
            this.label_Page.TabIndex = 17;
            this.label_Page.Text = "Trang 0/0";
            this.label_Page.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Page.TextChanged += new System.EventHandler(this.Label_Page_TextChanged);
            // 
            // button_PageIncrease
            // 
            this.button_PageIncrease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_PageIncrease.BackColor = System.Drawing.Color.White;
            this.button_PageIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_PageIncrease.Enabled = false;
            this.button_PageIncrease.FlatAppearance.BorderSize = 0;
            this.button_PageIncrease.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_PageIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PageIncrease.Image = global::MainForm.Properties.Resources.RightCap;
            this.button_PageIncrease.Location = new System.Drawing.Point(1280, 36);
            this.button_PageIncrease.Name = "button_PageIncrease";
            this.button_PageIncrease.Size = new System.Drawing.Size(26, 32);
            this.button_PageIncrease.TabIndex = 16;
            this.button_PageIncrease.UseVisualStyleBackColor = false;
            this.button_PageIncrease.Click += new System.EventHandler(this.Button_PageIncrease_Click);
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomOut.BackColor = System.Drawing.Color.White;
            this.button_ZoomOut.FlatAppearance.BorderSize = 0;
            this.button_ZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomOut.ImageIndex = 1;
            this.button_ZoomOut.ImageList = this.imageList32x32;
            this.button_ZoomOut.Location = new System.Drawing.Point(1171, 195);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(135, 45);
            this.button_ZoomOut.TabIndex = 17;
            this.button_ZoomOut.Text = "Thu nhỏ";
            this.button_ZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ZoomOut.UseVisualStyleBackColor = false;
            this.button_ZoomOut.Click += new System.EventHandler(this.Button_ZoomOut_Click);
            // 
            // imageList32x32
            // 
            this.imageList32x32.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageList32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32x32.ImageStream")));
            this.imageList32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList32x32.Images.SetKeyName(0, "ZoomIn.png");
            this.imageList32x32.Images.SetKeyName(1, "ZoomOut.png");
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomIn.BackColor = System.Drawing.Color.White;
            this.button_ZoomIn.FlatAppearance.BorderSize = 0;
            this.button_ZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button_ZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomIn.ImageIndex = 0;
            this.button_ZoomIn.ImageList = this.imageList32x32;
            this.button_ZoomIn.Location = new System.Drawing.Point(1171, 133);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(135, 45);
            this.button_ZoomIn.TabIndex = 18;
            this.button_ZoomIn.Text = "Phóng to";
            this.button_ZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ZoomIn.UseVisualStyleBackColor = false;
            this.button_ZoomIn.Click += new System.EventHandler(this.Button_ZoomIn_Click);
            // 
            // checkBox_ValueLabel
            // 
            this.checkBox_ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ValueLabel.AutoSize = true;
            this.checkBox_ValueLabel.BackColor = System.Drawing.Color.White;
            this.checkBox_ValueLabel.Location = new System.Drawing.Point(1091, 87);
            this.checkBox_ValueLabel.Name = "checkBox_ValueLabel";
            this.checkBox_ValueLabel.Size = new System.Drawing.Size(215, 29);
            this.checkBox_ValueLabel.TabIndex = 16;
            this.checkBox_ValueLabel.Text = "Hiển thị giá trị trên cột";
            this.checkBox_ValueLabel.UseVisualStyleBackColor = false;
            this.checkBox_ValueLabel.CheckedChanged += new System.EventHandler(this.CheckBox_ValueLabel_CheckedChanged);
            // 
            // panel_Chart
            // 
            this.panel_Chart.AutoScroll = true;
            this.panel_Chart.BackColor = System.Drawing.Color.White;
            this.panel_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Chart.Location = new System.Drawing.Point(3, 27);
            this.panel_Chart.Name = "panel_Chart";
            this.panel_Chart.Size = new System.Drawing.Size(1340, 481);
            this.panel_Chart.TabIndex = 3;
            // 
            // StatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitContainer_Main);
            this.DoubleBuffered = true;
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(1346, 1035);
            this.Load += new System.EventHandler(this.StatisticsControl_Load);
            this.splitContainer_Main.Panel1.ResumeLayout(false);
            this.splitContainer_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).EndInit();
            this.splitContainer_Main.ResumeLayout(false);
            this.splitContainer_Top.Panel1.ResumeLayout(false);
            this.splitContainer_Top.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Top)).EndInit();
            this.splitContainer_Top.ResumeLayout(false);
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox_KetQua.ResumeLayout(false);
            this.groupBox_KetQua.PerformLayout();
            this.groupBox_Chart.ResumeLayout(false);
            this.groupBox_Chart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer_Main;
        private GroupBox groupBox_Chart;
        private Panel panel_Chart;
        private SplitContainer splitContainer_Top;
        private GroupBox groupBox_Info;
        private Label label_Name;
        private ComboBox comboBox_Name;
        private DateTimePicker dateTimePicker_EndDate;
        private DateTimePicker dateTimePicker_StartDate;
        private Label label2;
        private Button buttonShow;
        private ComboBox comboBox_GroupBy;
        private Label label3;
        private Label label1;
        private Label label_ID;
        private ComboBox comboBox_ID;
        private Label label4;
        private ComboBox comboBox_TableType;
        private GroupBox groupBox_KetQua;
        private Label label7;
        private TextBox textBox_AverageValue;
        private Label label6;
        private TextBox textBox_MinValue;
        private Label label5;
        private TextBox textBox_MaxValue;
        private ImageList imageList32x32;
        private CheckBox checkBox_ValueLabel;
        private Button button_ZoomIn;
        private Button button_ZoomOut;
        private TextBox textBox_Total;
        private Label label8;
        private Label label_Page;
        private Button button_PageIncrease;
        private Button button_PageDecrease;
        private GroupBox groupBox1;
        private Button button_BarBorderColor;
        private Label label10;
        private Button button_BarColor;
        private Label label9;
        private Panel panel1;
        private ImageList imageListSmall;
        private Button button_AxisColor;
        private Label label11;
    }
}
