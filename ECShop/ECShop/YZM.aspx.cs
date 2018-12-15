using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ecshop
{
    public partial class YZM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.ContentType = "imgage/JPEG";
            Bitmap bitmap = new Bitmap(55, 25);
            Graphics g = Graphics.FromImage(bitmap);
            Random rand = new Random();
            int code = rand.Next(1000, 9999);
            string strCode = code.ToString();
            HttpContext.Current.Session["Code"] = strCode;
            g.DrawString(strCode, new Font("宋体", 15), Brushes.HotPink, new PointF(0, 0));
            bitmap.Save(Response.OutputStream, ImageFormat.Jpeg);
        }
    }
}