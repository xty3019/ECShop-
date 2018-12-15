using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class CategoryDAL
    {
        public static SqlDataReader CategoryBookList(int count,int page)
        {
            string sql =string.Format( "select top {0} * from book where bid not in(select top ({0}*({1}-1)) Bid from book) ",count,page);
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader SelectBook(int count, int page,string name)
        {
            string sql = string.Format("  select top {0} * from book where bid not in(select top ({0}*({1}-1)) Bid from book where bname like '%{2}%')  and bname like '%{2}%' order by Bid", count,page, name);
            return DBHelper.MyExecuteReader(sql);
        }

        public static int SumCount()
        {
            string sql = "select count(*) from book ";
            return Convert.ToInt32( DBHelper.Select(sql));

        }
    }
}
