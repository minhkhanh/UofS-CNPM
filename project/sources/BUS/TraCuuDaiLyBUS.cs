using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using DTO;

namespace BUS
{
    public class TraCuuDaiLyBUS
    {
        public static List<TraCuuDaiLyDTO> LayDanhSachTraCuu(string dk1, string dk2, string dk3, string dk4)
        {
            return TraCuuDaiLyDAO.LayDanhSachTraCuu(dk1, dk2, dk3, dk4);
        }
    }
}
