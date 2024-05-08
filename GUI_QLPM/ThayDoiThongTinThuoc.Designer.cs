namespace GUI_QLPM
{
    partial class ThayDoiThongTinThuoc
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
            this.thaydoi = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.mathuoc = new System.Windows.Forms.TextBox();
            this.tenthuoc = new System.Windows.Forms.TextBox();
            this.cachdung = new System.Windows.Forms.TextBox();
            this.dongia = new System.Windows.Forms.TextBox();
            this.donvitinh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thuốc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cách dùng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn vị tính :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá :";
            // 
            // thaydoi
            // 
            this.thaydoi.Location = new System.Drawing.Point(422, 274);
            this.thaydoi.Name = "thaydoi";
            this.thaydoi.Size = new System.Drawing.Size(88, 38);
            this.thaydoi.TabIndex = 5;
            this.thaydoi.Text = "Thay đổi";
            this.thaydoi.UseVisualStyleBackColor = true;
            // 
            // quaylai
            // 
            this.quaylai.Location = new System.Drawing.Point(540, 274);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(100, 38);
            this.quaylai.TabIndex = 6;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = true;
            // 
            // mathuoc
            // 
            this.mathuoc.Location = new System.Drawing.Point(197, 70);
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Size = new System.Drawing.Size(100, 22);
            this.mathuoc.TabIndex = 7;
            // 
            // tenthuoc
            // 
            this.tenthuoc.Location = new System.Drawing.Point(197, 132);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(100, 22);
            this.tenthuoc.TabIndex = 8;
            // 
            // cachdung
            // 
            this.cachdung.Location = new System.Drawing.Point(197, 194);
            this.cachdung.Name = "cachdung";
            this.cachdung.Size = new System.Drawing.Size(100, 22);
            this.cachdung.TabIndex = 9;
            // 
            // dongia
            // 
            this.dongia.Location = new System.Drawing.Point(503, 132);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(121, 22);
            this.dongia.TabIndex = 10;
            // 
            // donvitinh
            // 
            this.donvitinh.FormattingEnabled = true;
            this.donvitinh.Location = new System.Drawing.Point(503, 70);
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Size = new System.Drawing.Size(121, 24);
            this.donvitinh.TabIndex = 11;
            // 
            // ThayDoiThongTinThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 351);
            this.Controls.Add(this.donvitinh);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.cachdung);
            this.Controls.Add(this.tenthuoc);
            this.Controls.Add(this.mathuoc);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.thaydoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThayDoiThongTinThuoc";
            this.Text = "ThayDoiThongTinThuoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button thaydoi;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.TextBox mathuoc;
        private System.Windows.Forms.TextBox tenthuoc;
        private System.Windows.Forms.TextBox cachdung;
        private System.Windows.Forms.TextBox dongia;
        private System.Windows.Forms.ComboBox donvitinh;
    }
}