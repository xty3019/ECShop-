using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;
using Model;

namespace ECShop
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SumPrice();

                Showbuybook();
            }
        }

        private void Showbuybook()
        {
            int Mid = Convert.ToInt32(Session["Mid"]);
            SqlDataReader dr = TradeBLL.SelectTrade(Mid);
            this.repgoods.DataSource = dr;
            this.repgoods.DataBind();
            dr.Close();
        }

        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            string Oid = "DD" + DateTime.Now.ToString("yyyyMMddMMss");

            Orders order = new Orders()
            {
                OID = Oid,
                MID = Convert.ToInt32(Session["Mid"]),
                ODate = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd")),
                OConsignee = this.consignee_0.Value,
                OAddress = this.oaddress.Value,
                OTelephone = this.tel_0.Value,
                OSumPrice = Convert.ToInt32(this.txtSumPrice.Value),
                OState = 1,
            };

            bool ck = OrderBLL.AddOrder(order)>0? true :false;


            if(ck)
            {

                RepeaterItemCollection items = repgoods.Items;
                foreach (RepeaterItem item in items)
                {
                    Label bid = (Label)item.FindControl("bBID");
                    Label tid = (Label)item.FindControl("bTID");
                    Label price= (Label)item.FindControl("price");
                    TextBox lbcount= (TextBox)item.FindControl("lbcount");

                    OrderDetails o = new OrderDetails() {
                        OID= Oid,
                        BID=Convert.ToInt32( bid.Text),
                        BPrice=Convert.ToDouble( price.Text),
                        BCount=Convert.ToInt32( lbcount.Text)
                    };
                    bool cko = OrderBLL.AddOrderDetails(o) > 0 ? true : false;
                    if (cko)
                    {
                        bool ckd = OrderBLL.DeleteTrade(Convert.ToInt32(tid.Text)) > 0 ? true : false;

                        if (ckd)
                        {
                            OrderBLL.UpdateBcount(Convert.ToInt32(lbcount.Text), Convert.ToInt32(bid.Text));
                        }
                    }


                }
                Response.Redirect("done.aspx?oid=" + Oid);
            }
 
        }

        protected void lbcount_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            RepeaterItemCollection items = repgoods.Items;

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

        protected void btn_Sel_Click(object sender, EventArgs e)
        {
            string name = this.bookname.Value;
            Session["name"] = name;
            Response.Redirect("Category.aspx");
        }
        private void SumPrice()
        {
            int Mid = Convert.ToInt32(Session["Mid"]);
            SqlDataReader dr = TradeBLL.SelectTrade(Mid);
            double sum = 0;

            while (dr.Read())
            {
                sum += Convert.ToDouble(dr["BCount"]) * Convert.ToDouble(dr["BPrice"]);
            }
            txtSumPrice.Value = sum.ToString();
            this.repgoods.DataSource = dr;
            this.repgoods.DataBind();
            dr.Close();
        }
    }
}