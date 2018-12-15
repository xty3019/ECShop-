using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BLCategoryDAL
    {
        public static List<BLCategory> SelectAll()
        {
            string sql = "SELECT  BLID,BLName FROM BLCategory ";
            SqlDataReader dr = DBHelper.MyExecuteReader(sql);
            List<BLCategory> list = new List<BLCategory>();
            while (dr.Read())
            {
                BLCategory bl = new BLCategory();
                bl.BLID = Convert.ToInt32(dr["BLID"]);
                bl.BLName = dr["BLName"].ToString();
                list.Add(bl);
            }
            dr.Close();
            return list;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="count"></param>
        /// <param name="page"></param>
        /// <param name="BSID"></param>
        /// <returns></returns>
        public static SqlDataReader SelecBLIDtBook(int count, int page, int BLID)
        {
            string sql = string.Format(" select top {0} * from book a inner join BSCategory b on a.BSID=b.BSID where bid not in(select top ({0}*({1}-1)) Bid from book where BLID='{2}' order by Bid)  and BLID='{2}' order by Bid", count, page, BLID);
            return DBHelper.MyExecuteReader(sql);
        }
    }
}
