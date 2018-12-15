<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ECShop.Login" %>

<%@ Register Src="~/HeadDaohang.ascx" TagPrefix="uc1" TagName="HeadDaohang" %>
<%@ Register Src="~/Headtou.ascx" TagPrefix="uc1" TagName="Headtou" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    </head>
<body>
    <form id="form1" runat="server">
    
        <uc1:Headtou runat="server" ID="Headtou" />
    <div class="blank">
    </div>
    
        <uc1:HeadDaohang runat="server" ID="HeadDaohang" />
    <div class="clearfix" id="search">
        
        <p class="auto-style1" style="float:right">
        书名:<input type="text" runat="server" maxlength="30" style="width: 110px;" class="B_input" value="" id="keyword"
            name="keywords">
        <asp:Button runat="server" ID="btnSel" style="cursor: pointer;"  CssClass="go" OnClick="btnSel_Click" ValidationGroup="Sel" />
        </p>
        
    </div>
    <div class="block">
        <div class="flowBox">
            <table align="center" width="99%" cellspacing="1" cellpadding="5" border="0" bgcolor="#dddddd">
                <tbody>
                    <tr>
                        <td width="50%" valign="top" bgcolor="#ffffff">
                            <h6>
                                <span>用户登录：</span></h6>
                            
                            <table width="90%" cellspacing="1" cellpadding="8" border="0" bgcolor="#B0D8FF" class="table">
                                <tbody>
                                    <tr>
                                        <td bgcolor="#ffffff">
                                            <div align="right">
                                                <strong>用户名</strong></div>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="text" runat="server" id="txtname" class="inputBg" name="username">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtname" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="log"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td bgcolor="#ffffff">
                                            <div align="right">
                                                <strong>密码</strong></div>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="password" id="txtpwd" runat="server" class="inputBg" name="password" />
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpwd" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="log"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td bgcolor="#ffffff" colspan="2">
                                            <div align="center">
                                                <asp:Button ID="btnlog" runat="server" Text="登录" CssClass="bnt_blue" OnClick="btnlog_Click" ValidationGroup="log" />
                                            </div>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                            
                        </td>
                        <td valign="top" bgcolor="#ffffff">
                            <h6>
                                <span>用户注册：</span></h6>
                            
                            <table width="98%" cellspacing="1" cellpadding="8" border="0" bgcolor="#B0D8FF" class="table" >
                                <tbody>
                                    <tr>
                                        <td align="right" width="25%" bgcolor="#ffffff">
                                            <strong>用户名</strong>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="text" id="username" class="inputBg" name="username" runat="server">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="username" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" bgcolor="#ffffff">
                                            <strong>电子邮件地址</strong>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="text" id="txtemail" class="inputBg" name="email" runat="server">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemail" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" bgcolor="#ffffff">
                                            <strong>密码</strong>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="password" id="password1" class="inputBg" name="password" runat="server">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password1" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="right" bgcolor="#ffffff">
                                            <strong>确认密码</strong>
                                        </td>
                                        <td bgcolor="#ffffff">
                                            <input type="password" id="confirm_password" class="inputBg" name="confirm_password" runat="server">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="confirm_password" ErrorMessage="不能为空" Font-Size="8pt" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" bgcolor="#ffffff" colspan="2">
                                            <asp:Button runat="server" ID="btn_Reg" Text="注册新用户" CssClass="bnt_blue_1" OnClick="btn_Reg_Click" ValidationGroup="reg" />
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </td>
                    </tr>
                </tbody>
            </table>
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
