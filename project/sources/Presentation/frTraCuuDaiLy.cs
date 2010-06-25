using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;

namespace Presentation
{
    public partial class frTraCuuDaiLy : Form
    {
        public frTraCuuDaiLy()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayDanhSachDaiLy();
            gridDaiLy.Rows.Clear();
            for (int i = 0; i < dsDaiLy.Count; ++i)
            {
                gridDaiLy.Rows.Add(i+1,dsDaiLy[i].MaDaiLy, dsDaiLy[i].TenDaiLy, LoaiDaiLyBUS.LayTenLoaiDaiLy(dsDaiLy[i].MaLoaiDaiLy), QuanBUS.LayTenQuan(dsDaiLy[i].MaQuan), dsDaiLy[i].NoCuaDaiLy);
                gridDaiLy.Rows[gridDaiLy.RowCount - 1].Tag = dsDaiLy[i];
            }
        }
        private void frTraCuuDaiLy_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void buttonTraCuu_Click(object sender, EventArgs e)
        {
            LoadGridTraCuu();
        }
        private void LoadGridTraCuu()
        {
            textBoxDaiLy.Text = textBoxDaiLy.Text.Trim();
            textBoxLoai.Text = textBoxLoai.Text.Trim();
            textBoxQuan.Text = textBoxQuan.Text.Trim();
            textBoxTienNo.Text = textBoxTienNo.Text.Trim();

            string DaiLy = textBoxDaiLy.Text;
            string Loai = textBoxLoai.Text;
            string Quan = textBoxQuan.Text;
            string TienNo = textBoxTienNo.Text;

            List<TraCuuDaiLyDTO> dsTraCuuDaiLy = TraCuuDaiLyBUS.LayDanhSachTraCuu(DaiLy, Loai, Quan, TienNo);
            gridDaiLy.Rows.Clear();
            for (int i = 0; i < dsTraCuuDaiLy.Count; ++i)
            {
                gridDaiLy.Rows.Add(i + 1,dsTraCuuDaiLy[i].MaDaiLy, dsTraCuuDaiLy[i].TenDaiLy, dsTraCuuDaiLy[i].TenLoaiDaiLy,dsTraCuuDaiLy[i].TenQuan, dsTraCuuDaiLy[i].TienNo);
                gridDaiLy.Rows[gridDaiLy.RowCount - 1].Tag = dsTraCuuDaiLy[i];
            }
        }

    }
}
