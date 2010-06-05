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
    public partial class frThemLoaiDaiLy : Form
    {
        private List<LoaiDaiLyDTO> dsLoaiDaiLy;
        public frThemLoaiDaiLy()
        {
            InitializeComponent();
        }

        private void frThemLoaiDaiLy_Load(object sender, EventArgs e)
        {
            numNoToiDa.Value = 20000;
            dsLoaiDaiLy = LoaiDaiLyBUS.LayToanBoDanhSachLoaiDaiLy();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
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
            for (int i = 0; i < dsLoaiDaiLy.Count; ++i)
            {
                if (String.Compare(dsLoaiDaiLy[i].TenLoaiDaiLy, txtTenLoai.Text) == 0)
                {
                    MessageBox.Show("Tên loại bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            LoaiDaiLyDTO loaiDaiLy = new LoaiDaiLyDTO();
            loaiDaiLy.TenLoaiDaiLy = txtTenLoai.Text;
            loaiDaiLy.NoToiDa = (int)numNoToiDa.Value;
            if (LoaiDaiLyBUS.ThemMoi(loaiDaiLy))
            {
                if (MessageBox.Show("Thêm thành công! Bạn có muốn thêm tiếp không?", "Chúc mừng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                {
                    Close();
                }
                dsLoaiDaiLy = LoaiDaiLyBUS.LayToanBoDanhSachLoaiDaiLy();
                return;
            }
            MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
