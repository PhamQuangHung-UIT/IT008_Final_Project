namespace MainForm
{
    partial class FChangeTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbOldTable = new System.Windows.Forms.ComboBox();
            this.cbNewTable = new System.Windows.Forms.ComboBox();
            this.btnChangeTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bàn cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bàn mới";
            // 
            // cbOldTable
            // 
            this.cbOldTable.FormattingEnabled = true;
            this.cbOldTable.Location = new System.Drawing.Point(110, 49);
            this.cbOldTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOldTable.Name = "cbOldTable";
            this.cbOldTable.Size = new System.Drawing.Size(188, 33);
            this.cbOldTable.TabIndex = 2;
            // 
            // cbNewTable
            // 
            this.cbNewTable.FormattingEnabled = true;
            this.cbNewTable.Location = new System.Drawing.Point(449, 49);
            this.cbNewTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNewTable.Name = "cbNewTable";
            this.cbNewTable.Size = new System.Drawing.Size(188, 33);
            this.cbNewTable.TabIndex = 3;
            // 
            // btnChangeTable
            // 
            this.btnChangeTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeTable.Location = new System.Drawing.Point(260, 195);
            this.btnChangeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeTable.Name = "btnChangeTable";
            this.btnChangeTable.Size = new System.Drawing.Size(118, 36);
            this.btnChangeTable.TabIndex = 4;
            this.btnChangeTable.Text = "Đổi bàn";
            this.btnChangeTable.UseVisualStyleBackColor = true;
            this.btnChangeTable.Click += new System.EventHandler(this.BtnChangeTable_Click);
            // 
            // FChangeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 280);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangeTable);
            this.Controls.Add(this.cbNewTable);
            this.Controls.Add(this.cbOldTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FChangeTable";
            this.Text = "Đổi bàn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cbOldTable;
        private ComboBox cbNewTable;
        private Button btnChangeTable;
    }
}