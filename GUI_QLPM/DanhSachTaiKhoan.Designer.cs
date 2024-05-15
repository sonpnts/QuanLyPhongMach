namespace GUI_QLPM
{
    partial class DanhSachTaiKhoan
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TimKiem = new System.Windows.Forms.Button();
            this.maThuoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gird = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 44);
            this.button3.TabIndex = 15;
            this.button3.Text = "Quay lại";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 44);
            this.button2.TabIndex = 14;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TimKiem
            // 
            this.TimKiem.Location = new System.Drawing.Point(190, 90);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(92, 44);
            this.TimKiem.TabIndex = 13;
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.UseVisualStyleBackColor = true;
            // 
            // maThuoc
            // 
            this.maThuoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maThuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maThuoc.Location = new System.Drawing.Point(273, 39);
            this.maThuoc.Multiline = true;
            this.maThuoc.Name = "maThuoc";
            this.maThuoc.Size = new System.Drawing.Size(313, 27);
            this.maThuoc.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // gird
            // 
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 235);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(800, 215);
            this.gird.TabIndex = 16;
            // 
            // DanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.maThuoc);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachTaiKhoan";
            this.Text = "DanhSachTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.TextBox maThuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gird;
    }
}