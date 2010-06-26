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
    public partial class frThemDaiLy : Form
    {
        public frThemDaiLy()
        {
            InitializeComponent();
        }

        private void frThemDaiLy_Load(object sender, EventArgs e)
        {
            List<LoaiDaiLyDTO> dsLoaiDaiLy = LoaiDaiLyBUS.LayDanhSachLoaiDaiLy();
            List<QuanDTO> dsQuan = QuanBUS.LayDanhSachQuan();
            cbLoaiDaiLy.DataSource = dsLoaiDaiLy;
            cbLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
            cbQuan.DataSource = dsQuan;
            cbQuan.DisplayMember = "TenQuan";
            dateNgayTiepNhan.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTenDaiLy.Text == "")
            {
                MessageBox.Show("Tên đại lý không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ đại lý không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Điện thoại đại lý không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } if (txtEmail.Text == "")
            {
                MessageBox.Show("Email đại lý không được rỗng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbQuan.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn quận mà đại lý thuộc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbLoaiDaiLy.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn loại của đại lý!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayToanBoDanhSachDaiLy();
            for (int i = 0; i < dsDaiLy.Count; ++i)
            {
                if (String.Compare(dsDaiLy[i].TenDaiLy, txtTenDaiLy.Text) == 0)
                {
                    MessageBox.Show("Tên đại lý bị trùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            DaiLyDTO daiLy = new DaiLyDTO();
            daiLy.DiaChi = txtDiaChi.Text.Trim();
            daiLy.DienThoai = txtDienThoai.Text.Trim();
            daiLy.Email = txtEmail.Text.Trim();
            daiLy.MaLoaiDaiLy = ((LoaiDaiLyDTO)cbLoaiDaiLy.Items[cbLoaiDaiLy.SelectedIndex]).MaLoaiDaiLy;
            daiLy.MaQuan = ((QuanDTO)cbQuan.Items[cbQuan.SelectedIndex]).MaQuan;
            daiLy.NgayTiepNhan = dateNgayTiepNhan.Value;
            daiLy.NoCuaDaiLy = 0;
            daiLy.TenDaiLy = txtTenDaiLy.Text.Trim();
            if (DaiLyBUS.ThemMoi(daiLy))
            {
                dsDaiLy = DaiLyBUS.LayToanBoDanhSachDaiLy();
                for (int j = 0; j < dsDaiLy.Count; ++j)
                {
                    if (String.Compare(dsDaiLy[j].TenDaiLy, txtTenDaiLy.Text) == 0)
                    {
                        if (MessageBox.Show("Thêm thành công! Với mã đại lý là: " + dsDaiLy[j].MaDaiLy.ToString() + " . Bạn có muốn thêm tiếp không?", "Chúc mừng", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                        {
                            Close();
                        }
                        return;
                    }
                }
            }
            MessageBox.Show("Có lỗi trong quá trình thêm!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
