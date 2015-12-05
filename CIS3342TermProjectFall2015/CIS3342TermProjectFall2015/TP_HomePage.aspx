<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TP_HomePage.aspx.cs" Inherits="CIS3342TermProjectFall2015.TP_HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


    <link href="css/HomePage.css" rel="stylesheet" />
</head>
<body>
    <asp:Panel ID="pnlLogIn" runat="server">
        <div class="container">
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
                            <div class="CustSearch">
                                <br />
                                <br />
                                <asp:DropDownList ID="ddDepartment" runat="server" BackColor="#0F3D0F" ForeColor="#66FF33" OnSelectedIndexChanged="ddDepartment_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                
                                <asp:GridView ID="gvCatalog" runat="server" AutoGenerateColumns="False" BackColor="#0B2D0B" ForeColor="#66FF33" style="opacity:initial" OnRowCommand="gvCatalog_RowCommand">
                                    <Columns>
                                        <asp:BoundField DataField="ProductNumber" HeaderText="Product" />
                                        <asp:BoundField DataField="Description" HeaderText="Description" />
                                        <asp:BoundField DataField="QuantityOnHand" HeaderText="Available" />
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

                                    </Columns>
                                </asp:GridView>
                            </div>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update Shopping Cart" OnClick="btnUpdate_Click" />
                            
                            
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
                        <asp:Button ID="btnEdit" Text="Edit" runat="server" CssClass="greenbutton" OnClick="btnEdit_Click" />
                        <asp:Label ID="lblRequest" Text="Request New Card:" runat="server"></asp:Label><br />
                        <br />
                        <asp:Button ID="btnAddCard" Text="New Card" runat="server" CssClass="greenbuttonLarge" OnClick="btnAddCard_Click" /><br />
                    </div>
                </div>

            </form>
        </div>
    </asp:Panel>

</body>
</html>
