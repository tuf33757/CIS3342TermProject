using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342TermProjectFall2015
{
    public partial class TP_Merchant_Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitMerch_Click(object sender, EventArgs e)
        {
            if (passwordMatch(txtPassword.Text, txtPasswordConfirm.Text))
            {
                lblInform.Text = "Passwords Match";
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