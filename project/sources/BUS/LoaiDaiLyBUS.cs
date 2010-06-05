using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class LoaiDaiLyBUS
    {
        /// <summary>
        /// Lấy ds các các loại đại lý
        /// </summary>
        /// <returns>Danh sách các loại đại lý</returns>
        public static List<LoaiDaiLyDTO> LayDanhSachLoaiDaiLy()
        {
            return LoaiDaiLyDAO.LayDanhSachLoaiDaiLy();
        }
        /// <summary>
        /// Lấy tên loại theo mã
        /// </summary>
        /// <param name="maLoai">Thông tin mã loại</param>
        /// <returns>Tên quận</returns>
        public static string LayTenLoaiDaiLy(long maLoai)
        {
            string kq = "";
            List<LoaiDaiLyDTO> dsLoaiDaiLy = LoaiDaiLyBUS.LayToanBoDanhSachLoaiDaiLy();
            for (int i = 0; i < dsLoaiDaiLy.Count; ++i)
            {
                if (dsLoaiDaiLy[i].MaLoaiDaiLy == maLoai)
                {
                    kq = dsLoaiDaiLy[i].TenLoaiDaiLy;
                    break;
                }
            }
            return kq;
        }
        public static int LayLoaiDaiLy(long maLoai)
        {
            int kq = 0;
            List<LoaiDaiLyDTO> dsLoaiDaiLy = LoaiDaiLyBUS.LayToanBoDanhSachLoaiDaiLy();
            for (int i = 0; i < dsLoaiDaiLy.Count; ++i)
            {
                if (dsLoaiDaiLy[i].MaLoaiDaiLy == maLoai)
                {
                    kq = i;
                    break;
                }
            }
            return kq;
        }
        /// <summary>
        /// Lấy ds các các loại đại lý kể cả bị xóa
        /// </summary>
        /// <returns>Danh sách các loại đại lý</returns>
        public static List<LoaiDaiLyDTO> LayToanBoDanhSachLoaiDaiLy()
        {
            return LoaiDaiLyDAO.LayToanBoDanhSachLoaiDaiLy();
        }
        /// <summary>
        /// Thêm 1 loại đại lý mới
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin loại đại lý mới cần thêm</param>
        /// <returns>True: Thêm thành công; False: Thêm thất bại</returns>
        public static bool ThemMoi(LoaiDaiLyDTO loaiDaiLy)
        {
            //Kiểm tra các qui định
            return LoaiDaiLyDAO.ThemMoi(loaiDaiLy);
        }
        /// <summary>
        /// Cập nhật thông tin một loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Thông tin loại đại lý cần cập nhật</param>
        /// <returns>True: Cập nhật thành công; False: Cập nhật thất bại</returns>
        public static bool CapNhat(LoaiDaiLyDTO loaiDaiLy)
        {
            //Kiểm tra các qui định
            return LoaiDaiLyDAO.CapNhat(loaiDaiLy);
        }
        /// <summary>
        /// Đánh dấu xóa thông tin 1 loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Loại đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool DanhDauXoa(LoaiDaiLyDTO loaiDaiLy)
        {
            //Kiểm tra các qui định
            return LoaiDaiLyDAO.DanhDauXoa(loaiDaiLy);
        }

        /// <summary>
        /// Xóa thật sự thông tin 1 loại đại lý
        /// </summary>
        /// <param name="loaiDaiLy">Loại đại lý cần xóa</param>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSu(LoaiDaiLyDTO loaiDaiLy)
        {
            //Kiểm tra các qui định
            return LoaiDaiLyDAO.XoaThatSu(loaiDaiLy);
        }

        /// <summary>
        /// Xóa thật sự toàn bộ thông tin
        /// </summary>
        /// <returns>True: Xóa thành công; False: Xóa thất bại</returns>
        public static bool XoaThatSuToanBo()
        {
            //Kiểm tra các qui định
            return LoaiDaiLyDAO.XoaThatSuToanBo();
        }
    }
}
