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
    public partial class frThemQuan : Form
    {
        public frThemQuan()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            List<QuanDTO> dsQuan = QuanBUS.LayToanBoDanhSachQuan();
            if (txtTenQuan.Text == "")
            {
                MessageBox.Show("Tên quận không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numSoDaiLyToiDa.Value <= 0)
            {
                MessageBox.Show("Số đại lý tối đa không được bé hơn không!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < dsQuan.Count; ++i)
            {
                if (String.Compare(dsQuan[i].TenQuan, txtTenQuan.Text) == 0)
                {
                    MessageBox.Show("Tên loại bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            QuanDTO quan = new QuanDTO();
            quan.TenQuan= txtTenQuan.Text;
            quan.SoLuongDaiLyToiDa = (int)numSoDaiLyToiDa.Value;
            if (QuanBUS.ThemMoi(quan))
            {
                if (MessageBox.Show("Thêm thành công! Bạn có muốn thêm tiếp không?", "Chúc mừng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    Close();
                }
                dsQuan = QuanBUS.LayToanBoDanhSachQuan();
                return;
            }
            MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
