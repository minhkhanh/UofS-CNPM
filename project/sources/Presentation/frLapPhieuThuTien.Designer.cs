namespace Presentation
{
    partial class frLapPhieuThuTien
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
            this.crystalReportViewerLapPhieuThuTien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.buttonLapPhieuThuTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenDaiLy = new System.Windows.Forms.TextBox();
            this.textBoxSoTienThu = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgayThuTien = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMaDaiLy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonThemPhieuTien = new System.Windows.Forms.Button();
            this.buttonCapNhapPhieuThuTien = new System.Windows.Forms.Button();
            this.buttonXoaPhieuThuTien = new System.Windows.Forms.Button();
            this.dataGridViewPhieuThuTien = new System.Windows.Forms.DataGridView();
            this.MaPhieuThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayThuTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuThuTien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập phiếu thu tiền";
            // 
            // crystalReportViewerLapPhieuThuTien
            // 
            this.crystalReportViewerLapPhieuThuTien.ActiveViewIndex = -1;
            this.crystalReportViewerLapPhieuThuTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerLapPhieuThuTien.Location = new System.Drawing.Point(12, 404);
            this.crystalReportViewerLapPhieuThuTien.Name = "crystalReportViewerLapPhieuThuTien";
            this.crystalReportViewerLapPhieuThuTien.SelectionFormula = "";
            this.crystalReportViewerLapPhieuThuTien.Size = new System.Drawing.Size(604, 305);
            this.crystalReportViewerLapPhieuThuTien.TabIndex = 1;
            this.crystalReportViewerLapPhieuThuTien.ViewTimeSelectionFormula = "";
            // 
            // buttonLapPhieuThuTien
            // 
            this.buttonLapPhieuThuTien.Location = new System.Drawing.Point(432, 375);
            this.buttonLapPhieuThuTien.Name = "buttonLapPhieuThuTien";
            this.buttonLapPhieuThuTien.Size = new System.Drawing.Size(125, 23);
            this.buttonLapPhieuThuTien.TabIndex = 2;
            this.buttonLapPhieuThuTien.Text = "Lập phiếu thu tiền";
            this.buttonLapPhieuThuTien.UseVisualStyleBackColor = true;
            this.buttonLapPhieuThuTien.Click += new System.EventHandler(this.buttonLapPhieuThuTien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày thu tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đại lý";
            // 
            // textBoxTenDaiLy
            // 
            this.textBoxTenDaiLy.Enabled = false;
            this.textBoxTenDaiLy.Location = new System.Drawing.Point(150, 133);
            this.textBoxTenDaiLy.Name = "textBoxTenDaiLy";
            this.textBoxTenDaiLy.Size = new System.Drawing.Size(124, 20);
            this.textBoxTenDaiLy.TabIndex = 7;
            // 
            // textBoxSoTienThu
            // 
            this.textBoxSoTienThu.Location = new System.Drawing.Point(150, 175);
            this.textBoxSoTienThu.Name = "textBoxSoTienThu";
            this.textBoxSoTienThu.Size = new System.Drawing.Size(124, 20);
            this.textBoxSoTienThu.TabIndex = 8;
            // 
            // dateTimePickerNgayThuTien
            // 
            this.dateTimePickerNgayThuTien.Location = new System.Drawing.Point(150, 52);
            this.dateTimePickerNgayThuTien.Name = "dateTimePickerNgayThuTien";
            this.dateTimePickerNgayThuTien.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayThuTien.TabIndex = 9;
            // 
            // comboBoxMaDaiLy
            // 
            this.comboBoxMaDaiLy.FormattingEnabled = true;
            this.comboBoxMaDaiLy.Location = new System.Drawing.Point(150, 91);
            this.comboBoxMaDaiLy.Name = "comboBoxMaDaiLy";
            this.comboBoxMaDaiLy.Size = new System.Drawing.Size(124, 21);
            this.comboBoxMaDaiLy.TabIndex = 10;
            this.comboBoxMaDaiLy.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaDaiLy_SelectedIndexChanged);
            this.comboBoxMaDaiLy.DropDown += new System.EventHandler(this.comboBoxMaDaiLy_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số tiền thu";
            // 
            // buttonThemPhieuTien
            // 
            this.buttonThemPhieuTien.Location = new System.Drawing.Point(415, 58);
            this.buttonThemPhieuTien.Name = "buttonThemPhieuTien";
            this.buttonThemPhieuTien.Size = new System.Drawing.Size(125, 23);
            this.buttonThemPhieuTien.TabIndex = 12;
            this.buttonThemPhieuTien.Text = "Thêm phiếu thu tiền";
            this.buttonThemPhieuTien.UseVisualStyleBackColor = true;
            this.buttonThemPhieuTien.Click += new System.EventHandler(this.buttonThemPhieuTien_Click);
            // 
            // buttonCapNhapPhieuThuTien
            // 
            this.buttonCapNhapPhieuThuTien.Location = new System.Drawing.Point(415, 103);
            this.buttonCapNhapPhieuThuTien.Name = "buttonCapNhapPhieuThuTien";
            this.buttonCapNhapPhieuThuTien.Size = new System.Drawing.Size(125, 23);
            this.buttonCapNhapPhieuThuTien.TabIndex = 13;
            this.buttonCapNhapPhieuThuTien.Text = "Cập nhập phiếu thu tiền";
            this.buttonCapNhapPhieuThuTien.UseVisualStyleBackColor = true;
            this.buttonCapNhapPhieuThuTien.Click += new System.EventHandler(this.buttonCapNhapPhieuThuTien_Click);
            // 
            // buttonXoaPhieuThuTien
            // 
            this.buttonXoaPhieuThuTien.Location = new System.Drawing.Point(415, 146);
            this.buttonXoaPhieuThuTien.Name = "buttonXoaPhieuThuTien";
            this.buttonXoaPhieuThuTien.Size = new System.Drawing.Size(125, 23);
            this.buttonXoaPhieuThuTien.TabIndex = 14;
            this.buttonXoaPhieuThuTien.Text = "Xóa phiếu thu tiền";
            this.buttonXoaPhieuThuTien.UseVisualStyleBackColor = true;
            this.buttonXoaPhieuThuTien.Click += new System.EventHandler(this.buttonXoaPhieuThuTien_Click);
            // 
            // dataGridViewPhieuThuTien
            // 
            this.dataGridViewPhieuThuTien.AllowUserToAddRows = false;
            this.dataGridViewPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuThuTien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuThu,
            this.NgayThuTien,
            this.SoTienThu,
            this.MaDaiLy,
            this.Deleted});
            this.dataGridViewPhieuThuTien.Location = new System.Drawing.Point(12, 226);
            this.dataGridViewPhieuThuTien.MultiSelect = false;
            this.dataGridViewPhieuThuTien.Name = "dataGridViewPhieuThuTien";
            this.dataGridViewPhieuThuTien.RowHeadersVisible = false;
            this.dataGridViewPhieuThuTien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPhieuThuTien.Size = new System.Drawing.Size(604, 130);
            this.dataGridViewPhieuThuTien.TabIndex = 15;
            this.dataGridViewPhieuThuTien.SelectionChanged += new System.EventHandler(this.dataGridViewPhieuThuTien_SelectionChanged);
            // 
            // MaPhieuThu
            // 
            this.MaPhieuThu.HeaderText = "Mã phiếu thu";
            this.MaPhieuThu.Name = "MaPhieuThu";
            // 
            // NgayThuTien
            // 
            this.NgayThuTien.HeaderText = "Ngày thu tiền";
            this.NgayThuTien.Name = "NgayThuTien";
            this.NgayThuTien.Width = 150;
            // 
            // SoTienThu
            // 
            this.SoTienThu.HeaderText = "Số tiền thu";
            this.SoTienThu.Name = "SoTienThu";
            this.SoTienThu.Width = 150;
            // 
            // MaDaiLy
            // 
            this.MaDaiLy.HeaderText = "Mã đại lý";
            this.MaDaiLy.Name = "MaDaiLy";
            // 
            // Deleted
            // 
            this.Deleted.HeaderText = "Deleted";
            this.Deleted.Name = "Deleted";
            // 
            // frLapPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 721);
            this.Controls.Add(this.dataGridViewPhieuThuTien);
            this.Controls.Add(this.buttonXoaPhieuThuTien);
            this.Controls.Add(this.buttonCapNhapPhieuThuTien);
            this.Controls.Add(this.buttonThemPhieuTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxMaDaiLy);
            this.Controls.Add(this.dateTimePickerNgayThuTien);
            this.Controls.Add(this.textBoxSoTienThu);
            this.Controls.Add(this.textBoxTenDaiLy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLapPhieuThuTien);
            this.Controls.Add(this.crystalReportViewerLapPhieuThuTien);
            this.Controls.Add(this.label1);
            this.Name = "frLapPhieuThuTien";
            this.Text = "Phiếu thu tiền";
            this.Load += new System.EventHandler(this.frLapPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuThuTien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerLapPhieuThuTien;
        private System.Windows.Forms.Button buttonLapPhieuThuTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenDaiLy;
        private System.Windows.Forms.TextBox textBoxSoTienThu;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayThuTien;
        private System.Windows.Forms.ComboBox comboBoxMaDaiLy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonThemPhieuTien;
        private System.Windows.Forms.Button buttonCapNhapPhieuThuTien;
        private System.Windows.Forms.Button buttonXoaPhieuThuTien;
        private System.Windows.Forms.DataGridView dataGridViewPhieuThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayThuTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deleted;
    }
}