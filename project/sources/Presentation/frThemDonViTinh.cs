using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Presentation
{
    public partial class frThemDonViTinh : Form
    {
        private List<DonViTinhDTO> dsDonViTinh;
        public frThemDonViTinh()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Tên đơn vị tính không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dsDonViTinh.Count; ++i)
            {
                if (String.Compare(dsDonViTinh[i].TenDonViTinh, txtDonViTinh.Text.Trim()) == 0)
                {
                    MessageBox.Show("Tên đơn vị tính bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DonViTinhDTO donViTinh = new DonViTinhDTO();
            donViTinh.TenDonViTinh = txtDonViTinh.Text.Trim();
            if (DonViTinhBUS.ThemMoi(donViTinh))
            {
                if (MessageBox.Show("Thêm thành công! Bạn có muốn thêm tiếp không?", "Chúc mừng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    Close();
                }
                dsDonViTinh = DonViTinhBUS.LayToanBoDanhSachDonViTinh();
                return;
            }
            MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frThemDonViTinh_Load(object sender, EventArgs e)
        {
            dsDonViTinh = DonViTinhBUS.LayToanBoDanhSachDonViTinh();
        }
    }
}
