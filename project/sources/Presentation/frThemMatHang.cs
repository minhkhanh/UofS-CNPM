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
    public partial class frThemMatHang : Form
    {
        private List<MatHangDTO> dsMatHang;
        public frThemMatHang()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frThemMatHang_Load(object sender, EventArgs e)
        {
            dsMatHang = MatHangBUS.LayToanBoDanhSachMatHang();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            if (txtTenMatHang.Text == "")
            {
                MessageBox.Show("Tên mặt hàng không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dsMatHang.Count; ++i)
            {
                if (String.Compare(dsMatHang[i].TenMatHang, txtTenMatHang.Text) == 0)
                {
                    MessageBox.Show("Tên mặt hàng bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            MatHangDTO matHang = new MatHangDTO();
            matHang.TenMatHang = txtTenMatHang.Text;
            if (MatHangBUS.ThemMoi(matHang))
            {
                if (MessageBox.Show("Thêm thành công! Bạn có muốn thêm tiếp không?", "Chúc mừng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    Close();
                }
                dsMatHang = MatHangBUS.LayToanBoDanhSachMatHang();
                return;
            }
            MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
