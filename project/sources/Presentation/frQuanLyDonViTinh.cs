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
    public partial class frQuanLyDonViTinh : Form
    {
        public frQuanLyDonViTinh()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemDonViTinh frThem = new frThemDonViTinh();
            frThem.ShowDialog();
            LoadGrid();
        }

        private void LoadGrid()
        {
            List<DonViTinhDTO> dsDonViTinh = DonViTinhBUS.LayDanhSachDonViTinh();
            gridDonViTinh.Rows.Clear();
            for (int i = 0; i < dsDonViTinh.Count; ++i)
            {
                gridDonViTinh.Rows.Add(dsDonViTinh[i].MaDonViTinh, dsDonViTinh[i].TenDonViTinh);
                gridDonViTinh.Rows[gridDonViTinh.RowCount - 1].Tag = dsDonViTinh[i];
            }
        }

        private void frQuanLyDonViTinh_Load(object sender, EventArgs e)
        {
            LoadGrid();
            gridDonViTinh_SelectionChanged(sender, e);
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
        {
            if (txtDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Tên đơn vị tính không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gridDonViTinh.CurrentRow.Tag != null)
            {
                try
                {
                    DonViTinhDTO donViTinhDuocChon = (DonViTinhDTO)gridDonViTinh.CurrentRow.Tag;
                    donViTinhDuocChon.TenDonViTinh = txtDonViTinh.Text.Trim();
                    bool ketQua = DonViTinhBUS.CapNhat(donViTinhDuocChon);
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

        private void gridDonViTinh_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridDonViTinh.CurrentRow.Tag != null)
            {
                DonViTinhDTO donViTinhDuocChon = (DonViTinhDTO)gridDonViTinh.CurrentRow.Tag;
                txtDonViTinh.Text = donViTinhDuocChon.TenDonViTinh;
            }
        }
    }
}
