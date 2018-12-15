using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecshop
{
    public partial class drag : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {

            }
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            //this.goods_name.Text = string.Empty;
            //this.goods_sn.Text = string.Empty;
            //this.list.Text = string.Empty;
            //this.shop_price.Text = string.Empty;
            ////this.goods_img.HasFile = string.Empty;
            //this.shop_count.Text = string.Empty;
        }
    }
}