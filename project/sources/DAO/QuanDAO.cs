using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class QuanDAO: AbstractDAO
    {
        /// <summary>
        /// Lấy ds các quận
        /// </summary>
        /// <returns>Danh sách các quận</returns>
        public static List<QuanDTO> LayDanhSachQuan()
        {
            OleDbConnection ketNoi = null;
            List<QuanDTO> dsQuan = new List<QuanDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaQuan, TenQuan, SoLuongDaiLyToiDa, Deleted FROM QUAN";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    QuanDTO quan = new QuanDTO();
                    quan.MaQuan = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        quan.TenQuan = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        quan.SoLuongDaiLyToiDa = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3) && boDoc.GetBoolean(3))
                        continue;
                    dsQuan.Add(quan);
                }
            }
            catch (Exception ex)
            {
                dsQuan = new List<QuanDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsQuan;
        }

        /// <summary>
        /// Lấy ds các quận, kể cả quận bị xóa
        /// </summary>
        /// <returns>Danh sách các quận</returns>
        public static List<QuanDTO> LayToanBoDanhSachQuan()
        {
            OleDbConnection ketNoi = null;
            List<QuanDTO> dsQuan = new List<QuanDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaQuan, TenQuan, SoLuongDaiLyToiDa, Deleted FROM QUAN";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    QuanDTO quan = new QuanDTO();
                    quan.MaQuan = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        quan.TenQuan = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        quan.SoLuongDaiLyToiDa = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        quan.Deleted = boDoc.GetBoolean(3);
                    dsQuan.Add(quan);
                }
            }
            catch (Exception ex)
            {
                dsQuan = new List<QuanDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsQuan;
        }

        /// <summary>
        /// Thêm 1 quận mới
        /// </summary>
        /// <param name="quan">Thông tin quận mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(QuanDTO quan)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã quận dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO QUAN(TenQuan, SoLuongDaiLyToiDa)";
                chuoiLenh += " VALUES(@TenQuan, @SoLuongDaiLyToiDa)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenQuan", OleDbType.VarChar);
                thamSo.Value = quan.TenQuan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoLuongDaiLyToiDa", OleDbType.Integer);
                thamSo.Value = quan.SoLuongDaiLyToiDa;
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
        /// Cập nhật thông tin một quận
        /// </summary>
        /// <param name="quan">Thông tin quận</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(QuanDTO quan)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE QUAN SET TenQuan=@TenQuan, SoLuongDaiLyToiDa=@SoLuongDaiLyToiDa, Deleted=@Deleted WHERE MaQuan=@MaQuan";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@TenQuan", OleDbType.VarChar);
                thamSo.Value = quan.TenQuan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoLuongDaiLyToiDa", OleDbType.Integer);
                thamSo.Value = quan.SoLuongDaiLyToiDa;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = quan.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaQuan", OleDbType.Integer);
                thamSo.Value = quan.MaQuan;
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
        /// Đánh dấu xóa thông tin 1 quận
        /// </summary>
        /// <param name="quan">Quận cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(QuanDTO quan)
        {
            quan.Deleted = true;
            return CapNhat(quan);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 quận
        /// </summary>
        /// <param name="quan">Quận cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(QuanDTO quan)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM QUAN WHERE MaSo=@MaQuan";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaQuan", OleDbType.Integer);
                thamSo.Value = quan.MaQuan;
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
                string chuoiLenh = "DELETE FROM QUAN";
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
