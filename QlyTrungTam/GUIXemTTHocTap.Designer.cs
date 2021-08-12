namespace QlyTrungTam
{
    partial class GUIXemTTHocTap
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
            this.lhtpi = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.p3dtgv = new System.Windows.Forms.DataGridView();
            this.p3lichhoc = new System.Windows.Forms.ComboBox();
            this.p3nh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.p3hocki = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kilb = new System.Windows.Forms.Label();
            this.dtlt = new System.Windows.Forms.DataGridView();
            this.nhcbb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hkcbb = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tttpi = new System.Windows.Forms.TabPage();
            this.ltcbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpi = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbHVKHTinhTrang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbHVKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbHVLoaiKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtgvHVDiem = new System.Windows.Forms.DataGridView();
            this.lhtpi.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3dtgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlt)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tttpi.SuspendLayout();
            this.dtpi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHVDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lhtpi
            // 
            this.lhtpi.Controls.Add(this.panel2);
            this.lhtpi.Location = new System.Drawing.Point(8, 26);
            this.lhtpi.Margin = new System.Windows.Forms.Padding(6);
            this.lhtpi.Name = "lhtpi";
            this.lhtpi.Size = new System.Drawing.Size(1563, 810);
            this.lhtpi.TabIndex = 2;
            this.lhtpi.Text = "Lịch học";
            this.lhtpi.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.p3dtgv);
            this.panel2.Controls.Add(this.p3lichhoc);
            this.panel2.Controls.Add(this.p3nh);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.p3hocki);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1551, 798);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Lịch học:";
            // 
            // p3dtgv
            // 
            this.p3dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.p3dtgv.Location = new System.Drawing.Point(14, 74);
            this.p3dtgv.Margin = new System.Windows.Forms.Padding(6);
            this.p3dtgv.Name = "p3dtgv";
            this.p3dtgv.RowHeadersWidth = 40;
            this.p3dtgv.Size = new System.Drawing.Size(1531, 718);
            this.p3dtgv.TabIndex = 9;
            // 
            // p3lichhoc
            // 
            this.p3lichhoc.FormattingEnabled = true;
            this.p3lichhoc.Items.AddRange(new object[] {
            "Chứng chỉ",
            "Kỹ thuật",
            "Chuyên đề"});
            this.p3lichhoc.Location = new System.Drawing.Point(704, 19);
            this.p3lichhoc.Margin = new System.Windows.Forms.Padding(6);
            this.p3lichhoc.Name = "p3lichhoc";
            this.p3lichhoc.Size = new System.Drawing.Size(136, 33);
            this.p3lichhoc.TabIndex = 11;
            this.p3lichhoc.SelectedIndexChanged += new System.EventHandler(this.p3lichhoc_SelectedIndexChanged);
            // 
            // p3nh
            // 
            this.p3nh.FormattingEnabled = true;
            this.p3nh.Location = new System.Drawing.Point(1252, 19);
            this.p3nh.Margin = new System.Windows.Forms.Padding(6);
            this.p3nh.Name = "p3nh";
            this.p3nh.Size = new System.Drawing.Size(136, 33);
            this.p3nh.TabIndex = 8;
            this.p3nh.SelectedIndexChanged += new System.EventHandler(this.p3nh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1127, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Năm học:";
            // 
            // p3hocki
            // 
            this.p3hocki.FormattingEnabled = true;
            this.p3hocki.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.p3hocki.Location = new System.Drawing.Point(984, 19);
            this.p3hocki.Margin = new System.Windows.Forms.Padding(6);
            this.p3hocki.Name = "p3hocki";
            this.p3hocki.Size = new System.Drawing.Size(92, 33);
            this.p3hocki.TabIndex = 6;
            this.p3hocki.Text = "1";
            this.p3hocki.SelectedIndexChanged += new System.EventHandler(this.p3hocki_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(883, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Học kì:";
            // 
            // kilb
            // 
            this.kilb.AutoSize = true;
            this.kilb.Location = new System.Drawing.Point(912, 40);
            this.kilb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.kilb.Name = "kilb";
            this.kilb.Size = new System.Drawing.Size(78, 25);
            this.kilb.TabIndex = 0;
            this.kilb.Text = "Học kì:";
            // 
            // dtlt
            // 
            this.dtlt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlt.Location = new System.Drawing.Point(12, 80);
            this.dtlt.Margin = new System.Windows.Forms.Padding(6);
            this.dtlt.Name = "dtlt";
            this.dtlt.RowHeadersWidth = 40;
            this.dtlt.Size = new System.Drawing.Size(1545, 718);
            this.dtlt.TabIndex = 4;
            // 
            // nhcbb
            // 
            this.nhcbb.FormattingEnabled = true;
            this.nhcbb.Location = new System.Drawing.Point(1384, 35);
            this.nhcbb.Margin = new System.Windows.Forms.Padding(6);
            this.nhcbb.Name = "nhcbb";
            this.nhcbb.Size = new System.Drawing.Size(136, 33);
            this.nhcbb.TabIndex = 3;
            this.nhcbb.SelectedIndexChanged += new System.EventHandler(this.nhcbb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1242, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm học:";
            // 
            // hkcbb
            // 
            this.hkcbb.FormattingEnabled = true;
            this.hkcbb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.hkcbb.Location = new System.Drawing.Point(1026, 35);
            this.hkcbb.Margin = new System.Windows.Forms.Padding(6);
            this.hkcbb.Name = "hkcbb";
            this.hkcbb.Size = new System.Drawing.Size(92, 33);
            this.hkcbb.TabIndex = 1;
            this.hkcbb.Text = "1";
            this.hkcbb.SelectedIndexChanged += new System.EventHandler(this.hkcbb_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tttpi);
            this.tabControl1.Controls.Add(this.dtpi);
            this.tabControl1.Controls.Add(this.lhtpi);
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 18);
            this.tabControl1.Location = new System.Drawing.Point(6, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 844);
            this.tabControl1.TabIndex = 1;
            // 
            // tttpi
            // 
            this.tttpi.Controls.Add(this.ltcbb);
            this.tttpi.Controls.Add(this.label6);
            this.tttpi.Controls.Add(this.dtlt);
            this.tttpi.Controls.Add(this.nhcbb);
            this.tttpi.Controls.Add(this.label1);
            this.tttpi.Controls.Add(this.hkcbb);
            this.tttpi.Controls.Add(this.kilb);
            this.tttpi.Location = new System.Drawing.Point(8, 26);
            this.tttpi.Margin = new System.Windows.Forms.Padding(6);
            this.tttpi.Name = "tttpi";
            this.tttpi.Padding = new System.Windows.Forms.Padding(6);
            this.tttpi.Size = new System.Drawing.Size(1563, 810);
            this.tttpi.TabIndex = 0;
            this.tttpi.Text = "Lịch thi";
            this.tttpi.UseVisualStyleBackColor = true;
            // 
            // ltcbb
            // 
            this.ltcbb.FormattingEnabled = true;
            this.ltcbb.Items.AddRange(new object[] {
            "Chứng chỉ",
            "Kỹ thuật",
            "Tốt nghiệp"});
            this.ltcbb.Location = new System.Drawing.Point(680, 35);
            this.ltcbb.Margin = new System.Windows.Forms.Padding(6);
            this.ltcbb.Name = "ltcbb";
            this.ltcbb.Size = new System.Drawing.Size(136, 33);
            this.ltcbb.TabIndex = 6;
            this.ltcbb.SelectedIndexChanged += new System.EventHandler(this.ltcbb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lịch thi:";
            // 
            // dtpi
            // 
            this.dtpi.Controls.Add(this.panel1);
            this.dtpi.Location = new System.Drawing.Point(8, 26);
            this.dtpi.Margin = new System.Windows.Forms.Padding(6);
            this.dtpi.Name = "dtpi";
            this.dtpi.Padding = new System.Windows.Forms.Padding(6);
            this.dtpi.Size = new System.Drawing.Size(1563, 810);
            this.dtpi.TabIndex = 1;
            this.dtpi.Text = "Điểm";
            this.dtpi.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dtgvHVDiem);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 798);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(5, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1536, 100);
            this.panel3.TabIndex = 12;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbHVKHTinhTrang);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(997, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(522, 80);
            this.panel6.TabIndex = 16;
            // 
            // cbHVKHTinhTrang
            // 
            this.cbHVKHTinhTrang.Enabled = false;
            this.cbHVKHTinhTrang.Location = new System.Drawing.Point(147, 27);
            this.cbHVKHTinhTrang.Margin = new System.Windows.Forms.Padding(6);
            this.cbHVKHTinhTrang.Name = "cbHVKHTinhTrang";
            this.cbHVKHTinhTrang.Size = new System.Drawing.Size(357, 31);
            this.cbHVKHTinhTrang.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label12.Location = new System.Drawing.Point(4, 24);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 32);
            this.label12.TabIndex = 12;
            this.label12.Text = "Tình Trạng:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbHVKhoaHoc);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Location = new System.Drawing.Point(506, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(485, 80);
            this.panel5.TabIndex = 15;
            // 
            // cbHVKhoaHoc
            // 
            this.cbHVKhoaHoc.FormattingEnabled = true;
            this.cbHVKhoaHoc.Location = new System.Drawing.Point(124, 24);
            this.cbHVKhoaHoc.Name = "cbHVKhoaHoc";
            this.cbHVKhoaHoc.Size = new System.Drawing.Size(339, 33);
            this.cbHVKhoaHoc.TabIndex = 13;
            this.cbHVKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbHVKhoaHoc_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label11.Location = new System.Drawing.Point(4, 24);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 32);
            this.label11.TabIndex = 12;
            this.label11.Text = "Khóa học:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbHVLoaiKhoaHoc);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Location = new System.Drawing.Point(15, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(485, 80);
            this.panel4.TabIndex = 14;
            // 
            // cbHVLoaiKhoaHoc
            // 
            this.cbHVLoaiKhoaHoc.FormattingEnabled = true;
            this.cbHVLoaiKhoaHoc.Location = new System.Drawing.Point(179, 24);
            this.cbHVLoaiKhoaHoc.Name = "cbHVLoaiKhoaHoc";
            this.cbHVLoaiKhoaHoc.Size = new System.Drawing.Size(284, 33);
            this.cbHVLoaiKhoaHoc.TabIndex = 13;
            this.cbHVLoaiKhoaHoc.SelectedIndexChanged += new System.EventHandler(this.cbHVLoaiKhoaHoc_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(4, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 32);
            this.label10.TabIndex = 12;
            this.label10.Text = "Loại khóa học:";
            // 
            // dtgvHVDiem
            // 
            this.dtgvHVDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHVDiem.Location = new System.Drawing.Point(10, 137);
            this.dtgvHVDiem.Margin = new System.Windows.Forms.Padding(6);
            this.dtgvHVDiem.Name = "dtgvHVDiem";
            this.dtgvHVDiem.RowHeadersWidth = 40;
            this.dtgvHVDiem.Size = new System.Drawing.Size(1514, 655);
            this.dtgvHVDiem.TabIndex = 9;
            // 
            // GUIXemTTHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GUIXemTTHocTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem thông tin học tập";
            this.lhtpi.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p3dtgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtlt)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tttpi.ResumeLayout(false);
            this.tttpi.PerformLayout();
            this.dtpi.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHVDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage lhtpi;
        private System.Windows.Forms.Label kilb;
        private System.Windows.Forms.DataGridView dtlt;
        private System.Windows.Forms.ComboBox nhcbb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox hkcbb;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tttpi;
        private System.Windows.Forms.ComboBox ltcbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox p3lichhoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView p3dtgv;
        private System.Windows.Forms.ComboBox p3nh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox p3hocki;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage dtpi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvHVDiem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbHVKhoaHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbHVLoaiKhoaHoc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox cbHVKHTinhTrang;
    }
}