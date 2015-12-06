<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Admin_Page.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Admin_Page" %>

<%@ Register Src="~/MenuBar.ascx" TagPrefix="uc1" TagName="MenuBar" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/NavBarStyle.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:MenuBar runat="server" id="MenuBar" />
        </div>
    </form>
</body>
</html>
