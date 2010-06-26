using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DAO;
using DTO;

namespace DAO
{
    public class ChiTietPhieuXuatDAO:AbstractDAO
    {
        /// <summary>
        /// Lấy ds các các phiếu xuất
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<ChiTietPhieuXuatDTO> LayDanhSachChiTietPhieuXuat()
        {
            OleDbConnection ketNoi = null;
            List<ChiTietPhieuXuatDTO> dsChiTietPhieuXuat = new List<ChiTietPhieuXuatDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaChiTietPhieuXuat, MaPhieuXuat, MaMatHang, MaDonViTinh, SoLuongXuat, DonGia, ThanhTien, Deleted FROM CHITIETPHIEUXUAT";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietPhieuXuatDTO chiTietPhieuXuat = new ChiTietPhieuXuatDTO();
                    chiTietPhieuXuat.MaChiTietPhieuXuat = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        chiTietPhieuXuat.MaPhieuXuat = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        chiTietPhieuXuat.MaMatHang = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        chiTietPhieuXuat.MaDonViTinh = boDoc.GetInt32(3);
                    if (!boDoc.IsDBNull(4))
                        chiTietPhieuXuat.SoLuongXuat = boDoc.GetInt32(4);
                    if (!boDoc.IsDBNull(5))
                        chiTietPhieuXuat.DonGia = boDoc.GetInt32(5);
                    if (!boDoc.IsDBNull(6))
                        chiTietPhieuXuat.ThanhTien = boDoc.GetInt32(6);
                    if ((!boDoc.IsDBNull(7)) && (boDoc.GetBoolean(7)))
                        continue;
                    dsChiTietPhieuXuat.Add(chiTietPhieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsChiTietPhieuXuat = new List<ChiTietPhieuXuatDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsChiTietPhieuXuat;
        }
        /// <summary>
        /// Lấy ds các các phiếu xuất kể cả phiếu bị xóa
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<ChiTietPhieuXuatDTO> LayToanBoDanhSachChiTietPhieuXuat()
        {
            OleDbConnection ketNoi = null;
            List<ChiTietPhieuXuatDTO> dsChiTietPhieuXuat = new List<ChiTietPhieuXuatDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaChiTietPhieuXuat, MaPhieuXuat, MaMatHang, MaDonViTinh, SoLuongXuat, DonGia, ThanhTien, Deleted FROM CHITIETPHIEUXUAT";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    ChiTietPhieuXuatDTO chiTietPhieuXuat = new ChiTietPhieuXuatDTO();
                    chiTietPhieuXuat.MaChiTietPhieuXuat = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        chiTietPhieuXuat.MaPhieuXuat = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        chiTietPhieuXuat.MaMatHang = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        chiTietPhieuXuat.MaDonViTinh = boDoc.GetInt32(3);
                    if (!boDoc.IsDBNull(4))
                        chiTietPhieuXuat.SoLuongXuat = boDoc.GetInt32(4);
                    if (!boDoc.IsDBNull(5))
                        chiTietPhieuXuat.DonGia = boDoc.GetInt32(5);
                    if (!boDoc.IsDBNull(6))
                        chiTietPhieuXuat.ThanhTien = boDoc.GetInt32(6);
                    if ((!boDoc.IsDBNull(7)))
                        chiTietPhieuXuat.Deleted = boDoc.GetBoolean(7);
                    dsChiTietPhieuXuat.Add(chiTietPhieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsChiTietPhieuXuat = new List<ChiTietPhieuXuatDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsChiTietPhieuXuat;
        }
        /// <summary>
        /// Thêm 1 phiếu xuất mới
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO CHITIETPHIEUXUAT(MaPhieuXuat, MaMatHang, MaDonViTinh, SoLuongXuat, DonGia, ThanhTien)";
                chuoiLenh += " VALUES(@MaPhieuXuat, @MaMatHang, @MaDonViTinh, @SoLuongXuat, @DonGia, @ThanhTien)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@MaPhieuXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaPhieuXuat;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaMatHang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaDonViTinh;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoLuongXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.SoLuongXuat;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DonGia", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.DonGia;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@ThanhTien", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.ThanhTien;
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
        public static bool CapNhat(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE CHITIETPHIEUXUAT SET  MaPhieuXuat=@MaPhieuXuat, MaMatHang=@MaMatHang, MaDonViTinh=@MaDonViTinh, SoLuongXuat=@SoLuongXuat, DonGia=@DonGia, ThanhTien=@ThanhTien, Deleted=@Deleted WHERE MaChiTietPhieuXuat=@MaChiTietPhieuXuat";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@MaPhieuXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaPhieuXuat;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaMatHang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaDonViTinh;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoLuongXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.SoLuongXuat;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DonGia", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.DonGia;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@ThanhTien", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.ThanhTien;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = chiTietPhieuXuat.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaChiTietPhieuXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaChiTietPhieuXuat;
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
        public static bool DanhDauXoa(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            chiTietPhieuXuat.Deleted = true;
            return CapNhat(chiTietPhieuXuat);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(ChiTietPhieuXuatDTO chiTietPhieuXuat)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM CHITIETPHIEUXUAT WHERE MaChiTietPhieuXuat=@MaChiTietPhieuXuat";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaChiTietPhieuXuat", OleDbType.Integer);
                thamSo.Value = chiTietPhieuXuat.MaChiTietPhieuXuat;
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
                string chuoiLenh = "DELETE FROM CHITIETPHIEUXUAT";
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
