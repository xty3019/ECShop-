<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Ecshop.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>管理员登陆</title>
    <style type="text/css">
        body
        {
            color: white;
            background: #278296;
            font-size:12px;
        }
    </style>
    <%--    验证码--%>
     <script type="text/javascript">
        function changePic() {
            document.getElementById("imagePic").src = 'YZM.aspx' + "?" + new Date();
         }
    </script>

    <%--<script type="text/javascript">
    function CheckPwd(Obj, args) {
        var pwd=args.Value;
        if (pwd.length > 6) {
            args.IsValid = true;
        }
        else {
            args.IsValid = false;
         }

     }

</script>--%>
    <%--    验证码--%>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table cellspacing="0" cellpadding="0" style="margin-top: 100px" align="center">
        <tr>
            <td>
                <img src="images/login.png" width="178" height="256" border="0" alt="ECSHOP" />
            </td>
            <td style="padding-left: 50px">
                <table>
                    <tr>
                        <td>
                            管理员姓名：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="username"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="username" ForeColor="Red" runat="server" ErrorMessage="请输入用户名"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            管理员密码：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="password" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ForeColor="Red" ControlToValidate="password" ErrorMessage="请输入密码"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            验证码：
                        </td>
                        <td>
                            <asp:TextBox runat="server" ID="yzm"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="yzm" ForeColor="Red" ErrorMessage="请输入验证码"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2" align="right">
                            <img id="imagePic" src="YZM.aspx" />
                            <a href="#" onclick="changePic()">看不清？点击更换另一个验证码。</a>
                           
                        </td>
                    </tr>
                    <tr>
                        <td>
                            &nbsp;
                        </td>
                        <td>
                            <asp:Button runat="server" ID="dl" Text="进入管理中心" OnClick="dl_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
