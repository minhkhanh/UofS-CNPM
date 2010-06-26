using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class MatHangBUS
    {
        /// <summary>
        /// Lấy ds các các mặt hàng
        /// </summary>
        /// <returns>Danh sách các mặt hàng</returns>
        public static List<MatHangDTO> LayDanhSachMatHang()
        {
            //Kiểm tra các qui định
            return MatHangDAO.LayDanhSachMatHang();
        }
        /// <summary>
        /// Lấy ds các các mặt hàng kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các mặt hàng</returns>
        public static List<MatHangDTO> LayToanBoDanhSachMatHang()
        {
            //Kiểm tra các qui định
            return MatHangDAO.LayToanBoDanhSachMatHang();
        }
        /// <summary>
        /// Lấy mặt hàng theo mã
        /// </summary>
        /// <returns>mặt hàng</returns>
        public static MatHangDTO LayMatHangTheoMa(MatHangDTO matHang)
        {
            //Kiểm tra các qui định
            return MatHangDAO.LayMatHangTheoMa(matHang);
        }
        /// <summary>
        /// Thêm 1 mặt hàng mới
        /// </summary>
        /// <param name="matHang">Thông tin mặt hàng mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(MatHangDTO matHang)
        {
            //Kiểm tra các qui định
            return MatHangDAO.ThemMoi(matHang);
        }
        /// <summary>
        /// Cập nhật thông tin một mặt hàng
        /// </summary>
        /// <param name="matHang">Thông tin mặt hàng cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(MatHangDTO matHang)
        {
            //Kiểm tra các qui định
            return MatHangDAO.CapNhat(matHang);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 mặt hàng
        /// </summary>
        /// <param name="matHang">Mặt hàng cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(MatHangDTO matHang)
        {
            //Kiểm tra các qui định
            return MatHangDAO.DanhDauXoa(matHang);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 mặt hàng
        /// </summary>
        /// <param name="matHang">Mặt hàng cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(MatHangDTO matHang)
        {
            //Kiểm tra các qui định
            return MatHangDAO.XoaThatSu(matHang);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return MatHangDAO.XoaThatSuToanBo();
        }

    }
}
