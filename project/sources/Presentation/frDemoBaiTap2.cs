using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation
{
    public partial class frDemoBaiTap2 : Form
    {
        public frDemoBaiTap2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frQuanLyDaiLy frm = new frQuanLyDaiLy();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frTraCuuDaiLy frm = new frTraCuuDaiLy();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frQuanLyLoaiDaiLy frm = new frQuanLyLoaiDaiLy();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frQuanLyQuan frm = new frQuanLyQuan();
            frm.ShowDialog();
        }

        private void buttonLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            //frLapPhieuThuTien frm = new frLapPhieuThuTien();
            //frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frQuanLyMatHang frm = new frQuanLyMatHang();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frQuanLyBangGia frm = new frQuanLyBangGia();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frQuanLyDonViTinh frm = new frQuanLyDonViTinh();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frThemPhieuXuat frm = new frThemPhieuXuat();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frLapPhieuThuTien frm = new frLapPhieuThuTien();
            frm.ShowDialog();
        }
    }
}
