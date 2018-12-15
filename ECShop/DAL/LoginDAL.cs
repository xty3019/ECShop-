using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;

namespace DAL
{
    public class LoginDAL
    {
        public static SqlDataReader LoginMember(Member member)
        {
            string sql = string.Format("select * from Member where Mname='{0}' and Mpassword='{1}'", member.MName, member.MPassword);
            return DBHelper.MyExecuteReader(sql);
        }

        public static int RegMember(Member member)
        {
            string sql=string.Format("insert into Member(MName,MEmail,MPassword)values('{0}','{1}','{2}')",member.MName,member.MEmail,member.MPassword);
            return DBHelper.MyExecuteNonQuery(sql);
        }
        public static object CheckUsername(string name)
        {
            string sql = string.Format("select count(Mname) from Member where Mname='{0}'",name);
            return DBHelper.Select(sql);
        }
    }
}
