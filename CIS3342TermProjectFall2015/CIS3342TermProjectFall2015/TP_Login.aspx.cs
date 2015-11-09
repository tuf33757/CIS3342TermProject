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
                if (checkUserPassword())
                {
                    Response.Redirect("TP_Registration.aspx");
                }
                else
                    lblError.Text = "Username and/or Password do not match our records.";
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

        protected Boolean checkUserPassword()
        {
            SqlCommand SQL = new SqlCommand();
            SQL.CommandType = CommandType.StoredProcedure;
            SQL.CommandText = "TP_validateUser";
            SQL.Parameters.AddWithValue("@username", txtLoginId.Text);
            SQL.Parameters.AddWithValue("@password", txtPassword.Text);
            int validate = DB.DoUpdateUsingCmdObj(SQL);
            if (validate == 1)
                return true;
            else
                return false;
        }
    }
}