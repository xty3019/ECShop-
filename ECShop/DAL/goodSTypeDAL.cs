using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class goodSTypeDAL
    {
        public static SqlDataReader GetAll() {
            string sql = "select a.BSID,a.BLName,a.BLID,b.BLID,b.BLName as Name from BSCategory a inner join BLCategory b on  a.BLID=b.BLID";
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader GetAllxiao()
        {
            string sql = "select * from BSCategory";
            return DBHelper.MyExecuteReader(sql);
        }
        public static SqlDataReader GetAllbig()
        {
            string sql = "select BLName from BLCategory";
            return DBHelper.MyExecuteReader(sql);
        }

        //删除大类别
        public static int DeleD(int id) {
            string sql = string.Format("delete BLCategory where BLID='{0}'", id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        //判断大类别中是否有小类别
        public static SqlDataReader PDxiao(int id) {
            string sql =string.Format( "select count(b.BSID) as counts from BLCategory a inner join BSCategory b on a.BLID=b.BLID where b.BLID='{0}'", id);
            return DBHelper.MyExecuteReader(sql);
        }
        //删除小类别
        public static int DeleX(int id)
        {
            string sql = string.Format("delete from BSCategory where BSID='{0}'", id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        //添加
        public static int AddGood(string name, int id) {
            string sql =string.Format("insert into BSCategory(BLName,BLID)values('{0}','{1}')", name,id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        //从大类别查看所有小类别
        public static SqlDataReader SelectSmall(int id) {
            string sql = string.Format("select a.BSID,a.BLName,a.BLID,b.BLID,b.BLName as Name from BSCategory a inner join BLCategory b on  a.BLID=b.BLID where a.BLID='{0}'", id);
            return DBHelper.MyExecuteReader(sql);
        }
        //修改
        public static int Update(string name,int id) {
            string sql = string.Format("update BLCategory set BLName='{0}' where BLID='{1}'", name,id);
            return DBHelper.MyExecuteNonQuery(sql);
        }
    }
}
