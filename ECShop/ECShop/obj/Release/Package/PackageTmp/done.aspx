<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="done.aspx.cs" Inherits="ECShop.done" %>

<%@ Register Src="~/Headtou.ascx" TagPrefix="uc1" TagName="Headtou" %>
<%@ Register Src="~/HeadDaohang.ascx" TagPrefix="uc1" TagName="HeadDaohang" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
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
            name="keywords">
            <asp:Button runat="server" ID="btn_Sel" Text="搜索" CssClass="go" OnClick="btn_Sel_Click" />
        </p>
    </div>
    <!-- 订单信息-->
    <div class="block">
        <div class="box">
            <div class="box_1">
                <h3>
                    <span>系统信息</span></h3>
                <div align="center" class="boxCenterList RelaArticle">
                    <div style="margin: 20px auto;">
                        <p style="font-size: 14px; font-weight: bold; color: red;">
                            订单号：<asp:Label ID="la" runat="server"></asp:Label></p>
                        <div class="blank">
                        </div>
                    </div>
                </div>
            </div>
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

