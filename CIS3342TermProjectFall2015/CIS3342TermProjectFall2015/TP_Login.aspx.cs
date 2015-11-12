﻿using System;
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
            if (!IsPostBack && Request.Cookies["LoginID"] != null)
            {
                HttpCookie cookie = Request.Cookies["LoginID"];
                txtLoginId.Text = cookie.Values["LoginID"].ToString();
                txtPassword.Text = cookie.Values["Customer_Password"].ToString();
                
            }

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
                        createCookie(user);
                        Response.Redirect("TP_Registration.aspx");
                    }
                    else if (userType == "Merchant")
                    {
                        createCookie(user);
                        Response.Redirect("TP_Merchant_Registration.aspx");
                    }
                    else if (userType == "Admin")
                    {
                        createCookie(user);
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

        protected void createCookie(DataSet DS)
        {
            if (Request.Cookies["LoginID"] == null)
            {
                HttpCookie myCookie = new HttpCookie("LoginID");
                myCookie.Values["LoginID"] = DS.Tables[0].Rows[0]["LoginID"].ToString();
                myCookie.Values["Customer_Password"] = DS.Tables[0].Rows[0]["Customer_Password"].ToString();
                myCookie.Values["LastVisited"] = DateTime.Now.ToString();
                myCookie.Expires = new DateTime(2025, 1, 1);

                Response.Cookies.Add(myCookie);
                lblError.Text = "The cookie was written to the user's computer.";
            }
        }

    }
}