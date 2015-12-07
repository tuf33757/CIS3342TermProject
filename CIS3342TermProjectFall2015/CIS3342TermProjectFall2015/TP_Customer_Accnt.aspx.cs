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
    public partial class TP_Customer_Accnt : System.Web.UI.Page
    { 
        string loginID;
         DBConnect DB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
             string session = (string)Session["Login"];
            loginID = (string)Session["LoginID"];
            if (session != "true")
                Response.Redirect("TP_Login.aspx");

            if (!IsPostBack)
            {
                
                Session["TotalCost"] = 0;
                Session["EditCust"] = true;
                lblWelcome.Text = "        Welcome, " + (string)Session["Customer_First"] + " " + (string)Session["Customer_Last"];

              

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

               
            }
        }
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("TP_HomePage.aspx");
        }
    }
}