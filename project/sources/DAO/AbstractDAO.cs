using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;

namespace DAO
{
    public class AbstractDAO
    {
        /// <summary>
        /// Chuỗi kết nối đến CSDL
        /// Mỗi loại CSDL sẽ có 1 chuỗi kết nối khác nhau
        /// Tham khảo: lên google search keyword: connection string sẽ có trang list danh sách các chuỗi kết nối
        /// </summary>
        private static string chuoiKetNoi = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=QLDL_DB.mdb";

        /// <summary>
        /// Tạo 1 kết nối và mở nó lên
        /// </summary>
        /// <returns>Một kết nối đang mở</returns>
        protected static OleDbConnection MoKetNoi()
        {
            OleDbConnection ketNoi = new OleDbConnection(chuoiKetNoi);
            ketNoi.Open();
            return ketNoi;
        }
    }
}
