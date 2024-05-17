namespace GUI_QLPM
{
    partial class DanhSachBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachBenh));
            this.label1 = new System.Windows.Forms.Label();
            this.maBenh = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.QuayLai = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Sua = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(428, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // maBenh
            // 
            this.maBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBenh.Location = new System.Drawing.Point(573, 53);
            this.maBenh.Multiline = true;
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(431, 37);
            this.maBenh.TabIndex = 1;
            // 
            // TimKiem
            // 
            this.TimKiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TimKiem.BackColor = System.Drawing.Color.RosyBrown;
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.ForeColor = System.Drawing.Color.Transparent;
            this.TimKiem.Location = new System.Drawing.Point(1028, 44);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Size = new System.Drawing.Size(126, 48);
            this.TimKiem.TabIndex = 2;
            this.TimKiem.Text = "Tìm kiếm";
            this.TimKiem.UseVisualStyleBackColor = false;
            this.TimKiem.Click += new System.EventHandler(this.TimKiem_Click);
            // 
            // Them
            // 
            this.Them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Them.BackColor = System.Drawing.Color.RosyBrown;
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.Transparent;
            this.Them.Location = new System.Drawing.Point(387, 136);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(166, 48);
            this.Them.TabIndex = 3;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // QuayLai
            // 
            this.QuayLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuayLai.BackColor = System.Drawing.Color.RosyBrown;
            this.QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuayLai.ForeColor = System.Drawing.Color.Transparent;
            this.QuayLai.Location = new System.Drawing.Point(1029, 136);
            this.QuayLai.Name = "QuayLai";
            this.QuayLai.Size = new System.Drawing.Size(166, 48);
            this.QuayLai.TabIndex = 4;
            this.QuayLai.Text = "Quay lại";
            this.QuayLai.UseVisualStyleBackColor = false;
            this.QuayLai.Click += new System.EventHandler(this.QuayLai_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grid.Location = new System.Drawing.Point(0, 204);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(1582, 449);
            this.grid.TabIndex = 5;
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // Sua
            // 
            this.Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sua.BackColor = System.Drawing.Color.RosyBrown;
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.Transparent;
            this.Sua.Location = new System.Drawing.Point(601, 136);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(166, 48);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Xoa
            // 
            this.Xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Xoa.BackColor = System.Drawing.Color.RosyBrown;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.Transparent;
            this.Xoa.Location = new System.Drawing.Point(815, 136);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(166, 48);
            this.Xoa.TabIndex = 7;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // DanhSachBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.QuayLai);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DanhSachBenh";
            this.Text = "Danh sách bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox maBenh;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button QuayLai;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.Button Xoa;
    }
}