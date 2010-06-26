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
    public partial class frQuanLyBangGia : Form
    {
        public frQuanLyBangGia()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frQuanLyBangGia_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridBangGia_SelectionChanged(sender, e);
        }

        private void LoadGrid()
        {
            List<BangGiaDTO> dsBangGia = BangGiaBUS.LayDanhSachBangGia();
            gridBangGia.Rows.Clear();
            for (int i = 0; i < dsBangGia.Count; ++i)
            {
                MatHangDTO matHang = new MatHangDTO();
                matHang.MaMatHang = dsBangGia[i].MaMatHang;
                DonViTinhDTO donViTinh = new DonViTinhDTO();
                donViTinh.MaDonViTinh = dsBangGia[i].MaDonViTinh;
                MatHangBUS.LayMatHangTheoMa(matHang);
                DonViTinhBUS.LayDonViTinhTheoMa(donViTinh);
                gridBangGia.Rows.Add(dsBangGia[i].MaMatHang, dsBangGia[i].MaDonViTinh, matHang.TenMatHang, donViTinh.TenDonViTinh, dsBangGia[i].DonGia);
                gridBangGia.Rows[gridBangGia.RowCount - 1].Tag = dsBangGia[i];
            }
        }

        private void gridBangGia_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridBangGia.CurrentRow.Tag != null)
            {
                BangGiaDTO bangGiaDuocChon = (BangGiaDTO)gridBangGia.CurrentRow.Tag;
                txtDonGia.Text = bangGiaDuocChon.DonGia.ToString();
            }
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            txtDonGia.Text = txtDonGia.Text.Trim();
            
            if (gridBangGia.CurrentRow.Tag != null)
            {
                try
                {
                    if (Int32.Parse(txtDonGia.Text) <= 0)
                    {
                        MessageBox.Show("Đơn giá phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    BangGiaDTO bangGiaDuocChon = (BangGiaDTO)gridBangGia.CurrentRow.Tag;
                    bangGiaDuocChon.DonGia = Int32.Parse(txtDonGia.Text);
                    bool ketQua = BangGiaBUS.CapNhat(bangGiaDuocChon);
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

            LoadGrid();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemBangGia frThem = new frThemBangGia();
            frThem.ShowDialog();
            LoadGrid();
        }
    }
}
