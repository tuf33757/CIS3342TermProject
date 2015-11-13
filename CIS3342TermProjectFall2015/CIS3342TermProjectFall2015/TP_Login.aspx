<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Login.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">

    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/jquery-2.1.4.min.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>

    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />

    <link href="css/LoginStyle.css" rel="stylesheet" />

    <title>Login</title>
</head>

<body >
    
    <%-- <form id="form1" runat="server">--%>

    

    <div class="container">
        <br />
        <br />
        <div id="topbanner" class="topBanner" runat="server">
           <h1> Apocalpse Trading Company</h1>
            <p1>Where your bottle caps spend</p1><br />
             <p2>    as well as your dollars!</p2>
        </div>
        <div id="comments" class="comments" runat="server">
            test
        </div>
        <div id="signin" >
            <form class="form-signin" runat="server">
                <h1 class="form-signin-heading">Login Page</h1>
                <asp:Label ID="lblError" Text="" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblLoginId" Text="Username:" runat="server"></asp:Label>
                <asp:TextBox ID="txtLoginId" Text="" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Label ID="lblPassword" Text="Password" runat="server"></asp:Label>
                <asp:TextBox ID="txtPassword" Text="" CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnSubmit" Text="Login" runat="server" CssClass="greenbutton" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" Text="Cancel" runat="server" CssClass="greenbutton" />
                <br />
                <asp:Label ID="lblRemember" Text="Remember me:" runat="server"></asp:Label><asp:CheckBox ID="chkRemember" Checked="true" runat="server" />
                <br />
                <br />
                <asp:Label ID="lblRegistration" Text="Register for a New Account:" runat="server"></asp:Label>
                <asp:Button ID="btnRegister" Text="New Account" runat="server" CssClass="greenbuttonLarge" OnClick="btnRegister_Click" />

            </form>
        </div>
    </div>
</body>
</html>
