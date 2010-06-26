namespace Presentation
{
    partial class frQuanLyDonViTinh
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
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDonViTinh = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridDonViTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(370, 155);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(96, 30);
            this.cmdDong.TabIndex = 27;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(370, 111);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(96, 31);
            this.cmdCapNhat.TabIndex = 26;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            this.cmdCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(370, 62);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(96, 33);
            this.cmdThem.TabIndex = 25;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.Location = new System.Drawing.Point(110, 62);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(228, 23);
            this.txtDonViTinh.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tên đơn vị tính";
            // 
            // gridDonViTinh
            // 
            this.gridDonViTinh.AllowUserToAddRows = false;
            this.gridDonViTinh.AllowUserToDeleteRows = false;
            this.gridDonViTinh.AllowUserToResizeRows = false;
            this.gridDonViTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDonViTinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDonViTinh,
            this.tenDonViTinh});
            this.gridDonViTinh.Location = new System.Drawing.Point(10, 111);
            this.gridDonViTinh.MultiSelect = false;
            this.gridDonViTinh.Name = "gridDonViTinh";
            this.gridDonViTinh.RowHeadersVisible = false;
            this.gridDonViTinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDonViTinh.Size = new System.Drawing.Size(334, 213);
            this.gridDonViTinh.TabIndex = 22;
            this.gridDonViTinh.SelectionChanged += new System.EventHandler(this.gridDonViTinh_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "QUẢN LÝ CÁC ĐƠN VỊ TÍNH";
            // 
            // maDonViTinh
            // 
            this.maDonViTinh.HeaderText = "Mã đơn vị tính";
            this.maDonViTinh.Name = "maDonViTinh";
            this.maDonViTinh.ReadOnly = true;
            // 
            // tenDonViTinh
            // 
            this.tenDonViTinh.HeaderText = "Tên đơn vị tính";
            this.tenDonViTinh.Name = "tenDonViTinh";
            this.tenDonViTinh.ReadOnly = true;
            this.tenDonViTinh.Width = 230;
            // 
            // frQuanLyDonViTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 337);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDonViTinh);
            this.Controls.Add(this.label1);
            this.Name = "frQuanLyDonViTinh";
            this.Text = "frQuanLyDonViTinh";
            this.Load += new System.EventHandler(this.frQuanLyDonViTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDonViTinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridDonViTinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDonViTinh;
    }
}