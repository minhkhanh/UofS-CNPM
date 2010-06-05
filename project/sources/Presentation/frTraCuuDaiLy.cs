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
    }
}
