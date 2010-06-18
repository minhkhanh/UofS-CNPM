using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class MatHangDAO: AbstractDAO
    {

        /// <summary>
        /// Lấy ds các các mặt hàng
        /// </summary>
        /// <returns>Danh sách các mặt hàng</returns>
        public static List<MatHangDTO> LayDanhSachMatHang()
        {
            OleDbConnection ketNoi = null;
            List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaMatHang, TenMatHang, Deleted FROM MATHANG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    MatHangDTO phieuXuat = new MatHangDTO();
                    phieuXuat.MaMatHang = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuXuat.TenMatHang = boDoc.GetString(1);
                    if ((!boDoc.IsDBNull(2)) && (boDoc.GetBoolean(2)))
                        continue;
                    dsMatHang.Add(phieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsMatHang = new List<MatHangDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsMatHang;
        }
        /// <summary>
        /// Lấy ds các các mặt hàng kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các mặt hàng</returns>
        public static List<MatHangDTO> LayToanBoDanhSachMatHang()
        {
            OleDbConnection ketNoi = null;
            List<MatHangDTO> dsMatHang = new List<MatHangDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaMatHang, TenMatHang, Deleted FROM MATHANG";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    MatHangDTO phieuXuat = new MatHangDTO();
                    phieuXuat.MaMatHang = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuXuat.TenMatHang = boDoc.GetString(1);
                    if ((!boDoc.IsDBNull(2)) && (boDoc.GetBoolean(2)))
                        phieuXuat.Deleted = boDoc.GetBoolean(2);
                    dsMatHang.Add(phieuXuat);
                }
            }
            catch (Exception ex)
            {
                dsMatHang = new List<MatHangDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsMatHang;
        }
        /// <summary>
        /// Thêm 1 mặt hàng mới
        /// </summary>
        /// <param name="matHang">Thông tin mặt hàng mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(MatHangDTO matHang)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO MATHANG(TenMatHang)";
                chuoiLenh += " VALUES(@TenMatHang)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenMatHang", OleDbType.VarChar);
                thamSo.Value = matHang.TenMatHang;
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
        /// Cập nhật thông tin một mặt hàng
        /// </summary>
        /// <param name="matHang">Thông tin mặt hàng cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(MatHangDTO matHang)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE MATHANG SET  TenMatHang=@TenMatHang, Deleted=@Deleted WHERE MaMatHang=@MaMatHang";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenMatHang", OleDbType.VarChar);
                thamSo.Value = matHang.TenMatHang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = matHang.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = matHang.MaMatHang;
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
        /// Đánh dấu xóa thông tin 1 mặt hàng
        /// </summary>
        /// <param name="matHang">Mặt hàng cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(MatHangDTO matHang)
        {
            matHang.Deleted = true;
            return CapNhat(matHang);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 mặt hàng
        /// </summary>
        /// <param name="matHang">Mặt hàng cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(MatHangDTO matHang)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM MATHANG WHERE MaMatHang=@MaMatHang";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = matHang.MaMatHang;
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
                string chuoiLenh = "DELETE FROM MATHANG";
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
