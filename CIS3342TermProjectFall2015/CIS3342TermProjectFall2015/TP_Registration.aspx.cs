using System;
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbBilling_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBilling.Checked == true)
            {
                txtbillCity.Enabled = false;
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
                        Boolean result = newCust.setBillingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtbillZip.Text);
                        if (result)
                        {
                            newCust.setShippingAddress(txtshipStreet1.Text, txtshipStreet2.Text, txtshipCity.Text, ddlshipState.SelectedValue, txtbillZip.Text);
                            newCust.firstName = txtFirstName.Text;
                            newCust.lastName = txtLastName.Text;
                            newCust.setUserName(txtLoginId.Text);
                            newCust.setPassword(txtPassword.Text);
                            newCust.email = txtEmail.Text;
                            newCust.userType = "Customer";

                        }
                        else
                        {
                            lblInform.Text = "Error setting billing address";
                        }
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

    }
}