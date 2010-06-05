namespace Presentation
{
    partial class frQuanLyLoaiDaiLy
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
            this.gridLoaiDaiLy = new System.Windows.Forms.DataGridView();
            this.colMaLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLoaiDaiLy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numNoToiDa = new System.Windows.Forms.NumericUpDown();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdThem = new System.Windows.Forms.Button();
            this.cmdCapNhat = new System.Windows.Forms.Button();
            this.cmdDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiDaiLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ LOẠI ĐẠI LÝ";
            // 
            // gridLoaiDaiLy
            // 
            this.gridLoaiDaiLy.AllowUserToAddRows = false;
            this.gridLoaiDaiLy.AllowUserToDeleteRows = false;
            this.gridLoaiDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLoaiDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLoaiDaiLy,
            this.colTenLoaiDaiLy,
            this.colNoToiDa});
            this.gridLoaiDaiLy.Location = new System.Drawing.Point(18, 161);
            this.gridLoaiDaiLy.MultiSelect = false;
            this.gridLoaiDaiLy.Name = "gridLoaiDaiLy";
            this.gridLoaiDaiLy.RowHeadersVisible = false;
            this.gridLoaiDaiLy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLoaiDaiLy.Size = new System.Drawing.Size(334, 169);
            this.gridLoaiDaiLy.TabIndex = 1;
            this.gridLoaiDaiLy.SelectionChanged += new System.EventHandler(this.gridLoaiDaiLy_SelectionChanged);
            // 
            // colMaLoaiDaiLy
            // 
            this.colMaLoaiDaiLy.HeaderText = "Mã loại";
            this.colMaLoaiDaiLy.Name = "colMaLoaiDaiLy";
            this.colMaLoaiDaiLy.ReadOnly = true;
            // 
            // colTenLoaiDaiLy
            // 
            this.colTenLoaiDaiLy.HeaderText = "Tên loại";
            this.colTenLoaiDaiLy.Name = "colTenLoaiDaiLy";
            this.colTenLoaiDaiLy.ReadOnly = true;
            this.colTenLoaiDaiLy.Width = 130;
            // 
            // colNoToiDa
            // 
            this.colNoToiDa.HeaderText = "Nợ tối đa";
            this.colNoToiDa.Name = "colNoToiDa";
            this.colNoToiDa.ReadOnly = true;
            // 
            // numNoToiDa
            // 
            this.numNoToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numNoToiDa.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numNoToiDa.Location = new System.Drawing.Point(119, 115);
            this.numNoToiDa.Margin = new System.Windows.Forms.Padding(4);
            this.numNoToiDa.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numNoToiDa.Name = "numNoToiDa";
            this.numNoToiDa.Size = new System.Drawing.Size(228, 23);
            this.numNoToiDa.TabIndex = 8;
            this.numNoToiDa.Tag = "VND";
            this.numNoToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numNoToiDa.ThousandsSeparator = true;
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoai.Location = new System.Drawing.Point(118, 68);
            this.txtTenLoai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(228, 23);
            this.txtTenLoai.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nợ tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên loại";
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(378, 68);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(96, 33);
            this.cmdThem.TabIndex = 9;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(378, 117);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(96, 31);
            this.cmdCapNhat.TabIndex = 10;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            this.cmdCapNhat.Click += new System.EventHandler(this.cmdCapNhat_Click);
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(378, 161);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(96, 30);
            this.cmdDong.TabIndex = 11;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // frQuanLyLoaiDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 336);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.numNoToiDa);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridLoaiDaiLy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frQuanLyLoaiDaiLy";
            this.Text = "Quản lý loại đại lý";
            this.Load += new System.EventHandler(this.frQuanLyLoaiDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLoaiDaiLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numNoToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoaiDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoToiDa;
        private System.Windows.Forms.NumericUpDown numNoToiDa;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdDong;
    }
}