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
    public partial class goodLType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Loadshow();
            }
        }

        //添加
        protected void add_Click(object sender, EventArgs e)
        {
            string n = this.name.Text;
            int c = BLL.BLCategoryBLL.AddBLCategory(n);
            if (c > 0)
            {
                Response.Write("<script>alert('添加成功');location.href=('goodLType.aspx');</script>");
            }
            else
            {
                Response.Write("<script>alert('网络繁忙！！！');</script>");
            }
        }
        //删除
        protected void del_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "sc")
            {
                int i = Convert.ToInt32(e.CommandArgument);
                    int counts;
                    SqlDataReader dr = BLL.goodSTypeBLL.g(i);
                    if (dr.Read())
                    {
                        counts = Convert.ToInt32(dr["counts"].ToString());
                        if (counts > 0)
                        {
                        Response.Write("<script>alert('此类别中有小类别，请删除小类别后操作');location.href=('goodLType.aspx');</script>");

                    }
                        else
                        {
                            int c = BLL.goodSTypeBLL.DeleD(i);
                            if (c < 0)
                            {
                                Response.Write("<script>alert('删除成功');location.href=('goodLType.aspx');</script>");
                            }
                           
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('网络繁忙！！！');</script>");

                }
            }
        }

        private void Loadshow()
        {
            SqlDataReader dr = BLL.BLCategoryBLL.SelectAll();
            this.Blgrivew.DataSource = dr;
            this.Blgrivew.DataBind();
            dr.Close();
        }

        protected void selectBsbtn_Click(object sender, ImageClickEventArgs e)
        {
            ImageButton b = sender as ImageButton;
            Session["uid"] = b.CommandArgument;
            Response.Redirect("goodSType.aspx");
        }

        protected void Blgrivew_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            string id = Blgrivew.DataKeys[e.RowIndex].Values[0].ToString();
            string BLID = ((TextBox)Blgrivew.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            string BLName = ((TextBox)Blgrivew.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            int i = BLL.goodSTypeBLL.Update(BLName, Convert.ToInt32(BLID));
            if (i > 0)
            {
                Response.Write("<script>alert('更新成功')</script>");
                Blgrivew.EditIndex = -1;
                Loadshow();
            }
            else
            {
                Response.Write("<script>alert('网络繁忙')</script>");
            }
        }

        protected void Blgrivew_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Blgrivew.EditIndex = -1;
            Loadshow();
        }

        protected void Blgrivew_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Blgrivew.EditIndex = e.NewEditIndex;
            Loadshow();
        }
    }
}