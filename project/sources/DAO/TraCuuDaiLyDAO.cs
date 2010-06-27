using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using DTO;


namespace DAO
{
   public class TraCuuDaiLyDAO :AbstractDAO
    {
       public static List<TraCuuDaiLyDTO> LayDanhSachTraCuu(string dk1, string dk2, string dk3, string dk4)
       {
           OleDbConnection ketNoi = null;
           List<TraCuuDaiLyDTO> dsTraCuuDaiLy = new List<TraCuuDaiLyDTO>();
           try
           {
               ketNoi = MoKetNoi();
               string chuoiLenh = "select DL.MADAILY, DL.TENDAILY, LDL.TENLOAIDAILY, Q.TENQUAN, DL.NOCUADAILY, DL.Deleted from DAILY DL, LOAIDAILY LDL, QUAN Q where DL.MALOAIDAILY = LDL.MALOAIDAILY AND DL.MAQUAN = Q.MAQUAN";
               if (dk1.Length > 0)
                   chuoiLenh = chuoiLenh + " AND DL.TENDAILY = '" + dk1 + "'";
               if (dk2.Length > 0)
                   chuoiLenh = chuoiLenh + " AND LDL.TENLOAIDAILY = '" + dk2 + "'";
               if (dk3.Length > 0)
                   chuoiLenh = chuoiLenh + " AND Q.TENQUAN = '" + dk3 + "'";
               if (dk4.Length > 0)
                   chuoiLenh = chuoiLenh + " AND DL.NOCUADAILY = " + dk4;

               OleDbCommand lenh = new OleDbCommand(chuoiLenh, ketNoi);
               OleDbDataReader boDoc = lenh.ExecuteReader();
               while (boDoc.Read())
               {
                   TraCuuDaiLyDTO traCuuDaiLy = new TraCuuDaiLyDTO();

                   traCuuDaiLy.MaDaiLy = boDoc.GetInt32(0);
                   if (!boDoc.IsDBNull(1))
                       traCuuDaiLy.TenDaiLy = boDoc.GetString(1);
                   if (!boDoc.IsDBNull(2))
                       traCuuDaiLy.TenLoaiDaiLy = boDoc.GetString(2);
                   if (!boDoc.IsDBNull(3))
                       traCuuDaiLy.TenQuan = boDoc.GetString(3);
                   traCuuDaiLy.TienNo = boDoc.GetInt32(4);
                   if (!boDoc.IsDBNull(5) && boDoc.GetBoolean(5))
                       continue;
                   dsTraCuuDaiLy.Add(traCuuDaiLy);
               }
           }
           catch (Exception ex)
           {
               dsTraCuuDaiLy = new List<TraCuuDaiLyDTO>();
           }
           finally
           {
               if (ketNoi != null && ketNoi.State == System.Data.ConnectionState.Open)
                   ketNoi.Close(); // sau khi làm xong phải đóng kết nối
           }
           return dsTraCuuDaiLy;
       }
    }
}
