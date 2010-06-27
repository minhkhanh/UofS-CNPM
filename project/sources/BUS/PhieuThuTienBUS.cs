using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;


namespace BUS
{
    public class PhieuThuTienBUS
    {
        /// <summary>
        /// Lấy ds các các phiếu thu tiền
        /// </summary>
        /// <returns>Danh sách các phiếu thu tiền</returns>
        public static List<PhieuThuTienDTO> LayDanhSachPhieuThuTien()
        {
            return PhieuThuTienDAO.LayDanhSachPhieuThuTien();
        }
        /// <summary>
        /// Lấy ds các các phiếu thu tiền ke ca nhung phieu bi xoa
        /// </summary>
        /// <returns>Danh sách các phiếu thu tiền</returns>
        public static List<PhieuThuTienDTO> LayToanBoDanhSachPhieuThuTien()
        {
            return PhieuThuTienDAO.LayToanBoDanhSachPhieuThuTien();
        }
        /// <summary>
        /// Thêm 1 phiếu thu tiền moi
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu thu tiền mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(PhieuThuTienDTO phieuThuTien)
        {
            //Kiểm tra các qui định
            return PhieuThuTienDAO.ThemMoi(phieuThuTien);
        }
        /// <summary>
        /// Cập nhật thông tin một phiếu thu tiền
        /// </summary>
        /// <param name="phieuXuat">Thông tin phiếu thu tiền cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(PhieuThuTienDTO phieuThuTien)
        {
            //Kiểm tra các qui định
            return PhieuThuTienDAO.CapNhat(phieuThuTien);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 phiếu thu tiền 
        /// </summary>
        /// <param name="phieuXuat">Phiếu thu tiền cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(PhieuThuTienDTO phieuThuTien)
        {
            //Kiểm tra các qui định
            return PhieuThuTienDAO.DanhDauXoa(phieuThuTien);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 phiếu thu tiền 
        /// </summary>
        /// <param name="phieuXuat">Phiếu thu tiền cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(PhieuThuTienDTO phieuThuTien)
        {
            //Kiểm tra các qui định
            return PhieuThuTienDAO.XoaThatSu(phieuThuTien);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return PhieuThuTienDAO.XoaThatSuToanBo();
        }
        
    }
}
