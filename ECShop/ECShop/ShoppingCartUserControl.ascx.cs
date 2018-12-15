using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;

namespace EcShopUI.UserControl
{
    public partial class ShoppingCartUserControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadFlow();
            }
        }

        private void LoadFlow()
        {
            if (Session["MId"] == null)
            {
                LookFlow.Text = "您的购物车中有 0 件商品，总计金额 ￥0.00元。";
                LookFlow.PostBackUrl = null;
            }
            else
            {
                SqlDataReader dr = TradeBLL.CheckTradeCount(Convert.ToInt32(Session["MID"]));
                while (dr.Read())
                {
                    LookFlow.Text = "您的购物车中有 "+dr["size"].ToString() +" 件商品，总计金额 ￥"+dr["sumprice"].ToString() +"元。";
                    
                }
            }
        }
    }
}