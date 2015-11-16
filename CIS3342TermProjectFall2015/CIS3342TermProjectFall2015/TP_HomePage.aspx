<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_HomePage.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/LoginStyle.css" rel="stylesheet" />
</head>
<body>
    <div class="container">
        <br />
        <br />
        <div id="topbanner" class="topBanner" runat="server">
            <h1>Apocalypse Trading Company</h1>
            <p1>Where your bottle caps spend</p1>
            <br />
            <p2>    as well as your dollars!</p2>
            <br />
            <asp:Label ID="lblWelcome" Text="" runat="server"></asp:Label>

        </div>
        <div id="comments" class="comments" runat="server">
            <div id="commentbox" class="commentbox" runat="server">
                <br />
                <br />
                <asp:DropDownList ID="ddDepartment" runat="server"></asp:DropDownList>
            </div>
        </div>
</body>
</html>
