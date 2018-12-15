using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
    public class goodSTypeBLL
    {
        public static SqlDataReader GetAll()
        {
            return DAL.goodSTypeDAL.GetAll();
        }
        public static SqlDataReader GetAllxiao()
        {
            return goodSTypeDAL.GetAllxiao();
        }
        public static SqlDataReader GetAllbig()
        {
            return goodSTypeDAL.GetAllbig();
        }
        //删除大类别
        public static int DeleD(int id)
        {
            return DAL.goodSTypeDAL.DeleD(id);
        }
        //判断大类别中是否有小类别
        public static SqlDataReader g(int id)
        {
            return DAL.goodSTypeDAL.PDxiao(id);
        }
        //删除小类别
        public static int DeleX(int id)
        {
            return DAL.goodSTypeDAL.DeleX(id);
        }
        //添加
        public static int AddGood(string name, int id)
        {
            return DAL.goodSTypeDAL.AddGood(name, id);
        }
        //从大类别查看所有小类别
        public static SqlDataReader SelectSmall(int id)
        {
            return DAL.goodSTypeDAL.SelectSmall(id);
        }
        //修改
        public static int Update(string name, int id)
        {
            return DAL.goodSTypeDAL.Update(name, id);
        }
    }
}
