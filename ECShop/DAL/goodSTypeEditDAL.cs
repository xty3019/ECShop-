using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class goodSTypeEditDAL
    {
        //通过id查询所有
        public static SqlDataReader SelectIDAll(int id)
        {
            string sql =string.Format("select a.BSID,a.BLName,a.BLID,b.BLID,b.BLName as Name from BSCategory a inner join BLCategory b on  a.BLID=b.BLID where BSID='{0}'",id);
            return DBHelper.MyExecuteReader(sql);
        }
        //通过id查询下拉框
        public static SqlDataReader SelectID()
        {
            string sql = string.Format("select * from BLCategory");
            return DBHelper.MyExecuteReader(sql);
        }
        //修改
        public static int update(string name,int list,int id) {
            string sql =string.Format("update BSCategory set BLName='{0}',BLID='{1}' where BSID='{2}'", name,list,id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
    }
}
