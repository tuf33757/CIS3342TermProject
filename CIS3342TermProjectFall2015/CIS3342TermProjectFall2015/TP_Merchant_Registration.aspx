<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Merchant_Registration.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Merchant_Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="js/jquery-2.1.4.js"></script>
    <script src="js/jquery-2.1.4.min.js"></script>
    <%--   <script src="js/bootstrap.js"></script>
    <script src="js/bootstrap.min.js"></script>--%>

    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/LoginStyle.css" rel="stylesheet" />
    <link href="css/RegistrationStyle.css" rel="stylesheet" />
    <title>Register Merchant</title>
</head>
<body>
    <div class="container">
        <div id="registerMerch" style="background-color: white; opacity:.8; border-color: darkgreen" runat="server">
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
                <h3>Store Information</h3>
                <asp:Label ID="lblStoreName" runat="server" Text="Store Name: "></asp:Label>
                <asp:TextBox ID="txtStoreName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblStoreDescrip" runat="server" Text="Store Description: "></asp:Label>
                <br />
                <asp:TextBox ID="txtStoreDescription" runat="server" Height="100px" Width="349px"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblOwnerFirstName" runat="server" Text="Owner First Name: "></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblOwnerLastName" runat="server" Text="Owner Last Name: "></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnSubmitMerch" runat="server" Text="Submit" OnClick="btnSubmitMerch_Click" />
                <br /><br />
                <asp:Label ID="lblInform" runat="server" Text=""></asp:Label>
            </form>
        </div>
    </div>
</body>
</html>
