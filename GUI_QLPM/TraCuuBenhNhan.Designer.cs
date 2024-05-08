namespace GUI_QLPM
{
    partial class TraCuuBenhNhan
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
            this.timkiem = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.nhaptukhoa = new System.Windows.Forms.TextBox();
            this.gird = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // timkiem
            // 
            this.timkiem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.timkiem.Location = new System.Drawing.Point(509, 70);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(108, 40);
            this.timkiem.TabIndex = 1;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            // 
            // quaylai
            // 
            this.quaylai.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quaylai.Location = new System.Drawing.Point(636, 70);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(108, 40);
            this.quaylai.TabIndex = 2;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = false;
            // 
            // nhaptukhoa
            // 
            this.nhaptukhoa.Location = new System.Drawing.Point(188, 79);
            this.nhaptukhoa.Multiline = true;
            this.nhaptukhoa.Name = "nhaptukhoa";
            this.nhaptukhoa.Size = new System.Drawing.Size(288, 28);
            this.nhaptukhoa.TabIndex = 3;
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 180);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(828, 202);
            this.gird.TabIndex = 4;
            // 
            // TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 382);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.nhaptukhoa);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.label1);
            this.Name = "TraCuuBenhNhan";
            this.Text = "TraCuuBenhNhan";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.TextBox nhaptukhoa;
        private System.Windows.Forms.DataGridView gird;
    }
}