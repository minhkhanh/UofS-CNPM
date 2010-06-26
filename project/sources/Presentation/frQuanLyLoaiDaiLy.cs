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
    public partial class frQuanLyLoaiDaiLy : Form
    {
        //private List<LoaiDaiLyDTO> dsLoaiDaiLy;
        public frQuanLyLoaiDaiLy()
        {
            InitializeComponent();
        }
        private void LoadGrid()
        {
            List<LoaiDaiLyDTO> dsLoaiDaiLy = LoaiDaiLyBUS.LayDanhSachLoaiDaiLy();
            gridLoaiDaiLy.Rows.Clear();
            for (int i = 0; i < dsLoaiDaiLy.Count; ++i)
            {
                gridLoaiDaiLy.Rows.Add(dsLoaiDaiLy[i].MaLoaiDaiLy, dsLoaiDaiLy[i].TenLoaiDaiLy, dsLoaiDaiLy[i].NoToiDa);
                gridLoaiDaiLy.Rows[gridLoaiDaiLy.RowCount - 1].Tag = dsLoaiDaiLy[i];
            }
        }

        private void frQuanLyLoaiDaiLy_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridLoaiDaiLy_SelectionChanged(sender, e);
        }

        private void gridLoaiDaiLy_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridLoaiDaiLy.CurrentRow.Tag != null)
            {
                LoaiDaiLyDTO loaiDaiLyDuocChon = (LoaiDaiLyDTO)gridLoaiDaiLy.CurrentRow.Tag;
                txtTenLoai.Text = loaiDaiLyDuocChon.TenLoaiDaiLy;
                numNoToiDa.Value = loaiDaiLyDuocChon.NoToiDa;
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemLoaiDaiLy frThem = new frThemLoaiDaiLy();
            frThem.ShowDialog();
            LoadGrid();
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenLoai.Text == "")
            {
                MessageBox.Show("Tên loại không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numNoToiDa.Value < 0)
            {
                MessageBox.Show("Nợ tối đa không được bé hơn không!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gridLoaiDaiLy.CurrentRow.Tag != null)
            {
                try
                {
                    LoaiDaiLyDTO loaiDaiLyDuocChon = (LoaiDaiLyDTO)gridLoaiDaiLy.CurrentRow.Tag;
                    loaiDaiLyDuocChon.TenLoaiDaiLy = txtTenLoai.Text.Trim();
                    loaiDaiLyDuocChon.NoToiDa = (int)numNoToiDa.Value;
                    bool ketQua = LoaiDaiLyBUS.CapNhat(loaiDaiLyDuocChon);
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
    }
}
