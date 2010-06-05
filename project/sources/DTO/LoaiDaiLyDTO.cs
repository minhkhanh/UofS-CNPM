using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class LoaiDaiLyDTO
    {
        /// <summary>
        /// Mã của loại đại lý, dùng quản lý trong csdl
        /// </summary>
        private long maLoaiDaiLy = -1;
        public long MaLoaiDaiLy
        {
            get { return maLoaiDaiLy; }
            set { maLoaiDaiLy = value; }
        }
        /// <summary>
        /// Tên của loại đại lý
        /// </summary>
        private string tenLoaiDaiLy = "";
        public string TenLoaiDaiLy
        {
            get { return tenLoaiDaiLy; }
            set { tenLoaiDaiLy = value; }
        }
        /// <summary>
        /// Số tiền tối đa mà loại đại lý này có thể nợ
        /// </summary>
        private long noToiDa = -1;
        public long NoToiDa
        {
            get { return noToiDa; }
            set { noToiDa = value; }
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
