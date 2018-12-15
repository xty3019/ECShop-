using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;

namespace ECShop
{
    public partial class HeadDaohang : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                LoadMsg();

            }

        }

        private void LoadMsg()
        {
            SqlDataReader dr = MainBLL.LoadMsg();
            this.repHead.DataSource = dr;
            this.repHead.DataBind();
        }
    }
}