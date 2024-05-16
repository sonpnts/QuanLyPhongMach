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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemLoaiBenh));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maBenh = new System.Windows.Forms.TextBox();
            this.tenBenh = new System.Windows.Forms.TextBox();
            this.Thêm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại bệnh :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại bệnh :";
            // 
            // maBenh
            // 
            this.maBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBenh.Location = new System.Drawing.Point(238, 54);
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(262, 30);
            this.maBenh.TabIndex = 2;
            // 
            // tenBenh
            // 
            this.tenBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenBenh.Location = new System.Drawing.Point(238, 105);
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.Size = new System.Drawing.Size(262, 30);
            this.tenBenh.TabIndex = 5;
            // 
            // Thêm
            // 
            this.Thêm.BackColor = System.Drawing.Color.RosyBrown;
            this.Thêm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thêm.ForeColor = System.Drawing.Color.Transparent;
            this.Thêm.Location = new System.Drawing.Point(208, 171);
            this.Thêm.Name = "Thêm";
            this.Thêm.Size = new System.Drawing.Size(170, 51);
            this.Thêm.TabIndex = 6;
            this.Thêm.Text = "Thêm";
            this.Thêm.UseVisualStyleBackColor = false;
            this.Thêm.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ThemLoaiBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(587, 255);
            this.Controls.Add(this.Thêm);
            this.Controls.Add(this.tenBenh);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemLoaiBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm loại bệnh";
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