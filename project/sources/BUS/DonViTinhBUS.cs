using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DonViTinhBUS
    {
        /// <summary>
        /// Lấy ds các đơn vị tính
        /// </summary>
        /// <returns>Danh sách các đơn vị tính</returns>
        public static List<DonViTinhDTO> LayDanhSachDonViTinh()
        {
            return DonViTinhDAO.LayDanhSachDonViTinh();
        }

        /// <summary>
        /// Lấy ds các đơn vị tính, kể cả đơn vị tính bị xóa
        /// </summary>
        /// <returns>Danh sách các đơn vị tính</returns>
        public static List<DonViTinhDTO> LayToanBoDanhSachDonViTinh()
        {
            return DonViTinhDAO.LayToanBoDanhSachDonViTinh();
        }

        /// <summary>
        /// Thêm 1 đơn vị tính mới
        /// </summary>
        /// <param name="quan">Thông tin đơn vị tính mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(DonViTinhDTO donViTinh)
        {
            //Kiểm tra các qui định
            return DonViTinhDAO.ThemMoi(donViTinh);
        }
        /// <summary>
        /// Cập nhật thông tin một đơn vị tính
        /// </summary>
        /// <param name="quan">Thông tin đơn vị tính</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(DonViTinhDTO donViTinh)
        {
            //Kiểm tra các qui định
            return DonViTinhDAO.CapNhat(donViTinh);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 đơn vị tính
        /// </summary>
        /// <param name="quan">Đơn vị tính cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(DonViTinhDTO donViTinh)
        {
            //Kiểm tra các qui định
            return DonViTinhDAO.DanhDauXoa(donViTinh);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 đơn vị tính
        /// </summary>
        /// <param name="quan">Đơn vị tính cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(DonViTinhDTO donViTinh)
        {
            //Kiểm tra các qui định
            return DonViTinhDAO.XoaThatSu(donViTinh);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return DonViTinhDAO.XoaThatSuToanBo();
        }
    }
}
