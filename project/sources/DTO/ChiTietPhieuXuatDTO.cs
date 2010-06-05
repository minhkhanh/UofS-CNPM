using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class ChiTietPhieuXuatDTO
    {
        /// <summary>
        /// Mã số, con số tự động tăng, dùng quản lý trong CSDL
        /// </summary>
        private long maChiTietPhieuXuat = -1;
        public long MaChiTietPhieuXuat
        {
            get { return maChiTietPhieuXuat; }
            set { maChiTietPhieuXuat = value; }
        }
        /// <summary>
        /// Mã phiếu xuất hàng
        /// </summary>
        private long maPhieuXuat = -1;
        public long MaPhieuXuat
        {
            get { return maPhieuXuat; }
            set { maPhieuXuat = value; }
        }
        /// <summary>
        /// Mã của mặt hàng
        /// </summary>
        private long maMatHang = -1;
        public long MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        /// <summary>
        /// Mã của đơn vị tính
        /// </summary>
        private long maDonViTinh = -1;
        public long MaDonViTinh
        {
            get { return maDonViTinh; }
            set { MaDonViTinh = value; }
        }
        /// <summary>
        /// Số lượng xuất
        /// </summary>
        private long soLuongXuat = -1;
        public long SoLuongXuat
        {
            get { return soLuongXuat; }
            set { soLuongXuat = value; }
        }
        /// <summary>
        /// Đơn giá của mặt hàng
        /// </summary>
        private long donGia = -1;
        public long DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        /// <summary>
        /// Thành tiền của phiếu xuất chi tiết
        /// </summary>
        private long thanhTien = -1;
        public long ThanhTien
        {
            get { return thanhTien; }
            set { thanhTien = value; }
        }
    }
}
