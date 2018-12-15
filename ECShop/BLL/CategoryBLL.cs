using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class CategoryBLL
    {
        public static SqlDataReader CategoryBookList(int count,int page)
        {
            return CategoryDAL.CategoryBookList(count,page);
        }

        public static SqlDataReader SelectBook(int count,int page,string name)
        {
            return CategoryDAL.SelectBook(count,page,name);
        }

        public static int SumCount()
        {
            return Convert.ToInt32( CategoryDAL.SumCount());
        }
    }
}
