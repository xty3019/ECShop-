using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class MainDAL
    {
        public static SqlDataReader SelectMainBestBook()
        {
            string sql = "select top 5 * from Book";
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader SelectNewBook()
        {
            string sql = "select top 5 * from book order by  BDate desc";
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader LoadMsg()
        {
            string sql = "select BLID,BLName from BLCategory";
            return DBHelper.MyExecuteReader(sql);
        }
        
    }
}
