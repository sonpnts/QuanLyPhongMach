namespace GUI_QLPM
{
    partial class ThemThuocMoi
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
            this.Them = new System.Windows.Forms.Button();
            this.mathuoc = new System.Windows.Forms.TextBox();
            this.dongia = new System.Windows.Forms.TextBox();
            this.tenthuoc = new System.Windows.Forms.TextBox();
            this.donvitinh = new System.Windows.Forms.ComboBox();
            this.cachdung = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thuốc :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên thuốc :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị tính :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Đơn giá :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cách dùng :";
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(115, 344);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(168, 44);
            this.Them.TabIndex = 5;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // mathuoc
            // 
            this.mathuoc.Location = new System.Drawing.Point(157, 31);
            this.mathuoc.Name = "mathuoc";
            this.mathuoc.Size = new System.Drawing.Size(177, 22);
            this.mathuoc.TabIndex = 6;
            // 
            // dongia
            // 
            this.dongia.Location = new System.Drawing.Point(157, 223);
            this.dongia.Name = "dongia";
            this.dongia.Size = new System.Drawing.Size(177, 22);
            this.dongia.TabIndex = 7;
            // 
            // tenthuoc
            // 
            this.tenthuoc.Location = new System.Drawing.Point(157, 95);
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.Size = new System.Drawing.Size(177, 22);
            this.tenthuoc.TabIndex = 8;
            // 
            // donvitinh
            // 
            this.donvitinh.FormattingEnabled = true;
            this.donvitinh.Location = new System.Drawing.Point(157, 157);
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Size = new System.Drawing.Size(177, 24);
            this.donvitinh.TabIndex = 10;
            // 
            // cachdung
            // 
            this.cachdung.FormattingEnabled = true;
            this.cachdung.Location = new System.Drawing.Point(157, 285);
            this.cachdung.Name = "cachdung";
            this.cachdung.Size = new System.Drawing.Size(177, 24);
            this.cachdung.TabIndex = 11;
            // 
            // ThemThuocMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 425);
            this.Controls.Add(this.cachdung);
            this.Controls.Add(this.donvitinh);
            this.Controls.Add(this.tenthuoc);
            this.Controls.Add(this.dongia);
            this.Controls.Add(this.mathuoc);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemThuocMoi";
            this.Text = "ThemThuocMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.TextBox mathuoc;
        private System.Windows.Forms.TextBox dongia;
        private System.Windows.Forms.TextBox tenthuoc;
        private System.Windows.Forms.ComboBox donvitinh;
        private System.Windows.Forms.ComboBox cachdung;
    }
}