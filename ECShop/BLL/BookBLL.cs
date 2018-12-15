using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class BookBLL
    {
        /// <summary>
        /// 显示表格
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader SelectAll()
        {
            return DAL.BookDAL.SelectAll();
        }
        public static SqlDataReader SelectIdenx(int count, int index)
        {
            return DAL.BookDAL.SelectIdenx(count,index);
        }
        /// <summary>
        /// 总页数
        /// </summary>
        /// <returns></returns>
        public static object SelectCount()
        {
            return DAL.BookDAL.SelectCount();
        }
        /// 总页数
        public static object SelectCountOrder()
        {
            return DAL.BookDAL.SelectCountOrder();
        }
        //模糊查询
        public static SqlDataReader SelectMH(string name)
        {
            return DAL.BookDAL.SelectMH(name);
        }
        //删除
        public static int delete(int id)
        {
            return DAL.BookDAL.delete(id);
        }
        //根据id
        public static SqlDataReader SelectAllID(int id)
        {
            return DAL.BookDAL.SelectAllID(id);
        }
        //修改
        public static int UpDate(string Name, string ISBN, int SID, decimal Price, string Pic, int Count, string Author, int bid)
        {
            return DAL.BookDAL.UpDate(Name, ISBN, SID, Price, Pic, Count, Author,bid);
        }
    }
}
