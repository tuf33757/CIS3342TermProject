<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Merchant_Registration.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Merchant_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="container">
        <div id="registerMerch">
            <form id="Form3" class="form-register-merch" runat="server">

                <h1 class="form-register-heading text-muted">Merchant Registration</h1>
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
                <br />

                <h3>Store Information</h3>
                <asp:Label ID="lblStoreName" runat="server" Text="Store Name: "></asp:Label>
                <asp:TextBox ID="txtStoreName" runat="server"></asp:TextBox>
                <br />
                <br />
            </form>
        </div>
    </div>
</body>
</html>
