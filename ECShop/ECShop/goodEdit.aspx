<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodEdit.aspx.cs" Inherits="Ecshop.goodEdit" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>编辑商品信息</title>
    <script src="js/jquery-3.3.1.min.js"></script>
    <link href="styles/general.css" rel="stylesheet" type="text/css" />
    <link href="styles/main.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .auto-style1 {
            width: 36px;
        }
    </style>
</head>
<body>
    <form runat="server">
<h1>
<span class="action-span"><a href="goods.aspx">商品列表</a></span>
<span class="action-span1"><a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id" class="action-span1"> - 编辑商品信息 </span>
<div style="clear:both"></div>
</h1>

<!-- start goods form -->
<div class="tab-div">
    <!-- tab bar -->
    <div id="tabbar-div">
      <p>
        <span class="tab-front" id="general-tab">通用信息</span><span
      </p>
    </div>

    <!-- tab body -->
    <div id="tabbody-div">
      <form enctype="multipart/form-data" action="" method="post" name="theForm">
        <!-- 通用信息 -->
        <table width="90%" id="general-table" align="center">
          <tr>
            <td class="label">商品名称：</td>
            <td class="auto-style1"><asp:TextBox runat="server" ID="goods_name"></asp:TextBox>
                
                <%--<input type="text" name="goods_name" value="Visual C#2005技术内幕" style="float:left;color:;" size="30" />--%>
          </tr>
          <tr>
            <td class="label">
             商品货号： </td>
            <td class="auto-style1"><asp:TextBox runat="server" ID="goods_sn"></asp:TextBox>
                <%--<input type="text" name="goods_sn" value="9787302144175" size="20" /><br />--%>
          </tr>
            <tr>
                <td class="label">作者姓名:</td>
                <td class="auto-style1"><asp:TextBox runat="server" ID="zz"></asp:TextBox></td>
            </tr>
          <tr>
            <td class="label">商品小类：</td>
            <td class="auto-style1"><asp:DropDownList runat="server" ID="list">
                <asp:ListItem>请选择</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>.NET</asp:ListItem>
                <asp:ListItem>ASP.NET</asp:ListItem>
                <asp:ListItem>穿越小说</asp:ListItem>
                </asp:DropDownList>
                <%--<select name="cat_id">
                <option value="0">请选择...</option>
                <option value="1" selected > C#</option>
                <option value="2" > .NET</option>
                <option value="3" > ASP.NET</option>
                <option value="4" > 穿越小说</option>
                </select>
                <span class="require-field">*</span>            --%></td>
          </tr>
          <tr>
            <td class="label">商品价格：</td>
            <td class="auto-style1"><asp:TextBox runat="server" ID="shop_price"></asp:TextBox>
                <%--<input type="text" name="shop_price" value="59.0000" size="20"/>--%>
          </tr>
          <tr>
            <td class="label">上传商品图片：</td>
              <td class="auto-style1"><asp:Image Width="80px" Height="70px" runat="server" ID="pics" /></td>
            <td><asp:FileUpload runat="server" ID="goods_img" />
            </td>
          </tr>
          <tr>
            <td class="label">商品库存：</td>
            <td class="auto-style1"><asp:TextBox runat="server" ID="shop_count"></asp:TextBox>
                <%--<input type="text" name="shop_count" value="0" size="20"/>--%>
          </tr>
        </table>
        <div class="button-div">
            <asp:Button runat="server" ID="submit" Text="确定" OnClick="submit_Click" />
            <asp:Button runat="server" ID="reset" Text="重置" OnClick="reset_Click" />
          <%--<input type="hidden" name="goods_id" value="32" />
                    <input type="submit" value=" 确定 " class="button" />
          <input type="reset" value=" 重置 " class="button" />--%>
        </div>
      </form>
    </div>
</div>
<!-- end goods form -->
        </form>
</body>
</html>

