using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using System.Data.SqlClient;

namespace ECShop
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowNewBook();//新品上市
                ShowBestBook();//推荐
            }
            
            
        }


        private void ShowNewBook()
        {
            SqlDataReader dr = MainBLL.SelectNewBook();
            this.repNewBook.DataSource = dr;
            this.repNewBook.DataBind();
        }

        private void ShowBestBook()
        {
            SqlDataReader dr= MainBLL.SelectMainBestBook();
            this.repRecommend.DataSource = dr;
            this.repRecommend.DataBind();
        }

        protected void btn_Sel_Click(object sender, EventArgs e)
        {
            string name = this.keyword.Value;
            Session["name"] = name;
            Response.Redirect("Category.aspx");
        }
    }
}