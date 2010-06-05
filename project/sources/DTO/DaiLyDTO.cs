using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DaiLyDTO
    {
        /// <summary>
        /// Mã của đại lý, dùng quản lý trong csdl
        /// </summary>
        private long maDaiLy = -1;
        public long MaDaiLy
        {
            get { return maDaiLy; }
            set { maDaiLy = value; }
        }
        /// <summary>
        /// Tên của đại lý
        /// </summary>
        private string tenDaiLy = "";
        public string TenDaiLy
        {
            get { return tenDaiLy; }
            set { tenDaiLy = value; }
        }
        /// <summary>
        /// Mã của loại đại lý
        /// </summary>
        private long maLoaiDaiLy = -1;
        public long MaLoaiDaiLy
        {
            get { return maLoaiDaiLy; }
            set { maLoaiDaiLy = value; }
        }
        /// <summary>
        /// Điện thoại của đại lý
        /// </summary>
        private string dienThoai = "";
        public string DienThoai
        {
            get { return dienThoai; }
            set { dienThoai = value; }
        }
        /// <summary>
        /// Địa chỉ của đại lý
        /// </summary>
        private string diaChi = "";
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        /// <summary>
        /// Mã của quận
        /// </summary>
        private long maQuan = -1;
        public long MaQuan
        {
            get { return maQuan; }
            set { maQuan = value; }
        }
        /// <summary>
        /// Ngày tiếp nhận đại lý
        /// </summary>
        private DateTime ngayTiepNhan = DateTime.Now;
        public DateTime NgayTiepNhan
        {
            get { return ngayTiepNhan; }
            set { ngayTiepNhan = value; }
        }
        /// <summary>
        /// Email của đại lý
        /// </summary>
        private string email = "";
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>
        ///  Số tiền đại lý đang nợ
        /// </summary>
        private long noCuaDaiLy = -1;
        public long NoCuaDaiLy
        {
            get { return noCuaDaiLy; }
            set { noCuaDaiLy = value; }
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
