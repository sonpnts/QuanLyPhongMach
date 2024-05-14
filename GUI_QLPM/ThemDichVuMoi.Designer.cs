namespace GUI_QLPM
{
    partial class ThemDichVuMoi
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
            this.tenDichVu = new System.Windows.Forms.TextBox();
            this.tienDichVu = new System.Windows.Forms.TextBox();
            this.maDichVu = new System.Windows.Forms.TextBox();
            this.Them = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tenDichVu
            // 
            this.tenDichVu.Location = new System.Drawing.Point(358, 165);
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.Size = new System.Drawing.Size(177, 22);
            this.tenDichVu.TabIndex = 27;
            // 
            // tienDichVu
            // 
            this.tienDichVu.Location = new System.Drawing.Point(358, 235);
            this.tienDichVu.Name = "tienDichVu";
            this.tienDichVu.Size = new System.Drawing.Size(177, 22);
            this.tienDichVu.TabIndex = 26;
            // 
            // maDichVu
            // 
            this.maDichVu.Location = new System.Drawing.Point(358, 101);
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.ReadOnly = true;
            this.maDichVu.Size = new System.Drawing.Size(177, 22);
            this.maDichVu.TabIndex = 25;
            // 
            // Them
            // 
            this.Them.Location = new System.Drawing.Point(321, 305);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(168, 44);
            this.Them.TabIndex = 24;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tiền dịch vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên dịch vụ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã dịch vụ :";
            // 
            // ThemDichVuMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tenDichVu);
            this.Controls.Add(this.tienDichVu);
            this.Controls.Add(this.maDichVu);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemDichVuMoi";
            this.Text = "ThemDichVuMoi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tenDichVu;
        private System.Windows.Forms.TextBox tienDichVu;
        private System.Windows.Forms.TextBox maDichVu;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}