using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class BangGiaBUS
    {
        /// <summary>
        /// Lấy ds các bảng giá
        /// </summary>
        /// <returns>Danh sách các bảng giá</returns>
        public static List<BangGiaDTO> LayDanhSachBangGia()
        {
            //Kiểm tra các qui định
            return BangGiaDAO.LayDanhSachBangGia();
        }
        /// <summary>
        /// Lấy ds các các bảng giá kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các bảng giá</returns>
        public static List<BangGiaDTO> LayToanBoDanhSachBangGia()
        {
            //Kiểm tra các qui định
            return BangGiaDAO.LayToanBoDanhSachBangGia();
        }
        /// <summary>
        /// Thêm 1 bảng giá mới
        /// </summary>
        /// <param name="bangGia">Thông tin bảng giá mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(BangGiaDTO bangGia)
        {
            //Kiểm tra các qui định
            return BangGiaDAO.ThemMoi(bangGia);
        }
        /// <summary>
        /// Cập nhật thông tin một bảng giá
        /// </summary>
        /// <param name="bangGia">Thông tin bảng giá cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(BangGiaDTO bangGia)
        {
            //Kiểm tra các qui định
            return BangGiaDAO.CapNhat(bangGia);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 bảng giá
        /// </summary>
        /// <param name="matHang">Bảng giá cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(BangGiaDTO bangGia)
        {
            //Kiểm tra các qui định
            return BangGiaDAO.DanhDauXoa(bangGia);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 bảng giá
        /// </summary>
        /// <param name="matHang">Bảng giá cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(BangGiaDTO bangGia)
        {
            //Kiểm tra các qui định
            return BangGiaBUS.XoaThatSu(bangGia);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return BangGiaBUS.XoaThatSuToanBo();
        }
    }
}
