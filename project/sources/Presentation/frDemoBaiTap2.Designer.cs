namespace Presentation
{
    partial class frDemoBaiTap2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonLapPhieuThuTien = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Quản lý đại lý";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 61);
            this.button2.TabIndex = 0;
            this.button2.Text = "Tra cứu đại lý";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 61);
            this.button3.TabIndex = 0;
            this.button3.Text = "Quản lý quận";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 61);
            this.button4.TabIndex = 0;
            this.button4.Text = "Quản lý loại đại lý";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonLapPhieuThuTien
            // 
            this.buttonLapPhieuThuTien.Location = new System.Drawing.Point(32, 251);
            this.buttonLapPhieuThuTien.Name = "buttonLapPhieuThuTien";
            this.buttonLapPhieuThuTien.Size = new System.Drawing.Size(129, 59);
            this.buttonLapPhieuThuTien.TabIndex = 1;
            this.buttonLapPhieuThuTien.Text = "Lập phiếu thu tiền";
            this.buttonLapPhieuThuTien.UseVisualStyleBackColor = true;
            this.buttonLapPhieuThuTien.Click += new System.EventHandler(this.buttonLapPhieuThuTien_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(200, 249);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 61);
            this.button5.TabIndex = 2;
            this.button5.Text = "Quản lý mặt hàng";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frDemoBaiTap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttonLapPhieuThuTien);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frDemoBaiTap2";
            this.Text = "Demo bài tập 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonLapPhieuThuTien;
        private System.Windows.Forms.Button button5;
    }
}