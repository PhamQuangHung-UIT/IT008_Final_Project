namespace MainForm
{
    partial class FAddHD
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.nud = new System.Windows.Forms.NumericUpDown();
            this.btnAddDV = new System.Windows.Forms.Button();
            this.flpDV = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox_CustomerInfo = new System.Windows.Forms.GroupBox();
            this.tbDC = new System.Windows.Forms.TextBox();
            this.tbSDT = new System.Windows.Forms.TextBox();
            this.tbTenKH = new System.Windows.Forms.TextBox();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flpBan = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddHD = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHDDV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud)).BeginInit();
            this.groupBox_CustomerInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.nud);
            this.splitContainer1.Panel1.Controls.Add(this.btnAddDV);
            this.splitContainer1.Panel1.Controls.Add(this.flpDV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox_CustomerInfo);
            this.splitContainer1.Panel2.Controls.Add(this.flpBan);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 633);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(13, 564);
            this.nud.Margin = new System.Windows.Forms.Padding(4);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(121, 31);
            this.nud.TabIndex = 2;
            this.nud.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
            // 
            // btnAddDV
            // 
            this.btnAddDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddDV.Location = new System.Drawing.Point(149, 544);
            this.btnAddDV.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.Size = new System.Drawing.Size(130, 89);
            this.btnAddDV.TabIndex = 1;
            this.btnAddDV.Text = "Thêm";
            this.btnAddDV.UseVisualStyleBackColor = true;
            this.btnAddDV.Click += new System.EventHandler(this.BtnAddDV_Click);
            // 
            // flpDV
            // 
            this.flpDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDV.Location = new System.Drawing.Point(0, 0);
            this.flpDV.Margin = new System.Windows.Forms.Padding(4);
            this.flpDV.Name = "flpDV";
            this.flpDV.Size = new System.Drawing.Size(279, 544);
            this.flpDV.TabIndex = 0;
            // 
            // groupBox_CustomerInfo
            // 
            this.groupBox_CustomerInfo.Controls.Add(this.tbDC);
            this.groupBox_CustomerInfo.Controls.Add(this.tbSDT);
            this.groupBox_CustomerInfo.Controls.Add(this.tbTenKH);
            this.groupBox_CustomerInfo.Controls.Add(this.tbMaKH);
            this.groupBox_CustomerInfo.Controls.Add(this.label4);
            this.groupBox_CustomerInfo.Controls.Add(this.label3);
            this.groupBox_CustomerInfo.Controls.Add(this.label2);
            this.groupBox_CustomerInfo.Controls.Add(this.label1);
            this.groupBox_CustomerInfo.Location = new System.Drawing.Point(2, 161);
            this.groupBox_CustomerInfo.Name = "groupBox_CustomerInfo";
            this.groupBox_CustomerInfo.Size = new System.Drawing.Size(782, 166);
            this.groupBox_CustomerInfo.TabIndex = 3;
            this.groupBox_CustomerInfo.TabStop = false;
            this.groupBox_CustomerInfo.Text = "Thông tin khách hàng";
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(546, 112);
            this.tbDC.Margin = new System.Windows.Forms.Padding(4);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(195, 31);
            this.tbDC.TabIndex = 18;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(546, 61);
            this.tbSDT.Margin = new System.Windows.Forms.Padding(4);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(195, 31);
            this.tbSDT.TabIndex = 17;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(190, 112);
            this.tbTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(199, 31);
            this.tbTenKH.TabIndex = 16;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(190, 57);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(199, 31);
            this.tbMaKH.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã khách hàng";
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpBan.Location = new System.Drawing.Point(0, 334);
            this.flpBan.Margin = new System.Windows.Forms.Padding(4);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(787, 248);
            this.flpBan.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAddHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 582);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(787, 51);
            this.panel2.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSave.Location = new System.Drawing.Point(222, 0);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 51);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Lưu";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(669, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 51);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddHD
            // 
            this.btnAddHD.AutoSize = true;
            this.btnAddHD.Location = new System.Drawing.Point(348, 0);
            this.btnAddHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(118, 51);
            this.btnAddHD.TabIndex = 2;
            this.btnAddHD.Text = "Tạo";
            this.btnAddHD.UseVisualStyleBackColor = true;
            this.btnAddHD.Click += new System.EventHandler(this.ButtonAddHD_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHDDV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 154);
            this.panel1.TabIndex = 0;
            // 
            // dgvHDDV
            // 
            this.dgvHDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDDV.Location = new System.Drawing.Point(0, 0);
            this.dgvHDDV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHDDV.Name = "dgvHDDV";
            this.dgvHDDV.RowHeadersWidth = 50;
            this.dgvHDDV.RowTemplate.Height = 29;
            this.dgvHDDV.Size = new System.Drawing.Size(787, 154);
            this.dgvHDDV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên khách hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "CCCD";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // FAddHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 633);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAddHD";
            this.ShowIcon = false;
            this.Text = "Thêm hóa đơn mới";
            this.Load += new System.EventHandler(this.FAddHD_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
            this.groupBox_CustomerInfo.ResumeLayout(false);
            this.groupBox_CustomerInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panel1;
        private DataGridView dgvHDDV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private FlowLayoutPanel flpBan;
        private Panel panel2;
        private Button button2;
        private Button btnAddHD;
        private Button buttonSave;
        private NumericUpDown nud;
        private Button btnAddDV;
        private FlowLayoutPanel flpDV;
        private GroupBox groupBox_CustomerInfo;
        private TextBox tbDC;
        private TextBox tbSDT;
        private TextBox tbTenKH;
        private TextBox tbMaKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}