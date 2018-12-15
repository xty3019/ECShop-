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
    public partial class goodSType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                SelectBig();
            }
        }

        //显示类别
        private void SelectBig() {
            if (Session["uid"] != null)
            {
                SqlDataReader dr = BLL.goodSTypeBLL.SelectSmall(Convert.ToInt32(Session["uid"]));
                this.show.DataSource = dr;
                this.show.DataBind();
                dr.Close();
            }
            else {
                big();
            }
        }

        //private void SelectSmall() {
        //    int uid = Convert.ToInt32(Request.QueryString["uid"].ToString());
        //    SqlDataReader dr = BLL.goodSTypeBLL.SelectSmall(uid);
        //    this.show.DataSource = dr;
        //    this.show.DataBind();
        //    dr.Close();
        //}
        protected void AddType_Click(object sender, EventArgs e)
        {
            Response.Redirect("goodSTypeAdd.aspx");
        }
        private void big()
        {
            SqlDataReader dr = BLL.goodSTypeBLL.GetAll();
            this.show.DataSource = dr;
            this.show.DataBind();
            dr.Close();
        }
        protected void xsall_Click(object sender, EventArgs e)
        {
            big();
        }

        protected void del_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName=="sc") {
                int i =Convert.ToInt32( e.CommandArgument);
                int c = BLL.goodSTypeBLL.DeleX(i);
                if (c>0) {
                    Response.Write("<script>alert('删除成功');location.href('goodSType.aspx');</script>");
                    big();
                }
                else
                {
                    Response.Write("<script>alert('网络繁忙！！！');</script>");

                }
            }
        }
    }
}