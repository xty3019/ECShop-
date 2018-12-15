using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECShop
{
    public partial class Head : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LogUser();
            }
        }

        private void LogUser()
        {
            
            if (Session["uname"]!=null)
            {
                btnLog.Visible = false;
                btnReg.Visible = false;
                btnClear.Visible = true;
                this.lbuser.Text = "欢迎" + Session["uname"];
            }
        }


        protected void btnLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
        

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Session.Clear();
            btnLog.Visible = true;
            btnReg.Visible = true;
            btnClear.Visible = false;
            Response.Redirect("Login.aspx");
        }
    }
}