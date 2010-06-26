using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class ChiTietPhieuXuatBUS
    {
        /// <summary>
        /// Lấy ds các các phiếu xuất
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<ChiTietPhieuXuatDTO> LayDanhSachChiTietPhieuXuat()
        {
            return ChiTietPhieuXuatDAO.LayDanhSachChiTietPhieuXuat();
        }
        /// <summary>
        /// Lấy ds các các phiếu xuất kể cả phiếu bị xóa
        /// </summary>
        /// <returns>Danh sách các phiếu xuất</returns>
        public static List<ChiTietPhieuXuatDTO> LayToanBoDanhSachChiTietPhieuXuat()
        {
            return ChiTietPhieuXuatDAO.LayToanBoDanhSachChiTietPhieuXuat();
        }
        /// <summary>
        /// Thêm 1 phiếu xuất mới
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(ChiTietPhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return ChiTietPhieuXuatDAO.ThemMoi(phieuXuat);
        }
        /// <summary>
        /// Cập nhật thông tin một phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu xuất cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(ChiTietPhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return ChiTietPhieuXuatDAO.CapNhat(phieuXuat);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(ChiTietPhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return ChiTietPhieuXuatDAO.DanhDauXoa(phieuXuat);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu xuất
        /// </summary>
        /// <param name="phieuXuat">Phiếu xuất cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(ChiTietPhieuXuatDTO phieuXuat)
        {
            //Kiểm tra các qui định
            return ChiTietPhieuXuatDAO.XoaThatSu(phieuXuat);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return ChiTietPhieuXuatDAO.XoaThatSuToanBo();
        }
    }
}
