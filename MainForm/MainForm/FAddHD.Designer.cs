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
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDDV)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Panel2.Controls.Add(this.tbDC);
            this.splitContainer1.Panel2.Controls.Add(this.tbSDT);
            this.splitContainer1.Panel2.Controls.Add(this.tbTenKH);
            this.splitContainer1.Panel2.Controls.Add(this.tbMaKH);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.flpBan);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 450);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 0;
            // 
            // nud
            // 
            this.nud.Location = new System.Drawing.Point(0, 409);
            this.nud.Name = "nud";
            this.nud.Size = new System.Drawing.Size(97, 27);
            this.nud.TabIndex = 2;
            this.nud.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnAddDV
            // 
            this.btnAddDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAddDV.Location = new System.Drawing.Point(109, 392);
            this.btnAddDV.Name = "btnAddDV";
            this.btnAddDV.Size = new System.Drawing.Size(104, 58);
            this.btnAddDV.TabIndex = 1;
            this.btnAddDV.Text = "Thêm";
            this.btnAddDV.UseVisualStyleBackColor = true;
            this.btnAddDV.Click += new System.EventHandler(this.btnAddDV_Click);
            // 
            // flpDV
            // 
            this.flpDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpDV.Location = new System.Drawing.Point(0, 0);
            this.flpDV.Name = "flpDV";
            this.flpDV.Size = new System.Drawing.Size(213, 392);
            this.flpDV.TabIndex = 0;
            // 
            // tbDC
            // 
            this.tbDC.Location = new System.Drawing.Point(418, 173);
            this.tbDC.Name = "tbDC";
            this.tbDC.Size = new System.Drawing.Size(157, 27);
            this.tbDC.TabIndex = 10;
            // 
            // tbSDT
            // 
            this.tbSDT.Location = new System.Drawing.Point(418, 132);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Size = new System.Drawing.Size(157, 27);
            this.tbSDT.TabIndex = 9;
            // 
            // tbTenKH
            // 
            this.tbTenKH.Location = new System.Drawing.Point(133, 173);
            this.tbTenKH.Name = "tbTenKH";
            this.tbTenKH.Size = new System.Drawing.Size(160, 27);
            this.tbTenKH.TabIndex = 8;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Location = new System.Drawing.Point(133, 129);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(160, 27);
            this.tbMaKH.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên khách hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã khách hàng";
            // 
            // flpBan
            // 
            this.flpBan.AutoScroll = true;
            this.flpBan.Location = new System.Drawing.Point(3, 239);
            this.flpBan.Name = "flpBan";
            this.flpBan.Size = new System.Drawing.Size(581, 164);
            this.flpBan.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnAddHD);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(599, 41);
            this.panel2.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Lưu";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(505, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddHD
            // 
            this.btnAddHD.AutoSize = true;
            this.btnAddHD.Location = new System.Drawing.Point(278, 0);
            this.btnAddHD.Name = "btnAddHD";
            this.btnAddHD.Size = new System.Drawing.Size(94, 41);
            this.btnAddHD.TabIndex = 2;
            this.btnAddHD.Text = "Tạo";
            this.btnAddHD.UseVisualStyleBackColor = true;
            this.btnAddHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvHDDV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 123);
            this.panel1.TabIndex = 0;
            // 
            // dgvHDDV
            // 
            this.dgvHDDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDDV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDDV.Location = new System.Drawing.Point(0, 0);
            this.dgvHDDV.Name = "dgvHDDV";
            this.dgvHDDV.RowHeadersWidth = 50;
            this.dgvHDDV.RowTemplate.Height = 29;
            this.dgvHDDV.Size = new System.Drawing.Size(599, 123);
            this.dgvHDDV.TabIndex = 0;
            this.dgvHDDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FAddHD";
            this.Text = "Thêm khách hàng";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud)).EndInit();
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
        private TextBox tbDC;
        private TextBox tbSDT;
        private TextBox tbTenKH;
        private TextBox tbMaKH;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
        private NumericUpDown nud;
        private Button btnAddDV;
        private FlowLayoutPanel flpDV;
    }
}