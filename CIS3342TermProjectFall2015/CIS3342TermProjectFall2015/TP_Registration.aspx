<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Registration.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Registration" %>

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
    <link href="css/RegistrationStyle.css" rel="stylesheet" />
    <title>Register</title>
</head>
<body>
    <form id="form2" runat="server">
        <div id="fullscreen_bg" class="fullscreen_bg" />
        <div class="container">
            <div id="register">
                <form class="form-register">
                    <h1 class="form-register-heading text-muted">Customer Registration</h1>
                    <br />
                    <h3>Login Information</h3>
                    <asp:Label ID="lblLoginId" Text="Username:" runat="server"></asp:Label>
                    <asp:TextBox ID="txtLoginId" Text="" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblEmail" runat="server" Text="Email Address: "></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblPassword" Text="Password" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPassword" Text="" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblPasswordConfirm" Text="Confirm Password" runat="server"></asp:Label>
                    <asp:TextBox ID="txtPasswordConfirm" Text="" runat="server"></asp:TextBox>

                    <h3>Shipping Information</h3>
                    <asp:Label ID="lblStreet1" runat="server" Text="Street 1: "></asp:Label>
                    <asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblStreet2" runat="server" Text="Street 2: "></asp:Label>
                    <asp:TextBox ID="txtStreet2" runat="server"></asp:TextBox>
                </form>
            </div>
        </div>
    </form>
</body>
</html>
