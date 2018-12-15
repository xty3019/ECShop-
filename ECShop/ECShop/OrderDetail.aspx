<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="Ecshop.OrderDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>订单信息</title>
        <link href="styles/general.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
    <h1>
        <span class="action-span"><a href="Orders.aspx">订单列表</a></span> <span class="action-span1">
            <a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id" class="action-span1">
                - 订单信息 </span>
        <div style="clear: both">
        </div>
    </h1>
    <div class="list-div" style="margin-bottom: 5px">
        <table width="100%" cellpadding="3" cellspacing="1">
            <tr>
                <th colspan="4">
                </th>
            </tr>
            <tr>
                <td width="18%">
                    <div align="right">
                        <strong>订单号：</strong></div>
                </td>
                <td width="34%">
                    <asp:Label runat="server" ID="orderid"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="orderid" ReadOnly="true"></asp:TextBox>--%>
                </td>
                <td width="15%">
                    <div align="right">
                        <strong>订单状态：</strong></div>
                </td>
                <td>
                    <asp:Label runat="server" ID="newOrder"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="newOrder" ReadOnly="true"></asp:TextBox>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <div align="right">
                        <strong>收货人：</strong></div>
                </td>
                <td>
                    <asp:Label runat="server" ID="name"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="name" ReadOnly="true"></asp:TextBox>--%>
                </td>
                <td>
                    <div align="right">
                        <strong>订单时间：</strong></div>
                </td>
                <td>
                    <asp:Label runat="server" ID="times"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="times" ReadOnly="true"></asp:TextBox>--%>
                </td>
            </tr>
            <tr>
                <td>
                    <div align="right">
                        <strong>送货地址：</strong></div>
                </td>
                <td>
                    <asp:Label runat="server" ID="address"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="address" ReadOnly="true"></asp:TextBox>--%>
                </td>
                <td>
                    <div align="right">
                        <strong>联系电话：</strong></div>
                </td>
                <td>
                    <asp:Label runat="server" ID="tel"></asp:Label>
                    <%--<asp:TextBox runat="server" ID="tel" ReadOnly="true"></asp:TextBox>--%>
                </td>
            </tr>
        </table>
    </div>
    <div class="list-div" style="margin-bottom: 5px">
        <div style="text-align:center">
                    商品信息
        </div>
            <asp:GridView ID="show" runat="server" AutoGenerateColumns="False" BorderColor="White">
            <Columns>
                <asp:BoundField HeaderText="订单号" DataField="OID" />
                <asp:BoundField HeaderText="书籍编号" DataField="BID" />
                <asp:BoundField HeaderText="价格" DataField="OSumPrice" />
                <asp:BoundField HeaderText="数量" DataField="BCount" />
            </Columns>
        </asp:GridView>
        <div  class="list-div" style="margin-bottom: 5px; height: 27px;">
            
            <div style=" float:right; margin-left: 144px; padding-right:210px;"><asp:Label runat="server" ID="price"></asp:Label></div>
            <div style=" float:right; padding-right:30px;">合计： </div>
        </div>
            <%--<tr>
                <td scope="col">
                    <div align="center">
                        <strong>订单号</strong></div>
                </td>
                <td scope="col">
                    <div align="center">
                        <strong>书籍编号</strong></div>
                </td>
                <td scope="col">
                    <div align="center">
                        <strong>价格</strong></div>
                </td>
                <td scope="col">
                    <div align="center">
                        <strong>数量</strong></div>
                </td>
            </tr>
            <tr>
                <td align="center">
                    DD20120305
                </td>
                <td align="center">
                    4939
                </td>
                <td>
                    <div align="right">
                        ￥50.00元</div>
                </td>
                <td>
                    <div align="right">
                        1
                    </div>
                </td>
            </tr>
            <tr>
                <td align="center">
                    DD20120305
                </td>
                <td align="center">
                    4942
                </td>
                <td>
                    <div align="right">
                        ￥50.00元</div>
                </td>
                <td>
                    <div align="right">
                        1
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    <div align="right">
                        <strong>合计：</strong></div>
                </td>
                <td>
                    <div align="right">
                        ￥100.00元</div>
                </td>
            </tr>--%>
    </div>
    </form>
        </form>
</body>
</html>
