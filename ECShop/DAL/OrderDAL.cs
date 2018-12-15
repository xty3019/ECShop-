using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class OrderDAL
    {
        /// <summary>
        /// 订单表添加信息
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static int AddOrder(Orders order)
        {
            string sql = string.Format(@"insert into Orders(OID,MID,ODate,OConsignee,OAddress,OTelephone,OSumPrice,OState)
                                        values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                        order.OID,order.MID,order.ODate,order.OConsignee,order.OAddress,order.OTelephone,order.OSumPrice,order.OState);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        /// <summary>
        /// 订单详细表添加信息
        /// </summary>
        /// <param name="orde"></param>
        /// <returns></returns>
        public static int AddOrderDetails(OrderDetails orde)
        {
            string sql = string.Format(@"insert into OrderDetails(OID,BID,BPrice,BCount)values('{0}','{1}','{2}','{3}')",
                                        orde.OID,orde.BID,orde.BPrice,orde.BCount);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        /// <summary>
        /// 删除购物车记录
        /// </summary>
        /// <param name="tid"></param>
        /// <returns></returns>
        public static int DeleteTrade(int tid)
        {
            string sql = string.Format("delete from Trade where Tid='{0}'",tid);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        /// <summary>
        /// 更新商品库存
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public static int UpdateBcount(int count,int bid)
        {
            string sql = string.Format("update book set BCount=BCount-'{0}' where BID='{1}'",count,bid);
            return DBHelper.MyExecuteNonQuery(sql);
        }
    }
}
