using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DonViTinhDTO
    {
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
        /// Tên của đơn vị tính
        /// </summary>
        private string tenDonViTinh = "";
        public string TenDonViTinh
        {
            get { return tenDonViTinh; }
            set { tenDonViTinh = value; }
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
