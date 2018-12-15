using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class LoginBLL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="member"></param>
        /// <param name="Mid"></param>
        /// <returns></returns>
		public static bool LoginMember(Member member,out string Mid)
        {
            SqlDataReader dr = LoginDAL.LoginMember(member);
            if (dr.Read())
            {
                Mid = dr["Mid"].ToString();
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                Mid = "";
                return false;
            }
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public static int RegMember(Member member)
        {
            return LoginDAL.RegMember(member);
        }
        /// <summary>
        /// 检测用户名是否被注册
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int CheckUsername(string name)
        {
            return Convert.ToInt32( LoginDAL.CheckUsername(name));
        }
    }
}
