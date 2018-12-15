using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECShop
{
    public partial class done : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                la.Text = Request.QueryString["oid"].ToString();
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