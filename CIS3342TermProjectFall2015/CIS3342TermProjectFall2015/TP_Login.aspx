<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_Login.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_Login" %>


<%@ Register Src="~/themeMusic.ascx" TagPrefix="uc1" TagName="themeMusic" %>



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
    <form id="Form1" class="form-signin" runat="server">
        <%-- <form id="form1" runat="server">--%>



        <div class="container">
            <br />
            <br />
            <div id="topbanner" class="topBanner" runat="server">
                <h1>Apocalypse Trading Company</h1>
                <p1>Where your bottle caps spend</p1>
                <br />
                <p2>    as well as your dollars!</p2>
            </div>

            <div id="comments" class="comments" runat="server">
                <div id="commentbox" class="commentbox" runat="server">
                    <asp:Panel ID="pnlComments" runat="server">
                        <br />
                        <br />
                        <p1>Don't sweat the little stuff, it's only the end of the world!</p1>
                        <br />
                        <p2>--Co-Founder and Totally RAD Dude Rob Zahorchak</p2>
                        <br />
                        <br />
                        <p1>Something something the world is ending something this is a</p1>
                        <br />
                        <p1> quote. I have to code now.</p1>
                        <br />
                        <p2>--Co-Founder Tracey Harrison</p2>
                        <br />
                        <br />

                        <p1>This place doesn't pull it's punches!</p1>
                        <br />
                        <p2>--Mr. Fisty</p2>
                        <br />
                        <br />
                        <p1>They do good work!</p1>
                        <p2>--Life long user Mox</p2>
                    </asp:Panel>
                    <asp:Panel ID="pnlForgotEmail" runat="server" CssClass="pnlForgotEmail">
                        <asp:Label ID="lblForgotMessage" Text="" runat="server" ForeColor="#66FF33"></asp:Label>
                        <asp:Label ID="lblForgotUserName" Text="Username:" runat="server" ForeColor="#66FF33"></asp:Label>
                        <asp:TextBox ID="txtForgotUserName" Text="" CssClass="form-control" runat="server" Width="227px"></asp:TextBox>
                        <br />
                        <asp:Button ID="btnRequest" Text="Request Password" runat="server" CssClass="greenbuttonLarge" OnClick="btnRequest_Click" />
                        <asp:Button ID="btnRequestCancel" Text="Cancel" runat="server" CssClass="greenbutton" OnClick="btnRequestCancel_Click" />

                    </asp:Panel>
                </div>

                <uc1:themeMusic runat="server" id="themeMusic" />

            </div>


            <div id="signin">

                <h1 class="form-signin-heading">Login:</h1>
                <asp:Label ID="lblError" Text="" runat="server"></asp:Label>
                <br />
                <asp:Label ID="lblLoginId" Text="Email Address:" runat="server"></asp:Label>
                <asp:TextBox ID="txtLoginId" Text="" CssClass="form-control" runat="server"></asp:TextBox>
                <asp:Label ID="lblPassword" Text="Password" runat="server"></asp:Label>
                <asp:TextBox ID="txtPassword" Text="" CssClass="form-control" runat="server"></asp:TextBox>
                <br />
                <asp:Button ID="btnForgotPass" Text="Forgot Password" runat="server"
                    BackColor="Transparent" ForeColor="#66FF33" BorderColor="Transparent" BorderStyle="None" Width="115px" OnClick="btnForgotPass_Click" /><br />
                <asp:Button ID="btnSubmit" Text="Login" runat="server" CssClass="greenbutton" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" Text="Cancel" runat="server" CssClass="greenbutton" OnClick="btnCancel_Click" />
                <br />
                <asp:Label ID="lblRemember" Text="Remember me:" runat="server"></asp:Label><asp:CheckBox ID="chkRemember" Checked="true" runat="server" />
                <br />
                <br />
                <asp:Label ID="lblRegistration" Text="Register for a New Account:" runat="server"></asp:Label>
                <asp:Button ID="btnRegister" Text="New Account" runat="server" CssClass="greenbuttonLarge" OnClick="btnRegister_Click" /><br />
                <asp:Label ID="lblMerchant" Text="Register for a Merchant Account:" runat="server"></asp:Label>
                <asp:Button ID="btnMerchantRegister" Text="New Partner" runat="server" CssClass="greenbuttonLarge" OnClick="btnMerchantRegister_Click" />
            </div>

        </div>
    </form>

</body>
</html>
