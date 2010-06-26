using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class DonViTinhDAO: AbstractDAO
    {
        /// <summary>
        /// Lấy ds các đơn vị tính
        /// </summary>
        /// <returns>Danh sách các đơn vị tính</returns>
        public static List<DonViTinhDTO> LayDanhSachDonViTinh()
        {
            OleDbConnection ketNoi = null;
            List<DonViTinhDTO> dsDonViTinh = new List<DonViTinhDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDonViTinh, TenDonViTinh, Deleted FROM DONVITINH";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    DonViTinhDTO donViTinh = new DonViTinhDTO();
                    donViTinh.MaDonViTinh = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        donViTinh.TenDonViTinh = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2) && boDoc.GetBoolean(2))
                        continue;
                    dsDonViTinh.Add(donViTinh);
                }
            }
            catch (Exception ex)
            {
                dsDonViTinh = new List<DonViTinhDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsDonViTinh;
        }

        /// <summary>
        /// Lấy ds các đơn vị tính, kể cả đơn vị tính bị xóa
        /// </summary>
        /// <returns>Danh sách các đơn vị tính</returns>
        public static List<DonViTinhDTO> LayToanBoDanhSachDonViTinh()
        {
            OleDbConnection ketNoi = null;
            List<DonViTinhDTO> dsDonViTinh = new List<DonViTinhDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDonViTinh, TenDonViTinh, Deleted FROM DONVITINH";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    DonViTinhDTO donViTinh = new DonViTinhDTO();
                    donViTinh.MaDonViTinh = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        donViTinh.TenDonViTinh = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        donViTinh.Deleted = boDoc.GetBoolean(2);
                    dsDonViTinh.Add(donViTinh);
                }
            }
            catch (Exception ex)
            {
                dsDonViTinh = new List<DonViTinhDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsDonViTinh;
        }

        /// <summary>
        /// Lấy đơn vị tính theo mã
        /// </summary>
        /// <returns>đơn vị tính</returns>
        public static DonViTinhDTO LayDonViTinhTheoMa(DonViTinhDTO donViTinh)
        {
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaDonViTinh, TenDonViTinh, Deleted FROM DONVITINH WHERE MaDonViTinh=@MaDonViTinh";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = donViTinh.MaDonViTinh;
                lenh.Parameters.Add(thamSo);

                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    donViTinh.MaDonViTinh = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        donViTinh.TenDonViTinh = boDoc.GetString(1);
                    if (!boDoc.IsDBNull(2))
                        donViTinh.Deleted = boDoc.GetBoolean(2);
                    break;
                }
            }
            catch (Exception ex)
            {
                donViTinh = new DonViTinhDTO();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return donViTinh;
        }

        /// <summary>
        /// Thêm 1 đơn vị tính mới
        /// </summary>
        /// <param name="quan">Thông tin đơn vị tính mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(DonViTinhDTO donViTinh)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã quận dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO DONVITINH(TenDonViTinh)";
                chuoiLenh += " VALUES(@TenDonViTinh)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@TenDonViTinh", OleDbType.VarChar);
                thamSo.Value = donViTinh.TenDonViTinh;
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
        /// Cập nhật thông tin một đơn vị tính
        /// </summary>
        /// <param name="quan">Thông tin đơn vị tính</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(DonViTinhDTO donViTinh)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE DONVITINH SET TenDonViTinh=@TenDonViTinh, Deleted=@Deleted WHERE MaDonViTinh=@MaDonViTinh";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@TenDonViTinh", OleDbType.VarChar);
                thamSo.Value = donViTinh.TenDonViTinh;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = donViTinh.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = donViTinh.MaDonViTinh;
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
        /// Đánh dấu xóa thông tin 1 đơn vị tính
        /// </summary>
        /// <param name="quan">Đơn vị tính cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(DonViTinhDTO donViTinh)
        {
            donViTinh.Deleted = true;
            return CapNhat(donViTinh);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 đơn vị tính
        /// </summary>
        /// <param name="quan">Đơn vị tính cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(DonViTinhDTO donViTinh)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM DONVITINH WHERE MaDonViTinh=@MaDonViTinh";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = donViTinh.MaDonViTinh;
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
                string chuoiLenh = "DELETE FROM DONVITINH";
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
