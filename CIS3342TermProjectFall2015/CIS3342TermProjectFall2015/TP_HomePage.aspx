<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_HomePage.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_HomePage" %>

<%@ Register Src="~/themeMusic.ascx" TagPrefix="uc1" TagName="themeMusic" %>
<%@ Register Src="~/MenuBar.ascx" TagPrefix="uc1" TagName="MenuBar" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <link href="css/HomePage.css" rel="stylesheet" />
    <script src="js/jquery-1.8.3.min.js"></script>
    <script src="js/jquery.elevateZoom-3.0.8.min.js"></script>
    <script src="js/jquery.elevatezoom.js"></script>
    <link href="css/NavBarStyle.css" rel="stylesheet" />
    <script>
        $(function () {
            $("[id*=gvCatalog] img").elevateZoom({
                cursor: 'pointer',
                tint: true,
                tintColour: '#F90',
                tintOpacity: 0.5,
            });
        });
    </script>
</head>
<body>
    <uc1:MenuBar runat="server" ID="MenuBar" />

    <div class="container">
        <uc1:themeMusic runat="server" ID="themeMusic" />
        <br />
        <br />

        <div id="topbanner" class="topBanner" runat="server">
            <h1>Apocalypse Trading Company</h1>
            <p1>Where your bottle caps spend</p1>
            <br />
            <p2>    as well as your dollars!</p2>
            <br />
            <br />
            <br />

            <asp:Label ID="lblWelcome" Text="" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="LightYellow" Font-Names=" Coronetscript, cursive" BorderWidth="15px" BorderColor="Transparent"></asp:Label>

        </div>
        
        <form id="Form1" class="form-signin" runat="server">
            <div id="comments" class="comments" runat="server">
                <div id="shopping" class="shopping" runat="server">
                    <div id="shoppingInfo" class="shoppingInfo" runat="server">
                        <asp:Panel ID="pnlCatalog" runat="server">
                            <div class="CustSearch">
                                <br />
                                <br />
                                <asp:DropDownList ID="ddDepartment" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" OnSelectedIndexChanged="ddDepartment_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>

                                <asp:GridView ID="gvCatalog" runat="server" AutoGenerateColumns="False" BackColor="#0B2D0B" ForeColor="#66FF33" OnRowCommand="gvCatalog_RowCommand">
                                    <Columns>
                                        <asp:BoundField DataField="ProductNumber" HeaderText="Product" />
                                        <asp:BoundField DataField="ProductDesc" HeaderText="Description" />
                                        <asp:BoundField DataField="ProductQOH" HeaderText="Available" />
                                        <asp:BoundField DataField="ProductPrice" HeaderText="Price" />
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Button ID="btnSelect" runat="server" Text="Select" CommandName="Add" CommandArgument="<%#Container.DataItemIndex %>" />
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:Button ID="btnRemove" runat="server" Text="Remove" CommandName="Remove" CommandArgument="<%#Container.DataItemIndex %>" />
                                            </ItemTemplate>

                                        </asp:TemplateField>
                                        <asp:ImageField DataImageUrlField="ProductImageURL" HeaderText="Image" ControlStyle-Width="50" ControlStyle-Height="50">
                                        </asp:ImageField>
                                    </Columns>
                                </asp:GridView>

                                <asp:Button ID="btnUpdate" runat="server" Text="Update Shopping Cart" CssClass="greenbuttonLarge" OnClick="btnUpdate_Click" />
                                <asp:Label ID="lblInformUpdate" runat="server" Text=""></asp:Label>
                                <asp:Button ID="btnPurchase" runat="server" Text="Purchase" CssClass="greenbuttonLarge" OnClick="btnPurchase_Click" />
                                <br />
                                <asp:Label ID="lblTotalCost" runat="server" Text=""></asp:Label>
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />
                                <br />


                            </div>
                        </asp:Panel>
                        <asp:Panel ID="pnlPurchase" runat="server" Visible="false">
                            <div id="purchaseInfo" class="purchaseInfo">
                                <br />
                                <br />
                                <asp:Label ID="lblSelectCard" runat="server" Text="Select Which Amazon Card You'd Like To Use:"></asp:Label>
                                <br />
                                <asp:DropDownList ID="ddCreditCards" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" AutoPostBack="True" OnSelectedIndexChanged="ddCreditCards_SelectedIndexChanged">
                                    <asp:ListItem>Select Card</asp:ListItem>
                                </asp:DropDownList>
                                <br />
                                <asp:Label ID="lbltotalMessage" runat="server" Text="Your Total:"></asp:Label>
                                <asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>
                                <br />
                                <asp:Button ID="btnProcess" runat="server" Text="Process" CssClass="greenbutton" OnClick="btnProcess_Click" />
                                <br />
                                <br />
                                <asp:Label ID="lblInformPurchase" runat="server" Text=""></asp:Label>
                            </div>
                        </asp:Panel>
                    </div>
                </div>
            </div>




            <div id="custInfo" class="custInfo" runat="server">
                <div id="custInfoBox" class="CustInfoBox" runat="server">
                    <asp:Label ID="lclCustInfo" Text="Customer Information:" runat="server"></asp:Label><br />
                    <asp:Label ID="lblName" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblEmail" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblShippingAddress" Text="Shipping Address: " runat="server"></asp:Label><br />
                    <asp:Label ID="lblAdderss1" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblAddress2" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblState" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblZip" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillingAddress" Text="Billing Address:" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillAdd1" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillAdd2" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillState" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillCity" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblBillZip" Text="" runat="server"></asp:Label><br />
                    <asp:Label ID="lblEdit" Text="Edit Customer Infomation: " runat="server"></asp:Label>
                    <asp:Button ID="btnEdit" Text="Edit" runat="server" CssClass="greenbutton" OnClick="btnEdit_Click" /><br />
                    <asp:Label ID="lblRequest" Text="Request New Card:" runat="server"></asp:Label><br />
                    <br />
                    <asp:Button ID="btnAddCard" Text="New Card" runat="server" CssClass="greenbuttonLarge" OnClick="btnAddCard_Click" /><br />
                    <asp:Label ID="lblCustAccount" Text="View Account History:" runat="server"></asp:Label><br />
                    <br />
                    <asp:Button ID="btnCustAccount" Text="History" runat="server" CssClass="greenbuttonLarge" OnClick="btnCustAccount_Click" /><br />
                </div>
            </div>

        </form>
    </div>




</body>
</html>
