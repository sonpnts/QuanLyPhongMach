namespace GUI_QLPM
{
    partial class ThemPhieuKhamBenh
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LapPhieu = new System.Windows.Forms.Button();
            this.KeToa = new System.Windows.Forms.Button();
            this.huy = new System.Windows.Forms.Button();
            this.hoten = new System.Windows.Forms.TextBox();
            this.maPKB = new System.Windows.Forms.TextBox();
            this.trieuchung = new System.Windows.Forms.TextBox();
            this.ngayKham = new System.Windows.Forms.TextBox();
            this.mabenhnhan = new System.Windows.Forms.ComboBox();
            this.benh = new System.Windows.Forms.ComboBox();
            this.gird = new System.Windows.Forms.DataGridView();
            this.KiemTra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gird)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bệnh nhân :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(738, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày khám :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Triệu chứng :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(363, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dự đoán loại bệnh :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(738, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã PKB :";
            // 
            // LapPhieu
            // 
            this.LapPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapPhieu.Location = new System.Drawing.Point(39, 187);
            this.LapPhieu.Name = "LapPhieu";
            this.LapPhieu.Size = new System.Drawing.Size(125, 44);
            this.LapPhieu.TabIndex = 6;
            this.LapPhieu.Text = "Lập phiếu";
            this.LapPhieu.UseVisualStyleBackColor = true;
            this.LapPhieu.Click += new System.EventHandler(this.LapPhieu_Click);
            // 
            // KeToa
            // 
            this.KeToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeToa.Location = new System.Drawing.Point(204, 187);
            this.KeToa.Name = "KeToa";
            this.KeToa.Size = new System.Drawing.Size(125, 44);
            this.KeToa.TabIndex = 7;
            this.KeToa.Text = "Kê toa";
            this.KeToa.UseVisualStyleBackColor = true;
            this.KeToa.Click += new System.EventHandler(this.KeToa_Click);
            // 
            // huy
            // 
            this.huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huy.Location = new System.Drawing.Point(369, 187);
            this.huy.Name = "huy";
            this.huy.Size = new System.Drawing.Size(125, 44);
            this.huy.TabIndex = 8;
            this.huy.Text = "Hủy";
            this.huy.UseVisualStyleBackColor = true;
            this.huy.Click += new System.EventHandler(this.huy_Click);
            // 
            // hoten
            // 
            this.hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.Location = new System.Drawing.Point(447, 47);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(271, 27);
            this.hoten.TabIndex = 9;
            // 
            // maPKB
            // 
            this.maPKB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maPKB.Location = new System.Drawing.Point(846, 121);
            this.maPKB.Name = "maPKB";
            this.maPKB.Size = new System.Drawing.Size(123, 27);
            this.maPKB.TabIndex = 10;
            // 
            // trieuchung
            // 
            this.trieuchung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trieuchung.Location = new System.Drawing.Point(153, 121);
            this.trieuchung.Name = "trieuchung";
            this.trieuchung.Size = new System.Drawing.Size(154, 27);
            this.trieuchung.TabIndex = 11;
            // 
            // ngayKham
            // 
            this.ngayKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayKham.Location = new System.Drawing.Point(846, 47);
            this.ngayKham.Name = "ngayKham";
            this.ngayKham.Size = new System.Drawing.Size(182, 27);
            this.ngayKham.TabIndex = 12;
            // 
            // mabenhnhan
            // 
            this.mabenhnhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mabenhnhan.FormattingEnabled = true;
            this.mabenhnhan.Location = new System.Drawing.Point(169, 46);
            this.mabenhnhan.Name = "mabenhnhan";
            this.mabenhnhan.Size = new System.Drawing.Size(75, 28);
            this.mabenhnhan.TabIndex = 13;
            // 
            // benh
            // 
            this.benh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.benh.FormattingEnabled = true;
            this.benh.Location = new System.Drawing.Point(536, 120);
            this.benh.Name = "benh";
            this.benh.Size = new System.Drawing.Size(167, 28);
            this.benh.TabIndex = 14;
            // 
            // gird
            // 
            this.gird.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gird.Location = new System.Drawing.Point(0, 263);
            this.gird.Name = "gird";
            this.gird.RowHeadersWidth = 51;
            this.gird.RowTemplate.Height = 24;
            this.gird.Size = new System.Drawing.Size(1086, 230);
            this.gird.TabIndex = 15;
            // 
            // KiemTra
            // 
            this.KiemTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KiemTra.Location = new System.Drawing.Point(250, 39);
            this.KiemTra.Name = "KiemTra";
            this.KiemTra.Size = new System.Drawing.Size(98, 43);
            this.KiemTra.TabIndex = 16;
            this.KiemTra.Text = "Kiểm tra";
            this.KiemTra.UseVisualStyleBackColor = true;
            this.KiemTra.Click += new System.EventHandler(this.KiemTra_Click);
            // 
            // ThemPhieuKhamBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 493);
            this.Controls.Add(this.KiemTra);
            this.Controls.Add(this.gird);
            this.Controls.Add(this.benh);
            this.Controls.Add(this.mabenhnhan);
            this.Controls.Add(this.ngayKham);
            this.Controls.Add(this.trieuchung);
            this.Controls.Add(this.maPKB);
            this.Controls.Add(this.hoten);
            this.Controls.Add(this.huy);
            this.Controls.Add(this.KeToa);
            this.Controls.Add(this.LapPhieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemPhieuKhamBenh";
            this.Text = "ThemPhieuKhamBenh";
            ((System.ComponentModel.ISupportInitialize)(this.gird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button LapPhieu;
        private System.Windows.Forms.Button KeToa;
        private System.Windows.Forms.Button huy;
        private System.Windows.Forms.TextBox hoten;
        private System.Windows.Forms.TextBox maPKB;
        private System.Windows.Forms.TextBox trieuchung;
        private System.Windows.Forms.TextBox ngayKham;
        private System.Windows.Forms.ComboBox mabenhnhan;
        private System.Windows.Forms.ComboBox benh;
        private System.Windows.Forms.DataGridView gird;
        private System.Windows.Forms.Button KiemTra;
    }
}