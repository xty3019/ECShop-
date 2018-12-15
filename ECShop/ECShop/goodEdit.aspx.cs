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
    public partial class goodEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                GetAll();
            }
        }

        private void GetAll() {
            int id =Convert.ToInt32( Request.QueryString["uid"].ToString());
            SqlDataReader dr = BLL.BookBLL.SelectAllID(id);
            while (dr.Read()) {
                this.goods_name.Text = dr["BName"].ToString();
                this.goods_sn.Text = dr["BISBN"].ToString();
                this.zz.Text= dr["BAuthor"].ToString();
                this.list.SelectedValue = dr["BSID"].ToString();
                this.shop_price.Text = dr["BPrice"].ToString();
                this.pics.ImageUrl = "~/Imgs" +@"\"+dr["BPic"].ToString();
                this.shop_count.Text = dr["BCount"].ToString();
                ViewState["BPic"] = dr["BPic"].ToString();
            }
            dr.Close();
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            this.goods_name.Text = string.Empty;
            this.goods_sn.Text = string.Empty;
            this.zz.Text = string.Empty;
            this.list.Text = string.Empty;
            this.shop_price.Text = string.Empty;
            //this.goods_img. = string.Empty;
            this.shop_count.Text = string.Empty;
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string BPic = "";
            if (!ViewState["BPic"].Equals(""))
            {
                BPic = ViewState["BPic"].ToString();
            }
            if (this.goods_img.HasFile) {
                string filename = this.goods_img.FileName;
                string filepath = "~/Imgs";
                string path = Server.MapPath(filepath);
                path += @"\" + filename;
                this.goods_img.SaveAs(path);
                BPic = this.goods_img.FileName;
            }
            //if (this.pics.HasFile)
            //{
            //    string filename = this.goodsfile.FileName;
            //    string filepath = "~/Images";
            //    string path = Server.MapPath(filepath);
            //    path += @"\" + filename;
            //    this.pics.SaveAs(path);
            //    BPic = this.goodsfile.FileName;
            //}
            int id =Convert.ToInt32( Request.QueryString["uid"].ToString());
            string n= this.goods_name.Text;
            string sn = this.goods_sn.Text;
            string zz = this.zz.Text;
            int li = this.list.SelectedIndex;
            decimal money =Convert.ToDecimal( this.shop_price.Text);
            string p = BPic; 
            int sum = Convert.ToInt32(this.shop_count.Text);
            int c = BLL.BookBLL.UpDate(n,sn,li,money,p,sum,zz,id);
            if (c>0) {
                Response.Write("<script>alert('修改成功');location.href='goods.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('网络繁忙，请稍后再试')</script>");
            }
        }
    }
}