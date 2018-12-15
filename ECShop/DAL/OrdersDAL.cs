using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class OrdersDAL
    {
        //查询订单
        public static SqlDataReader GetAll() {
            string sql = string.Format(@"select case b.OState when 1 then '新订单' end as DingDanZhuanTai,* from Member a inner join 
                                        Orders b on a.MID = b.MID inner join
                                        Trade c on c.MID = a.MID");
            return DBHelper.MyExecuteReader(sql);
        }
        //通过订单id查询订单信息
        //public static SqlDataReader SelectAll(string id) {
        //    string sql = string.Format(@"select case b.OState when 1 then '新订单' end as DingDanZhuanTai,* from Member a inner
        //                                                                           join
        //                                    Orders b on a.MID = b.MID inner
        //                                                                           join
        //                                             Trade c on c.MID = a.MID where b.OID = '{0}'", id);
        //    return DBHelper.MyExecuteReader(sql);
        //}
        //main中
        public static SqlDataReader SelectAll(string id)
        {
            string sql = string.Format(@"select *, case 
                                            when OState='0' then  '新订单'
                                            when OState='1' then  '新订单'
                                            when OState='2' then  '确定订单'
                                            when OState='3' then  '发货'
                                            when OState='4' then  '订单完成'
                                            end as DingDanZhuanTai
                                            ,
                                             case
                                            when OState='0' then  '确认订单'
                                            when OState='1' then  '确认订单'
                                            when OState='2' then  '发货'
                                            when OState='3' then  '完成订单'
                                            when OState='4' then  '隐藏'
                                            end as ButZhuangTai from Orders where OID = '{0}'", id);
            return DBHelper.MyExecuteReader(sql);
        }
        //模糊查询
        public static SqlDataReader selectIDNAME(string oid,string name) {
            string sql = string.Format(@"select *, case 
                                            when OState='0' then  '新订单'
                                            when OState='1' then  '新订单'
                                            when OState='2' then  '确定订单'
                                            when OState='3' then  '发货'
                                            when OState='4' then  '订单完成'
                                            end as DingDanZhuanTai
                                            ,
                                             case
                                            when OState='0' then  '确认订单'
                                            when OState='1' then  '确认订单'
                                            when OState='2' then  '发货'
                                            when OState='3' then  '完成订单'
                                            when OState='4' then  '隐藏'
                                            end as ButZhuangTai from Orders where 1>0");
            if (!string.IsNullOrEmpty(oid)) {
                sql += string.Format("and OID like '%{0}%'",oid);
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += string.Format("and  OConsignee like '%{0}%'", name);
            }
            return DBHelper.MyExecuteReader(sql);
        }
        //查询订单信息表
        public static SqlDataReader SelectAllOrder(string mid) {
            string sql =string.Format(@"select * from Orders a 
                            inner join Trade b on a.MID = b.MID
                            inner join Book c on c.BID = b.BID where a.OID='{0}'", mid);
            return DBHelper.MyExecuteReader(sql);
        }
        //总订单数量
        public static SqlDataReader SelectSum() {
            string sql = string.Format(@"select count(OState) as sumcount from Orders where OState=1 or OState=0");
            return DBHelper.MyExecuteReader(sql);
        }
        //确认的订单
        public static SqlDataReader SelectOK() {
            string sql = string.Format(@"select sum(OState) as ok from Orders where OState=2");
            return DBHelper.MyExecuteReader(sql);
        }
        //总价
        public static SqlDataReader SelectPrice(string oid) {
            string sql = string.Format(@"select sum(a.OSumPrice*b.BCount)  as price from Orders a 
                            inner join Trade b on a.MID = b.MID
                            inner join Book c on c.BID = b.BID where a.OID='{0}'", oid);
            return DBHelper.MyExecuteReader(sql);
        }
        //public static SqlDataReader SelectAll(string oid, string mname, DateTime odate, string home, string tel, int zt, int id)
        //{
        //    string sql = string.Format(@"select b.OID='{0}',a.MName='{1}',b.ODate='{2}',b.OAddress='{3}',
        //                                    b.OTelephone = '{4}', b.OState = '{5}' from Member a inner
        //                                                                           join
        //                                    Orders b on a.MID = b.MID inner
        //                                                                           join
        //                                             Trade c on c.MID = a.MID where a.MID = '{6}'", oid, mname, odate, home, tel, zt, id);
        //    return DBHelper.MyExecuteReader(sql);
        //}

        public static SqlDataReader BianOState() {
            //绑定状态
            string sql = string.Format(@"select *, case 
                                            when OState='0' then  '新订单'
                                            when OState='1' then  '新订单'
                                            when OState='2' then  '确定订单'
                                            when OState='3' then  '发货'
                                            when OState='4' then  '订单完成'
                                            end as DingDanZhuanTai
                                            ,
                                             case
                                            when OState='0' then  '确认订单'
                                            when OState='1' then  '确认订单'
                                            when OState='2' then  '发货'
                                            when OState='3' then  '完成订单'
                                            when OState='4' then  '隐藏'
                                            end as ButZhuangTai from Orders ");

            return DBHelper.MyExecuteReader(sql);

        }
        public static int UpdateOrders(int osate, string oid ) {

            //修改
            string sql = string.Format(" Update Orders set OState='{0}' where OID='{1}'", osate, oid);
            return DBHelper.MyExecuteNonQuery(sql);
        }

        //订单发货数量
        public static SqlDataReader SelectFaHuo() {
            string sql = "select sum(OState) as fh from Orders where OState=3";
            return DBHelper.MyExecuteReader(sql);
        }
        //订单成交数量
        public static SqlDataReader SelectChnegJiao()
        {
            string sql = "select sum(OState) as chengjiao from Orders where OState=4";
            return DBHelper.MyExecuteReader(sql);
        }
    
    }
}
