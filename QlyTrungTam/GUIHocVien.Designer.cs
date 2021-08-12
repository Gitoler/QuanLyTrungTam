namespace QlyTrungTam
{
    partial class GUIHocVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvHVKhoaHoc = new System.Windows.Forms.DataGridView();
            this.qlttmnStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.xtthtmni = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStrip = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rtxtHVMoTa = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtHVKhoaHocOpening = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbHVKhoaHocName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbHVKhoaHocID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbHVLoaiKhoaHoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHVKhoaHoc)).BeginInit();
            this.mnStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvHVKhoaHoc);
            this.groupBox1.Location = new System.Drawing.Point(15, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(754, 807);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khoá học ";
            // 
            // dtgvHVKhoaHoc
            // 
            this.dtgvHVKhoaHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHVKhoaHoc.Location = new System.Drawing.Point(10, 34);
            this.dtgvHVKhoaHoc.Name = "dtgvHVKhoaHoc";
            this.dtgvHVKhoaHoc.RowHeadersWidth = 82;
            this.dtgvHVKhoaHoc.RowTemplate.Height = 33;
            this.dtgvHVKhoaHoc.Size = new System.Drawing.Size(725, 764);
            this.dtgvHVKhoaHoc.TabIndex = 0;
            // 
            // qlttmnStrip
            // 
            this.qlttmnStrip.Name = "qlttmnStrip";
            this.qlttmnStrip.Size = new System.Drawing.Size(218, 36);
            this.qlttmnStrip.Text = "Quản lí thông tin";
            this.qlttmnStrip.Click += new System.EventHandler(this.qlttmnStrip_Click);
            // 
            // xtthtmni
            // 
            this.xtthtmni.Name = "xtthtmni";
            this.xtthtmni.Size = new System.Drawing.Size(226, 36);
            this.xtthtmni.Text = "Thông tin học tập";
            this.xtthtmni.Click += new System.EventHandler(this.xtthtmni_Click);
            // 
            // mnStrip
            // 
            this.mnStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mnStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qlttmnStrip,
            this.xtthtmni});
            this.mnStrip.Location = new System.Drawing.Point(0, 0);
            this.mnStrip.Name = "mnStrip";
            this.mnStrip.Size = new System.Drawing.Size(1600, 40);
            this.mnStrip.TabIndex = 5;
            this.mnStrip.Text = "mnStrip";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(779, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 807);
            this.panel1.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rtxtHVMoTa);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(4, 352);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(799, 446);
            this.panel6.TabIndex = 8;
            // 
            // rtxtHVMoTa
            // 
            this.rtxtHVMoTa.Location = new System.Drawing.Point(7, 46);
            this.rtxtHVMoTa.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtHVMoTa.Name = "rtxtHVMoTa";
            this.rtxtHVMoTa.Size = new System.Drawing.Size(788, 377);
            this.rtxtHVMoTa.TabIndex = 2;
            this.rtxtHVMoTa.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.dtHVKhoaHocOpening);
            this.panel5.Location = new System.Drawing.Point(3, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(803, 81);
            this.panel5.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày Bắt Đầu:";
            // 
            // dtHVKhoaHocOpening
            // 
            this.dtHVKhoaHocOpening.Location = new System.Drawing.Point(168, 22);
            this.dtHVKhoaHocOpening.Name = "dtHVKhoaHocOpening";
            this.dtHVKhoaHocOpening.Size = new System.Drawing.Size(632, 31);
            this.dtHVKhoaHocOpening.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbHVKhoaHocName);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(803, 81);
            this.panel4.TabIndex = 4;
            // 
            // cbHVKhoaHocName
            // 
            this.cbHVKhoaHocName.FormattingEnabled = true;
            this.cbHVKhoaHocName.Location = new System.Drawing.Point(168, 19);
            this.cbHVKhoaHocName.Name = "cbHVKhoaHocName";
            this.cbHVKhoaHocName.Size = new System.Drawing.Size(632, 33);
            this.cbHVKhoaHocName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên Khóa Học:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txbHVKhoaHocID);
            this.panel3.Location = new System.Drawing.Point(3, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(803, 81);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID Khóa Học:";
            // 
            // txbHVKhoaHocID
            // 
            this.txbHVKhoaHocID.Enabled = false;
            this.txbHVKhoaHocID.Location = new System.Drawing.Point(168, 24);
            this.txbHVKhoaHocID.Name = "txbHVKhoaHocID";
            this.txbHVKhoaHocID.Size = new System.Drawing.Size(632, 31);
            this.txbHVKhoaHocID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbHVLoaiKhoaHoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 81);
            this.panel2.TabIndex = 2;
            // 
            // cbHVLoaiKhoaHoc
            // 
            this.cbHVLoaiKhoaHoc.FormattingEnabled = true;
            this.cbHVLoaiKhoaHoc.Location = new System.Drawing.Point(168, 19);
            this.cbHVLoaiKhoaHoc.Name = "cbHVLoaiKhoaHoc";
            this.cbHVLoaiKhoaHoc.Size = new System.Drawing.Size(632, 33);
            this.cbHVLoaiKhoaHoc.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại Khóa Học:";
            // 
            // GUIHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mnStrip);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "GUIHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Học viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUIHocVien_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHVKhoaHoc)).EndInit();
            this.mnStrip.ResumeLayout(false);
            this.mnStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem qlttmnStrip;
        private System.Windows.Forms.ToolStripMenuItem xtthtmni;
        private System.Windows.Forms.MenuStrip mnStrip;
        private System.Windows.Forms.DataGridView dtgvHVKhoaHoc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtHVKhoaHocOpening;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbHVKhoaHocName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbHVKhoaHocID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbHVLoaiKhoaHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox rtxtHVMoTa;
        private System.Windows.Forms.Label label5;
    }
}