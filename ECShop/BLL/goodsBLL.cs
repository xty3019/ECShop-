using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class goodsBLL
    {
        public static SqlDataReader SelectGoods(int id)
        {
            return goodsDAL.SelectGoods(id);
        }

        public static SqlDataReader ShowGood(int id)
        {
            return goodsDAL.ShowGood(id);
        }
        /// <summary>
        /// 往购物车内添加商品
        /// </summary>
        /// <param name="Bid">商品id</param>
        /// <param name="Mid">会员id</param>
        /// <param name="count">购买数量</param>
        /// <returns></returns>
        public static int AddGood(int Bid, int Mid, int count)
        {
            return goodsDAL.AddGood(Bid,Mid,count);
        }
    }
}
