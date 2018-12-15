using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TradeBLL
    {
        /// <summary>
        /// 查询购物车的商品
        /// </summary>
        /// <param name="id">会员id</param>
        /// <returns></returns>
        public static SqlDataReader SelectTrade(int id)
        {
            return TradeDAL.SelectTrade(id);
        }
        /// <summary>
        /// 删除购物车内商品
        /// </summary>
        /// <param name="id">商品id</param>
        /// <returns></returns>
        public static int DeleteGoods(int id)
        {
            return TradeDAL.DeleteGoods(id);
        }
        /// <summary>
        /// 检查库存
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public static int CheckBcount(int bid)
        {
            return Convert.ToInt32(TradeDAL.CheckBcount(bid));
        }

        /// <summary>
        /// 查询购物车内商品数量和总价钱
        /// </summary>
        /// <param name="mid"></param>
        /// <returns></returns>
        public static SqlDataReader CheckTradeCount(int mid)
        {
            return TradeDAL.CheckTradeCount(mid);
        }
    }
}
