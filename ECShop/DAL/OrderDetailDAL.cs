using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class OrderDetailDAL
    {
        //case b.OState when 1 then '新订单' end as DingDanZhuanTai,
        //分页
        public static SqlDataReader SelectCountFY(int count,int index) {
            string sql =string.Format(@"select Top {0} OID,case OState when 1 then '新订单' end as DingDanZhuanTai,* from Orders
                                        WHERE OID not in (select top({0} * ({1} - 1))OID from Orders)", count,index);
            return DBHelper.MyExecuteReader(sql);
        }
        //获取总数据
        public static SqlDataReader SelectCount() {
            string sql = string.Format("select count(OID) from Orders");
            return DBHelper.MyExecuteReader(sql);
        }
    }
}
