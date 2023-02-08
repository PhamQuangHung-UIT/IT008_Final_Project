namespace MainForm
{
    partial class FMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_XuatHoaDon = new System.Windows.Forms.Button();
            this.tvHD = new System.Windows.Forms.TreeView();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateHD = new System.Windows.Forms.Button();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_XuatHoaDon);
            this.splitContainer1.Panel1.Controls.Add(this.tvHD);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flpTable);
            this.splitContainer1.Panel2.Controls.Add(this.btnCreateHD);
            this.splitContainer1.Size = new System.Drawing.Size(1579, 799);
            this.splitContainer1.SplitterDistance = 523;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_XuatHoaDon
            // 
            this.button_XuatHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_XuatHoaDon.Location = new System.Drawing.Point(347, 735);
            this.button_XuatHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.button_XuatHoaDon.Name = "button_XuatHoaDon";
            this.button_XuatHoaDon.Size = new System.Drawing.Size(154, 51);
            this.button_XuatHoaDon.TabIndex = 1;
            this.button_XuatHoaDon.Text = "Xuất hóa đơn";
            this.button_XuatHoaDon.UseVisualStyleBackColor = true;
            // 
            // tvHD
            // 
            this.tvHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvHD.Location = new System.Drawing.Point(0, 4);
            this.tvHD.Margin = new System.Windows.Forms.Padding(4);
            this.tvHD.Name = "tvHD";
            this.tvHD.Size = new System.Drawing.Size(523, 723);
            this.tvHD.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(0, 147);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(1046, 652);
            this.flpTable.TabIndex = 1;
            // 
            // btnCreateHD
            // 
            this.btnCreateHD.Location = new System.Drawing.Point(4, 4);
            this.btnCreateHD.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateHD.Name = "btnCreateHD";
            this.btnCreateHD.Size = new System.Drawing.Size(195, 130);
            this.btnCreateHD.TabIndex = 0;
            this.btnCreateHD.Text = "Thêm hóa đơn mới";
            this.btnCreateHD.UseVisualStyleBackColor = true;
            this.btnCreateHD.Click += new System.EventHandler(this.BtnCreateHD_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(129, 29);
            this.adminToolStripMenuItem.Text = "Quản trị viên";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.AdminMenuToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(182, 29);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thôngTinTàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1579, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 832);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartBilliard";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnCreateHD;
        private TreeView tvHD;
        private FlowLayoutPanel flpTable;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button button_XuatHoaDon;
    }
}