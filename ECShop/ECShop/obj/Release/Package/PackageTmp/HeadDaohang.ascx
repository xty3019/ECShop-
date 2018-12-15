<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeadDaohang.ascx.cs" Inherits="ECShop.HeadDaohang" %>
<link href="css/style.css" rel="stylesheet" />

<asp:Repeater runat="server" ID="repHead">
    <HeaderTemplate>
        <div class="clearfix" id="mainNav">
        <a class="cur" href="main.aspx">首页<span></span></a> 
        
    
    </HeaderTemplate>
    <ItemTemplate>
        <a href="Category.aspx?BLID=<%#Eval("BLID") %>"><%#Eval("BLName") %><span></span></a>
    </ItemTemplate>
    <FooterTemplate>
        </div>
    </FooterTemplate>
</asp:Repeater>
