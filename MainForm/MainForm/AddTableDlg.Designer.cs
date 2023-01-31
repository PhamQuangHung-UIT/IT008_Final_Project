namespace MainForm
{
    partial class AddTableDlg
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_GiaTienBan = new System.Windows.Forms.TextBox();
            this.label_GiaTienBan = new System.Windows.Forms.Label();
            this.textBox_idBan = new System.Windows.Forms.TextBox();
            this.label_idBan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(580, 246);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(112, 34);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Hủy";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Save.Location = new System.Drawing.Point(420, 246);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(112, 34);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Lưu";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // textBox_GiaTienBan
            // 
            this.textBox_GiaTienBan.Location = new System.Drawing.Point(226, 131);
            this.textBox_GiaTienBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_GiaTienBan.Name = "textBox_GiaTienBan";
            this.textBox_GiaTienBan.Size = new System.Drawing.Size(306, 31);
            this.textBox_GiaTienBan.TabIndex = 8;
            // 
            // label_GiaTienBan
            // 
            this.label_GiaTienBan.AutoSize = true;
            this.label_GiaTienBan.Location = new System.Drawing.Point(83, 134);
            this.label_GiaTienBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GiaTienBan.Name = "label_GiaTienBan";
            this.label_GiaTienBan.Size = new System.Drawing.Size(75, 25);
            this.label_GiaTienBan.TabIndex = 7;
            this.label_GiaTienBan.Text = "Giá tiền:";
            // 
            // textBox_idBan
            // 
            this.textBox_idBan.Location = new System.Drawing.Point(226, 45);
            this.textBox_idBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idBan.Name = "textBox_idBan";
            this.textBox_idBan.Size = new System.Drawing.Size(306, 31);
            this.textBox_idBan.TabIndex = 6;
            // 
            // label_idBan
            // 
            this.label_idBan.AutoSize = true;
            this.label_idBan.Location = new System.Drawing.Point(82, 50);
            this.label_idBan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_idBan.Name = "label_idBan";
            this.label_idBan.Size = new System.Drawing.Size(76, 25);
            this.label_idBan.TabIndex = 5;
            this.label_idBan.Text = "Mã bàn:";
            // 
            // AddTableDlg
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(715, 292);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_GiaTienBan);
            this.Controls.Add(this.label_GiaTienBan);
            this.Controls.Add(this.textBox_idBan);
            this.Controls.Add(this.label_idBan);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.Name = "AddTableDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm bàn mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cancel;
        private Button button_Save;
        private TextBox textBox_GiaTienBan;
        private Label label_GiaTienBan;
        private TextBox textBox_idBan;
        private Label label_idBan;
    }
}