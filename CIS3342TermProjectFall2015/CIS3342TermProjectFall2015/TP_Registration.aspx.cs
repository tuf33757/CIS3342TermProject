﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectClassLib;


namespace CIS3342TermProjectFall2015
{
    public partial class TP_Registration : System.Web.UI.Page
    {
        Customer newCust = new Customer();
        TP_CreditCardWS.TP_CreditCardWS creditcardWS = new TP_CreditCardWS.TP_CreditCardWS();

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if ((Boolean)Session["EditCust"])
                {
                    pnlCustReg.Visible = false;
                    txtCEUsername.Text = (string)Session["LoginID"];
                    txtCEFirstName.Text= (string)Session["Customer_First"];
                    txtCELast.Text = (string)Session["Customer_Last"];
                    txtCEStreet1.Text = (string)Session["Ship_Address_1"];
                    txtCEStreet2.Text = (string)Session["Ship_Address_2"];
                    txtCEShipCity.Text = (string)Session["Ship_City"];
                    ddShipState.SelectedValue = (string)Session["Ship_State"];
                    txtCEShipZip.Text = (string)Session["Ship_Zip"];
                    txtCEBillStreet1.Text = (string)Session["Bill_Address_1"];
                    txtCEBillStreet2.Text = (string)Session["Bill_Address_2"];
                    txtCEBillCity.Text = (string)Session["Bill_City"];
                    ddCEBillState.SelectedValue = (string)Session["Bill_State"];
                    txtCEBillZip.Text = (string)Session["Bill_Zip"];
                    txtCEEmail.Text = (string)Session["Customer_Email"];
                  
                }
            }
            catch (NullReferenceException ex) { }
        }

        protected void cbBilling_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBilling.Checked == true)
            {
                txtbillCity.Enabled = false;
                ddlbillState.Enabled = false;
                txtbillStreet1.Enabled = false;
                txtbillStreet2.Enabled = false;
                txtbillZip.Enabled = false;

            }
            else
            {
                txtbillCity.Enabled = true;
                txtbillStreet1.Enabled = true;
                txtbillStreet2.Enabled = true;
                txtbillZip.Enabled = true;
                ddlbillState.Enabled = true;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

            if (passwordsNotNull(txtPassword.Text, txtPasswordConfirm.Text))
            {
                if (passwordMatch(txtPassword.Text, txtPasswordConfirm.Text))
                {
                    if (cbBilling.Checked == true)
                    {
                        Boolean result = newCust.setBillingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);
                        if (result)
                        {
                            newCust.setShippingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);

                            newCust.firstName = txtFirstName.Text;
                            newCust.lastName = txtLastName.Text;
                            newCust.setUserName(txtLoginId.Text);
                            newCust.setPassword(txtPassword.Text);
                            newCust.email = txtEmail.Text;
                            newCust.userType = "Customer";

                            putCustomerInDB();
                        }
                        else
                        {
                            lblInform.Text = "Error setting billing address";
                        }
                    }
                    else
                    {
                        Boolean result = newCust.setBillingAddress(txtbillStreet1.Text, txtbillStreet2.Text,
                            txtbillCity.Text, ddlbillState.SelectedValue, txtbillZip.Text);

                        newCust.setShippingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);

                        newCust.firstName = txtFirstName.Text;
                        newCust.lastName = txtLastName.Text;
                        newCust.setUserName(txtLoginId.Text);
                        newCust.setPassword(txtPassword.Text);
                        newCust.email = txtEmail.Text;
                        newCust.userType = "Customer";

                        putCustomerInDB();
                    }
                }
                else
                {
                    lblInform.Text = "Passowrds Do Not Match";
                }
            }
            else
            {
                lblInform.Text = "Please enter passwords";
            }
        }

        public Boolean passwordsNotNull(string p1, string p2)
        {
            if (p1 != "" && p2 != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean passwordMatch(string p1, string p2)
        {
            if (p1.Equals(p2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void clearPage(Control page)
        {
            {
                foreach (Control c in page.Controls)
                {
                    if (c.Controls.Count > 0)
                        clearPage(c);
                    else
                    {
                        if (c is TextBox)
                            (c as TextBox).Text = "";

                        if (c is CheckBox)
                            (c as CheckBox).Checked = false;

                        if (c is DropDownList)
                            (c as DropDownList).SelectedIndex = 1;
                    }
                    lblInform.Text = "";
                }
            }
        }

        protected void btnCleaar_Click(object sender, EventArgs e)
        {
            clearPage(this);
        }

        public void putCustomerInDB()
        {
            TP_CreditCardWS.Customer Cust = new TP_CreditCardWS.Customer();

            Cust.userName = newCust.userName;
            Cust.firstName = newCust.firstName;
            Cust.lastName = newCust.lastName;
            Cust.email = newCust.email;
            Cust.password = newCust.password;
            Cust.userType = newCust.userType;
            Cust.shipAddress1 = newCust.shipAddress1;
            Cust.shipAddress2 = newCust.shipAddress2;
            Cust.shipCity = newCust.shipCity;
            Cust.shipState = newCust.shipState;
            Cust.shipZip = newCust.shipZip;
            Cust.billAddress1 = newCust.billAddress1;
            Cust.billAddress2 = newCust.billAddress2;
            Cust.billCity = newCust.billCity;
            Cust.billState = newCust.billState;
            Cust.billZip = newCust.billZip;
            Cust.totalDollarSales = newCust.totalDollarSales;

            creditcardWS.AddCustomer(Cust);

        }

        protected void chkBilling_CheckedChanged(object sender, EventArgs e)
        {
         
            if (chkBilling.Checked == true)
            {
                txtCEBillCity.Enabled = false;
                ddCEBillState.Enabled = false;
                txtCEStreet1.Enabled = false;
                txtCEStreet2.Enabled = false;
                txtCEBillZip.Enabled = false;

            }
            else
            {
                txtCEBillCity.Enabled = true;
                ddCEBillState.Enabled = true;
                txtCEStreet1.Enabled = true;
                txtCEStreet2.Enabled = true;
                txtCEBillZip.Enabled = true;
            }
        
        }

        protected void btnCESubmit_Click(object sender, EventArgs e)
        {
 
            if (passwordsNotNull(txtCEPassword1.Text, txtCEPassword2.Text))
            {
                if (passwordMatch(txtPassword.Text, txtPasswordConfirm.Text))
                {
                    if (cbBilling.Checked == true)
                    {
                        Boolean result = newCust.setBillingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);
                        if (result)
                        {
                            newCust.setShippingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);

                            newCust.firstName = txtFirstName.Text;
                            newCust.lastName = txtLastName.Text;
                            newCust.setUserName(txtLoginId.Text);
                            newCust.setPassword(txtPassword.Text);
                            newCust.email = txtEmail.Text;
                            newCust.userType = "Customer";

                            putCustomerInDB();
                        }
                        else
                        {
                            lblInform.Text = "Error setting billing address";
                        }
                    }
                    else
                    {
                        Boolean result = newCust.setBillingAddress(txtbillStreet1.Text, txtbillStreet2.Text,
                            txtbillCity.Text, ddlbillState.SelectedValue, txtbillZip.Text);

                        newCust.setShippingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtshipZip.Text);

                        newCust.firstName = txtFirstName.Text;
                        newCust.lastName = txtLastName.Text;
                        newCust.setUserName(txtLoginId.Text);
                        newCust.setPassword(txtPassword.Text);
                        newCust.email = txtEmail.Text;
                        newCust.userType = "Customer";

                        putCustomerInDB();
                    }
                }
                else
                {
                    lblInform.Text = "Passowrds Do Not Match";
                }
            }
            else
            {
                lblInform.Text = "Please enter passwords";
            }
        }
        }
       

    }
}