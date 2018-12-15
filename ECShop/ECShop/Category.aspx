<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Category.aspx.cs" Inherits="ECShop.Category" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>
<%@ Register Src="~/ShoppingCartUserControl.ascx" TagPrefix="uc1" TagName="ShoppingCartUserControl" %>
<%@ Register Src="~/TreeView.ascx" TagPrefix="uc1" TagName="TreeView" %>
<%@ Register Src="~/Headtou.ascx" TagPrefix="uc1" TagName="Headtou" %>
<%@ Register Src="~/HeadDaohang.ascx" TagPrefix="uc1" TagName="HeadDaohang" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/demo.css" rel="stylesheet" type="text/css" />
      <style type="text/css">
        dt, dl
        {
            margin: 0px;
            padding: 0px;
        }
        dd
        {
            margin-left: 40px;
        }
        .flash1
        {
            width: 400px;
            height: 200px;
        }
          .auto-style1 {
              margin-left: 680px;
          }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <uc1:Headtou runat="server" ID="Headtou" />
    <div class="blank">
    </div>
        <uc1:HeadDaohang runat="server" ID="HeadDaohang" />
    <div class="clearfix" id="search">
        <p class="auto-style1">
        书名:<input type="text" maxlength="30" style="width: 110px;" class="B_input" value="" id="keyword"
            name="keywords" runat="server" />
            <asp:Button runat="server" ID="btn_Sel" Text="搜索" CssClass="go" OnClick="btn_Sel_Click" />
        </p>
    </div>
    <div class="block">
        <div class="AreaL">
          
            <uc1:ShoppingCartUserControl runat="server" ID="ShoppingCartUserControl" />
            <div class="blank5">
            </div>
            <div class="box">
                <div class="box_1">
                    
                    <uc1:TreeView runat="server" ID="TreeView" />
                </div>
            </div>
            <div class="blank5">
            </div>
        </div>
        <div class="AreaR">
            <div class="flowBox">
               
                <asp:Repeater runat="server" ID="repBookList">
                    <HeaderTemplate></HeaderTemplate>
                    <ItemTemplate>
                        <table align="center" width="99%" cellspacing="1" cellpadding="5" border="0" bgcolor="#dddddd">
                    <tbody>
                        <tr>
                            <td align="center" bgcolor="#ffffff" rowspan="3" style="width: 100px;">
                                <a href='goods.aspx?bid=<%#Eval("BId") %>'><img border="0" width="100px" height="100px;" title="Visual C++2005入门经典" src="<%#"images/"+Eval("BPic") %>""></a><br>
                            </td>
                            <td align="left" bgcolor="#ffffff">
                                书籍名：<%#Eval("BName") %></td>
                        </tr>
                        <tr>
                            <td align="left" bgcolor="#ffffff" colspan="2">
                                书籍作者: <%#Eval("BAuthor") %>
                            </td>
                        </tr>
                        <tr>
                            <td align="left" bgcolor="#ffffff" colspan="2">
                                商品价格:<%#Eval("BPrice") %></td>
                        </tr>
                        <tr>
                            <td align="left" bgcolor="#ffffff" colspan="2">
                                简介:<br />
                                <textarea style="resize:none;" id="TextArea1" cols="105" rows="5">
                                    <%#Eval("BComment") %>
                                </textarea>
                            </td>
                        </tr>
                    </tbody>
                </table>
                    </ItemTemplate>
                    <FooterTemplate></FooterTemplate>
                </asp:Repeater>
                <webdiyer:AspNetPager CssClass="anpager" ID="AspNetPager1" runat="server" FirstPageText="首页" LastPageText="尾页" NextPageText="下一页" OnPageChanging="AspNetPager1_PageChanging" PrevPageText="上一页"></webdiyer:AspNetPager>

            </div>
        </div>

        <div class="blank5">
        </div>
    </div>
    <div id="footer">
        <div class="text">
            &copy; 2005-2012 ECSHOP 版权所有，并保留所有权利。s="text">
            &copy; 2005-2012 ECSHOP 版权所有，并保留所有权利。<br>
            <br>
            共执行 41 个查询，用时 0.090556 秒，在线 2 人，Gzip 已禁用，占用内存 3.136 MB<br>
            <a style="font-family: Verdana; font-size: 11px;" target="_blank" href="http://www.ecshop.com">
                Powered&nbsp;by&nbsp;<strong><span style="color: #3366FF">ECShop</span>&nbsp;<span
                    style="color: #FF9966">v2.7.0</span></strong></a>&nbsp;<br>
            <div align="left" id="rss">
                <a href="#">
                    <img alt="rss" src="images/xml_rss2.gif"></a></div>
        </div>
    </div>
        </form>
</body>
</html>

