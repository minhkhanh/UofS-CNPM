using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class QuanDTO
    {
        /// <summary>
        /// Mã của quận, dùng quản lý trong csdl
        /// </summary>
        private long maQuan = -1;
        public long MaQuan
        {
            get { return maQuan; }
            set { maQuan = value; }
        }
        /// <summary>
        /// Tên của quận
        /// </summary>
        private string tenQuan = "";
        public string TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }
        /// <summary>
        /// Số đại lý tối đa trong quận
        /// </summary>
        private long soLuongDaiLyToiDa = 4;
        public long SoLuongDaiLyToiDa
        {
            get { return soLuongDaiLyToiDa; }
            set { soLuongDaiLyToiDa = value; }
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
