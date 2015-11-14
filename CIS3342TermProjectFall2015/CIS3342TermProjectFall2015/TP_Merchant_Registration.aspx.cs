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
            //string session = (string)Session["Login"];
            //if (session != "true")
            //    Response.Redirect("TP_Login.aspx");
        }

        protected void btnSubmitMerch_Click(object sender, EventArgs e)
        {
            if (checkForNull(this))
            { }
            else
                lblInform.Text = "Please enter all required fields.";

        }

        protected void btnCalcel_Click(object sender, EventArgs e)
        {
            clearPage(this);
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
                }
            }
        }

        protected Boolean checkForNull(Control page)
        {
            foreach (Control c in page.Controls)
            {
                if ((c is TextBox) && (c as TextBox).Text == "")
                    return false;
                if ((c is DropDownList) && (c as DropDownList).SelectedIndex == 0)
                    return false;
            }
            return true;
        }

    }
}