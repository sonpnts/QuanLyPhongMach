namespace GUI_QLPM
{
    partial class ThayDoiLoaiBenh
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
            this.maBenh = new System.Windows.Forms.TextBox();
            this.tenBenh = new System.Windows.Forms.TextBox();
            this.ThayDoi = new System.Windows.Forms.Button();
            this.QuayLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại bệnh:";
            // 
            // maBenh
            // 
            this.maBenh.Location = new System.Drawing.Point(287, 106);
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(173, 22);
            this.maBenh.TabIndex = 2;
            // 
            // tenBenh
            // 
            this.tenBenh.Location = new System.Drawing.Point(287, 166);
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.Size = new System.Drawing.Size(173, 22);
            this.tenBenh.TabIndex = 3;
            // 
            // ThayDoi
            // 
            this.ThayDoi.Location = new System.Drawing.Point(183, 253);
            this.ThayDoi.Name = "ThayDoi";
            this.ThayDoi.Size = new System.Drawing.Size(113, 41);
            this.ThayDoi.TabIndex = 4;
            this.ThayDoi.Text = "Thay đổi";
            this.ThayDoi.UseVisualStyleBackColor = true;
            this.ThayDoi.Click += new System.EventHandler(this.ThayDoi_Click);
            // 
            // QuayLai
            // 
            this.QuayLai.Location = new System.Drawing.Point(363, 253);
            this.QuayLai.Name = "QuayLai";
            this.QuayLai.Size = new System.Drawing.Size(113, 41);
            this.QuayLai.TabIndex = 5;
            this.QuayLai.Text = "Quay lại";
            this.QuayLai.UseVisualStyleBackColor = true;
            this.QuayLai.Click += new System.EventHandler(this.QuayLai_Click);
            // 
            // ThayDoiLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 375);
            this.Controls.Add(this.QuayLai);
            this.Controls.Add(this.ThayDoi);
            this.Controls.Add(this.tenBenh);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThayDoiLoaiBenh";
            this.Text = "ThayDoiLoaiBenh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maBenh;
        private System.Windows.Forms.TextBox tenBenh;
        private System.Windows.Forms.Button ThayDoi;
        private System.Windows.Forms.Button QuayLai;
    }
}