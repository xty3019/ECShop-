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
    public partial class goodAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                this.list.Items.Insert(0, "-请选择-");
                GetList();
            }
        }

        private void GetList() {
           SqlDataReader dr= BLL.BSCategoryBLL.SelectBLNameID();
            this.list.DataSource = dr;
            this.list.DataTextField = "BLName";
            this.list.DataValueField = "BLID";
            
            this.list.DataBind();
            dr.Close();
        }
        protected void reset_Click(object sender, EventArgs e)
        {
            this.goods_name.Text = string.Empty;
            this.goods_sn.Text = string.Empty;
            //this.list.Text = string.Empty;
            this.shop_price.Text = string.Empty;
            this.zz.Text = string.Empty;
            //this.goods_img.HasFile = string.Empty;
            this.shop_count.Text = string.Empty;
        }

        protected void tz_Click(object sender, EventArgs e)
        {
            Response.Redirect("goods.aspx");
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string name = this.goods_name.Text;
            string sn = this.goods_sn.Text;
            int list = this.list.SelectedIndex;
            double price =Convert.ToDouble( this.shop_price.Text);
            string img = this.goods_img.FileName;
            int count =Convert.ToInt32( this.shop_count.Text);
            DateTime time =Convert.ToDateTime( DateTime.Now.ToString());
            string n = this.zz.Text; ;
            int c = BLL.BSCategoryBLL.AddShop(name, sn, list, price, img, count,time,n);
            if (c > 0)
            {
                Response.Write("<script>alert('添加成功');location.href=('goods.aspx');</script>");
            }
            else {
                Response.Write("<script>alert('网络繁忙，请稍后再试')</script>");
            }
        }
    }
}