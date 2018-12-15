using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;

namespace Ecshop
{
    public partial class Orders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GetAll();
                //Count();
                //BIndDate(1, 1);
            }
        }

        //protected void fy_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        //{
        //    BIndDate(1, e.NewPageIndex);
        //}
        //分页2

        //获取总数据
        //private void Count()
        //{
        //    int dr = Convert.ToInt32(BLL.BookBLL.SelectCountOrder());
        //    this.fy.RecordCount = dr;
        //}

        ///// 分页1
        //private void BIndDate(int count, int index)
        //{
        //    SqlDataReader dr = BLL.OrderDetailBLL.SelectCountFY(count, index);
        //    this.show.DataSource = dr;
        //    this.show.DataBind();
        //    dr.Close();
        //}

        private void GetAll() {
            SqlDataReader dr = BLL.OrdersBLL.BianOState();
            this.show.DataSource = dr;
            this.show.DataBind();
            dr.Close();
        }

        protected void sousuo_Click(object sender, EventArgs e)
        {
            string orderid = this.ordernumber.Text;
            string man = this.orderRen.Text;
            SqlDataReader dr = BLL.OrdersBLL.selectIDNAME(orderid, man);
            this.show.DataSource = dr;
            this.show.DataBind();
            //BIndDate(1, 1);

            dr.Close();
        }
        //订单按钮
        protected void Button1_Load(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string name = b.Text;
            if (name== "隐藏") {
                b.Visible = false;
            }
        }
        //订单按钮
        protected void Button1_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            string name = b.Text;
            string oid = b.CommandArgument.ToString();
            int osate =0;
            if (name== "确认订单")
            {
                osate=2;
            }

            if (name == "发货")
            {
                osate=3;
            }
            if (name== "完成订单")
            {
                osate=4;
            }
           

            int c = BLL.OrdersBLL.UpdateOrders(osate, oid);
            if (c > 0)
            {
                Response.Write("<script>location.href=('Orders.aspx')</script>");
            }
            else
            {
                Response.Write("<script>alert('网络繁忙，请稍后再试')</script>");
            }
        }

        protected void fenye_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {

        }

    }
    
}