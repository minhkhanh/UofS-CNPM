namespace Presentation
{
    partial class frThemQuan
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
            this.cmdDong = new System.Windows.Forms.Button();
            this.cmdThem = new System.Windows.Forms.Button();
            this.numSoDaiLyToiDa = new System.Windows.Forms.NumericUpDown();
            this.txtTenQuan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSoDaiLyToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM QUẬN MỚI";
            // 
            // cmdDong
            // 
            this.cmdDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDong.Location = new System.Drawing.Point(273, 167);
            this.cmdDong.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDong.Name = "cmdDong";
            this.cmdDong.Size = new System.Drawing.Size(108, 38);
            this.cmdDong.TabIndex = 12;
            this.cmdDong.Text = "Đóng";
            this.cmdDong.UseVisualStyleBackColor = true;
            this.cmdDong.Click += new System.EventHandler(this.cmdDong_Click);
            // 
            // cmdThem
            // 
            this.cmdThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThem.Location = new System.Drawing.Point(112, 168);
            this.cmdThem.Margin = new System.Windows.Forms.Padding(4);
            this.cmdThem.Name = "cmdThem";
            this.cmdThem.Size = new System.Drawing.Size(119, 37);
            this.cmdThem.TabIndex = 11;
            this.cmdThem.Text = "Thêm";
            this.cmdThem.UseVisualStyleBackColor = true;
            this.cmdThem.Click += new System.EventHandler(this.cmdThem_Click);
            // 
            // numSoDaiLyToiDa
            // 
            this.numSoDaiLyToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoDaiLyToiDa.Location = new System.Drawing.Point(154, 121);
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
            this.numSoDaiLyToiDa.TabIndex = 10;
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
            this.txtTenQuan.Location = new System.Drawing.Point(153, 74);
            this.txtTenQuan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenQuan.Name = "txtTenQuan";
            this.txtTenQuan.Size = new System.Drawing.Size(228, 23);
            this.txtTenQuan.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Số đại lý tối đa tối đa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên quận";
            // 
            // frThemQuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 218);
            this.Controls.Add(this.cmdDong);
            this.Controls.Add(this.cmdThem);
            this.Controls.Add(this.numSoDaiLyToiDa);
            this.Controls.Add(this.txtTenQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frThemQuan";
            this.Text = "Thêm quận mới";
            ((System.ComponentModel.ISupportInitialize)(this.numSoDaiLyToiDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdDong;
        private System.Windows.Forms.Button cmdThem;
        private System.Windows.Forms.NumericUpDown numSoDaiLyToiDa;
        private System.Windows.Forms.TextBox txtTenQuan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}