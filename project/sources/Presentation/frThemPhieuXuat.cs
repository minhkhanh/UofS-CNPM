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
    public partial class frThemPhieuXuat : Form
    {
        private List<ChiTietPhieuXuatDTO> dsChiTietPhieuXuat;
        //private List<MatHangDTO> dsMatHang;
        //private List<DonViTinhDTO> dsDonViTinh;
        long iMaPhieu = -1;
        public frThemPhieuXuat()
        {
            InitializeComponent();
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frThemPhieuXuat_Load(object sender, EventArgs e)
        {
            List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayDanhSachDaiLy();
            cbTenDaiLy.DataSource = dsDaiLy;
            cbTenDaiLy.DisplayMember = "TenDaiLy";
            dateNgayLapPhieu.Value = DateTime.Now;
            dsChiTietPhieuXuat = new List<ChiTietPhieuXuatDTO>();
            iMaPhieu = PhieuXuatBUS.LayMaPhieuXuatKhaDung();
            txtMaPhieu.Text = iMaPhieu.ToString();
            //dsMatHang = MatHangBUS.LayToanBoDanhSachMatHang();
            //dsDonViTinh = DonViTinhBUS.LayToanBoDanhSachDonViTinh();
        }

        private void butThem_Click(object sender, EventArgs e)
        {
            frThemChiTietPhieuXuat frm = new frThemChiTietPhieuXuat();
            frm.ShowDialog();
            if (frm.chiTietPhieuXuat.MaChiTietPhieuXuat == -1)
            {
                return;
            }
            frm.chiTietPhieuXuat.MaPhieuXuat = iMaPhieu;
            frm.chiTietPhieuXuat.MaChiTietPhieuXuat = LaySttKhaDung();
            dsChiTietPhieuXuat.Add(frm.chiTietPhieuXuat);
            LoadGrid();
        }

        private void LoadGrid()
        {
            gridChiTietXuat.Rows.Clear();
            MatHangDTO matHang = new MatHangDTO();
            DonViTinhDTO donViTinh = new DonViTinhDTO();
            for (int i = 0; i < dsChiTietPhieuXuat.Count; ++i)
            {
                matHang.MaMatHang = dsChiTietPhieuXuat[i].MaMatHang;
                donViTinh.MaDonViTinh = dsChiTietPhieuXuat[i].MaDonViTinh;
                MatHangBUS.LayMatHangTheoMa(matHang);
                DonViTinhBUS.LayDonViTinhTheoMa(donViTinh);
                gridChiTietXuat.Rows.Add(dsChiTietPhieuXuat[i].MaChiTietPhieuXuat, matHang.TenMatHang, donViTinh.TenDonViTinh, dsChiTietPhieuXuat[i].SoLuongXuat, dsChiTietPhieuXuat[i].DonGia, dsChiTietPhieuXuat[i].ThanhTien);
                gridChiTietXuat.Rows[gridChiTietXuat.RowCount - 1].Tag = dsChiTietPhieuXuat[i];
            }
        }
        private long LaySttKhaDung()
        {
            try
            {
                return dsChiTietPhieuXuat[dsChiTietPhieuXuat.Count - 1].MaChiTietPhieuXuat + 1;
            }
            catch (System.Exception ex)
            {
                return 0;
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            if (gridChiTietXuat.CurrentRow.Tag != null)
            {
                try
                {
                    ChiTietPhieuXuatDTO chiTietPhieuDuocChon = (ChiTietPhieuXuatDTO)gridChiTietXuat.CurrentRow.Tag;
                    for (long i = chiTietPhieuDuocChon.MaChiTietPhieuXuat; i <dsChiTietPhieuXuat.Count; ++i)
                    {
                        --dsChiTietPhieuXuat[(int)i].MaChiTietPhieuXuat; 
                    }
                    dsChiTietPhieuXuat.Remove(chiTietPhieuDuocChon);
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi");
                }
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (gridChiTietXuat.CurrentRow.Tag != null)
            {
                try
                {
                    ChiTietPhieuXuatDTO chiTietPhieuDuocChon = (ChiTietPhieuXuatDTO)gridChiTietXuat.CurrentRow.Tag;
                    frSuaChiTietPhieuXuat frm = new frSuaChiTietPhieuXuat();
                    frm.chiTietPhieuXuat = chiTietPhieuDuocChon;
                    frm.ShowDialog();
                    if (!frm.bIsUpdate)
                    {
                        return;
                    }
                    LoadGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi");
                }
            }
        }

        private void butCreate_Click(object sender, EventArgs e)
        {
            if (cbTenDaiLy.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn đại lý muốn xuất hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (iMaPhieu < 0)
            {
                MessageBox.Show("Có lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dsChiTietPhieuXuat.Count <= 0)
            {
                MessageBox.Show("Cần chọn ít nhất 1 mặt hàng cần xuất!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                long iSum = 0;
                for (int i = 0; i < dsChiTietPhieuXuat.Count; ++i )
                {
                    iSum += dsChiTietPhieuXuat[i].ThanhTien;
                }
                PhieuXuatDTO phieuXuat = new PhieuXuatDTO();
                phieuXuat.MaPhieuXuat = iMaPhieu;
                phieuXuat.MaDaiLy = ((DaiLyDTO)cbTenDaiLy.Items[cbTenDaiLy.SelectedIndex]).MaDaiLy;
                phieuXuat.NgayLapPhieu = dateNgayLapPhieu.Value;
                phieuXuat.TongTriGia = iSum;
                if (!PhieuXuatBUS.ThemMoi(phieuXuat))
                {
                    throw new Exception();
                }
                for (int i = 0; i < dsChiTietPhieuXuat.Count; ++i )
                {
                    ChiTietPhieuXuatBUS.ThemMoi(dsChiTietPhieuXuat[i]);
                }
                MessageBox.Show("Thêm thành công!");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm!");
            }
        }
    }
}
