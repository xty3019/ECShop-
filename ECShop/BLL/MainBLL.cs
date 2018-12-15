using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class MainBLL
    {
        /// <summary>
        /// 查询精品推荐书籍
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader SelectMainBestBook()
        {
            return MainDAL.SelectMainBestBook();
        }
        /// <summary>
        /// 查询最新上市书籍
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader SelectNewBook()
        {
            return MainDAL.SelectNewBook();
        }
        /// <summary>
        /// 查询BLID
        /// </summary>
        /// <returns></returns>
        public static SqlDataReader LoadMsg()
        {
            return MainDAL.LoadMsg(); ;
        }
    }
}
