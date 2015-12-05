<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Merchant_Registration.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Merchant_Registration" %>

<%@ Register Src="~/themeMusic.ascx" TagPrefix="uc1" TagName="themeMusic" %>


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
    <link href="css/MerchantRegistration.css" rel="stylesheet" />

    <title>Register Merchant</title>
</head>
<body>
    <br /><br />
    <div class="container">
        <uc1:themeMusic runat="server" id="themeMusic" />
        <div id="registerMerch" class="register" runat="server">
            <form id="Form3" class="form-register-merch" runat="server">
                
                <h1 class="form-register-heading text-muted">Merchant Registration</h1>
                <br />
                <h3>Login Information</h3>
                <asp:Label ID="lblLoginId" Text="Username:" runat="server"></asp:Label>
                <asp:TextBox ID="txtLoginId" Text="" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblEmail" runat="server" Text="Email Address: "></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <h3>Store Information</h3>
                <asp:Label ID="lblStoreName" runat="server" Text="Store Name: "></asp:Label>
                <asp:TextBox ID="txtStoreName" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblStoreDescrip" runat="server" Text="Store Description: "></asp:Label>
                <br />
                <asp:TextBox ID="txtStoreDescription" runat="server" Height="100px" Width="349px" ForeColor="#66FF33" BackColor="#0F3D0F" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblOwnerFirstName" runat="server" Text="Owner First Name: "></asp:Label>
                <asp:TextBox ID="txtFirstName" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="lblOwnerLastName" runat="server" Text="Owner Last Name: "></asp:Label>
                <asp:TextBox ID="txtLastName" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" BorderColor="Black"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnSubmitMerch" runat="server" CssClass="greenbutton" Text="Submit" OnClick="btnSubmitMerch_Click" />
                 <asp:Button ID="btnCalcel" runat="server" CssClass="greenbutton" Text="Clear" OnClick="btnCalcel_Click" />
                <br /><br />
                <asp:Label ID="lblInform" runat="server" Text=""></asp:Label><br /><br />
                <asp:Label ID="lblAPI" runat="server" Text=""></asp:Label>
            </form>
        </div>
    </div>
</body>
</html>
