using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhieuXuatDTO
    {
        /// <summary>
        /// Mã của loại của phiếu xuất, dùng quản lý trong csdl
        /// </summary>
        private long maPhieuXuat = -1;
        public long MaPhieuXuat
        {
            get { return maPhieuXuat; }
            set { maPhieuXuat = value; }
        }
        /// <summary>
        /// Mã của đại lý được xuất hàng
        /// </summary>
        private long maDaiLy = -1;
        public long MaDaiLy
        {
            get { return maDaiLy; }
            set { maDaiLy = value; }
        }
        /// <summary>
        /// Ngày lập phiếu
        /// </summary>
        private DateTime ngayLapPhieu = DateTime.Now;
        public DateTime NgayLapPhieu
        {
            get { return ngayLapPhieu; }
            set { ngayLapPhieu = value; }
        }
        /// <summary>
        /// Tổng trị giá của phiếu xuất
        /// </summary>
        private long tongTriGia = -1;
        public long TongTriGia
        {
            get { return tongTriGia; }
            set { tongTriGia = value; }
        }
        /// <summary>
        /// Đánh dấu có bị xóa hay không
        /// </summary>
        private bool deleted = false;
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
    }
}
