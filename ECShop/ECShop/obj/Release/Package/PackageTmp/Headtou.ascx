<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Headtou.ascx.cs" Inherits="ECShop.Head" %>
<link href="css/style.css" rel="stylesheet" />
 <div class="block clearfix">
        <div class="f_l">
            <a name="top" href="Main.aspx">
                <img src="images/logo.gif"></a></div>
        <div class="f_r log">
            <ul>
                <li class="userInfo">
                    <font id="ECS_MEMBERZONE">
                    <div id="append_parent"></div> 
                        <asp:Label runat="server" ID="lbuser"></asp:Label>
                        
                        <%--<a href="Login.aspx">
                            <img src="images/bnt_log.gif" class="auto-style1">
                        </a> --%>
                        
                    <%--<a href="Login.aspx">
                            <img src="images/bnt_reg.gif">
                    </a>--%>
                        <asp:Button runat="server" ID="btnReg" CssClass="btnReg" OnClick="btnReg_Click" />
                        <asp:Button runat="server" ID="btnLog" CssClass="btnLog" OnClick="btnLog_Click" />
                        <asp:Button runat="server" ID="btnClear" Text="退出" OnClick="btnClear_Click" Visible="false" />
                    </font>
                </li>
            </ul>
        </div>
    </div>
