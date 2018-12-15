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
    public partial class goodSTypeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GetListBig();
            }
        }

        private void GetListBig() {
            SqlDataReader dr= BLL.BSCategoryBLL.SelectBLNameID();
            this.list.DataSource = dr;
            this.list.DataTextField = "BLName";
            this.list.DataValueField = "BLID";
            this.list.Items.Insert(0,new ListItem("-请选择-"));
            this.list.DataBind();
            dr.Close();
        }

        //private void BindDate() {
        //    int id = this.list.SelectedIndex;
        //    string N = this.name.Text;
        //    int c = BLL.goodSTypeBLL.AddGood(N);
        //    if (id > 0)
        //    {
        //        if (c > 0)
        //        {
        //            Response.Write("<script>alert('添加成功');</script>");
        //        }
        //        else
        //        {
        //            Response.Write("<script>alert('网络繁忙')</script>");
        //        }
        //    }
        //}

        protected void tj_Click(object sender, EventArgs e)
        {
            int id =Convert.ToInt32( this.list.SelectedValue);
            string N = this.name.Text;
            int c = BLL.goodSTypeBLL.AddGood(N, id);
            if (id >0)
            {
                if (c > 0)
                {
                    Response.Write("<script>alert('添加成功');</script>");
                }
                else
                {
                    Response.Write("<script>alert('网络繁忙')</script>");
                }
            }
        }

        protected void cz_Click(object sender, EventArgs e)
        {
            this.name.Text = string.Empty;
        }
    }
}