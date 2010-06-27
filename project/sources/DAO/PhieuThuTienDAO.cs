using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.OleDb;

namespace DAO
{
    public class PhieuThuTienDAO: AbstractDAO
    {

        /// <summary>
        /// Lấy ds các phiếu thu tiền
        /// </summary>
        /// <returns>Danh sách các phiếu thu tiền</returns>
        public static List<PhieuThuTienDTO> LayDanhSachPhieuThuTien()
        {
            OleDbConnection ketNoi = null;
            List<PhieuThuTienDTO> dsPhieuThuTien = new List<PhieuThuTienDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaPhieuThu, NgayThuTien, SoTienThu, MaDaiLy, Deleted FROM PHIEUTHUTIEN";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    PhieuThuTienDTO phieuThuTien  = new PhieuThuTienDTO();

                    if (!boDoc.IsDBNull(0))
                        phieuThuTien.MaPhieuThu = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuThuTien.NgayThuTien = boDoc.GetDateTime(1);
                    if (!boDoc.IsDBNull(2))
                        phieuThuTien.SoTienThu = boDoc.GetDouble(2);
                    if (!boDoc.IsDBNull(3))
                        phieuThuTien.MaDaiLy = boDoc.GetInt32(3);
                    if ((!boDoc.IsDBNull(4)) && (boDoc.GetBoolean(4)))
                        continue;
                    dsPhieuThuTien.Add(phieuThuTien);
                }
            }
            catch (Exception ex)
            {
                dsPhieuThuTien = new List<PhieuThuTienDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsPhieuThuTien;
        }

        public static List<PhieuThuTienDTO> LayToanBoDanhSachPhieuThuTien()
        {
            OleDbConnection ketNoi = null;
            List<PhieuThuTienDTO> dsPhieuThuTien = new List<PhieuThuTienDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaPhieuThu, NgayThuTien, SoTienThu, MaDaiLy, Deleted FROM PHIEUTHUTIEN";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    PhieuThuTienDTO phieuThuTien = new PhieuThuTienDTO();

                    if (!boDoc.IsDBNull(0))
                        phieuThuTien.MaPhieuThu = boDoc.GetInt32(0);
                    if (!boDoc.IsDBNull(1))
                        phieuThuTien.NgayThuTien = boDoc.GetDateTime(1);
                    if (!boDoc.IsDBNull(2))
                        phieuThuTien.SoTienThu = boDoc.GetInt32(2);
                    if (!boDoc.IsDBNull(3))
                        phieuThuTien.MaDaiLy = boDoc.GetInt32(3);

                    if ((!boDoc.IsDBNull(4)))
                        phieuThuTien.Deleted = boDoc.GetBoolean(4);
                    dsPhieuThuTien.Add(phieuThuTien);
                }
            }
            catch (Exception ex)
            {
                dsPhieuThuTien = new List<PhieuThuTienDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsPhieuThuTien;
        }
        /// <summary>
        /// Lấy ds các các phiếu xuất kể cả phiếu bị xóa
        /// </summary>
        /// <returns>Danh sách các phiếu thu tien</returns>
        /// 

        /// <summary>
        /// Thêm 1 phiếu thu tien 
        /// </summary>
        /// <param name="phieuThuTien">Thông tin phieu thu tien mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(PhieuThuTienDTO phieuThuTien)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do mã dùng auto number và delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO PHIEUTHUTIEN(NgayThuTien, SoTienThu, MaDaiLy)";
                chuoiLenh += " VALUES(@NgayThuTien, @SoTienThu, @MaDaiLy)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@NgayThuTien", OleDbType.Date);
                thamSo.Value = phieuThuTien.NgayThuTien;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoTienThu", OleDbType.Integer);
                thamSo.Value = phieuThuTien.SoTienThu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = phieuThuTien.MaDaiLy;
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
        /// Cập nhật thông tin một phiếu thu tien
        /// </summary>
        /// <param name="phieuThuTien">Thông tin phiếu thu tiền cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        /// 
        public static bool CapNhat(PhieuThuTienDTO phieuThuTien)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE PHIEUTHUTIEN SET  NgayThuTien=@NgayThuTien, SoTienThu=@SoTienThu, MaDaiLy=@MaDaiLy, Deleted=@Deleted WHERE MaPhieuThu=@MaPhieuThu";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@NgayThuTien", OleDbType.Date);
                thamSo.Value = phieuThuTien.NgayThuTien;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@SoTienThu", OleDbType.Integer);
                thamSo.Value = phieuThuTien.SoTienThu;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDaiLy", OleDbType.Integer);
                thamSo.Value = phieuThuTien.MaDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = phieuThuTien.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaPhieuThu", OleDbType.Integer);
                thamSo.Value = phieuThuTien.MaPhieuThu;
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
        /// Đánh dấu xóa thông tin 1 phiếu thu tien
        /// </summary>
        /// <param name="phieuThuTien">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        /// 


        public static bool DanhDauXoa(PhieuThuTienDTO phieuThuTien)
        {
            phieuThuTien.Deleted = true;
            return CapNhat(phieuThuTien);
        }
        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(PhieuThuTienDTO phieuThuTien)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM PHIEUTHUTIEN WHERE MaPhieuThu=@MaPhieuThu";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaPhieuThu", OleDbType.Integer);
                thamSo.Value = phieuThuTien.MaPhieuThu;
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
                string chuoiLenh = "DELETE FROM PHIEUTHUTIEN";
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
