using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CIS3342TermProjectFall2015
{
    public partial class TP_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (checkForNull(txtLoginId) && checkForNull(txtPassword))
            {
                Response.Redirect("TP_HomePage.aspx");
            }
        }

        protected Boolean checkForNull(TextBox tb)
        {
            if (tb.Text == "")
                return false;
            else
                return true;
        }
    }
}