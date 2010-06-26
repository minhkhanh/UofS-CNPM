using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class BangGiaDAO: AbstractDAO
    {
        /// <summary>
        /// Lấy ds bảng giá
        /// </summary>
        /// <returns>Danh sách bảng giá</returns>
        public static List<BangGiaDTO> LayDanhSachBangGia()
        {
            OleDbConnection ketNoi = null;
            List<BangGiaDTO> dsBangGia = new List<BangGiaDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaMatHang, MaDonViTinh, DonGia, Deleted FROM BANGGIA";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    BangGiaDTO bangGia = new BangGiaDTO();
                    bangGia.MaMatHang = boDoc.GetInt32(0);
                    bangGia.MaDonViTinh = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        bangGia.DonGia = boDoc.GetInt32(2);
                    if ((!boDoc.IsDBNull(3)) && (boDoc.GetBoolean(3)))
                        continue;
                    dsBangGia.Add(bangGia);
                }
            }
            catch (Exception ex)
            {
                dsBangGia = new List<BangGiaDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsBangGia;
        }
        /// <summary>
        /// Lấy ds các các bảng giá kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các bảng giá/returns>
        public static List<BangGiaDTO> LayToanBoDanhSachBangGia()
        {
            OleDbConnection ketNoi = null;
            List<BangGiaDTO> dsBangGia = new List<BangGiaDTO>();
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "SELECT MaMatHang, MaDonViTinh, DonGia, Deleted FROM BANGGIA";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbDataReader boDoc = lenh.ExecuteReader();
                while (boDoc.Read())
                {
                    BangGiaDTO bangGia = new BangGiaDTO();
                    bangGia.MaMatHang = boDoc.GetInt32(0);
                    bangGia.MaDonViTinh = boDoc.GetInt32(1);
                    if (!boDoc.IsDBNull(2))
                        bangGia.DonGia = boDoc.GetInt32(2);
                    if ((!boDoc.IsDBNull(3)) && (boDoc.GetBoolean(3)))
                        bangGia.Deleted = boDoc.GetBoolean(3);
                    dsBangGia.Add(bangGia);
                }
            }
            catch (Exception ex)
            {
                dsBangGia = new List<BangGiaDTO>();
            }
            finally
            {
                if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                    ketNoi.Close(); // sau khi làm xong phải đóng kết nối
            }
            return dsBangGia;
        }
        /// <summary>
        /// Thêm 1 loại bảng giá mới
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin loại đại lý mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(BangGiaDTO bangGia)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                //do delete dùng defaut 0 nên ko cần insert
                string chuoiLenh = "INSERT INTO BANGGIA(MaMatHang, MaDonViTinh, DonGia)";
                chuoiLenh += " VALUES(@MaMatHang, @MaDonViTinh, @DonGia)";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                // Các tham số
                // Thứ tự các tham số trong chuoiLenh và thứ tự add các tham số phải giống nhau
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = bangGia.MaMatHang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = bangGia.MaDonViTinh;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@DonGia", OleDbType.Integer);
                thamSo.Value = bangGia.DonGia;
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
        /// Cập nhật thông tin một bảng giá
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin bảng giá cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(BangGiaDTO bangGia)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "UPDATE LOAIDAILY SET  DonGia=@DonGia, Deleted=@Deleted WHERE MaMatHang=@MaMatHang AND MaDonViTinh=@MaDonViTinh";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
                OleDbParameter thamSo;

                thamSo = new OleDbParameter("@DonGia", OleDbType.Integer);
                thamSo.Value = bangGia.DonGia;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@Delete", OleDbType.Boolean);
                thamSo.Value = bangGia.Deleted;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = bangGia.MaMatHang;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
                thamSo.Value = bangGia.MaDonViTinh;
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
        /// Đánh dấu xóa thông tin 1 bảng giá
        /// </summary>
        /// <param name="bangGia">Bảng giá cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(BangGiaDTO bangGia)
        {
            bangGia.Deleted = true;
            return CapNhat(bangGia);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 bảng giá
        /// </summary>
        /// <param name="loaiDaiLy">Bảng giá cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(LoaiDaiLyDTO loaiDaiLy)
        {
            bool ketQua = true;
            OleDbConnection ketNoi = null;
            try
            {
                ketNoi = MoKetNoi();
                string chuoiLenh = "DELETE FROM BANGGIA WHERE MaMatHang=@MaMatHang AND MaDonViTinh=@MaDonViTinh";
                OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);

                OleDbParameter thamSo;
                thamSo = new OleDbParameter("@MaMatHang", OleDbType.Integer);
                thamSo.Value = loaiDaiLy.MaLoaiDaiLy;
                lenh.Parameters.Add(thamSo);

                thamSo = new OleDbParameter("@MaDonViTinh", OleDbType.Integer);
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
                string chuoiLenh = "DELETE FROM BANGGIA";
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
