using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class TraCuuDaiLyDTO
    {

        private long maDaiLy;

        public long MaDaiLy
        {
            get { return maDaiLy; }
            set { maDaiLy = value; }
        }
        private string tenDaiLy;

        public string TenDaiLy
        {
            get { return tenDaiLy; }
            set { tenDaiLy = value; }
        }
        private string tenLoaiDaiLy;

        public string TenLoaiDaiLy
        {
            get { return tenLoaiDaiLy; }
            set { tenLoaiDaiLy = value; }
        }
        private string tenQuan;

        public string TenQuan
        {
            get { return tenQuan; }
            set { tenQuan = value; }
        }
        
        private long tienNo;

        public long TienNo
        {
            get { return tienNo; }
            set { tienNo = value; }
        }


    }
}
