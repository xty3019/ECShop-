<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodAdd.aspx.cs" Inherits="Ecshop.goodAdd" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>添加商品信息</title>
    <script src="js/jquery-3.2.1.js"></script>
    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/jquery-3.3.1.min.js"></script>
    <link href="styles/general.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
<h1>
<span class="action-span">
    <a href="goods.aspx">商品列表</a>
</span>
<span class="action-span1"><a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id" class="action-span1"> - 添加商品信息 </span>
<div style="clear:both"></div>
</h1>

<!-- start goods form -->
<div class="tab-div">
    <!-- tab bar -->
    <div id="tabbar-div">
      <p>
        <span class="tab-front" id="general-tab">通用信息</span>
      </p>
    </div>
    <!-- tab body -->
    <div id="tabbody-div">
      <form enctype="multipart/form-data" action="" method="post" name="theForm">
        <!-- 通用信息 -->
        <table width="90%" id="general-table" align="center">
          <tr>
            <td class="label">商品名称：</td>
            <td>
                <asp:TextBox runat="server" ID="goods_name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="goods_name" ForeColor="Red" ErrorMessage="不能为空"></asp:RequiredFieldValidator>
                <%--<asp:RequiredFieldValidator ID="name" runat="server" ForeColor="Red" ControlToValidate="goods_name" Text="不能为空" ErrorMessage="不能为空"></asp:RequiredFieldValidator>--%>
            </td>
          </tr>
          <tr>
            <td class="label">
                商品货号：</td>
            <td>
                <asp:TextBox runat="server" ID="goods_sn"></asp:TextBox>
                <asp:RequiredFieldValidator ID="sn" runat="server" ForeColor="Red" ControlToValidate="goods_sn" Text="不能为空"></asp:RequiredFieldValidator>
             </td>
          </tr>
            <tr>
                <td class="label">作者姓名:</td>
                <td>
                    <asp:TextBox runat="server" ID="zz"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="zzname" runat="server" ForeColor="Red" ControlToValidate="goods_sn" Text="不能为空"></asp:RequiredFieldValidator>
                </td>
            </tr>
          <tr>
            <td class="label">商品小类：</td>
            <td>
                <asp:DropDownList runat="server" ID="list">
                </asp:DropDownList></td>
          </tr>
          <tr>
            <td class="label">商品价格：</td>
            <td>
                <asp:TextBox runat="server" ID="shop_price"></asp:TextBox>
                <asp:RequiredFieldValidator ID="price" runat="server" ForeColor="Red" ControlToValidate="shop_price" Text="不能为空"></asp:RequiredFieldValidator>
            </td>
          </tr>
          <tr>
            <td class="label">上传商品图片：</td>
            <td>
                <asp:FileUpload runat="server" ID="goods_img" />
            </td>
          </tr>
          <tr>
            <td class="label">商品库存：</td>
            <td>
                <asp:TextBox runat="server" ID="shop_count"></asp:TextBox>
            </td>
          </tr>
        </table>
        <div class="button-div">
            <asp:Button runat="server" ID="submit" Text="确定" OnClick="submit_Click" />
            <asp:Button runat="server" ID="reset" Text="重置" OnClick="reset_Click" />
        </div>
      </form>
    </div>
</div>
<!-- end goods form -->
        </form>
</body>
</html>

