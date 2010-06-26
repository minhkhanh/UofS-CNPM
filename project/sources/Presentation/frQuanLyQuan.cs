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
    public partial class frQuanLyQuan : Form
    {
        public frQuanLyQuan()
        {
            InitializeComponent();
        }

        private void LoadGrid()
        {
            List<QuanDTO> dsQuan = QuanBUS.LayDanhSachQuan();
            gridQuan.Rows.Clear();
            for (int i = 0; i < dsQuan.Count; ++i)
            {
                gridQuan.Rows.Add(dsQuan[i].MaQuan, dsQuan[i].TenQuan, dsQuan[i].SoLuongDaiLyToiDa);
                gridQuan.Rows[gridQuan.RowCount - 1].Tag = dsQuan[i];
            }
        }

        private void frQuanLyQuan_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridQuan_SelectionChanged(sender, e);
        }

        private void gridQuan_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridQuan.CurrentRow.Tag != null)
            {
                QuanDTO quanDuocChon = (QuanDTO)gridQuan.CurrentRow.Tag;
                txtTenQuan.Text = quanDuocChon.TenQuan;
                numSoDaiLyToiDa.Value = quanDuocChon.SoLuongDaiLyToiDa;
            }
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemQuan frThem = new frThemQuan();
            frThem.ShowDialog();
            LoadGrid();
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (txtTenQuan.Text == "")
            {
                MessageBox.Show("Tên quận không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoDaiLyToiDa.Value < 1)
            {
                MessageBox.Show("Số đại lý tối đa tối đa không được bé hơn 1!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gridQuan.CurrentRow.Tag != null)
            {
                try
                {
                    QuanDTO quanDuocChon = (QuanDTO)gridQuan.CurrentRow.Tag;
                    quanDuocChon.TenQuan = txtTenQuan.Text.Trim();
                    quanDuocChon.SoLuongDaiLyToiDa = (int)numSoDaiLyToiDa.Value;
                    bool ketQua = QuanBUS.CapNhat(quanDuocChon);
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
