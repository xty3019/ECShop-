﻿<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Index.aspx.cs" Inherits="Ecshop.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ECSHOP 管理中心</title>
    <link href="styles/Top.css" rel="stylesheet" />
    <link href="styles/Index.css" rel="stylesheet" />
    <style type="text/css">
        #div {
            width: 94px;
            height: 229px;
            margin-top: 29px;
        }
    </style>
    <link href="styles/Top.css" rel="stylesheet" />
    <link href="styles/Index.css" rel="stylesheet" />
    <style type="text/css">
        #div {
            width: 94px;
            height: 229px;
            margin-top: 29px;
        }
    </style>
</head>
    <form runat="server">

                    <frameset rows="52,*" framespacing="0" border="0">
                    <frame src="top.aspx" id="header-frame" name="header-frame" frameborder="no" scrolling="no" />
                                <frameset cols="180, 10, *" framespacing="0" border="0" id="frame-body">
                                <frame src="menu.aspx" id="menu-frame" name="menu-frame" frameborder="no" scrolling="yes">
                                <frame src="drag.aspx" id="drag-frame" name="drag-frame" frameborder="no" scrolling="no">
                                <frame src="main.aspx" id="main-frame" name="main-frame" frameborder="no" scrolling="yes">
                    </frameset>
                    </frameset>
</form>
</html>

