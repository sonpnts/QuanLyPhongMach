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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThayDoiLoaiBenh));
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại bệnh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại bệnh:";
            // 
            // maBenh
            // 
            this.maBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBenh.Location = new System.Drawing.Point(278, 66);
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(219, 30);
            this.maBenh.TabIndex = 2;
            // 
            // tenBenh
            // 
            this.tenBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenBenh.Location = new System.Drawing.Point(278, 125);
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.Size = new System.Drawing.Size(219, 30);
            this.tenBenh.TabIndex = 3;
            // 
            // ThayDoi
            // 
            this.ThayDoi.BackColor = System.Drawing.Color.RosyBrown;
            this.ThayDoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThayDoi.ForeColor = System.Drawing.Color.Transparent;
            this.ThayDoi.Location = new System.Drawing.Point(161, 202);
            this.ThayDoi.Name = "ThayDoi";
            this.ThayDoi.Size = new System.Drawing.Size(142, 47);
            this.ThayDoi.TabIndex = 4;
            this.ThayDoi.Text = "Thay đổi";
            this.ThayDoi.UseVisualStyleBackColor = false;
            this.ThayDoi.Click += new System.EventHandler(this.ThayDoi_Click);
            // 
            // QuayLai
            // 
            this.QuayLai.BackColor = System.Drawing.Color.RosyBrown;
            this.QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuayLai.ForeColor = System.Drawing.Color.Transparent;
            this.QuayLai.Location = new System.Drawing.Point(321, 202);
            this.QuayLai.Name = "QuayLai";
            this.QuayLai.Size = new System.Drawing.Size(142, 47);
            this.QuayLai.TabIndex = 5;
            this.QuayLai.Text = "Quay lại";
            this.QuayLai.UseVisualStyleBackColor = false;
            this.QuayLai.Click += new System.EventHandler(this.QuayLai_Click);
            // 
            // ThayDoiLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(624, 314);
            this.Controls.Add(this.QuayLai);
            this.Controls.Add(this.ThayDoi);
            this.Controls.Add(this.tenBenh);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThayDoiLoaiBenh";
            this.Text = "Thay đổi loại bệnh";
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