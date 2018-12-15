using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Model;


namespace DAL
{
    public class AdminDAL
    {
        public static SqlDataReader GetNP(string n,string p) {
            string sql =string.Format("select * from Admin where AName='{0}'and APassword='{1}'", n,p);
            return DBHelper.MyExecuteReader(sql);
        }
    }
}
