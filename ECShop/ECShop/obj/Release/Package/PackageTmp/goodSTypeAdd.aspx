<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodSTypeAdd.aspx.cs" Inherits="Ecshop.goodSTypeAdd" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加小类别</title>
    <link href="styles/general.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
    <h1>
        <span class="action-span"><a href="goodSType.aspx">商品小类别</a></span> <span class="action-span1">
            <a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id" class="action-span1">
                - 添加小类别 </span>
        <div style="clear: both">
        </div>
    </h1>
    <!-- start Type form -->
    <div class="tab-div">
        <!-- tab body -->
        <div id="tabbody-div">
            <form enctype="multipart/form-data" action="" method="post" name="theForm">
                <input type="hidden" name="goods_id" value="32" />
            <!-- 通用信息 -->
            <table width="90%" id="general-table" align="center">
                <tr>
                    <td class="label">
                        大类别名称：
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="list">
                        </asp:DropDownList>
                        <span class="require-field">*</span>
                </tr>
                <tr>
                    <td class="label">
                        小类别名称：
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="name"></asp:TextBox>
                        <span class="require-field">*</span><br />
                </tr>
            </table>
                <div class="button-div">
                <asp:Button runat="server" ID="tj" Text="确定" OnClick="tj_Click" />
                <asp:Button runat="server" ID="cz" Text="重置" OnClick="cz_Click" />
            </div>
            </form>
        </div>
    </div>
    <!-- end Type form -->
        </form>
</body>
</html>
