namespace Presentation
{
    partial class frQuanLyBangGia
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
            this.cmdDong = new System.Windows.Forms.Button();
            this.cmdCapNhat = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridBangGia = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBangGia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(434, 163);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(96, 30);
            this.cmdDong.TabIndex = 27;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(434, 119);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(96, 31);
            this.cmdCapNhat.TabIndex = 26;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            this.cmdCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(434, 70);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(96, 33);
            this.cmdThem.TabIndex = 25;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(115, 74);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(228, 23);
            this.txtDonGia.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Đơn giá";
            // 
            // gridBangGia
            // 
            this.gridBangGia.AllowUserToAddRows = false;
            this.gridBangGia.AllowUserToDeleteRows = false;
            this.gridBangGia.AllowUserToResizeRows = false;
            this.gridBangGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBangGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMatHang,
            this.maDonViTinh,
            this.tenMatHang,
            this.tenDonViTinh,
            this.donGia});
            this.gridBangGia.Location = new System.Drawing.Point(15, 123);
            this.gridBangGia.MultiSelect = false;
            this.gridBangGia.Name = "gridBangGia";
            this.gridBangGia.RowHeadersVisible = false;
            this.gridBangGia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBangGia.Size = new System.Drawing.Size(402, 213);
            this.gridBangGia.TabIndex = 22;
            this.gridBangGia.SelectionChanged += new System.EventHandler(this.gridBangGia_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "QUẢN LÝ BẢNG GIÁ";
            // 
            // maMatHang
            // 
            this.maMatHang.HeaderText = "Mã mặt hàng";
            this.maMatHang.Name = "maMatHang";
            this.maMatHang.ReadOnly = true;
            this.maMatHang.Visible = false;
            // 
            // maDonViTinh
            // 
            this.maDonViTinh.HeaderText = "Mã đơn vị tính";
            this.maDonViTinh.Name = "maDonViTinh";
            this.maDonViTinh.ReadOnly = true;
            this.maDonViTinh.Visible = false;
            // 
            // tenMatHang
            // 
            this.tenMatHang.HeaderText = "Tên mặt hàng";
            this.tenMatHang.Name = "tenMatHang";
            this.tenMatHang.ReadOnly = true;
            // 
            // tenDonViTinh
            // 
            this.tenDonViTinh.HeaderText = "Tên đơn vị tính";
            this.tenDonViTinh.Name = "tenDonViTinh";
            this.tenDonViTinh.ReadOnly = true;
            this.tenDonViTinh.Width = 120;
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            this.donGia.Width = 170;
            // 
            // frQuanLyBangGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 350);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridBangGia);
            this.Controls.Add(this.label1);
            this.Name = "frQuanLyBangGia";
            this.Text = "frQuanLyBangGia";
            this.Load += new System.EventHandler(this.frQuanLyBangGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBangGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridBangGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
    }
}