using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class BookDAL
    {
        /// <summary>
        /// 显示表格
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader SelectAll() {
            string sql = "select * from Book";
            return DBHelper.MyExecuteReader(sql);
        }
        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="count"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public static SqlDataReader SelectIdenx(int count,int index) {
            string sql = string.Format(@"select TOP {0}BID,*  from Book where BID
                                    NOT IN
                                     (select top ({0}*({1}-1))BID from Book)
                                    ", count,index);
            return DBHelper.MyExecuteReader(sql);
        }
        /// <summary>
        /// 总页数
        /// </summary>
        /// <returns></returns>
        public static object SelectCount() {
            string sql = "select count(BID) from Book";
            return DBHelper.MyExecuteScalar(sql);
        }
        /// 总页数
        public static object SelectCountOrder()
        {
            string sql = "select count(OID) from Orders";
            return DBHelper.MyExecuteScalar(sql);
        }
        //模糊查询
        public static SqlDataReader SelectMH(string name) {
            string sql = string.Format("select * from Book where BName like '%{0}%'", name);
            return DBHelper.MyExecuteReader(sql);
        }
        //删除
        public static int delete(int id) {
            string sql = string.Format("delete Book where BID='{0}'",id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        //根据id
        public static SqlDataReader SelectAllID(int id)
        {
            string sql =string.Format( "select * from Book where BID='{0}'",id);
            return DBHelper.MyExecuteReader(sql);
        }
        //修改
        public static int UpDate(string Name, string ISBN, int SID, decimal Price, string Pic, int Count, string Author,int bid) {
            string sql = string.Format("update Book set BName='{0}',BISBN='{1}',BAuthor='{2}',BSID='{3}',BPrice='{4}',BPic='{5}',BCount='{6}' where BID='{7}'",
                 Name, ISBN, Author,SID, Price, Pic, Count,bid);
            return DBHelper.MyExecuteNonQuery(sql);
        }

    }
}
