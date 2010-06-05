using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class LoaiDaiLyDAO: AbstractDAO
    {

        /// <summary>
        /// Lấy ds các các loại đại lý
        /// </summary>
        /// <returns>Danh sách các loại đại lý</returns>
        public static List<LoaiDaiLyDTO> LayDanhSachLoaiDaiLy()
        {
            OleDbConnection ketNoi = null;
            List<LoaiDaiLyDTO> dsLoaiDaiLy = new List<LoaiDaiLyDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaLoaiDaiLy, TenLoaiDaiLy, NoToiDa, Deleted FROM LOAIDAILY";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    LoaiDaiLyDTO loaiDaiLy = new LoaiDaiLyDTO();
                    loaiDaiLy.MaLoaiDaiLy = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        loaiDaiLy.TenLoaiDaiLy = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        loaiDaiLy.NoToiDa = boDoc.GetInt32(2);
                    if ((!boDoc.IsDBNull(3)) && (boDoc.GetBoolean(3)))
                        continue;
                    dsLoaiDaiLy.Add(loaiDaiLy);
                }
            }
            catch (Exception ex)
            {
                dsLoaiDaiLy = new List<LoaiDaiLyDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsLoaiDaiLy;
        }
        /// <summary>
        /// Lấy ds các các loại đại lý kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các loại đại lý</returns>
        public static List<LoaiDaiLyDTO> LayToanBoDanhSachLoaiDaiLy()
        {
            OleDbConnection ketNoi = null;
            List<LoaiDaiLyDTO> dsMatHang = new List<LoaiDaiLyDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaLoaiDaiLy, TenLoaiDaiLy, NoToiDa, Deleted FROM LOAIDAILY";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    LoaiDaiLyDTO loaiDaiLy = new LoaiDaiLyDTO();
                    loaiDaiLy.MaLoaiDaiLy = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        loaiDaiLy.TenLoaiDaiLy = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        loaiDaiLy.NoToiDa = boDoc.GetInt32(2);
                    if ((!boDoc.IsDBNull(3)) && (boDoc.GetBoolean(3)))
                        loaiDaiLy.Deleted = boDoc.GetBoolean(3);
                    dsMatHang.Add(loaiDaiLy);
                }
            }
            catch (Exception ex)
            {
                dsMatHang = new List<LoaiDaiLyDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsMatHang;
        }
        /// <summary>
        /// Thêm 1 loại đại lý mới
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin loại đại lý mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(LoaiDaiLyDTO loaiDaiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO LOAIDAILY(TenLoaiDaiLy, NoToiDa)";
                chuoiLenh += " VALUES(@TenLoaiDaiLy, @NoToiDa)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenLoaiDaiLy", OleDbType.VarChar);
                thamSo.Value = loaiDaiLy.TenLoaiDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NoToiDa", OleDbType.Integer);
                thamSo.Value = loaiDaiLy.NoToiDa;
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
        /// Cập nhật thông tin một loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin loại đại lý cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(LoaiDaiLyDTO loaiDaiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE LOAIDAILY SET  TenLoaiDaiLy=@TenLoaiDaiLy, NoToiDa=@NoToiDa, Deleted=@Deleted WHERE MaLoaiDaiLy=@MaLoaiDaiLy";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenLoaiDaiLy", OleDbType.VarChar);
                thamSo.Value = loaiDaiLy.TenLoaiDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NoToiDa", OleDbType.Integer);
                thamSo.Value = loaiDaiLy.NoToiDa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = loaiDaiLy.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaLoaiDaiLy", OleDbType.Integer);
                thamSo.Value = loaiDaiLy.MaLoaiDaiLy;
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
        /// Đánh dấu xóa thông tin 1 loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Loại đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(LoaiDaiLyDTO loaiDaiLy)
        {
            loaiDaiLy.Deleted = true;
            return CapNhat(loaiDaiLy);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Loại đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(LoaiDaiLyDTO loaiDaiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM LOAIDAILY WHERE MaLoaiDaiLy=@MaLoaiDaiLy";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaLoaiDaiLy", OleDbType.Integer);
                thamSo.Value = loaiDaiLy.MaLoaiDaiLy;
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
                string chuoiLenh = "DELETE FROM LOAIDAILY";
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
