<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goods.aspx.cs" Inherits="ECShop.WebForm1" ValidateRequest="false"%>

<%@ Register Src="~/ShoppingCartUserControl.ascx" TagPrefix="uc1" TagName="ShoppingCartUserControl" %>
<%@ Register Src="~/Headtou.ascx" TagPrefix="uc1" TagName="Headtou" %>
<%@ Register Src="~/HeadDaohang.ascx" TagPrefix="uc1" TagName="HeadDaohang" %>
<%@ Register Src="~/TreeView.ascx" TagPrefix="uc1" TagName="TreeView" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
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
    <form runat="server" id="form1">
        <uc1:Headtou runat="server" ID="Headtou" />
    <div class="blank">
    </div>
    
        <uc1:HeadDaohang runat="server" ID="HeadDaohang" />
    <div class="clearfix" id="search">
        <p class="auto-style1">
        书名:<input type="text" maxlength="30" runat="server" style="width: 110px;" class="B_input" value="" id="bookname"
            name="keywords" />
            <asp:Button runat="server" ID="btn_Sel" CssClass="go" Text="搜索" OnClick="btn_Sel_Click" />
        </p>
    </div>
    <div class="block clearfix">
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
            <div class="clearfix" id="goodsInfo">
                <div class="imgInfo">
                    <asp:Image runat="server" ID="imggoods" alt="Visual C++2005入门经典"/>
                </div>
                <!--书籍简要介绍-->
                <div class="textInfo">
                    <div class="clearfix">
                            <asp:Label runat="server" ID="lbbname" CssClass="f_l"></asp:Label>
                    </div>
                    <ul>
                        <li class="clearfix">
                            <dd>
                                <strong>书籍货号：</strong><asp:Label runat="server" ID="lbbHuoHao"></asp:Label>
                            </dd>
                            <dd class="ddR">
                                <strong>书籍库存：</strong> <font color="red"><asp:Label runat="server" ID="lbbcount"></asp:Label></font>
                            </dd>
                        </li>
                        <li class="clearfix">
                            <dd>
                                <strong>书籍作者：</strong><asp:Label runat="server" ID="lbbAuthor"></asp:Label>
                            </dd>
                            <dd class="ddR">
                                <strong>书籍价格：</strong><font id="Font1" class="shop"><asp:Label runat="server" ID="lbprice"></asp:Label></font>
                            </dd>
                        </li>
                        <li class="clearfix">
                            <dd>
                                <strong>购买数量：</strong>
                                <asp:TextBox runat="server" ID="txtCount" Text="1" MaxLength="5" ValidationGroup="count"></asp:TextBox> 
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCount" ErrorMessage="请输入正确的数量" ForeColor="#CC3300" ValidationExpression="^[1-9]\d*$" ValidationGroup="count"></asp:RegularExpressionValidator>
                            </dd>
                            <dd class="ddR">
                            </dd>
                        </li>
                        <li class="padd">
                            <asp:Button runat="server" ID="btn_Addgoods" CssClass="Addgoodsbtn" OnClick="btn_Addgoods_Click" ValidationGroup="count" />
                        </li>
                    </ul>
                </div>
            </div>
            <!--书籍简介介绍-->
            <div class="textInfo">
                <div class="clearfix">
                    <p style="font-size:14px;" class="f_l">
                        书籍简介</p>
                </div>
                <ul>
                    <li class="clearfix">
                        <dd>
                            <textarea style="resize:none;" runat="server" id="TextArea1" cols="70" rows="4" width="auto"></textarea>
                          
                        </dd>
                    </li>
                </ul>
            </div>
            <!--书籍描述介绍-->
            <div class="textInfo">
                <div class="clearfix">
                    <p style="font-size:14px;" class="f_l">
                        书籍描述</p>
                </div>
                <ul>
                    <li class="clearfix">
                        <dd>
                            <textarea style="resize:none;" runat="server" id="TextArea2" cols="70" rows="4"></textarea>
                        </dd>
                    </li>
                </ul>
            </div>
        </div>
        <div class="blank5">
        </div>
    </div>
    <div id="footer">
        <div class="text">
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

