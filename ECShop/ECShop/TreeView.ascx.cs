using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data.SqlClient;

namespace ECShop
{
    public partial class TreeView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SelectAll();
                
            }
        }

        private void SelectAll()
        {
            List<BLCategory> list = BLCategoryBLL.SelectAll();
            foreach (var item in list)
            {
                TreeNode tn = new TreeNode();
                tn.Text = item.BLName;
                tn.Value =item.BLID.ToString();
                tn.NavigateUrl = "Category.aspx?BLID="+item.BLID;
                 
                this.TreeView1.Nodes.Add(tn);
                List<BSCategory> list2 = BSCategoryBLL.SelectAll(item.BLID);
                foreach (var item2 in list2)
                {
                    TreeNode tn2 = new TreeNode();
                    tn2.Text = item2.BLName;
                    tn2.Value =item2.BSID.ToString();
                    tn2.NavigateUrl= "Category.aspx?BSID=" + item2.BSID;
                    tn.ChildNodes.Add(tn2);
                }
            }
            
        }

        protected void TreeView1_SelectedNodeChanged(object sender, EventArgs e)
        {
            TreeView tn = sender as TreeView;
            
            

        }
    }
}