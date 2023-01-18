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
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonShow = new System.Windows.Forms.Button();
            this.comboBox_TimeSpan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ID = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_TableType = new System.Windows.Forms.ComboBox();
            this.groupBox_KetQua = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_AverageValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_MinValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_MaxValue = new System.Windows.Forms.TextBox();
            this.groupBox_Chart = new System.Windows.Forms.GroupBox();
            this.panel_Chart = new System.Windows.Forms.Panel();
            this.button_ZoomIn = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button_ZoomOut = new System.Windows.Forms.Button();
            this.checkBox_ValueLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Main)).BeginInit();
            this.splitContainer_Main.Panel1.SuspendLayout();
            this.splitContainer_Main.Panel2.SuspendLayout();
            this.splitContainer_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_Top)).BeginInit();
            this.splitContainer_Top.Panel1.SuspendLayout();
            this.splitContainer_Top.Panel2.SuspendLayout();
            this.splitContainer_Top.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.groupBox_KetQua.SuspendLayout();
            this.groupBox_Chart.SuspendLayout();
            this.panel_Chart.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer_Main
            // 
            this.splitContainer_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_Main.IsSplitterFixed = true;
            this.splitContainer_Main.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_Main.Name = "splitContainer_Main";
            this.splitContainer_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_Main.Panel1
            // 
            this.splitContainer_Main.Panel1.Controls.Add(this.splitContainer_Top);
            // 
            // splitContainer_Main.Panel2
            // 
            this.splitContainer_Main.Panel2.Controls.Add(this.groupBox_Chart);
            this.splitContainer_Main.Size = new System.Drawing.Size(1087, 1035);
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
            this.splitContainer_Top.Panel1.Controls.Add(this.groupBox_Info);
            // 
            // splitContainer_Top.Panel2
            // 
            this.splitContainer_Top.Panel2.Controls.Add(this.groupBox_KetQua);
            this.splitContainer_Top.Size = new System.Drawing.Size(1087, 520);
            this.splitContainer_Top.SplitterDistance = 390;
            this.splitContainer_Top.TabIndex = 0;
            // 
            // groupBox_Info
            // 
            this.groupBox_Info.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Info.Controls.Add(this.label_Name);
            this.groupBox_Info.Controls.Add(this.comboBox_Name);
            this.groupBox_Info.Controls.Add(this.dateTimePicker_EndDate);
            this.groupBox_Info.Controls.Add(this.dateTimePicker_StartDate);
            this.groupBox_Info.Controls.Add(this.label2);
            this.groupBox_Info.Controls.Add(this.buttonShow);
            this.groupBox_Info.Controls.Add(this.comboBox_TimeSpan);
            this.groupBox_Info.Controls.Add(this.label3);
            this.groupBox_Info.Controls.Add(this.label1);
            this.groupBox_Info.Controls.Add(this.label_ID);
            this.groupBox_Info.Controls.Add(this.comboBox_ID);
            this.groupBox_Info.Controls.Add(this.label4);
            this.groupBox_Info.Controls.Add(this.comboBox_TableType);
            this.groupBox_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Info.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Info.Name = "groupBox_Info";
            this.groupBox_Info.Size = new System.Drawing.Size(1087, 390);
            this.groupBox_Info.TabIndex = 6;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Thông tin hiển thị";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(591, 112);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 25);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "Tên";
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(765, 104);
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
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(765, 232);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(258, 231);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_StartDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thời điểm kết thúc";
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonShow.Location = new System.Drawing.Point(452, 303);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(125, 44);
            this.buttonShow.TabIndex = 10;
            this.buttonShow.Text = "Hiển thị";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // comboBox_TimeSpan
            // 
            this.comboBox_TimeSpan.FormattingEnabled = true;
            this.comboBox_TimeSpan.Items.AddRange(new object[] {
            "Ngày",
            "Tháng"});
            this.comboBox_TimeSpan.Location = new System.Drawing.Point(258, 172);
            this.comboBox_TimeSpan.Name = "comboBox_TimeSpan";
            this.comboBox_TimeSpan.Size = new System.Drawing.Size(142, 33);
            this.comboBox_TimeSpan.TabIndex = 11;
            this.comboBox_TimeSpan.SelectedIndexChanged += new System.EventHandler(this.ComboBox_TimeSpan_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hiển thị theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 237);
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
            this.groupBox_KetQua.Controls.Add(this.label7);
            this.groupBox_KetQua.Controls.Add(this.textBox_AverageValue);
            this.groupBox_KetQua.Controls.Add(this.label6);
            this.groupBox_KetQua.Controls.Add(this.textBox_MinValue);
            this.groupBox_KetQua.Controls.Add(this.label5);
            this.groupBox_KetQua.Controls.Add(this.textBox_MaxValue);
            this.groupBox_KetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_KetQua.Location = new System.Drawing.Point(0, 0);
            this.groupBox_KetQua.Name = "groupBox_KetQua";
            this.groupBox_KetQua.Size = new System.Drawing.Size(1087, 126);
            this.groupBox_KetQua.TabIndex = 0;
            this.groupBox_KetQua.TabStop = false;
            this.groupBox_KetQua.Text = "Kết quả";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(676, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Trung bình:";
            // 
            // textBox_AverageValue
            // 
            this.textBox_AverageValue.Location = new System.Drawing.Point(782, 54);
            this.textBox_AverageValue.Name = "textBox_AverageValue";
            this.textBox_AverageValue.ReadOnly = true;
            this.textBox_AverageValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_AverageValue.TabIndex = 4;
            this.textBox_AverageValue.WordWrap = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Thấp nhất:";
            // 
            // textBox_MinValue
            // 
            this.textBox_MinValue.Location = new System.Drawing.Point(469, 54);
            this.textBox_MinValue.Name = "textBox_MinValue";
            this.textBox_MinValue.ReadOnly = true;
            this.textBox_MinValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_MinValue.TabIndex = 2;
            this.textBox_MinValue.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cao nhất:";
            // 
            // textBox_MaxValue
            // 
            this.textBox_MaxValue.Location = new System.Drawing.Point(160, 57);
            this.textBox_MaxValue.Name = "textBox_MaxValue";
            this.textBox_MaxValue.ReadOnly = true;
            this.textBox_MaxValue.Size = new System.Drawing.Size(150, 31);
            this.textBox_MaxValue.TabIndex = 0;
            this.textBox_MaxValue.WordWrap = false;
            // 
            // groupBox_Chart
            // 
            this.groupBox_Chart.Controls.Add(this.panel_Chart);
            this.groupBox_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Chart.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Chart.Name = "groupBox_Chart";
            this.groupBox_Chart.Size = new System.Drawing.Size(1087, 511);
            this.groupBox_Chart.TabIndex = 5;
            this.groupBox_Chart.TabStop = false;
            this.groupBox_Chart.Text = "Biểu đồ";
            // 
            // panel_Chart
            // 
            this.panel_Chart.AutoScroll = true;
            this.panel_Chart.BackColor = System.Drawing.Color.White;
            this.panel_Chart.Controls.Add(this.button_ZoomIn);
            this.panel_Chart.Controls.Add(this.button_ZoomOut);
            this.panel_Chart.Controls.Add(this.checkBox_ValueLabel);
            this.panel_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Chart.Location = new System.Drawing.Point(3, 27);
            this.panel_Chart.Name = "panel_Chart";
            this.panel_Chart.Size = new System.Drawing.Size(1081, 481);
            this.panel_Chart.TabIndex = 3;
            this.panel_Chart.SizeChanged += new System.EventHandler(this.Panel_Chart_SizeChanged);
            // 
            // button_ZoomIn
            // 
            this.button_ZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.button_ZoomIn.FlatAppearance.BorderSize = 0;
            this.button_ZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomIn.ImageIndex = 0;
            this.button_ZoomIn.ImageList = this.imageList;
            this.button_ZoomIn.Location = new System.Drawing.Point(928, 70);
            this.button_ZoomIn.Name = "button_ZoomIn";
            this.button_ZoomIn.Size = new System.Drawing.Size(135, 42);
            this.button_ZoomIn.TabIndex = 15;
            this.button_ZoomIn.Text = "Phóng to";
            this.button_ZoomIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ZoomIn.UseVisualStyleBackColor = false;
            this.button_ZoomIn.Click += new System.EventHandler(this.Button_ZoomIn_Click);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "ZoomIn.png");
            this.imageList.Images.SetKeyName(1, "ZoomOut.png");
            // 
            // button_ZoomOut
            // 
            this.button_ZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.button_ZoomOut.FlatAppearance.BorderSize = 0;
            this.button_ZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ZoomOut.ImageIndex = 1;
            this.button_ZoomOut.ImageList = this.imageList;
            this.button_ZoomOut.Location = new System.Drawing.Point(928, 131);
            this.button_ZoomOut.Name = "button_ZoomOut";
            this.button_ZoomOut.Size = new System.Drawing.Size(135, 42);
            this.button_ZoomOut.TabIndex = 14;
            this.button_ZoomOut.Text = "Thu nhỏ";
            this.button_ZoomOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ZoomOut.UseVisualStyleBackColor = false;
            this.button_ZoomOut.Click += new System.EventHandler(this.Button_ZoomOut_Click);
            // 
            // checkBox_ValueLabel
            // 
            this.checkBox_ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ValueLabel.AutoSize = true;
            this.checkBox_ValueLabel.Location = new System.Drawing.Point(848, 20);
            this.checkBox_ValueLabel.Name = "checkBox_ValueLabel";
            this.checkBox_ValueLabel.Size = new System.Drawing.Size(215, 29);
            this.checkBox_ValueLabel.TabIndex = 13;
            this.checkBox_ValueLabel.Text = "Hiển thị giá trị trên cột";
            this.checkBox_ValueLabel.UseVisualStyleBackColor = true;
            this.checkBox_ValueLabel.CheckedChanged += new System.EventHandler(this.CheckBox_ValueLabel_CheckedChanged);
            // 
            // StatisticsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.splitContainer_Main);
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(1087, 1035);
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
            this.groupBox_KetQua.ResumeLayout(false);
            this.groupBox_KetQua.PerformLayout();
            this.groupBox_Chart.ResumeLayout(false);
            this.panel_Chart.ResumeLayout(false);
            this.panel_Chart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer_Main;
        private CheckBox checkBox_ValueLabel;
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
        private ComboBox comboBox_TimeSpan;
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
        private Button button_ZoomIn;
        private Button button_ZoomOut;
        private ImageList imageList;
    }
}
