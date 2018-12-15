using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;
using System.Text;

namespace Ecshop
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {


            }
        }

        protected void dl_Click(object sender, EventArgs e)
        {
            string n = this.username.Text;
            string p = this.password.Text;
            SqlDataReader dr = AdminBLL.GetNP(n, p);
            string yzm = Session["code"].ToString();
            if (yzm != this.yzm.Text) {
                Response.Write("<script>alert('验证码错误，请重新输入！')</script>");
                return;
            }
            if (dr.HasRows) {
                Response.Redirect("Index.aspx");
            }
            else {
                Response.Write("<script>alert('用户名或密码错误，请重新登陆！！！')</script>");
            }
            //if (dr!=null) {
            //    string uid = Convert.ToString(AdminBLL.GetNP(n, p));
            //    Session["AName"] = n;
            //    Session["APassword"] = p;
            //    Session["AID"] = uid;
            //    byte[] buffer = Encoding.UTF8.GetBytes(uid);

            //    HttpCookie cookie = new HttpCookie("AName", n);
            //    cookie.Expires = DateTime.Now.AddMinutes(1);
            //    Response.Cookies.Add(cookie);
            //}
            //else {
            //    Response.Write("<script>alert('用户名或密码错误，请重新登陆！！！')</script>");
            //}
        }
    }
}