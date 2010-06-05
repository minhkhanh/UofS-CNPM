using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class DaiLyBUS
    {
        /// <summary>
        /// Lấy ds các đại lý
        /// </summary>
        /// <returns>Danh sách các đại lý</returns>
        public static List<DaiLyDTO> LayDanhSachDaiLy()
        {
            return DaiLyDAO.LayDanhSachDaiLy();
        }

        /// <summary>
        /// Lấy ds các đại lý, kể cả đại lý bị xóa
        /// </summary>
        /// <returns>Danh sách các đại lý</returns>
        public static List<DaiLyDTO> LayToanBoDanhSachDaiLy()
        {
            return DaiLyDAO.LayToanBoDanhSachDaiLy();
        }

        /// <summary>
        /// Thêm 1 đại lý mới
        /// </summary>
        /// <param name="daiLy">Thông tin đại lý mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(DaiLyDTO daiLy)
        {
            //Kiểm tra các qui định
            return DaiLyDAO.ThemMoi(daiLy);
        }
        /// <summary>
        /// Cập nhật thông tin một đại lý
        /// </summary>
        /// <param name="daiLy">Thông tin đại lý</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(DaiLyDTO daiLy)
        {
            //Kiểm tra các qui định
            return DaiLyDAO.CapNhat(daiLy);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 đại lý
        /// </summary>
        /// <param name="daiLy">Đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(DaiLyDTO daiLy)
        {
            //Kiểm tra các qui định
            return DaiLyDAO.DanhDauXoa(daiLy);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 đại lý
        /// </summary>
        /// <param name="daiLy">Đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(DaiLyDTO daiLy)
        {
            //Kiểm tra các qui định
            return DaiLyDAO.XoaThatSu(daiLy);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return DaiLyDAO.XoaThatSuToanBo();
        }

    }
}
