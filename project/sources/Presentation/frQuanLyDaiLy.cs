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
    public partial class frQuanLyDaiLy : Form
    {
        public frQuanLyDaiLy()
        {
            InitializeComponent();
        }

        private void cmdDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdThem_Click(object sender, EventArgs e)
        {
            frThemDaiLy frThem = new frThemDaiLy();
            frThem.ShowDialog();
            LoadGrid();
        }

        private void LoadGrid()
        {
            List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayDanhSachDaiLy();
            gridDaiLy.Rows.Clear();
            for (int i = 0; i < dsDaiLy.Count; ++i)
            {
                gridDaiLy.Rows.Add(dsDaiLy[i].MaDaiLy, dsDaiLy[i].TenDaiLy, LoaiDaiLyBUS.LayTenLoaiDaiLy(dsDaiLy[i].MaLoaiDaiLy), dsDaiLy[i].DienThoai, dsDaiLy[i].DiaChi, QuanBUS.LayTenQuan(dsDaiLy[i].MaQuan), dsDaiLy[i].NgayTiepNhan.ToShortDateString(), dsDaiLy[i].Email);
                gridDaiLy.Rows[gridDaiLy.RowCount - 1].Tag = dsDaiLy[i];
            }
        }

        private void LoadCombo()
        {
            List<LoaiDaiLyDTO> dsLoaiDaiLy = LoaiDaiLyBUS.LayDanhSachLoaiDaiLy();
            List<QuanDTO> dsQuan = QuanBUS.LayDanhSachQuan();
            cbLoaiDaiLy.DataSource = dsLoaiDaiLy;
            cbLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
            cbQuan.DataSource = dsQuan;
            cbQuan.DisplayMember = "TenQuan";
            dateNgayTiepNhan.Value = DateTime.Now;
        }

        private void frQuanLyDaiLy_Load(object sender, EventArgs e)
        {
            LoadGrid();
            LoadCombo();
        }

        private void cmdCapNhat_Click(object sender, EventArgs e)
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
            if (gridDaiLy.CurrentRow.Tag != null)
            {
                try
                {
                    DaiLyDTO daiLyDuocChon = (DaiLyDTO)gridDaiLy.CurrentRow.Tag;
                    daiLyDuocChon.DiaChi = txtDiaChi.Text.Trim();
                    daiLyDuocChon.DienThoai = txtDienThoai.Text.Trim();
                    daiLyDuocChon.Email = txtEmail.Text.Trim();
                    daiLyDuocChon.MaLoaiDaiLy = ((LoaiDaiLyDTO)cbLoaiDaiLy.Items[cbLoaiDaiLy.SelectedIndex]).MaLoaiDaiLy;
                    daiLyDuocChon.MaQuan = ((QuanDTO)cbQuan.Items[cbQuan.SelectedIndex]).MaQuan;
                    daiLyDuocChon.NgayTiepNhan = dateNgayTiepNhan.Value;
                    daiLyDuocChon.NoCuaDaiLy = (long)numNoDaiLy.Value;
                    daiLyDuocChon.TenDaiLy = txtTenDaiLy.Text.Trim();
                    bool ketQua = DaiLyBUS.CapNhat(daiLyDuocChon);
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

        private void gridDaiLy_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (gridDaiLy.CurrentRow.Tag != null)
            {
                LoadCombo();
                DaiLyDTO daiLyDuocChon = (DaiLyDTO)gridDaiLy.CurrentRow.Tag;
                txtDiaChi.Text = daiLyDuocChon.DiaChi;
                txtDienThoai.Text = daiLyDuocChon.DienThoai;
                txtEmail.Text = daiLyDuocChon.Email;
                cbLoaiDaiLy.SelectedIndex = LoaiDaiLyBUS.LayLoaiDaiLy(daiLyDuocChon.MaLoaiDaiLy);
                cbQuan.SelectedIndex = QuanBUS.LayQuan(daiLyDuocChon.MaQuan);
                dateNgayTiepNhan.Value = daiLyDuocChon.NgayTiepNhan;
                numNoDaiLy.Value = daiLyDuocChon.NoCuaDaiLy;
                txtTenDaiLy.Text = daiLyDuocChon.TenDaiLy;
            }
        }
    }
}
