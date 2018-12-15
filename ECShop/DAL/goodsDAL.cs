using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;


namespace DAL
{
    public class goodsDAL
    {
        public static SqlDataReader SelectGoods(int id)
        {
            string sql = string.Format("select * from book where bid='{0}'", id);
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader ShowGood(int id)
        {
            string sql = string.Format("select * from Book where Bid='{0}'",id);
            return DBHelper.MyExecuteReader(sql);
        }
        public static int AddGood(int Bid,int Mid,int count)
        {
            string sql = string.Format("insert into Trade(Bid,Mid,Bcount)values('{0}','{1}','{2}')",Bid,Mid,count);
            return DBHelper.MyExecuteNonQuery(sql);
        }
    }
}
