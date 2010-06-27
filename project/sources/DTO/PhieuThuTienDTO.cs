using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class PhieuThuTienDTO
    {
        int maPhieuThu;

        public int MaPhieuThu
        {
            get { return maPhieuThu; }
            set { maPhieuThu = value; }
        }
        DateTime ngayThuTien;

        public DateTime NgayThuTien
        {
            get { return ngayThuTien; }
            set { ngayThuTien = value; }
        }

        double soTienThu;

        public double SoTienThu
        {
            get { return soTienThu; }
            set { soTienThu = value; }
        }

        long maDaiLy;

        public long MaDaiLy
        {
            get { return maDaiLy; }
            set { maDaiLy = value; }
        }
        bool deleted;

        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

    }
}
