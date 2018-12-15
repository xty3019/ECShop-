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
    public partial class OrderDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GetALL();
                GetOrderList();
                GetPrice();
            }
        }

        private void GetPrice() {
            string uid = Request.QueryString["uid"].ToString();
            SqlDataReader dr = BLL.OrdersBLL.SelectPrice(uid);
            while (dr.Read()) {
                this.price.Text = "￥" + dr["price"].ToString()+ "元";
            }
            dr.Close();
        }

        private void GetOrderList() {
            string uid = Request.QueryString["uid"].ToString();
            SqlDataReader dr = BLL.OrdersBLL.SelectAllOrder(uid);
            this.show.DataSource = dr;
            this.show.DataBind();
            dr.Close();
        }

        private void GetALL() {
            string uid = Request.QueryString["uid"].ToString();
            SqlDataReader dr = BLL.OrdersBLL.SelectAll(uid);
            while (dr.Read()) {
                this.orderid.Text = dr["OID"].ToString();
                this.name.Text = dr["OConsignee"].ToString();
                this.times.Text =  dr["ODate"].ToString();
                this.address.Text = dr["OAddress"].ToString();
                this.newOrder.Text = dr["DingDanZhuanTai"].ToString();
                this.tel.Text = dr["OTelephone"].ToString();
            }
            dr.Close();
        }
    }
}