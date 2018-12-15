using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class goodSTypeEditBLL
    {
        //通过id查询所有
        public static SqlDataReader SelectIDAll(int id)
        {
            return DAL.goodSTypeEditDAL.SelectIDAll(id);
        }
        //通过id查询下拉框
        public static SqlDataReader SelectID()
        {
            return DAL.goodSTypeEditDAL.SelectID();
        }

        //修改
        public static int update(string name,int list,int id)
        {
            return DAL.goodSTypeEditDAL.update(name,list ,id);
        }
    }
}
