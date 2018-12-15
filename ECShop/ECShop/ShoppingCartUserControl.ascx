<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ShoppingCartUserControl.ascx.cs" Inherits="EcShopUI.UserControl.ShoppingCartUserControl" %>
<link href="css/style.css" rel="stylesheet" />
<div id="ECS_CARTINFO" class="cart">
    <asp:LinkButton ID="LookFlow" runat="server" ToolTip="查看购物车" PostBackUrl="~/flow.aspx"></asp:LinkButton>
</div>