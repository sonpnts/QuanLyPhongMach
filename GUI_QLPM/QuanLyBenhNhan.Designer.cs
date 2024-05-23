namespace GUI_QLPM
{
    partial class QuanLyBN
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyBN));
            this.gird = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.timkiem = new System.Windows.Forms.Button();
            this.quaylai = new System.Windows.Forms.Button();
            this.nhaptukhoa = new System.Windows.Forms.TextBox();
            this.hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.diaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ngaySinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gioiTinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xoabenhnhan = new System.Windows.Forms.Button();
            this.btnThembn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gird.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gird.ColumnHeadersHeight = 30;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gird.DefaultCellStyle = dataGridViewCellStyle2;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 291);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(1582, 362);
            this.gird.TabIndex = 4;
            this.gird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gird_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập từ khóa :";
            // 
            // timkiem
            // 
            this.timkiem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timkiem.Location = new System.Drawing.Point(1001, 22);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(140, 41);
            this.timkiem.TabIndex = 1;
            this.timkiem.Text = "Tìm kiếm";
            this.timkiem.UseVisualStyleBackColor = false;
            this.timkiem.Click += new System.EventHandler(this.timkiem_Click);
            // 
            // quaylai
            // 
            this.quaylai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quaylai.BackColor = System.Drawing.Color.RosyBrown;
            this.quaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quaylai.ForeColor = System.Drawing.Color.Transparent;
            this.quaylai.Location = new System.Drawing.Point(1071, 214);
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(191, 54);
            this.quaylai.TabIndex = 2;
            this.quaylai.Text = "Quay lại";
            this.quaylai.UseVisualStyleBackColor = false;
            this.quaylai.Click += new System.EventHandler(this.quaylai_Click);
            // 
            // nhaptukhoa
            // 
            this.nhaptukhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nhaptukhoa.Location = new System.Drawing.Point(575, 25);
            this.nhaptukhoa.Multiline = true;
            this.nhaptukhoa.Name = "nhaptukhoa";
            this.nhaptukhoa.Size = new System.Drawing.Size(389, 29);
            this.nhaptukhoa.TabIndex = 3;
            // 
            // hoten
            // 
            this.hoten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.ForeColor = System.Drawing.Color.Black;
            this.hoten.Location = new System.Drawing.Point(472, 102);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(273, 30);
            this.hoten.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(378, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Họ tên :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(378, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Địa chỉ :";
            // 
            // diaChi
            // 
            this.diaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.diaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diaChi.ForeColor = System.Drawing.Color.Black;
            this.diaChi.Location = new System.Drawing.Point(472, 149);
            this.diaChi.Name = "diaChi";
            this.diaChi.Size = new System.Drawing.Size(273, 30);
            this.diaChi.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(803, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày sinh :";
            // 
            // ngaySinh
            // 
            this.ngaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ngaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngaySinh.ForeColor = System.Drawing.Color.Black;
            this.ngaySinh.Location = new System.Drawing.Point(919, 100);
            this.ngaySinh.Name = "ngaySinh";
            this.ngaySinh.Size = new System.Drawing.Size(273, 30);
            this.ngaySinh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(803, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Giới tính :";
            // 
            // gioiTinh
            // 
            this.gioiTinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioiTinh.ForeColor = System.Drawing.Color.Black;
            this.gioiTinh.Location = new System.Drawing.Point(919, 151);
            this.gioiTinh.Name = "gioiTinh";
            this.gioiTinh.Size = new System.Drawing.Size(273, 30);
            this.gioiTinh.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(571, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sửa thông tin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xoabenhnhan
            // 
            this.xoabenhnhan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xoabenhnhan.BackColor = System.Drawing.Color.RosyBrown;
            this.xoabenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xoabenhnhan.ForeColor = System.Drawing.Color.Transparent;
            this.xoabenhnhan.Location = new System.Drawing.Point(813, 214);
            this.xoabenhnhan.Name = "xoabenhnhan";
            this.xoabenhnhan.Size = new System.Drawing.Size(191, 54);
            this.xoabenhnhan.TabIndex = 1;
            this.xoabenhnhan.Text = "Xóa bệnh nhân";
            this.xoabenhnhan.UseVisualStyleBackColor = false;
            this.xoabenhnhan.Click += new System.EventHandler(this.xoabenhnhan_Click);
            // 
            // btnThembn
            // 
            this.btnThembn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThembn.BackColor = System.Drawing.Color.RosyBrown;
            this.btnThembn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThembn.ForeColor = System.Drawing.Color.Transparent;
            this.btnThembn.Location = new System.Drawing.Point(321, 214);
            this.btnThembn.Name = "btnThembn";
            this.btnThembn.Size = new System.Drawing.Size(191, 54);
            this.btnThembn.TabIndex = 1;
            this.btnThembn.Text = "Thêm bệnh nhân";
            this.btnThembn.UseVisualStyleBackColor = false;
            this.btnThembn.Click += new System.EventHandler(this.btnThembn_Click);
            // 
            // QuanLyBN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1582, 653);
            this.Controls.Add(this.gioiTinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ngaySinh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diaChi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.nhaptukhoa);
            this.Controls.Add(this.quaylai);
            this.Controls.Add(this.xoabenhnhan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnThembn);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuanLyBN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bệnh nhân";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gird;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button timkiem;
        private System.Windows.Forms.Button quaylai;
        private System.Windows.Forms.TextBox nhaptukhoa;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox diaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ngaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox gioiTinh;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button xoabenhnhan;
        private System.Windows.Forms.Button btnThembn;
    }
}