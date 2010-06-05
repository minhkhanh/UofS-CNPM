using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class DaiLyDAO: AbstractDAO
    {
        /// <summary>
        /// Lấy ds các đại lý
        /// </summary>
        /// <returns>Danh sách các đại lý</returns>
        public static List<DaiLyDTO> LayDanhSachDaiLy()
        {
            OleDbConnection ketNoi = null;
            List<DaiLyDTO> dsDaiLy = new List<DaiLyDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDaiLy, TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, MaQuan, NgayTiepNhan, Email, NoCuaDaiLy, Deleted FROM DAILY";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    DaiLyDTO daiLy = new DaiLyDTO();
                    daiLy.MaDaiLy = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        daiLy.TenDaiLy = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        daiLy.MaLoaiDaiLy = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        daiLy.DienThoai = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        daiLy.DiaChi = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        daiLy.MaQuan = boDoc.GetInt32(5);
                    if (!boDoc.IsDBNull(6))
                        daiLy.NgayTiepNhan = boDoc.GetDateTime(6);
                    if (!boDoc.IsDBNull(7))
                        daiLy.Email = boDoc.GetString(7);
                    if (!boDoc.IsDBNull(8))
                        daiLy.NoCuaDaiLy = boDoc.GetInt32(8);
                    if (!boDoc.IsDBNull(9) && boDoc.GetBoolean(9))
                        continue;
                    dsDaiLy.Add(daiLy);
                }
            }
            catch (Exception ex)
            {
                dsDaiLy = new List<DaiLyDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsDaiLy;
        }

        /// <summary>
        /// Lấy ds các đại lý, kể cả đại lý bị xóa
        /// </summary>
        /// <returns>Danh sách các đại lý</returns>
        public static List<DaiLyDTO> LayToanBoDanhSachDaiLy()
        {
            OleDbConnection ketNoi = null;
            List<DaiLyDTO> dsDaiLy = new List<DaiLyDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDaiLy, TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, MaQuan, NgayTiepNhan, Email, NoCuaDaiLy, Deleted FROM DAILY";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    DaiLyDTO daiLy = new DaiLyDTO();
                    daiLy.MaDaiLy = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        daiLy.TenDaiLy = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        daiLy.MaLoaiDaiLy = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        daiLy.DienThoai = boDoc.GetString(3);
                    if (!boDoc.IsDBNull(4))
                        daiLy.DiaChi = boDoc.GetString(4);
                    if (!boDoc.IsDBNull(5))
                        daiLy.MaQuan = boDoc.GetInt32(5);
                    if (!boDoc.IsDBNull(6))
                        daiLy.NgayTiepNhan = boDoc.GetDateTime(6);
                    if (!boDoc.IsDBNull(7))
                        daiLy.Email = boDoc.GetString(7);
                    if (!boDoc.IsDBNull(8))
                        daiLy.NoCuaDaiLy = boDoc.GetInt32(8);
                    if (!boDoc.IsDBNull(9))
                        daiLy.Deleted = boDoc.GetBoolean(9);
                    dsDaiLy.Add(daiLy);
                }
            }
            catch (Exception ex)
            {
                dsDaiLy = new List<DaiLyDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsDaiLy;
        }

        /// <summary>
        /// Thêm 1 đại lý mới
        /// </summary>
        /// <param name="daiLy">Thông tin đại lý mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(DaiLyDTO daiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã quận dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO DAILY(TenDaiLy, MaLoaiDaiLy, DienThoai, DiaChi, MaQuan, NgayTiepNhan, Email, NoCuaDaiLy)";
                chuoiLenh += " VALUES(@TenDaiLy, @MaLoaiDaiLy, @DienThoai, @DiaChi, @MaQuan, @NgayTiepNhan, @Email, @NoCuaDaiLy)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenDaiLy", OleDbType.VarChar);
                thamSo.Value = daiLy.TenDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaLoaiDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.MaLoaiDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DienThoai", OleDbType.VarChar);
                thamSo.Value = daiLy.DienThoai;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DiaChi", OleDbType.VarChar);
                thamSo.Value = daiLy.DiaChi;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaQuan", OleDbType.Integer);
                thamSo.Value = daiLy.MaQuan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NgayTiepNhan", OleDbType.Date);
                thamSo.Value = daiLy.NgayTiepNhan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Email", OleDbType.VarChar);
                thamSo.Value = daiLy.Email;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NoCuaDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.NoCuaDaiLy;
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
        /// Cập nhật thông tin một đại lý
        /// </summary>
        /// <param name="daiLy">Thông tin đại lý</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(DaiLyDTO daiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE DAILY SET TenDaiLy=@TenDaiLy, MaLoaiDaiLy=@MaLoaiDaiLy, DienThoai=@DienThoai, DiaChi=@DiaChi, MaQuan=@MaQuan, NgayTiepNhan=@NgayTiepNhan, Email=@Email, NoCuaDaiLy=@NoCuaDaiLy, Deleted=@Deleted WHERE MaDaiLy=@MaDaiLy";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenDaiLy", OleDbType.VarChar);
                thamSo.Value = daiLy.TenDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaLoaiDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.MaLoaiDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DienThoai", OleDbType.VarChar);
                thamSo.Value = daiLy.DienThoai;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DiaChi", OleDbType.VarChar);
                thamSo.Value = daiLy.DiaChi;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaQuan", OleDbType.Integer);
                thamSo.Value = daiLy.MaQuan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NgayTiepNhan", OleDbType.Date);
                thamSo.Value = daiLy.NgayTiepNhan;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Email", OleDbType.VarChar);
                thamSo.Value = daiLy.Email;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@NoCuaDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.NoCuaDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = daiLy.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.MaDaiLy;
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
        /// Đánh dấu xóa thông tin 1 đại lý
        /// </summary>
        /// <param name="daiLy">Đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(DaiLyDTO daiLy)
        {
            daiLy.Deleted = true;
            return CapNhat(daiLy);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 đại lý
        /// </summary>
        /// <param name="daiLy">Đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(DaiLyDTO daiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM DAILY WHERE MaDaiLy=@MaDaiLy";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = daiLy.MaQuan;
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
                string chuoiLenh = "DELETE FROM DAILY";
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
