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
    public partial class frThemBangGia : Form
    {
        public frThemBangGia()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frThemBangGia_Load(object sender, EventArgs e)
        {
            List<MatHangDTO> dsMatHang = MatHangBUS.LayDanhSachMatHang();
            List<DonViTinhDTO> dsDonViTinh = DonViTinhBUS.LayDanhSachDonViTinh();
            cbMatHang.DataSource = dsMatHang;
            cbMatHang.DisplayMember = "TenMatHang";
            cbDonViTinh.DataSource = dsDonViTinh;
            cbDonViTinh.DisplayMember = "TenDonViTinh";
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (cbDonViTinh.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbMatHang.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn tên mặt hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtDonGia.Text = txtDonGia.Text.Trim();
            try
            {
                if (Int32.Parse(txtDonGia.Text) <= 0)
                {
                    MessageBox.Show("Phải nhập đơn giá lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Phải nhập đơn giá là số lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<BangGiaDTO> dsBangGia = BangGiaBUS.LayToanBoDanhSachBangGia();
            for (int i = 0; i < dsBangGia.Count; ++i)
            {
                if ((((MatHangDTO)cbMatHang.Items[cbMatHang.SelectedIndex]).MaMatHang == dsBangGia[i].MaMatHang) && ((DonViTinhDTO)cbDonViTinh.Items[cbDonViTinh.SelectedIndex]).MaDonViTinh == dsBangGia[i].MaDonViTinh)
                {
                    MessageBox.Show("Đã tồn tại thay vì tạo mới hãy phục hồi hoặc sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                BangGiaDTO bangGia = new BangGiaDTO();
                bangGia.MaMatHang = ((MatHangDTO)cbMatHang.Items[cbMatHang.SelectedIndex]).MaMatHang;
                bangGia.MaDonViTinh = ((DonViTinhDTO)cbDonViTinh.Items[cbDonViTinh.SelectedIndex]).MaDonViTinh;
                bangGia.DonGia = Int32.Parse(txtDonGia.Text);
                if (!BangGiaBUS.ThemMoi(bangGia))
                {
                    throw new Exception();
                }
                MessageBox.Show("Thêm thành công");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
