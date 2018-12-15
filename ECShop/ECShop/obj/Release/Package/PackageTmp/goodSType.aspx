<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodSType.aspx.cs" Inherits="Ecshop.goodSType" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品小类别</title>
    <link href="styles/general.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        td
        {
            text-align: center;
        }
        th
        {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form runat="server">
    <h1>
        <span class="action-span1"><a href="main.aspx">ECSHOP 管理中心</a></span><span id="search_id"class="action-span1"> - 商品小类别 </span>
        <div style="clear: both">
        </div>
    </h1>
    <!-- 商品搜索 -->
    <div class="form-div">
        </div>
            <asp:Button runat="server" ID="xsall" Text="显示所有小类别" OnClick="xsall_Click" />
            <asp:Button runat="server" ID="AddType" Text="小类别添加" OnClick="AddType_Click" />
    </div>
    <!-- 商品列表 -->
    <!-- start goods list -->
    <div class="list-div" id="listDiv">
        <%--<table cellpadding="3" cellspacing="1">--%>
            <asp:GridView ID="show" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="小类别" DataField="BLName" />
                    <asp:BoundField HeaderText="大类别" DataField="Name" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <a href="goodSTypeEdit.aspx?bsid=<%# Eval("BSID") %>"><img src="images/icon_edit.gif" title="编辑" /></a>
                            <a href="#" onclick=""><asp:ImageButton runat="server" ID="ImageButton1" CommandName="sc" ImageUrl="~/images/icon_trash.gif" ToolTip="回收站" CommandArgument='<%# Eval("BSID") %>'  OnCommand="del_Command" /></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        <%--</table>--%>
        <!-- end goods list -->
    </div>
        </form>
    </form>
        </body>
</html>
