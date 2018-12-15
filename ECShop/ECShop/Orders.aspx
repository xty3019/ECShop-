<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="Ecshop.Orders" enableEventValidation="false" %>

<%@ Register assembly="AspNetPager" namespace="Wuqi.Webdiyer" tagprefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>订单列表</title>
    <link href="styles/demo.css" rel="stylesheet" />
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
        <span class="action-span1"><a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id"class="action-span1">- 订单列表 </span>
        <div style="clear: both">
        </div>
    </h1>
    <!-- 商品搜索 -->
    <div class="form-div">
        <div>
        订单号
            <asp:TextBox runat="server" ID="ordernumber"></asp:TextBox>
        收货人
            <asp:TextBox runat="server" ID="orderRen"></asp:TextBox>
            <asp:Button runat="server" ID="sousuo" Text="搜索" OnClick="sousuo_Click" />
        </div>
    </div>
    <!-- 商品列表 -->
    <!-- start goods list -->
    <div class="list-div" id="listDiv">
            <asp:GridView runat="server" ID="show" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField HeaderText="订单号" DataField="OID" />
                    <asp:BoundField HeaderText="订单时间" DataField="ODate" />
                    <asp:BoundField HeaderText="收货人" DataField="OConsignee" />
                    <asp:BoundField HeaderText="总金额" DataField="OSumPrice" />
                    <asp:TemplateField HeaderText="操作">
                        <ItemTemplate>
                            <a href="OrderDetail.aspx?uid=<%# Eval("OID") %>"><image><img src="images/icon_view.gif" title="查看" /></image></a>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="订单状态">
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("DingDanZhuanTai") %>'></asp:Label>
                            &nbsp;
                            <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("OID") %>' OnClick="Button1_Click" OnLoad="Button1_Load" Text='<%# Eval("ButZhuangTai") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        <!-- end goods list -->
        <!-- 分页 -->
        <table id="page-table" cellspacing="0">
            <tr>
                <td align="right" nowrap="true">
                   <div  id="turn-page">
                       <webdiyer:AspNetPager runat="server" ID="fenye" OnPageChanging="fenye_PageChanging" UrlPaging="True"></webdiyer:AspNetPager>
                        <webdiyer:AspNetPager ID="fy" runat="server" UrlPaging="True" CssClass="paginator">
                        </webdiyer:AspNetPager>
                </div>

                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
