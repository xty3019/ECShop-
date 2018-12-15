using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class OrderBLL
    {
        /// <summary>
        /// 往订单表添加信息
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public static int AddOrder(Orders order)
        {
            return OrderDAL.AddOrder(order);
        }
        /// <summary>
        /// 订单详细表添加信息
        /// </summary>
        /// <param name="orde"></param>
        /// <returns></returns>
        public static int AddOrderDetails(OrderDetails orde)
        {
            return OrderDAL.AddOrderDetails(orde);
        }
        /// <summary>
        /// 删除购物车记录
        /// </summary>
        /// <param name="tid"></param>
        /// <returns></returns>
        public static int DeleteTrade(int tid)
        {
            return OrderDAL.DeleteTrade(tid);
        }
        /// <summary>
        /// 更新商品库存
        /// </summary>
        /// <param name="bid"></param>
        /// <returns></returns>
        public static int UpdateBcount(int count,int bid)
        {
            return OrderDAL.UpdateBcount(count,bid);
        }
    }
}
