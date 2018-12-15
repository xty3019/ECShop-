<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="goodLType.aspx.cs" Inherits="Ecshop.goodLType" EnableEventValidation="false"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品大类别</title>
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
        <span class="action-span"><a href="goodAdd.aspx">添加小类别</a></span> <span class="action-span1">
            <a href="main.aspx">ECSHOP 管理中心</a> </span><span id="search_id" class="action-span1">
                - 商品大类别 </span>
        <div style="clear: both">
        </div>
    </h1>
    <!-- 商品搜索 -->
    <div class="form-div">
        </div>
        商品大类别
            <asp:TextBox runat="server" ID="name"></asp:TextBox>
            <asp:Button runat="server" ID="add" Text="添加" OnClick="add_Click" />
    </div>
    <!-- 商品列表 -->
    <!-- start goods list -->
    <div class="list-div" id="listDiv">
        <table cellpadding="3" cellspacing="1">
            <tr>
                 <asp:GridView ID="Blgrivew" runat="server" AutoGenerateColumns="False" DataKeyNames="BLID"

            OnRowCancelingEdit="Blgrivew_RowCancelingEdit"
               
            OnRowUpdating="Blgrivew_RowUpdating1"

            OnRowEditing="Blgrivew_RowEditing"
               
             >

            <Columns>

                <asp:TemplateField HeaderText="编号">

                    <ItemTemplate>

                        <asp:Label Text='<%# Eval("BLID") %>' runat="server"></asp:Label>

                    </ItemTemplate>

                    <EditItemTemplate>

                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("BLID") %>' ></asp:TextBox>

                    </EditItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="大类别名称">

                    <ItemTemplate>

                        <%# DataBinder.Eval(Container.DataItem,"BLName") %>

                    </ItemTemplate>

                    <EditItemTemplate>

                        <asp:TextBox ID="TextBox2" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"BLName") %>'></asp:TextBox>

                    </EditItemTemplate>

                </asp:TemplateField>

                <asp:TemplateField HeaderText="操作">

                    <ItemTemplate>
                   <asp:ImageButton ID="updatethreebtn" runat="server"  ImageUrl="images/icon_edit.gif" CommandName="Edit" />
                   <a href="#" onclick=""><asp:ImageButton runat="server" ID="del" CommandName="sc" OnClientClick="return confirm('你确定要删除吗')" ImageUrl="~/images/icon_trash.gif" ToolTip="回收站" CommandArgument='<%# Eval("BLID") %>' OnCommand="del_Command"  /></a>
                   <asp:ImageButton ID="selectBsbtn" runat="server"  ImageUrl="images/icon_view.gif"  OnClick="selectBsbtn_Click" CommandArgument='<%#Eval("BLID") %> ' />
                    </ItemTemplate>

                    <EditItemTemplate>

                        <asp:LinkButton ID="Button1" runat="server" Text="更新" CommandName="Update" />

                        <asp:LinkButton ID="Button3" runat="server" Text="取消" CommandName="Cancel" />

                    </EditItemTemplate>

                </asp:TemplateField>

            </Columns>

        </asp:GridView>

                <%--<th>
                    大类别名称
                </th>
                <th>
                    操作
                </th>
                <tr>
                    <tr>
                        <td>
                            软件类
                        </td>
                        <td align="center">
                            <a href="#" title="编辑">
                                <img src="images/icon_edit.gif" width="16" height="16" border="0" /></a> <a onclick="javascript:confirm('你确定要删除吗')"
                                    title="回收站">
                                    <img src="images/icon_trash.gif" width="16" height="16" border="0" /></a>
                            <a href="goodSType.htm" title="查看小类别">
                                <img src="images/icon_view.gif" width="16" height="16" border="0" /></a>
                        </td>--%>
                    </tr>
        </table>
        <!-- end goods list -->
    </div>
    </form>
        </form>
</body>
</html>
