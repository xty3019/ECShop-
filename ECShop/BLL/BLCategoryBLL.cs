using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Data.SqlClient;

namespace BLL
{
    public class BLCategoryBLL
    {
        public static List<BLCategory> SelectAll()
        {
            return BLCategoryDAL.SelectAll();
        }
        public static SqlDataReader SelecBLIDtBook(int count, int page, int BLID)
        {
            return BLCategoryDAL.SelecBLIDtBook(count,page,BLID);
        }
    }
}
