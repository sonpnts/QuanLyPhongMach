namespace GUI_QLPM
{
    partial class ThemBenhNhanMoi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mabenhnhan = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.them = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ :";
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.Location = new System.Drawing.Point(428, 33);
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Size = new System.Drawing.Size(241, 22);
            this.mabenhnhan.TabIndex = 5;
            this.mabenhnhan.TabStop = false;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(428, 289);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(238, 22);
            this.diachi.TabIndex = 4;
            // 
            // hoten
            // 
            this.hoten.Location = new System.Drawing.Point(428, 97);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(241, 22);
            this.hoten.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(428, 162);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(501, 163);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // ngaysinh
            // 
            this.ngaysinh.Location = new System.Drawing.Point(428, 224);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(241, 22);
            this.ngaysinh.TabIndex = 3;
            // 
            // them
            // 
            this.them.Location = new System.Drawing.Point(360, 350);
            this.them.Name = "them";
            this.them.Size = new System.Drawing.Size(113, 39);
            this.them.TabIndex = 5;
            this.them.Text = "Thêm";
            this.them.UseVisualStyleBackColor = true;
            this.them.Click += new System.EventHandler(this.them_Click);
            // 
            // quaylai
            // 
            this.quaylai.Location = new System.Drawing.Point(553, 350);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(113, 39);
            this.quaylai.TabIndex = 6;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = true;
            // 
            // ThemBenhNhanMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 460);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.them);
            this.Controls.Add(this.ngaysinh);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.mabenhnhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemBenhNhanMoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemBenhNhanMoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mabenhnhan;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.DateTimePicker ngaysinh;
        private System.Windows.Forms.Button them;
        private System.Windows.Forms.Button quaylai;
    }
}