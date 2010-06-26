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
    public partial class frQuanLyMatHang : Form
    {
        public frQuanLyMatHang()
        {
            InitializeComponent();
        }

        private void frQuanLyMatHang_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridMatHang_SelectionChanged(sender, e);
        }
        private void LoadGrid()
        {
            List<MatHangDTO> dsMatHang = MatHangBUS.LayDanhSachMatHang();
            gridMatHang.Rows.Clear();
            for (int i = 0; i < dsMatHang.Count; ++i)
            {
                gridMatHang.Rows.Add(dsMatHang[i].MaMatHang, dsMatHang[i].TenMatHang);
                gridMatHang.Rows[gridMatHang.RowCount - 1].Tag = dsMatHang[i];
            }
        }

        private void gridMatHang_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridMatHang.CurrentRow.Tag != null)
            {
                MatHangDTO loaiMatHangDuocChon = (MatHangDTO)gridMatHang.CurrentRow.Tag;
                txtTenMatHang.Text = loaiMatHangDuocChon.TenMatHang;          
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text == "")
            {
                MessageBox.Show("Tên mặt hàng không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gridMatHang.CurrentRow.Tag != null)
            {
                try
                {
                    MatHangDTO matHangDuocChon = (MatHangDTO)gridMatHang.CurrentRow.Tag;
                    matHangDuocChon.TenMatHang = txtTenMatHang.Text.Trim();
                    bool ketQua = MatHangBUS.CapNhat(matHangDuocChon);
                    if (ketQua == false)
                        throw new Exception();
                    LoadGrid();
                    MessageBox.Show("Cập nhật thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemMatHang frThem = new frThemMatHang();
            frThem.ShowDialog();
            LoadGrid();
        }
    }
}
