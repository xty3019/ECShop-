using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class BSCategoryBLL
    {
        public static List<BSCategory> SelectAll(int BLID)
        {
            return BSCategoryDAL.SelectAll(BLID);
        }
        public static List<BSCategory> SelectBSIDAll(int BSID)
        {
            return BSCategoryDAL.SelectBSIDAll(BSID);
        }
        public static SqlDataReader SelectBook(int count, int page, int BSID)
        {
            return BSCategoryDAL.SelectBook(count,page,BSID);
        }
    }
}
