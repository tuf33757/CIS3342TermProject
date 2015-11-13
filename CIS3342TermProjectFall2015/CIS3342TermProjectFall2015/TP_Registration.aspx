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
    <title>Register Customer</title>
</head>
<body>
    <%--   <form id="form2" runat="server">--%>
    <div id="fullscreen_bg" class="fullscreen_bg" />
    <div class="container">
        <div id="register">
            <form class="form-register" runat="server">
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

                <div>
                    <h3>Shipping Information</h3>
                    <asp:Label ID="lblshipStreet1" runat="server" Text="Street 1: "></asp:Label>
                    <asp:TextBox ID="txtshipStreet1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblshipStreet2" runat="server" Text="Street 2: "></asp:Label>
                    <asp:TextBox ID="txtshipStreet2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblshipCity" runat="server" Text="City: "></asp:Label>
                    <asp:TextBox ID="txtshipCity" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblshipState" runat="server" Text="State: "></asp:Label>
                    <asp:DropDownList ID="ddlshipState" runat="server">
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NV</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>TX</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="lblshipZip" runat="server" Text="Zip Code: "></asp:Label>
                    <asp:TextBox ID="txtshipZip" runat="server"></asp:TextBox>
                </div>

                <div>
                    <h3>Billing Information</h3>
                    <asp:Label ID="lblsameBilling" runat="server" Text="Same as Shipping"></asp:Label>
                    <asp:CheckBox ID="cbBilling" runat="server" OnCheckedChanged="cbBilling_CheckedChanged" />
                    <br />
                    <br />
                    <asp:Label ID="lblbillStreet1" runat="server" Text="Street 1: "></asp:Label>
                    <asp:TextBox ID="txtbillStreet1" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblbillStreet2" runat="server" Text="Street 2: "></asp:Label>
                    <asp:TextBox ID="txtbillStreet2" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblbillCity" runat="server" Text="City: "></asp:Label>
                    <asp:TextBox ID="txtbillCity" runat="server"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Label ID="lblbillState" runat="server" Text="State: "></asp:Label>
                    <asp:DropDownList ID="ddlbillState" runat="server">
                        <asp:ListItem>AK</asp:ListItem>
                        <asp:ListItem>AL</asp:ListItem>
                        <asp:ListItem>AR</asp:ListItem>
                        <asp:ListItem>AZ</asp:ListItem>
                        <asp:ListItem>CA</asp:ListItem>
                        <asp:ListItem>CO</asp:ListItem>
                        <asp:ListItem>CT</asp:ListItem>
                        <asp:ListItem>DE</asp:ListItem>
                        <asp:ListItem>FL</asp:ListItem>
                        <asp:ListItem>GA</asp:ListItem>
                        <asp:ListItem>HI</asp:ListItem>
                        <asp:ListItem>IA</asp:ListItem>
                        <asp:ListItem>ID</asp:ListItem>
                        <asp:ListItem>IL</asp:ListItem>
                        <asp:ListItem>IN</asp:ListItem>
                        <asp:ListItem>KS</asp:ListItem>
                        <asp:ListItem>KY</asp:ListItem>
                        <asp:ListItem>LA</asp:ListItem>
                        <asp:ListItem>MA</asp:ListItem>
                        <asp:ListItem>MD</asp:ListItem>
                        <asp:ListItem>ME</asp:ListItem>
                        <asp:ListItem>MI</asp:ListItem>
                        <asp:ListItem>MN</asp:ListItem>
                        <asp:ListItem>MO</asp:ListItem>
                        <asp:ListItem>MS</asp:ListItem>
                        <asp:ListItem>MT</asp:ListItem>
                        <asp:ListItem>NC</asp:ListItem>
                        <asp:ListItem>ND</asp:ListItem>
                        <asp:ListItem>NE</asp:ListItem>
                        <asp:ListItem>NH</asp:ListItem>
                        <asp:ListItem>NJ</asp:ListItem>
                        <asp:ListItem>NM</asp:ListItem>
                        <asp:ListItem>NV</asp:ListItem>
                        <asp:ListItem>NY</asp:ListItem>
                        <asp:ListItem>OH</asp:ListItem>
                        <asp:ListItem>OK</asp:ListItem>
                        <asp:ListItem>OR</asp:ListItem>
                        <asp:ListItem>PA</asp:ListItem>
                        <asp:ListItem>RI</asp:ListItem>
                        <asp:ListItem>SC</asp:ListItem>
                        <asp:ListItem>SD</asp:ListItem>
                        <asp:ListItem>TN</asp:ListItem>
                        <asp:ListItem>TX</asp:ListItem>
                        <asp:ListItem>UT</asp:ListItem>
                        <asp:ListItem>VA</asp:ListItem>
                        <asp:ListItem>VT</asp:ListItem>
                        <asp:ListItem>WA</asp:ListItem>
                        <asp:ListItem>WI</asp:ListItem>
                        <asp:ListItem>WV</asp:ListItem>
                        <asp:ListItem>WY</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    <asp:Label ID="lblbillZip" runat="server" Text="Zip Code: "></asp:Label>
                    <asp:TextBox ID="txtbillZip" runat="server"></asp:TextBox>
                </div>
            </form>
        </div>

    </div>
</body>
</html>
