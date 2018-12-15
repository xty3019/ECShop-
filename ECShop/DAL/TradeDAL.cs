using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAL
{
    public class TradeDAL
    {
        public static SqlDataReader SelectTrade(int id)
        {
            string sql =string.Format( "select * from Trade inner join book on Trade.BID=book.BID where Mid ='{0}'",id);
            return DBHelper.MyExecuteReader(sql);
        }

        public static int DeleteGoods(int id)
        {
            string sql = string.Format("delete from Trade where Tid='{0}'",id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        /// <summary>
        /// 检查库存
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public static object CheckBcount(int bid)
        {
            string sql = string.Format("select Bcount from Book where Bid='{0}'",bid);
            return DBHelper.Select(sql);
        }
        /// <summary>
        /// 查询购物车内商品数量和总价钱
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public static SqlDataReader CheckTradeCount(int mid)
        {
            string sql = string.Format("select COUNT(*) size, sum(Trade.BCount * Book.BPrice) sumprice from Trade INNER join Book on Trade.BID = Book.BID where MID = "+mid);
            return DBHelper.MyExecuteReader(sql);
        }

        
    }
}
