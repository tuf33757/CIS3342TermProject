using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectClassLib;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Collections;

namespace CIS3342TermProjectFall2015
{
    public partial class TP_HomePage : System.Web.UI.Page
    {
        DBConnect DB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        TP_WebService.TP_WebService tpWebService = new TP_WebService.TP_WebService();
        TP_CreditCardWS.TP_CreditCardWS tpCreditCardWS = new TP_CreditCardWS.TP_CreditCardWS();
        GinErikaWS.MerchantStore Merchant1 = new GinErikaWS.MerchantStore();
        NickEricWS.MerchantStore Merchant2 = new NickEricWS.MerchantStore();
        ArrayList Departments = new ArrayList();
        ShoppingCart cart = new ShoppingCart();
        DataSet merchant2Dept = new DataSet();
        DataSet merchant1Dept = new DataSet();
        string loginID;



        protected void Page_Load(object sender, EventArgs e)
        {
            string session = (string)Session["Login"];
            loginID = (string)Session["LoginID"];
            if (session != "true")
                Response.Redirect("TP_Login.aspx");

            if (!IsPostBack)
            {
                Session["Cart"] = cart;
                Session["TotalCost"] = 0;
                Session["EditCust"] = true;
                lblWelcome.Text = "        Welcome, " + (string)Session["Customer_First"] + " " + (string)Session["Customer_Last"];

                PutWebServicesInDataset();

                ddDepartment.Items.Insert(0, new ListItem("Please select", "0"));
                lblName.Text = (string)Session["Customer_First"] + " " + (string)Session["Customer_Last"];
                lblAdderss1.Text = (string)Session["Ship_Address_1"];
                lblAddress2.Text = (string)Session["Ship_Address_2"];
                lblState.Text = (string)Session["Ship_City"];
                lblZip.Text = (string)Session["Ship_Zip"];
                lblBillAdd1.Text = (string)Session["Bill_Address1"];
                lblBillAdd2.Text = (string)Session["Bill_Address2"];
                lblBillCity.Text = (string)Session["Bill_City"];
                lblBillState.Text = (string)Session["Bill_State"];
                lblBillZip.Text = (string)Session["Bill_Zip"];
                lblEmail.Text = (string)Session["Customer_Email"];
                DB.CloseConnection();

                deserializeCart();
            }
        }


        protected void gvCatalog_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Add")
            {
                addSelectedItemToCart(index);
                decreaseQOH(index);
                increaseTotal(index);
                int totalCost = Convert.ToInt32(Session["TotalCost"]);
                lblTotalCost.Text = "Your Current Total Is: $ " + totalCost;
            }
            if (e.CommandName == "Remove")
            {

                removeSelectedItemFromCart(index);
                increaseQOH(index);
                decreaseTotal(index);
                int totalCost = Convert.ToInt32(Session["TotalCost"]);
                lblTotalCost.Text = "Your Current Total Is: $ " + totalCost;
            }
        }

        protected void btnAddCard_Click(object sender, EventArgs e)
        {
            string username = (string)Session["LoginID"];
            Boolean result = tpCreditCardWS.RequestAmazonCreditCard(username);
            if (result)
            {
                lblRequest.Text = "Your request has been approved";
            }
            else
            {
                lblRequest.Text = "Your request has been denied.";
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Session["EditCust"] = true;
            Response.Redirect("TP_Registration.aspx");
        }

        protected void ddDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddDepartment.SelectedIndex != 0)
            {
                DBConnect db = new DBConnect();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TP_GetCatalog";
                command.Parameters.AddWithValue("@DepartmentNumber", ddDepartment.SelectedValue);
                DataSet DS = db.GetDataSetUsingCmdObj(command);
                if (DS.Tables[0].Rows.Count == 0)
                {
                    checkWebServiceDepartment(ddDepartment.SelectedValue);
                }
                else
                {
                    gvCatalog.DataSource = DS;
                    gvCatalog.DataBind();
                }
            }
        }

        public void checkWebServiceDepartment(string departmentNum)
        {
            DataSet DS = Merchant1.GetProductCatalog(departmentNum);
            if (DS.Tables[0].Rows.Count == 0)
            {
                DS = Merchant2.GetProductCatalog(departmentNum);
                gvCatalog.DataSource = DS;
                gvCatalog.DataBind();
            }
            else
            {
                gvCatalog.DataSource = DS;
                gvCatalog.DataBind();
            }
        }

        public void addSelectedItemToCart(int index)
        {

            GridViewRow gvRow = gvCatalog.Rows[index];
            String prodNumString = gvCatalog.Rows[index].Cells[0].Text;
            int prodNum = Convert.ToInt32(prodNumString);
            Product newProd = new Product(prodNum);
            ShoppingCart tempCart = (ShoppingCart)Session["Cart"];
            tempCart.addItemToCart(newProd);
            Session["Cart"] = tempCart;
        }

        public void increaseQOH(int index)
        {
            GridViewRow gvRow = gvCatalog.Rows[index];
            String prodNumString = gvCatalog.Rows[index].Cells[0].Text;
            int prodNum = Convert.ToInt32(prodNumString);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_AddItemToQOH";

            objCommand.Parameters.AddWithValue("@productID", prodNum);
            DB.DoUpdateUsingCmdObj(objCommand);
        }

        public void increaseTotal(int index)
        {
            GridViewRow gvRow = gvCatalog.Rows[index];
            String costString = gvCatalog.Rows[index].Cells[3].Text;
            int cost = Convert.ToInt32(costString);
            cart.total = cart.total + cost;
            try
            {
                int temp = (int)Session["TotalCost"];
                temp += cost;
                Session["TotalCost"] = temp;
            }
            catch (Exception)
            {
            }
        }
        public void decreaseTotal(int index)
        {
            GridViewRow gvRow = gvCatalog.Rows[index];
            String costString = gvCatalog.Rows[index].Cells[3].Text;
            int cost = Convert.ToInt32(costString);
            cart.total = cart.total - cost;
            try
            {
                int temp = (int)Session["TotalCost"];
                temp -= cost;
                Session["TotalCost"] = temp;
            }
            catch (Exception)
            {
            }
        }

        public void decreaseQOH(int index)
        {
            GridViewRow gvRow = gvCatalog.Rows[index];
            String prodNumString = gvCatalog.Rows[index].Cells[0].Text;
            int prodNum = Convert.ToInt32(prodNumString);
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_PurchaseProduct";

            objCommand.Parameters.AddWithValue("@productID", prodNum);
            DB.DoUpdateUsingCmdObj(objCommand);
        }

        public void removeSelectedItemFromCart(int index)
        {
            GridViewRow gvRow = gvCatalog.Rows[index];
            String prodNumString = gvCatalog.Rows[index].Cells[0].Text;
            int prodNum = Convert.ToInt32(prodNumString);
            Product newProd = new Product(prodNum);
            ShoppingCart tempCart = (ShoppingCart)Session["Cart"];
            tempCart.removeItemFromCart(newProd);
            Session["Cart"] = tempCart;

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            serializeCart();
            lblInformUpdate.Text = "Cart Updated";
        }

        public void serializeCart()
        {
            BinaryFormatter serializer = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();
            ShoppingCart tempCart = (ShoppingCart)Session["Cart"];
            serializer.Serialize(memStream, tempCart);
            byte[] byteArray;
            byteArray = memStream.ToArray();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_StoreShoppingCart";

            objCommand.Parameters.AddWithValue("@loginID", loginID);
            objCommand.Parameters.AddWithValue("@shoppingCart", byteArray);

            DB.DoUpdateUsingCmdObj(objCommand);
        }

        public void deserializeCart()
        {
            BinaryFormatter deserializer = new BinaryFormatter();
            MemoryStream memStream = new MemoryStream();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_GetCart";
            objCommand.Parameters.AddWithValue("@loginID", loginID);

            DB.GetDataSetUsingCmdObj(objCommand);
            ShoppingCart shopCart = new ShoppingCart();
            {
                try
                {
                    byte[] byteArray = (byte[])DB.GetField("ShoppingCart", 0);
                    shopCart = (ShoppingCart)deserializer.Deserialize(memStream);
                    Session["Cart"] = shopCart;
                }
                catch (Exception)
                {

                }
            }
            cart = shopCart;
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            pnlCatalog.Visible = false;
            pnlPurchase.Visible = true;
        }

        public void PutWebServicesInDataset()
        {
            merchant1Dept = Merchant1.GetDepartments();
            merchant2Dept = Merchant2.GetDepartments();

            SqlCommand SQL = new SqlCommand();
            SQL.CommandType = CommandType.StoredProcedure;
            SQL.CommandText = "TP_GetDepartment";
            DataSet DS = DB.GetDataSetUsingCmdObj(SQL);

            DS.Merge(merchant1Dept);
            DS.Merge(merchant2Dept);

            ddDepartment.DataSource = DS;
            ddDepartment.DataTextField = "DepartmentName";
            ddDepartment.DataValueField = "DepartmentNumber";
            ddDepartment.DataBind();
        }

        protected void btnCustAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("TP_Customer_Accnt.aspx");
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                
                int total = (int)Session["TotalCost"];
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_UpdateTotalDollars";
                objCommand.Parameters.AddWithValue("@loginID", loginID);
                objCommand.Parameters.AddWithValue("@cost", total);

                DB.GetDataSetUsingCmdObj(objCommand);

                serializeCart();
                objCommand.Parameters.Clear();

                //objCommand.CommandType = CommandType.StoredProcedure;
                //objCommand.CommandText = "TP_RecordPurchase";
                //objCommand.Parameters.AddWithValue("@loginID", loginID);
                //objCommand.Parameters.AddWithValue("@SiteID", "");
                //objCommand.Parameters.AddWithValue("@Quantity", 1);
                //objCommand.Parameters.AddWithValue("@CardType", "Amazon Card");

                lblTotalCost.Text = "";
                lblInformUpdate.Text = "Thank You For Your Purchase!";
            }
            catch (Exception)
            {
            }
        }
    }
}