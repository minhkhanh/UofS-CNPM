using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class PhieuXuatBUS
    {
        /// <summary>
        /// Lấy ds các các phiếu xuất
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<PhieuXuatDTO> LayDanhSachPhieuXuat()
        {
            return PhieuXuatDAO.LayDanhSachPhieuXuat();
        }
        /// <summary>
        /// Lấy ds các các phiếu xuất kể cả phiếu bị xóa
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<PhieuXuatDTO> LayToanBoDanhSachPhieuXuat()
        {
            return PhieuXuatDAO.LayToanBoDanhSachPhieuXuat();
        }
        /// <summary>
        /// Thêm 1 phiếu xuất mới
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(PhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return PhieuXuatDAO.ThemMoi(phieuXuat);
        }
        /// <summary>
        /// Cập nhật thông tin một phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(PhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return PhieuXuatDAO.CapNhat(phieuXuat);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(PhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return PhieuXuatDAO.DanhDauXoa(phieuXuat);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(PhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return PhieuXuatDAO.XoaThatSu(phieuXuat);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return PhieuXuatDAO.XoaThatSuToanBo();
        }
    }
}
