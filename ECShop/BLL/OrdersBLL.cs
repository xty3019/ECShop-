using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class OrdersBLL
    {
        //查询订单
        public static SqlDataReader GetAll()
        {
            return DAL.OrdersDAL.GetAll();
        }
        //通过订单id查询订单信息
        public static SqlDataReader SelectAll(string id)
        {
            return DAL.OrdersDAL.SelectAll(id);
        }
        //模糊查询
        public static SqlDataReader selectIDNAME(string oid, string name)
        {
            return DAL.OrdersDAL.selectIDNAME(oid, name);
        }
        //查询订单信息表
        public static SqlDataReader SelectAllOrder(string mid)
        {
            return DAL.OrdersDAL.SelectAllOrder(mid);
        }
        //总订单数量
        public static SqlDataReader SelectSum()
        {
            return DAL.OrdersDAL.SelectSum();
        }
        //确认的订单
        public static SqlDataReader SelectOK()
        {
            return DAL.OrdersDAL.SelectOK();
        }
        //总价
        public static SqlDataReader SelectPrice(string oid)
        {
            return DAL.OrdersDAL.SelectPrice(oid);
        }
        //public static SqlDataReader SelectAll(string oid, string mname, DateTime odate, string home, string tel, int zt, int id)
        //{
        //    return DAL.OrdersDAL.SelectAll(oid, mname, odate, home, tel, zt, id);
        //}
        public static SqlDataReader BianOState()
        {
            //绑定状态
            return OrdersDAL.BianOState();
        }

        public static int UpdateOrders(int osate, string oid)
        {
            //修改
            return OrdersDAL.UpdateOrders(osate,oid);
        }

        //订单发货数量
        public static SqlDataReader SelectFaHuo()
        {
            return OrdersDAL.SelectFaHuo();
        }
        //订单成交数量
        public static SqlDataReader SelectChnegJiao()
        {
            return OrdersDAL.SelectChnegJiao();
        }
    }
    }
