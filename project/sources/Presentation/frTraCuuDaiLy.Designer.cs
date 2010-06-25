namespace Presentation
{
    partial class frTraCuuDaiLy
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
            this.gridDaiLy = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDaiLy = new System.Windows.Forms.TextBox();
            this.textBoxLoai = new System.Windows.Forms.TextBox();
            this.textBoxQuan = new System.Windows.Forms.TextBox();
            this.textBoxTienNo = new System.Windows.Forms.TextBox();
            this.buttonTraCuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDaiLy)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU ĐẠI LÝ";
            // 
            // gridDaiLy
            // 
            this.gridDaiLy.AllowUserToAddRows = false;
            this.gridDaiLy.AllowUserToDeleteRows = false;
            this.gridDaiLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDaiLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.gridDaiLy.Location = new System.Drawing.Point(3, 218);
            this.gridDaiLy.MultiSelect = false;
            this.gridDaiLy.Name = "gridDaiLy";
            this.gridDaiLy.RowHeadersVisible = false;
            this.gridDaiLy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDaiLy.Size = new System.Drawing.Size(605, 163);
            this.gridDaiLy.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã đại lý";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tên";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Loại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Quận";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tiền nợ";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Đại lý";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Loại Đại Lý";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quận";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(297, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tiền nợ";
            // 
            // textBoxDaiLy
            // 
            this.textBoxDaiLy.Location = new System.Drawing.Point(127, 64);
            this.textBoxDaiLy.Name = "textBoxDaiLy";
            this.textBoxDaiLy.Size = new System.Drawing.Size(126, 23);
            this.textBoxDaiLy.TabIndex = 10;
            // 
            // textBoxLoai
            // 
            this.textBoxLoai.Location = new System.Drawing.Point(127, 109);
            this.textBoxLoai.Name = "textBoxLoai";
            this.textBoxLoai.Size = new System.Drawing.Size(126, 23);
            this.textBoxLoai.TabIndex = 11;
            // 
            // textBoxQuan
            // 
            this.textBoxQuan.Location = new System.Drawing.Point(392, 64);
            this.textBoxQuan.Name = "textBoxQuan";
            this.textBoxQuan.Size = new System.Drawing.Size(126, 23);
            this.textBoxQuan.TabIndex = 12;
            // 
            // textBoxTienNo
            // 
            this.textBoxTienNo.Location = new System.Drawing.Point(392, 106);
            this.textBoxTienNo.Name = "textBoxTienNo";
            this.textBoxTienNo.Size = new System.Drawing.Size(126, 23);
            this.textBoxTienNo.TabIndex = 13;
            // 
            // buttonTraCuu
            // 
            this.buttonTraCuu.Location = new System.Drawing.Point(394, 160);
            this.buttonTraCuu.Name = "buttonTraCuu";
            this.buttonTraCuu.Size = new System.Drawing.Size(152, 29);
            this.buttonTraCuu.TabIndex = 14;
            this.buttonTraCuu.Text = "Tra cứu";
            this.buttonTraCuu.UseVisualStyleBackColor = true;
            this.buttonTraCuu.Click += new System.EventHandler(this.buttonTraCuu_Click);
            // 
            // frTraCuuDaiLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 393);
            this.Controls.Add(this.buttonTraCuu);
            this.Controls.Add(this.textBoxTienNo);
            this.Controls.Add(this.textBoxQuan);
            this.Controls.Add(this.textBoxLoai);
            this.Controls.Add(this.textBoxDaiLy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridDaiLy);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frTraCuuDaiLy";
            this.Text = "Tra cứu đại lý";
            this.Load += new System.EventHandler(this.frTraCuuDaiLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDaiLy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridDaiLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDaiLy;
        private System.Windows.Forms.TextBox textBoxLoai;
        private System.Windows.Forms.TextBox textBoxQuan;
        private System.Windows.Forms.TextBox textBoxTienNo;
        private System.Windows.Forms.Button buttonTraCuu;
    }
}