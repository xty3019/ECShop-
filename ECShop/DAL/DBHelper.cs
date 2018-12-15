using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {

        private static string connStr = "server=(local);database=ecshop;uid=sa;pwd=123";
        /// <summary>
        /// 增删改查
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int MyExecuteNonQuery(string sql)
        {
            using (SqlConnection sqlconn = new SqlConnection(connStr))
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                int i = cmd.ExecuteNonQuery();
                return i;
            }
        }

        public static object Select(string sql)
        {
            using (SqlConnection sqlconn = new SqlConnection(connStr))
            {
                sqlconn.Open();
                SqlCommand cmd = new SqlCommand(sql, sqlconn);
                object i = cmd.ExecuteScalar();
                return i;
            }
        }

        public static SqlDataReader MyExecuteReader(string sql)
        {
            SqlConnection sqlcon = new SqlConnection(connStr);
            sqlcon.Open();
            SqlCommand cmd = new SqlCommand(sql, sqlcon);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;

        }

    }
}
