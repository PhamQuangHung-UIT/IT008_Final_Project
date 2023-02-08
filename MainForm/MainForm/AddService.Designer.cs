namespace MainForm
{
    partial class AddService
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
            this.textBox_GiaTienDV = new System.Windows.Forms.TextBox();
            this.label_GiaTienDV = new System.Windows.Forms.Label();
            this.textBox_TenDV = new System.Windows.Forms.TextBox();
            this.label_TenDV = new System.Windows.Forms.Label();
            this.textBox_idDV = new System.Windows.Forms.TextBox();
            this.label1_idDV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(581, 266);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(112, 34);
            this.button_Cancel.TabIndex = 0;
            this.button_Cancel.Text = "Hủy";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Save.Location = new System.Drawing.Point(421, 266);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(112, 34);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Lưu";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // textBox_GiaTienDV
            // 
            this.textBox_GiaTienDV.Location = new System.Drawing.Point(234, 188);
            this.textBox_GiaTienDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_GiaTienDV.Name = "textBox_GiaTienDV";
            this.textBox_GiaTienDV.Size = new System.Drawing.Size(360, 31);
            this.textBox_GiaTienDV.TabIndex = 12;
            // 
            // label_GiaTienDV
            // 
            this.label_GiaTienDV.AutoSize = true;
            this.label_GiaTienDV.Location = new System.Drawing.Point(93, 194);
            this.label_GiaTienDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GiaTienDV.Name = "label_GiaTienDV";
            this.label_GiaTienDV.Size = new System.Drawing.Size(75, 25);
            this.label_GiaTienDV.TabIndex = 11;
            this.label_GiaTienDV.Text = "Giá tiền:";
            // 
            // textBox_TenDV
            // 
            this.textBox_TenDV.Location = new System.Drawing.Point(234, 115);
            this.textBox_TenDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_TenDV.Name = "textBox_TenDV";
            this.textBox_TenDV.Size = new System.Drawing.Size(360, 31);
            this.textBox_TenDV.TabIndex = 10;
            // 
            // label_TenDV
            // 
            this.label_TenDV.AutoSize = true;
            this.label_TenDV.Location = new System.Drawing.Point(93, 115);
            this.label_TenDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenDV.Name = "label_TenDV";
            this.label_TenDV.Size = new System.Drawing.Size(104, 25);
            this.label_TenDV.TabIndex = 9;
            this.label_TenDV.Text = "Tên dịch vụ:";
            // 
            // textBox_idDV
            // 
            this.textBox_idDV.Location = new System.Drawing.Point(234, 34);
            this.textBox_idDV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_idDV.Name = "textBox_idDV";
            this.textBox_idDV.Size = new System.Drawing.Size(360, 31);
            this.textBox_idDV.TabIndex = 8;
            // 
            // label1_idDV
            // 
            this.label1_idDV.AutoSize = true;
            this.label1_idDV.Location = new System.Drawing.Point(93, 37);
            this.label1_idDV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1_idDV.Name = "label1_idDV";
            this.label1_idDV.Size = new System.Drawing.Size(99, 25);
            this.label1_idDV.TabIndex = 7;
            this.label1_idDV.Text = "Mã dịch vụ";
            // 
            // AddService
            // 
            this.AcceptButton = this.button_Save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(715, 312);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_GiaTienDV);
            this.Controls.Add(this.label_GiaTienDV);
            this.Controls.Add(this.textBox_TenDV);
            this.Controls.Add(this.label_TenDV);
            this.Controls.Add(this.textBox_idDV);
            this.Controls.Add(this.label1_idDV);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Cancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm dịch vụ mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_Cancel;
        private Button button_Save;
        private TextBox textBox_GiaTienDV;
        private Label label_GiaTienDV;
        private TextBox textBox_TenDV;
        private Label label_TenDV;
        private TextBox textBox_idDV;
        private Label label1_idDV;
    }
}