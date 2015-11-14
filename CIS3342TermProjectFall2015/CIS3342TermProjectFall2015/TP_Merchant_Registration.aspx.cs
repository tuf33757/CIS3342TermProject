using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TermProjectClassLib;


namespace CIS3342TermProjectFall2015
{
    public partial class TP_Merchant_Registration : System.Web.UI.Page
    {
        TP_WebService.TP_WebService tpWebService = new TP_WebService.TP_WebService();
        TP_WebService.Merchant newMerch = new TP_WebService.Merchant();

        protected void Page_Load(object sender, EventArgs e)
        {
            //string session = (string)Session["Login"];
            //if (session != "true")
            //    Response.Redirect("TP_Login.aspx");
        }

        protected void btnSubmitMerch_Click(object sender, EventArgs e)
        {
            if (checkForNull() == true)
            {
                lblInform.Text = "Cogratz you win!";
                putMerchantInDB();
            }
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
        protected Boolean checkForNull()
        {
            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtEmail.Text == "")
                || (txtLoginId.Text == "") || (txtStoreDescription.Text == "") || (txtStoreName.Text == ""))
                return false;
            else
                return true;
        }
        //protected Boolean checkForNull(Control page)
        //{
        //    foreach (Control c in page.Controls)
        //    {
        //        if (c is TextBox){
        //            if((c as TextBox).Text == "")
        //            return false;}
        //        if ((c is DropDownList) && (c as DropDownList).SelectedIndex == 0)
        //            return false;
        //    }
        //    return true;
        //}

        public void putMerchantInDB()
        {
            newMerch.firstName = txtFirstName.Text;
            newMerch.lastName = txtLastName.Text;
            newMerch.storeName = txtStoreName.Text;
            newMerch.storeDescrip = txtStoreDescription.Text;
            newMerch.loginID = txtLoginId.Text;

            Random rand = new Random();
            int IDnum = rand.Next(100000);
            newMerch.merchantID = txtLoginId.Text + IDnum;

            tpWebService.addMerchant(newMerch);
        }

    }
}