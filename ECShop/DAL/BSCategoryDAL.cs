using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;

namespace DAL
{
    public class BSCategoryDAL
    {
        public static List<BSCategory> SelectAll(int BLID)
        {
            string sql =string.Format( "SELECT  BSID,BLID,BLName FROM BSCategory where BLID='{0}' ", BLID);
            SqlDataReader dr = DBHelper.MyExecuteReader(sql);
            List<BSCategory> list = new List<BSCategory>();
            while (dr.Read())
            {
                BSCategory bs = new BSCategory();
                bs.BSID=Convert.ToInt32(dr["BSID"]);
                bs.BLID = Convert.ToInt32(dr["BLID"]);
                bs.BLName = dr["BLName"].ToString();
                list.Add(bs);
            }
            dr.Close();
            return list;
        }
        public static List<BSCategory> SelectBSIDAll(int BSID)
        {
            string sql = string.Format("SELECT  BSID,BLID,BLName FROM BSCategory where BLID='{0}' ", BSID);
            SqlDataReader dr = DBHelper.MyExecuteReader(sql);
            List<BSCategory> list = new List<BSCategory>();
            while (dr.Read())
            {
                BSCategory bs = new BSCategory();
                bs.BSID = Convert.ToInt32(dr["BSID"]);
                bs.BLID = Convert.ToInt32(dr["BLID"]);
                bs.BLName = dr["BLName"].ToString();
                list.Add(bs);
            }
            dr.Close();
            return list;
        }
        public static SqlDataReader SelectBook(int count,int page, int BSID)
        {
            string sql = string.Format(" select top {0} * from book where bid not in(select top ({0}*({1}-1)) Bid from book where BSID='{2}' order by Bid)  and BSID='{2}' order by Bid", count,page,BSID);
            return DBHelper.MyExecuteReader(sql);
        }
    }
}
