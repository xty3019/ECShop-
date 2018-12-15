<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Flow.aspx.cs" Inherits="ECShop.Flow" %>

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
    <form id="form1" runat="server">
    
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
    <div class="block">
        <div class="flowBox">
            <h6>
                <span>商品列表</span>
            </h6>
            
            <asp:Repeater runat="server" ID="repbuygood">
                <HeaderTemplate>
                    <table align="center" width="99%" cellspacing="1" cellpadding="5" border="0" bgcolor="#dddddd">
                        <tbody>
                    <tr>
                        <th bgcolor="#ffffff">
                            商品名称
                        </th>
                        <th bgcolor="#ffffff">
                            价格
                        </th>
                        <th bgcolor="#ffffff">
                            购买数量
                        </th>
                        <th bgcolor="#ffffff">
                            小计
                        </th>
                        <th bgcolor="#ffffff">
                            操作
                        </th>
                    </tr>
                        
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td align="center" bgcolor="#ffffff">
                            <img border="0" width="100px" height="100px;" title="Visual C++2005入门经典" src="<%#"images/"+Eval("BPic") %>"><br>
                            <%#Eval("BName") %>
                        </td>
                        <td align="right" bgcolor="#ffffff">
                            <asp:Label ID="price" runat="server" Text='<%#Eval("BPrice") %>'></asp:Label>
                            
                        </td>
                        <td align="right" bgcolor="#ffffff">
                            <asp:TextBox MaxLength="5" ID="lbcount" runat="server" OnTextChanged="lbcount_TextChanged" AutoPostBack="true" Text='<%#Eval("BCount") %>'></asp:TextBox>
                        </td>
                        <td align="right" bgcolor="#ffffff">
                            <asp:Label ID="lbsum" runat="server" Text='<%#Convert.ToInt32( Eval("BCount")) * Convert.ToInt32( Eval("BPrice")) %>'></asp:Label>
                        </td>
                        <td align="center" bgcolor="#ffffff">
                            <asp:LinkButton runat="server" ID="btn_Del" OnClientClick="return confirm('您确定要把该商品移除购物车吗？')" CommandArgument='<%#Eval("TID") %>' Text="删除" OnClick="btn_Del_Click"></asp:LinkButton>
                        </td>
                    </tr>
                        
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <table align="center" width="99%" cellspacing="0" cellpadding="5" border="0" bgcolor="#dddddd">
                <tbody>
                    <tr>
                        <td align="right" bgcolor="#ffffff">
                            <a href='consignee.aspx?bid=<%# Eval("bid")%> '>
                                <img alt="checkout" src="images/checkout.gif" />
                            </a>
                        </td>
                    </tr>
                </tbody>
            </table>
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
