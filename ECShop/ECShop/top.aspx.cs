using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecshop
{
    public partial class top : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void qc_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Write("<script>alert('清除成功');</script>");
        }
    }
}