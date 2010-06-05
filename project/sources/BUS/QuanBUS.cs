using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class QuanBUS
    {
        /// <summary>
        /// Lấy ds các quận
        /// </summary>
        /// <returns>Danh sách các quận</returns>
        public static List<QuanDTO> LayDanhSachQuan()
        {
            return QuanDAO.LayDanhSachQuan();
        }
        /// <summary>
        /// Lấy tên quận theo mã quận
        /// </summary>
        /// <param name="maQuan">Thông tin quận</param>
        /// <returns>Tên quận</returns>
        public static string LayTenQuan(long maQuan)
        {
            string kq = "";
            List<QuanDTO> dsQuan = QuanBUS.LayToanBoDanhSachQuan();
            for (int i = 0; i < dsQuan.Count; ++i)
            {
                if (dsQuan[i].MaQuan == maQuan)
                {
                    kq = dsQuan[i].TenQuan;
                    break;
                }
            }
            return kq;
        }
        public static int LayQuan(long maQuan)
        {
            int kq = 0;
            List<QuanDTO> dsQuan = QuanBUS.LayToanBoDanhSachQuan();
            for (int i = 0; i < dsQuan.Count; ++i)
            {
                if (dsQuan[i].MaQuan == maQuan)
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }
        /// <summary>
        /// Lấy ds các quận, kể cả quận bị xóa
        /// </summary>
        /// <returns>Danh sách các quận</returns>
        public static List<QuanDTO> LayToanBoDanhSachQuan()
        {
            return QuanDAO.LayToanBoDanhSachQuan();
        }

        /// <summary>
        /// Thêm 1 quận mới
        /// </summary>
        /// <param name="quan">Thông tin quận mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(QuanDTO quan)
        {
            //Kiểm tra các qui định
            return QuanDAO.ThemMoi(quan);
        }
        /// <summary>
        /// Cập nhật thông tin một quận
        /// </summary>
        /// <param name="quan">Thông tin quận</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(QuanDTO quan)
        {
            //Kiểm tra các qui định
            return QuanDAO.CapNhat(quan);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 quận
        /// </summary>
        /// <param name="quan">Quận cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(QuanDTO quan)
        {
            //Kiểm tra các qui định
            return QuanDAO.DanhDauXoa(quan);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 quận
        /// </summary>
        /// <param name="quan">Quận cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(QuanDTO quan)
        {
            //Kiểm tra các qui định
            return QuanDAO.XoaThatSu(quan);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return QuanDAO.XoaThatSuToanBo();
        }
    }
}
