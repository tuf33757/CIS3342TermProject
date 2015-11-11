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
<body>
    <form id="form1" runat="server">
    <div id="fullscreen_bg" class="fullscreen_bg"/>

<div class="container">
    <div id="signin">
	<form class="form-signin">
		<h1 class="form-signin-heading text-muted">Login Page</h1>
        <asp:Label ID="lblError" Text="" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lblLoginId" Text="Username:" runat="server"></asp:Label>
        <asp:TextBox ID ="txtLoginId" Text="" CssClass="form-control" runat="server" ></asp:TextBox>
		<asp:Label ID="lblPassword" Text="Password" runat="server"></asp:Label>
        <asp:TextBox ID ="txtPassword" Text="" CssClass="form-control" runat="server" ></asp:TextBox>
		<asp:Button ID ="btnSubmit" Text="Login" runat="server" CssClass="btn-group-sm" OnClick="btnSubmit_Click" />
        <asp:Button id="btnCancel" text="Cancel" runat="server" cssclass="btn-group-sm" />
		
	    <br />
        <br />
		<asp:Label ID="lblRegistration" Text="Register for a New Account:" runat="server"></asp:Label>
        <asp:Button ID="btnRegister" Text="New Account" runat="server" CssClass="btn-group-lg" />
	</form>
</div>
</div>
            
    </form>
</body>
</html>
