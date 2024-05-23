namespace GUI_QLPM
{
    partial class QuanLyBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBenh));
            this.label1 = new System.Windows.Forms.Label();
            this.ma = new System.Windows.Forms.TextBox();
            this.TimKiem = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.QuayLai = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.Sua = new System.Windows.Forms.Button();
            this.maBenh = new System.Windows.Forms.TextBox();
            this.tenBenh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xoabenh = new System.Windows.Forms.Button();
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
            // ma
            // 
            this.ma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ma.Location = new System.Drawing.Point(573, 53);
            this.ma.Multiline = true;
            this.ma.Name = "ma";
            this.ma.Size = new System.Drawing.Size(431, 37);
            this.ma.TabIndex = 1;
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
            this.Them.Location = new System.Drawing.Point(355, 242);
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
            this.QuayLai.Location = new System.Drawing.Point(956, 242);
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
            this.grid.Location = new System.Drawing.Point(0, 317);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 51;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(1582, 336);
            this.grid.TabIndex = 5;
            this.grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellClick);
            this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
            // 
            // Sua
            // 
            this.Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sua.BackColor = System.Drawing.Color.RosyBrown;
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.Transparent;
            this.Sua.Location = new System.Drawing.Point(562, 242);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(166, 48);
            this.Sua.TabIndex = 6;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // maBenh
            // 
            this.maBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maBenh.Location = new System.Drawing.Point(573, 120);
            this.maBenh.Multiline = true;
            this.maBenh.Name = "maBenh";
            this.maBenh.Size = new System.Drawing.Size(431, 37);
            this.maBenh.TabIndex = 1;
            // 
            // tenBenh
            // 
            this.tenBenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tenBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenBenh.Location = new System.Drawing.Point(573, 163);
            this.tenBenh.Multiline = true;
            this.tenBenh.Name = "tenBenh";
            this.tenBenh.Size = new System.Drawing.Size(431, 37);
            this.tenBenh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã loại bệnh :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên loại bệnh :";
            // 
            // xoabenh
            // 
            this.xoabenh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoabenh.BackColor = System.Drawing.Color.RosyBrown;
            this.xoabenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabenh.ForeColor = System.Drawing.Color.Transparent;
            this.xoabenh.Location = new System.Drawing.Point(763, 242);
            this.xoabenh.Name = "xoabenh";
            this.xoabenh.Size = new System.Drawing.Size(166, 48);
            this.xoabenh.TabIndex = 6;
            this.xoabenh.Text = "Xóa";
            this.xoabenh.UseVisualStyleBackColor = false;
            this.xoabenh.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // QuanLyBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.xoabenh);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.QuayLai);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.tenBenh);
            this.Controls.Add(this.maBenh);
            this.Controls.Add(this.ma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyBenh";
            this.Text = "Quản lý bệnh";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ma;
        private System.Windows.Forms.Button TimKiem;
        private System.Windows.Forms.Button Them;
        private System.Windows.Forms.Button QuayLai;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Button Sua;
        private System.Windows.Forms.TextBox maBenh;
        private System.Windows.Forms.TextBox tenBenh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button xoabenh;
    }
}