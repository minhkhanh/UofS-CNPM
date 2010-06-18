using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    class HangTonDTO
    {
        /// <summary>
        /// Mã của mặt hàng, dùng quản lý trong csdl
        /// </summary>
        private long maMatHang = -1;
        public long MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        /// <summary>
        /// Mã của đơn vị tính, dùng quản lý trong csdl
        /// </summary>
        private long maDonViTinh = -1;
        public long MaDonViTinh
        {
            get { return maDonViTinh; }
            set { maDonViTinh = value; }
        }
        /// <summary>
        /// Số lượng tồn trong kho của mặt hàng
        /// </summary>
        private long soLuongTon = -1;
        public long SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
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
