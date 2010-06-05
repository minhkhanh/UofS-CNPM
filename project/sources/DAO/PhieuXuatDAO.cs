using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class PhieuXuatDAO: AbstractDAO
    {
        /// <summary>
        /// Lấy ds các các phiếu xuất
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<PhieuXuatDTO> LayDanhSachPhieuXuat()
        {
            OleDbConnection ketNoi = null;
            List<PhieuXuatDTO> dsPhieuXuat = new List<PhieuXuatDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaPhieuXuat, MaDaiLy, NgayLapPhieu, TongTriGia, Deleted FROM PHIEUXUAT";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    PhieuXuatDTO phieuXuat = new PhieuXuatDTO();
                    phieuXuat.MaPhieuXuat = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuXuat.MaDaiLy = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        phieuXuat.NgayLapPhieu = boDoc.GetDateTime(2);
                    if (!boDoc.IsDBNull(3))
                        phieuXuat.TongTriGia = boDoc.GetInt32(3);
                    if ((!boDoc.IsDBNull(4)) && (boDoc.GetBoolean(4)))
                        continue;
                    dsPhieuXuat.Add(phieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsPhieuXuat = new List<PhieuXuatDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsPhieuXuat;
        }
        /// <summary>
        /// Lấy ds các các phiếu xuất kể cả phiếu bị xóa
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<PhieuXuatDTO> LayToanBoDanhSachPhieuXuat()
        {
            OleDbConnection ketNoi = null;
            List<PhieuXuatDTO> dsPhieuXuat = new List<PhieuXuatDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaPhieuXuat, MaDaiLy, NgayLapPhieu, TongTriGia, Deleted FROM PHIEUXUAT";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    PhieuXuatDTO phieuXuat = new PhieuXuatDTO();
                    phieuXuat.MaPhieuXuat = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuXuat.MaDaiLy = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        phieuXuat.NgayLapPhieu = boDoc.GetDateTime(2);
                    if (!boDoc.IsDBNull(3))
                        phieuXuat.TongTriGia = boDoc.GetInt32(3);
                    if ((!boDoc.IsDBNull(4)))
                        phieuXuat.Deleted = boDoc.GetBoolean(4);
                    dsPhieuXuat.Add(phieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsPhieuXuat = new List<PhieuXuatDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsPhieuXuat;
        }
        /// <summary>
        /// Thêm 1 phiếu xuất mới
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(PhieuXuatDTO phieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO PHIEUXUAT(MaDaiLy, NgayLapPhieu, TongTriGia)";
                chuoiLenh += " VALUES(@MaDaiLy, @NgayLapPhieu, @TongTriGia)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = phieuXuat.MaDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NgayLapPhieu", OleDbType.Date);
                thamSo.Value = phieuXuat.NgayLapPhieu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@TongTriGia", OleDbType.Integer);
                thamSo.Value = phieuXuat.TongTriGia;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ketQua = false;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return ketQua;

        }
        /// <summary>
        /// Cập nhật thông tin một phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(PhieuXuatDTO phieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE PHIEUXUAT SET  MaDaiLy=@MaDaiLy, NgayLapPhieu=@NgayLapPhieu, TongTriGia=@TongTriGia, Deleted=@Deleted WHERE MaPhieuXuat=@MaPhieuXuat";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = phieuXuat.MaDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NgayLapPhieu", OleDbType.Date);
                thamSo.Value = phieuXuat.NgayLapPhieu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@TongTriGia", OleDbType.Integer);
                thamSo.Value = phieuXuat.TongTriGia;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = phieuXuat.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaPhieuXuat", OleDbType.Integer);
                thamSo.Value = phieuXuat.MaPhieuXuat;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ketQua = false;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return ketQua;

        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(PhieuXuatDTO phieuXuat)
        {
            phieuXuat.Deleted = true;
            return CapNhat(phieuXuat);
        }
        
        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(PhieuXuatDTO phieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM PHIEUXUAT WHERE MaPhieuXuat=@MaPhieuXuat";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaPhieuXuat", OleDbType.Integer);
                thamSo.Value = phieuXuat.MaPhieuXuat;
                lenh.Parameters.Add(thamSo);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ketQua = false;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return ketQua;
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM PHIEUXUAT";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                lenh.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ketQua = false;
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close();
            }
            return ketQua;
        }
    }
}
