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
                    lblInform.Text = "Passwords Match";
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