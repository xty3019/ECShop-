using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class AdminBLL
    {
        public static SqlDataReader GetNP(string n, string p)
        {
            return DAL.AdminDAL.GetNP(n, p);
        }
        }
}
