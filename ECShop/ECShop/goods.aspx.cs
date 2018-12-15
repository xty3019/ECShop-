using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using BLL;
using Model;
using System.Web.UI.WebControls;

namespace ECShop
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                ShowGoods();
            }
        }

        private void ShowGoods()
        {
            if (Request.QueryString["bid"] != null)
            {
                int id = Convert.ToInt32(Request.QueryString["bid"]);
                SqlDataReader dr = goodsBLL.SelectGoods(id);
                while (dr.Read())
                {
                    this.imggoods.ImageUrl = "images/" + dr["BPic"].ToString();
                    this.lbbname.Text = dr["BName"].ToString();
                    this.lbbHuoHao.Text = dr["BISBN"].ToString();
                    this.lbbcount.Text = dr["BCount"].ToString();
                    this.lbbAuthor.Text = dr["BAuthor"].ToString();
                    this.lbprice.Text = dr["BPrice"].ToString();
                    this.TextArea1.Value = dr["BTOC"].ToString();
                    this.TextArea2.Value = dr["BComment"].ToString();
                    //this.txtCount.Text = dr["TCount"].ToString();
                }
            }
        }

        protected void btn_Addgoods_Click(object sender, EventArgs e)
        {
            if (Session["Mid"] == null)
            {
                
                Response.Redirect("Login.aspx?url="+Request.RawUrl);
            }
            else
            {
                int Bid = Convert.ToInt32(Request.QueryString["bid"]);
                int usercount =Convert.ToInt32(txtCount.Text);
                int checkcount= TradeBLL.CheckBcount(Bid);
                    if (checkcount >= usercount)
                    {
                        int Mid = Convert.ToInt32(Session["Mid"]);
                        int count = Convert.ToInt32(txtCount.Text);
                        int c = goodsBLL.AddGood(Bid, Mid, count);
                        if (c > 0)
                        {
                            Response.Redirect("Flow.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('网络繁忙，请稍后')</script>");
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('对不起，库存不足')</script>");
                    }
                
                
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