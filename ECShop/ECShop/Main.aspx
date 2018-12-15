<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="ECShop.Main" %>

<%@ Register Src="~/ShoppingCartUserControl.ascx" TagPrefix="uc1" TagName="ShoppingCartUserControl" %>
<%@ Register Src="~/TreeView.ascx" TagPrefix="uc1" TagName="TreeView" %>
<%@ Register Src="~/Headtou.ascx" TagPrefix="uc1" TagName="Headtou" %>
<%@ Register Src="~/HeadDaohang.ascx" TagPrefix="uc1" TagName="HeadDaohang" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="js/jquery-1.4.2.min.js"></script>
    <script type="text/javascript" src="js/main-common.min.js"></script>
    <link rel="stylesheet" type="text/css" href="css/lanrenzhijia.css" />
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
            left: 0px;
            top: 5px;
        }
        .auto-style2 {
            margin-left: 680px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
        <uc1:Headtou runat="server" ID="Head" />
    <div class="blank">
    </div>
    
        <uc1:HeadDaohang runat="server" ID="HeadDaohang" />
    <div class="clearfix" id="search">
        <p class="auto-style2">
        书名:<input type="text" maxlength="30" style="width: 110px;" class="B_input" value="" id="keyword"
            name="keywords" runat="server" />
            <asp:Button runat="server" ID="btn_Sel" Text="搜索" CssClass="go" OnClick="btn_Sel_Click" />
        </p>
    </div>
    <div class="block clearfix">
        <div class="AreaL">
           
                <uc1:ShoppingCartUserControl runat="server" id="ShoppingCartUserControl" />
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
            <div class="banner-slider">
			<div id="banner-slider-gallery" class="gallery" style="width: 3940px; left: -960px; ">
				<a href="#" target="_blank"><img style="height:212px;" src="images/one.png" alt="" /></a>
				<a href="#" target="_blank"><img style="height:212px;" src="images/two.png" alt=""/></a>
			</div>
			<div id="banner-slider-mask" class="mask" style="opacity: 0.4; "></div>
			<div id="banner-slider-ctrl" class="ctrl">
				<a href="#" target="_blank" class="">1</a>
				<a href="#" target="_blank" class="">2</a>
			</div>
		</div>
            <div class="blank5">
            </div>
            <div class="blank5">
            </div>
            <div class="box">
                <div class="box_2 centerPadd">
                    <div id="itemBest" class="itemTit">
                    </div>
                    <asp:Repeater ID="repRecommend" runat="server">
                        <HeaderTemplate></HeaderTemplate>
                        <ItemTemplate>
                            <div class="goodsItem">
                            <span class="best"></span><a href="goods.aspx?bid=<%#Eval("BID") %>">
                                <img class="goodsimg" alt="C++ Primer 习题解答（第4版）" src="<%#"images/"+Eval("BPic") %>"></a><br>
                            <p>
                                <a title="" href="goods.aspx?bid=<%#Eval("BID") %>"><%#Eval("BName") %></a></p>
                            <font class="f1"><%#Eval("BPrice") %> </font>
                        </div>
                        </ItemTemplate>
                        <FooterTemplate></FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="blank5">
            </div>
            <div class="box">
                <div class="box_2 centerPadd">
                    <div id="itemNew" class="itemTit New">
                    </div>
                    <asp:Repeater runat="server" ID="repNewBook">
                        <HeaderTemplate></HeaderTemplate>
                        <ItemTemplate>
                            <div class="goodsItem">
                            <span class="best"></span><a href="goods.aspx?bid=<%#Eval("BID") %>">
                                <img class="goodsimg" alt="Visual C++2005入门经典" src="<%#"images/"+Eval("BPic") %>"></a><br>
                            <p>
                                <a title="" href="goods.aspx?bid=<%#Eval("BID") %>"><%#Eval("BName") %></a></p>
                            <font class="f1"><%#Eval("BPrice") %> </font>
                        </div>
                        </ItemTemplate>
                        <FooterTemplate></FooterTemplate>
                    </asp:Repeater>
                </div>
            </div>
            <div class="blank5">
            </div>
            <div class="blank5">
            </div>
        </div>
    </div>
    <div id="footer">
        <div class="text">
            &copy; 2005-2012 ECSHOP 版权所有，并保留所有权利。<br />
            <br>
            共执行 41 个查询，用时 0.090556 秒，在线 2 人，Gzip 已禁用，占用内存 3.136 MB<br />
            <a style="font-family: Verdana; font-size: 11px;" target="_blank" href="http://www.ecshop.com">
                Powered&nbsp;by&nbsp;<strong><span style="color: #3366FF">ECShop</span>&nbsp;<span
                    style="color: #FF9966">v2.7.0</span></strong></a>&nbsp;<br />
            <div align="left" id="rss">
                <a href="#">
                    <img alt="rss" src="images/xml_rss2.gif" /></a></div>
        </div>
    </div>
        </form>
</body>
</html>
