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
    public partial class goodSTypeEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GetList();
                GetAll();
            }
        }
        private void GetList() {
            SqlDataReader dr = BLL.goodSTypeEditBLL.SelectID();
            this.list.DataSource = dr;
            this.list.DataValueField = "BLID";
            this.list.DataTextField = "BLName";
            this.list.DataBind();
            //this.list.SelectedIndex= Convert.ToInt32(Request.QueryString["bsid"].ToString());

        }

        private void GetAll() {
            int i = Convert.ToInt32(Request.QueryString["bsid"].ToString());
            SqlDataReader dr = BLL.goodSTypeEditBLL.SelectIDAll(i);
            while (dr.Read()) {
                this.list.SelectedIndex =Convert.ToInt32( dr["BSID"].ToString());
                this.small.Text = dr["BLName"].ToString();
            }
            dr.Close();
        }

        protected void tj_Click(object sender, EventArgs e)
        {
            int i =Convert.ToInt32( Request.QueryString["bsid"].ToString());
            int list =Convert.ToInt32( this.list.SelectedValue);
            this.list.Enabled = false;
            string name = this.small.Text;
            int c = BLL.goodSTypeEditBLL.update(name, list,i);
            if (c>0) {
                Response.Write("<script>alert('修改成功');location.href('goodSType.aspx');</script>");
            }
            else
            {
                Response.Write("<script>alert('网络繁忙！！！');</script>");

            }


        }

        protected void cz_Click(object sender, EventArgs e)
        {
            this.small.Text = string.Empty;
        }
    }
}