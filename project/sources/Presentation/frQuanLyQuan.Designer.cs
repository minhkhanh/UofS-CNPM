namespace Presentation
{
    partial class frQuanLyQuan
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
            this.numSoDaiLyToiDa = new System.Windows.Forms.NumericUpDown();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridQuan = new System.Windows.Forms.DataGridView();
            this.colMaLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDaiLyToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(409, 160);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(96, 30);
            this.cmdDong.TabIndex = 20;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(409, 116);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(96, 31);
            this.cmdCapNhat.TabIndex = 19;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            this.cmdCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(409, 67);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(96, 33);
            this.cmdThem.TabIndex = 18;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // numSoDaiLyToiDa
            // 
            this.numSoDaiLyToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoDaiLyToiDa.Location = new System.Drawing.Point(114, 114);
            this.numSoDaiLyToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.numSoDaiLyToiDa.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numSoDaiLyToiDa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoDaiLyToiDa.Name = "numSoDaiLyToiDa";
            this.numSoDaiLyToiDa.Size = new System.Drawing.Size(228, 23);
            this.numSoDaiLyToiDa.TabIndex = 17;
            this.numSoDaiLyToiDa.Tag = "";
            this.numSoDaiLyToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numSoDaiLyToiDa.ThousandsSeparator = true;
            this.numSoDaiLyToiDa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTenQuan
            // 
            this.txtTenQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenQuan.Location = new System.Drawing.Point(113, 67);
            this.txtTenQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(228, 23);
            this.txtTenQuan.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số đại lý tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên quận";
            // 
            // gridQuan
            // 
            this.gridQuan.AllowUserToAddRows = false;
            this.gridQuan.AllowUserToDeleteRows = false;
            this.gridQuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQuan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiDaiLy,
            this.colTenLoaiDaiLy,
            this.colNoToiDa});
            this.gridQuan.Location = new System.Drawing.Point(13, 155);
            this.gridQuan.MultiSelect = false;
            this.gridQuan.Name = "gridQuan";
            this.gridQuan.RowHeadersVisible = false;
            this.gridQuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridQuan.Size = new System.Drawing.Size(390, 169);
            this.gridQuan.TabIndex = 13;
            this.gridQuan.SelectionChanged += new System.EventHandler(this.gridQuan_SelectionChanged);
            // 
            // colMaLoaiDaiLy
            // 
            this.colMaLoaiDaiLy.HeaderText = "Mã quận";
            this.colMaLoaiDaiLy.Name = "colMaLoaiDaiLy";
            this.colMaLoaiDaiLy.ReadOnly = true;
            // 
            // colTenLoaiDaiLy
            // 
            this.colTenLoaiDaiLy.HeaderText = "Tên quận";
            this.colTenLoaiDaiLy.Name = "colTenLoaiDaiLy";
            this.colTenLoaiDaiLy.ReadOnly = true;
            this.colTenLoaiDaiLy.Width = 130;
            // 
            // colNoToiDa
            // 
            this.colNoToiDa.HeaderText = "Số đại lý tối đa";
            this.colNoToiDa.Name = "colNoToiDa";
            this.colNoToiDa.ReadOnly = true;
            this.colNoToiDa.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ QUẬN";
            // 
            // frQuanLyQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 336);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.numSoDaiLyToiDa);
            this.Controls.Add(this.txtTenQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridQuan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frQuanLyQuan";
            this.Text = "Quản lý quận";
            this.Load += new System.EventHandler(this.frQuanLyQuan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSoDaiLyToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridQuan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.NumericUpDown numSoDaiLyToiDa;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridQuan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoToiDa;
    }
}