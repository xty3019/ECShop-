using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class OrderDetailBLL
    {
        //分页
        public static SqlDataReader SelectCountFY(int count, int index)
        {
            return DAL.OrderDetailDAL.SelectCountFY(count,index);
        }
        //获取总数据
        public static SqlDataReader SelectCount()
        {
            return DAL.OrderDetailDAL.SelectCount();
        }
    }
}
