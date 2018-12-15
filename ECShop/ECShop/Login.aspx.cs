using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using System.Data.SqlClient;
using BLL;

namespace ECShop
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlog_Click(object sender, EventArgs e)
        {
            string Mid = "";
            Member member = new Member();
            member.MName = this.txtname.Value;
            member.MPassword = this.txtpwd.Value;
            bool c= LoginBLL.LoginMember(member,out Mid);
            if (c)
            {
                Session["uname"] = this.txtname.Value; ;
                Session["Mid"] = Mid;
                if (Request.QueryString["url"] != null)
                {
                    Response.Redirect(Request.QueryString["url"]);
                    Response.Redirect("goods.aspx");
                }
                else
                {
                    Response.Redirect("Main.aspx");
                }
                
            }
            else
            {
                Response.Write("<script>alert('用户名或密码错误！')</script>");
            }
        }

        protected void btn_Reg_Click(object sender, EventArgs e)
        {
            Member member = new Member()
            {
                MName = this.username.Value,
                MEmail=this.txtemail.Value,
                MPassword=this.password1.Value,
            };
            string pwd = this.password1.Value;
            string newpwd = this.confirm_password.Value;
            int checkuser = LoginBLL.CheckUsername(this.username.Value);
            if (checkuser > 0)
            {
                Response.Write("<script>alert('该用户已被注册！')</script>");
                return;
            }
            if (pwd != newpwd)
            {
                Response.Write("<script>alert('两次密码输入不一致！')</script>");
            }
            

            else
            {
                int check = LoginBLL.RegMember(member);
                if (check>0)
                {
                    Response.Write("<script>alert('注册成功！')</script>");
                }
                else
                {
                    Response.Write("<script>alert('网络繁忙，请稍后！')</script>");
                }
            }

        }

        protected void btnSel_Click(object sender, EventArgs e)
        {
            Session["name"] = this.keyword.Value;
            if (this.keyword.Value != "")
            {
                Response.Redirect("Category.aspx");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}