using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;

namespace Presentation
{
    public partial class frLapPhieuThuTien : Form
    {
        public frLapPhieuThuTien()
        {
            InitializeComponent();
        }

        private void buttonLapPhieuThuTien_Click(object sender, EventArgs e)
        {
            rptPhieuThuTien phieuThuTien = new rptPhieuThuTien();
            CrystalDecisions.Shared.TableLogOnInfo tliCurrent = new TableLogOnInfo();
            foreach (CrystalDecisions.CrystalReports.Engine.Table tbCurrent
                                    in phieuThuTien.Database.Tables)
            {
                tliCurrent = tbCurrent.LogOnInfo;
                tliCurrent.ConnectionInfo.ServerName = Application.StartupPath + "\\QLDL_DB.mdb";
                tliCurrent.ConnectionInfo.UserID = "";
                tliCurrent.ConnectionInfo.Password = "";
                tliCurrent.ConnectionInfo.DatabaseName = "";
                tbCurrent.ApplyLogOnInfo(tliCurrent);
            }
            DaiLyDTO daily = DaiLyBUS.TraCuuTheoMaDaiLy(((DaiLyDTO)(comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex])).MaDaiLy);
            phieuThuTien.SetParameterValue("TenDaiLy",daily.TenDaiLy);
            phieuThuTien.SetParameterValue("DiaChi", daily.DiaChi);
            phieuThuTien.SetParameterValue("DienThoai", daily.DienThoai);
            phieuThuTien.SetParameterValue("Email", daily.Email);
            phieuThuTien.SetParameterValue("NgayThuTien", dateTimePickerNgayThuTien.Value.Date);
            phieuThuTien.SetParameterValue("SoTienThu", double.Parse(textBoxSoTienThu.Text));

            crystalReportViewerLapPhieuThuTien.ReportSource = phieuThuTien;
        }



        private void comboBoxMaDaiLy_DropDown(object sender, EventArgs e)
        {
            textBoxTenDaiLy.Text = ((DaiLyDTO)comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex]).TenDaiLy;
        }

        private void comboBoxMaDaiLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<DaiLyDTO> daiLy = new List<DaiLyDTO>();
            daiLy = DaiLyBUS.LayDanhSachDaiLy();
            int vitri = comboBoxMaDaiLy.SelectedIndex;
            textBoxTenDaiLy.Text = ((DaiLyDTO)comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex]).TenDaiLy;
        }

        private void LoadGrid()
        {
            List<PhieuThuTienDTO> dsPhieuThu = PhieuThuTienBUS.LayDanhSachPhieuThuTien();
            dataGridViewPhieuThuTien.Rows.Clear();
            for (int i = 0; i < dsPhieuThu.Count; ++i)
            {
                dataGridViewPhieuThuTien.Rows.Add(dsPhieuThu[i].MaPhieuThu, dsPhieuThu[i].NgayThuTien, dsPhieuThu[i].SoTienThu,dsPhieuThu[i].MaPhieuThu,dsPhieuThu[i].Deleted);
                dataGridViewPhieuThuTien.Rows[dataGridViewPhieuThuTien.RowCount - 1].Tag = dsPhieuThu[i];
            }
        }

        private void buttonThemPhieuTien_Click(object sender, EventArgs e)
        {
            PhieuThuTienDTO phieuThuTien = new PhieuThuTienDTO();

            if (comboBoxMaDaiLy.SelectedIndex < 0)
            {
                MessageBox.Show("Phải chọn mã đại lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            phieuThuTien.NgayThuTien = dateTimePickerNgayThuTien.Value;
            phieuThuTien.MaDaiLy = ((DaiLyDTO)comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex]).MaDaiLy;
            if (textBoxSoTienThu.Text.Length == 0)
            {
                MessageBox.Show("Phải điền số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
 
            }
            phieuThuTien.SoTienThu = double.Parse(textBoxSoTienThu.Text);
            DaiLyDTO daily = DaiLyBUS.TraCuuTheoMaDaiLy(phieuThuTien.MaDaiLy);
            
            if (daily.NoCuaDaiLy < phieuThuTien.SoTienThu)
            {
                MessageBox.Show("Số tiền thu không vượt quá số tiền đang nợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (PhieuThuTienBUS.ThemMoi(phieuThuTien))
            {
                MessageBox.Show("Bạn đã thêm phiếu thu tiền thành công", "Chúc mừng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGrid();
                return;
            }


        }

        private void frLapPhieuThuTien_Load(object sender, EventArgs e)
        {
            LoadGrid();
            List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayDanhSachDaiLy();
           // cbLoaiDaiLy.DataSource = dsLoaiDaiLy;
           // cbLoaiDaiLy.DisplayMember = "TenLoaiDaiLy";
           // cbQuan.DataSource = dsQuan;
           // cbQuan.DisplayMember = "TenQuan";
           // dateNgayTiepNhan.Value = DateTime.Now;

            comboBoxMaDaiLy.DataSource = dsDaiLy;
            comboBoxMaDaiLy.DisplayMember = "MaDaiLy";
            dateTimePickerNgayThuTien.Value = DateTime.Now;
        }


        private void dataGridViewPhieuThuTien_SelectionChanged(object sender, EventArgs e)
        {
            // current row cho biết dòng đang chọn
            if (dataGridViewPhieuThuTien.CurrentRow.Tag != null)
            {
                List<PhieuThuTienDTO> dsPhieuThuTien = PhieuThuTienBUS.LayDanhSachPhieuThuTien();
                List<DaiLyDTO> dsDaiLy = DaiLyBUS.LayDanhSachDaiLy();


                PhieuThuTienDTO phieuThuTienDuocChon = (PhieuThuTienDTO)dataGridViewPhieuThuTien.CurrentRow.Tag;

                dateTimePickerNgayThuTien.Value = phieuThuTienDuocChon.NgayThuTien;

                textBoxSoTienThu.Text =  Convert.ToString(phieuThuTienDuocChon.SoTienThu);
               // textBoxSoTienThu.set
                comboBoxMaDaiLy.SelectedIndex = DaiLyBUS.LayDaiLy(phieuThuTienDuocChon.MaDaiLy);

                int vitri = comboBoxMaDaiLy.SelectedIndex;
                textBoxTenDaiLy.Text = ((DaiLyDTO)comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex]).TenDaiLy;           
            }
        }

        private void buttonCapNhapPhieuThuTien_Click(object sender, EventArgs e)
        {
           
            if (dataGridViewPhieuThuTien.CurrentRow.Tag != null)
            {
                try
                {
                    
                    PhieuThuTienDTO phieuThuTienDuocChon= (PhieuThuTienDTO)dataGridViewPhieuThuTien.CurrentRow.Tag;
                    phieuThuTienDuocChon.MaDaiLy = ((DaiLyDTO)comboBoxMaDaiLy.Items[comboBoxMaDaiLy.SelectedIndex]).MaDaiLy;
                    phieuThuTienDuocChon.NgayThuTien = dateTimePickerNgayThuTien.Value;
                    phieuThuTienDuocChon.SoTienThu = Convert.ToDouble(textBoxSoTienThu.Text);

                    if (comboBoxMaDaiLy.SelectedIndex < 0)
                    {
                        MessageBox.Show("Phải chọn mã đại lý", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (textBoxSoTienThu.Text.Length == 0)
                    {
                        MessageBox.Show("Phải điền số tiền thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    DaiLyDTO daily = DaiLyBUS.TraCuuTheoMaDaiLy(phieuThuTienDuocChon.MaDaiLy);

                    if (daily.NoCuaDaiLy < phieuThuTienDuocChon.SoTienThu)
                    {
                        MessageBox.Show("Số tiền thu không vượt quá số tiền đang nợ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    bool ketQua = PhieuThuTienBUS.CapNhat(phieuThuTienDuocChon);
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

        private void buttonXoaPhieuThuTien_Click(object sender, EventArgs e)
        {
            if (dataGridViewPhieuThuTien.CurrentRow.Tag != null)
            {
                // Khi làm chức năng xóa, bạn phải hỏi lại
                // Hàm show của lớp messageBox trả về 1 DialogResult. Nó là một enum
                if (MessageBox.Show("Bạn có thật muốn xóa ?", "Hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    PhieuThuTienDTO phieuThuTienDuocChon = (PhieuThuTienDTO)dataGridViewPhieuThuTien.CurrentRow.Tag;
                    bool ketQua = PhieuThuTienBUS.XoaThatSu(phieuThuTienDuocChon);
                    if (ketQua == false)
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                    else
                    {
                        // Xóa được thì load lại ds vào grid
                        LoadGrid();
                        MessageBox.Show("Xóa thành công");
                    }
                }
            }
        }


    }
}
