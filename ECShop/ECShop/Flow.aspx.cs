using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ECShop
{
    public partial class Flow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowGood();
            }
        }

        private void ShowGood()
        {
            int id = Convert.ToInt32(Session["Mid"]);
            SqlDataReader dr= TradeBLL.SelectTrade(id);
            this.repbuygood.DataSource = dr;
            this.repbuygood.DataBind();
        }


        protected void btn_Del_Click(object sender, EventArgs e)
        {
            LinkButton b=(sender as LinkButton);
            int id = Convert.ToInt32(b.CommandArgument);
            int c = TradeBLL.DeleteGoods(id);
            if (c > 0)
            {
                ShowGood();
            }
            else
            {
                Response.Write("<script>alert('网络繁忙,请稍后');location.href=('Flow.aspx')</script>");
            }
            
        }

        protected void lbcount_TextChanged(object sender, EventArgs e)
        {
            Regex num = new Regex(@"^[1-9]\d*$");
            TextBox txt = (TextBox)sender;
            if (num.IsMatch(txt.Text))
            {


                RepeaterItemCollection items = repbuygood.Items;

                Label dj = null;

                Label sum = null;

                foreach (var item in items)
                {
                    RepeaterItem a = (RepeaterItem)item;

                    if (txt == (TextBox)a.FindControl("lbcount"))
                    {
                        dj = (Label)a.FindControl("price");

                        sum = (Label)a.FindControl("lbsum");

                    }


                }
                sum.Text = (Convert.ToDouble(dj.Text) * Convert.ToInt32(txt.Text)).ToString();
            }
            else
            {
                Response.Redirect("<script>alert('请输入正确的数量')</script>");
            }
        }

        protected void btn_Sel_Click(object sender, EventArgs e)
        {
            string name = this.bookname.Value;
            Session["name"] = name;
            Response.Redirect("Category.aspx");
        }
    }
}