using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BLL;
using Model;

namespace ECShop
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["name"]!= null)
                {
                    SelectTreeView();
                    MainSelectBook();
                    this.AspNetPager1.RecordCount = SumCount();
                }
                else
                {
                    SelectBookList();

                    SelectTreeView();
                    
                    this.AspNetPager1.RecordCount = SumCount();
                }
               
            }
        }
        private int SumCount()
        {
            return Convert.ToInt32(CategoryBLL.SumCount());
        }
        private void SelectBookList()
        {
            SqlDataReader dr = CategoryBLL.CategoryBookList(5,1);
            this.repBookList.DataSource = dr;
            this.repBookList.DataBind();
        }

        protected void btn_Sel_Click(object sender, EventArgs e)
        {
            if (Session["name"] == null)
                Session["name"] = keyword.Value;

                string MainName = keyword.Value; ;
                string name = this.keyword.Value;
                

                SqlDataReader dr = CategoryBLL.SelectBook(5, 1, name);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
                dr.Close();
            Session.Clear();
         }

        private void MainSelectBook()
        {
            string MainName = Session["name"].ToString();
            string name = this.keyword.Value;
            if (MainName != null)
            {
                SqlDataReader dr = CategoryBLL.SelectBook(5,1,MainName);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
                dr.Close();
            }
            else
            {
                SqlDataReader dr = CategoryBLL.SelectBook(5,1,name);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
                dr.Close();
            }
            
        }

        protected void AspNetPager1_PageChanging(object src, Wuqi.Webdiyer.PageChangingEventArgs e)
        {
            if (Session["name"] != null)
            {
                string name = Session["name"].ToString();
                SqlDataReader dr = CategoryBLL.SelectBook(5, e.NewPageIndex, name);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
                dr.Close();
            }

            else
            {

                int BLID = Convert.ToInt32(Request.QueryString["BLID"]);
                int BSID = Convert.ToInt32(Request.QueryString["BSID"]);
                if (BLID>0)
                {
                    SqlDataReader dr = BLCategoryBLL.SelecBLIDtBook(5,e.NewPageIndex,BLID);
                    this.repBookList.DataSource = dr;
                    this.repBookList.DataBind();
                }
                else
                {
                
                    SqlDataReader dr = BSCategoryBLL.SelectBook(5, e.NewPageIndex, BSID);
                    this.repBookList.DataSource = dr;
                    this.repBookList.DataBind();
                }
            }
        }
        /// <summary>
        ///TreeView传值进行查询
        /// </summary>
        private void SelectTreeView()
        {
           
            int BLID = Convert.ToInt32(Request.QueryString["BLID"]);
            int BSID = Convert.ToInt32(Request.QueryString["BSID"]);
            if (BLID>0)
            {
                SqlDataReader dr = BLCategoryBLL.SelecBLIDtBook(5,1,BLID);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
            }
            else
            {
                
                SqlDataReader dr = BSCategoryBLL.SelectBook(5, 1, BSID);
                this.repBookList.DataSource = dr;
                this.repBookList.DataBind();
            }
            
        }
    }
}