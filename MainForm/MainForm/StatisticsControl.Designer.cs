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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.groupBox_Chart = new System.Windows.Forms.GroupBox();
            this.panel_Chart = new System.Windows.Forms.Panel();
            this.checkBox_ValueLabel = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox_Info.SuspendLayout();
            this.groupBox_Chart.SuspendLayout();
            this.panel_Chart.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox_Info);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_Chart);
            this.splitContainer1.Size = new System.Drawing.Size(1055, 915);
            this.splitContainer1.SplitterDistance = 415;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox_Info
            // 
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
            this.groupBox_Info.Size = new System.Drawing.Size(1055, 415);
            this.groupBox_Info.TabIndex = 5;
            this.groupBox_Info.TabStop = false;
            this.groupBox_Info.Text = "Thông tin hiển thị";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Enabled = false;
            this.label_Name.Location = new System.Drawing.Point(552, 118);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 25);
            this.label_Name.TabIndex = 14;
            this.label_Name.Text = "Tên";
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(640, 110);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(168, 33);
            this.comboBox_Name.Sorted = true;
            this.comboBox_Name.TabIndex = 13;
            this.comboBox_Name.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Name_SelectedIndexChanged);
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(737, 297);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_EndDate.TabIndex = 6;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_StartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(258, 297);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker_StartDate.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(562, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Thời điểm kết thúc";
            // 
            // buttonShow
            // 
            this.buttonShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonShow.Location = new System.Drawing.Point(456, 365);
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
            this.comboBox_TimeSpan.Location = new System.Drawing.Point(258, 238);
            this.comboBox_TimeSpan.Name = "comboBox_TimeSpan";
            this.comboBox_TimeSpan.Size = new System.Drawing.Size(142, 33);
            this.comboBox_TimeSpan.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hiển thị theo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 303);
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
            // groupBox_Chart
            // 
            this.groupBox_Chart.Controls.Add(this.panel_Chart);
            this.groupBox_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox_Chart.Location = new System.Drawing.Point(0, 0);
            this.groupBox_Chart.Name = "groupBox_Chart";
            this.groupBox_Chart.Size = new System.Drawing.Size(1055, 496);
            this.groupBox_Chart.TabIndex = 5;
            this.groupBox_Chart.TabStop = false;
            this.groupBox_Chart.Text = "Biểu đồ";
            // 
            // panel_Chart
            // 
            this.panel_Chart.AutoScroll = true;
            this.panel_Chart.Controls.Add(this.checkBox_ValueLabel);
            this.panel_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Chart.Location = new System.Drawing.Point(3, 27);
            this.panel_Chart.Name = "panel_Chart";
            this.panel_Chart.Size = new System.Drawing.Size(1049, 466);
            this.panel_Chart.TabIndex = 3;
            // 
            // checkBox_ValueLabel
            // 
            this.checkBox_ValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox_ValueLabel.AutoSize = true;
            this.checkBox_ValueLabel.Location = new System.Drawing.Point(816, 20);
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
            this.Controls.Add(this.splitContainer1);
            this.Name = "StatisticsControl";
            this.Size = new System.Drawing.Size(1055, 915);
            this.Load += new System.EventHandler(this.StatisticsControl_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox_Info.ResumeLayout(false);
            this.groupBox_Info.PerformLayout();
            this.groupBox_Chart.ResumeLayout(false);
            this.panel_Chart.ResumeLayout(false);
            this.panel_Chart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox_Info;
        private CheckBox checkBox_ValueLabel;
        private Label label3;
        private ComboBox comboBox_TimeSpan;
        private Button buttonShow;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker_StartDate;
        private DateTimePicker dateTimePicker_EndDate;
        private GroupBox groupBox_Chart;
        private Panel panel_Chart;
        private Label label_ID;
        private ComboBox comboBox_ID;
        private Label label4;
        private ComboBox comboBox_TableType;
        private Label label_Name;
        private ComboBox comboBox_Name;
    }
}
