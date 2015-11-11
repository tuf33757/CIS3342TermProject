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
    public partial class TP_Login : System.Web.UI.Page
    {
        DBConnect DB = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (checkForNull(txtLoginId) && checkForNull(txtPassword))
            {
                lblError.Text = "";
                DataSet user = validateUser();
                try
                {
                    string userType = user.Tables[0].Rows[0]["User_Type"].ToString();
                    if (userType == "Customer")
                    {
                        Response.Redirect("TP_Registration.aspx");
                    }
                    else if (userType == "Merchant")
                    {
                        Response.Redirect("TP_Merchant_Registration.aspx");
                    }
                    else if (userType == "Admin")
                    {
                        Response.Redirect("TP_Admin_Page.aspx");
                    }
                    else
                        lblError.Text = "Username and/or Password do not match our records.";
                }
                catch (IndexOutOfRangeException)
                {
                    lblError.Text = "Index out of Range";


                }
            }
            else
                lblError.Text = "Please Enter Username and Password.";




        }

        protected Boolean checkForNull(TextBox tb)
        {
            if (tb.Text == "")
                return false;
            else
                return true;
        }

        protected DataSet validateUser()
        {
            SqlCommand SQL = new SqlCommand();
            SQL.CommandType = CommandType.StoredProcedure;
            SQL.CommandText = "TPvalidateUser";
            SQL.Parameters.AddWithValue("@username", txtLoginId.Text);
            SQL.Parameters.AddWithValue("@password", txtPassword.Text);
            DataSet DS = new DataSet();
            DS = DB.GetDataSetUsingCmdObj(SQL);
            return DS;
        }



    }
}