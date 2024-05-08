namespace GUI_QLPM
{
    partial class ThemLoaiBenh
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
            this.Thêm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại bệnh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại bệnh :";
            // 
            // maBenh
            // 
            this.maBenh.Location = new System.Drawing.Point(180, 60);
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(262, 22);
            this.maBenh.TabIndex = 2;
            // 
            // tenBenh
            // 
            this.tenBenh.Location = new System.Drawing.Point(180, 114);
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.Size = new System.Drawing.Size(262, 22);
            this.tenBenh.TabIndex = 5;
            // 
            // Thêm
            // 
            this.Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thêm.Location = new System.Drawing.Point(218, 176);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(170, 37);
            this.Thêm.TabIndex = 6;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = true;
            this.Thêm.Click += new System.EventHandler(this.Thêm_Click);
            // 
            // ThemLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 255);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.tenBenh);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemLoaiBenh";
            this.Text = "ThemLoaiBenh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maBenh;
        private System.Windows.Forms.TextBox tenBenh;
        private System.Windows.Forms.Button Thêm;
    }
}