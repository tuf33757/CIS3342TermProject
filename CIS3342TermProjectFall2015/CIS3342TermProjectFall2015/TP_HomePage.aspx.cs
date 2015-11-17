using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectClassLib;
using System.Data;
using System.Data.SqlClient;

namespace CIS3342TermProjectFall2015
{
    public partial class TP_HomePage : System.Web.UI.Page
    {
        DBConnect DB = new DBConnect();
        TP_WebService.TP_WebService tpWebService = new TP_WebService.TP_WebService();
        TP_CreditCardWS.TP_CreditCardWS tpCreditCardWS = new TP_CreditCardWS.TP_CreditCardWS();
        protected void Page_Load(object sender, EventArgs e)
        {
            string session = (string)Session["Login"];
            if (session != "true")
                Response.Redirect("TP_Login.aspx");

            if (!IsPostBack)
            {

                lblWelcome.Text = "        Welcome, " + (string)Session["Customer_First"] + " " + (string)Session["Customer_Last"];
                SqlCommand SQL = new SqlCommand();
                SQL.CommandType = CommandType.StoredProcedure;
                SQL.CommandText = "TP_GetDepartment";
                DataSet DS = DB.GetDataSetUsingCmdObj(SQL);
                ddDepartment.DataSource = DS;
                ddDepartment.DataTextField = "DepartmentName";
                ddDepartment.DataValueField = "DepartmentNumber";
                ddDepartment.DataBind();
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

    }
}