namespace Presentation
{
    partial class frQuanLyMatHang
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
            this.txtTenMatHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridMatHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.maMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdDong
            // 
            this.cmdDong.Location = new System.Drawing.Point(372, 161);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(96, 30);
            this.cmdDong.TabIndex = 20;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            // 
            // cmdCapNhat
            // 
            this.cmdCapNhat.Location = new System.Drawing.Point(372, 117);
            this.cmdCapNhat.Name = "cmdCapNhat";
            this.cmdCapNhat.Size = new System.Drawing.Size(96, 31);
            this.cmdCapNhat.TabIndex = 19;
            this.cmdCapNhat.Text = "Cập nhật";
            this.cmdCapNhat.UseVisualStyleBackColor = true;
            // 
            // cmdThem
            // 
            this.cmdThem.Location = new System.Drawing.Point(372, 68);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(96, 33);
            this.cmdThem.TabIndex = 18;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            // 
            // txtTenMatHang
            // 
            this.txtTenMatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMatHang.Location = new System.Drawing.Point(112, 68);
            this.txtTenMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMatHang.Name = "txtTenMatHang";
            this.txtTenMatHang.Size = new System.Drawing.Size(228, 23);
            this.txtTenMatHang.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên mặt hàng";
            // 
            // gridMatHang
            // 
            this.gridMatHang.AllowUserToAddRows = false;
            this.gridMatHang.AllowUserToDeleteRows = false;
            this.gridMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMatHang,
            this.tenMatHang});
            this.gridMatHang.Location = new System.Drawing.Point(12, 117);
            this.gridMatHang.MultiSelect = false;
            this.gridMatHang.Name = "gridMatHang";
            this.gridMatHang.RowHeadersVisible = false;
            this.gridMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMatHang.Size = new System.Drawing.Size(334, 213);
            this.gridMatHang.TabIndex = 13;
            this.gridMatHang.SelectionChanged += new System.EventHandler(this.gridMatHang_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "QUẢN LÝ CÁC MẶT HÀNG";
            // 
            // maMatHang
            // 
            this.maMatHang.HeaderText = "Mã mặt hàng";
            this.maMatHang.Name = "maMatHang";
            this.maMatHang.ReadOnly = true;
            // 
            // tenMatHang
            // 
            this.tenMatHang.HeaderText = "Tên mặt hàng";
            this.tenMatHang.Name = "tenMatHang";
            this.tenMatHang.ReadOnly = true;
            this.tenMatHang.Width = 230;
            // 
            // frQuanLyMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 336);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdCapNhat);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.txtTenMatHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridMatHang);
            this.Controls.Add(this.label1);
            this.Name = "frQuanLyMatHang";
            this.Text = "frQuanLyMatHang";
            this.Load += new System.EventHandler(this.frQuanLyMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button cmdCapNhat;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.TextBox txtTenMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridMatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMatHang;
    }
}