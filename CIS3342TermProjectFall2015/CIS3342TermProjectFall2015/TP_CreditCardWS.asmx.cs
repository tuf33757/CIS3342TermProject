using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TermProjectClassLib;
using System.Data;
using System.Data.SqlClient;

namespace CIS3342TermProjectFall2015
{
    /// <summary>
    /// Summary description for TP_CreditCardWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TP_CreditCardWS : System.Web.Services.WebService
    {
        string AccessKey = "password";
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        //Gets all the customer IDs
        [WebMethod]
        public DataSet getCustomerID()
        {
            DBConnect objDB = new DBConnect();
            String strSQL = "SELECT AccountID FROM Account";
            DataSet myDS;

            myDS = objDB.GetDataSet(strSQL);

            return myDS;
        }

        //Gets the customer id related to a specific account
        [WebMethod]
        public DataSet getCustomerIDFromAccountID(String AccountID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetCustID";
            command.Parameters.AddWithValue("@accountID", AccountID);
            DataSet myds = objDB.GetDataSetUsingCmdObj(command);
            return myds;
        }

        //Adds a customer to the TP_Customer table in Rob's Database
        [WebMethod]
        public Boolean AddCustomer(Customer cust)
        {
            if (cust != null)
            {
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TP_AddCustomer";

                command.Parameters.AddWithValue("@firstName", cust.firstName);
                command.Parameters.AddWithValue("@lastName", cust.lastName);
                command.Parameters.AddWithValue("@email", cust.email);
                command.Parameters.AddWithValue("@userName", cust.getUsername());
                command.Parameters.AddWithValue("@pasword", cust.getPassword());
                command.Parameters.AddWithValue("@userType", cust.userType);
                command.Parameters.AddWithValue("@totalDollarSales", 0);

                command.Parameters.AddWithValue("@shipAdd1", cust.shipAddress1);
                command.Parameters.AddWithValue("@shipAdd2", cust.shipAddress2);
                command.Parameters.AddWithValue("@shipCity", cust.shipCity);
                command.Parameters.AddWithValue("@shipState", cust.shipState);
                command.Parameters.AddWithValue("@shipZip", cust.shipZip);

                command.Parameters.AddWithValue("@billAdd1", cust.billAddress1);
                command.Parameters.AddWithValue("@billAdd2", cust.billAddress2);
                command.Parameters.AddWithValue("@billCity", cust.billCity);
                command.Parameters.AddWithValue("@billState", cust.billState);
                command.Parameters.AddWithValue("@billZip", cust.billZip);

                objDB.DoUpdateUsingCmdObj(command);

                return true;
            }
            else
            {
                return false;
            }
        }

        //[WebMethod]
        //public Boolean UpdateCustomerInfo(Customer cust, string password)
        //{
        //    if (cust != null && password == this.AccessKey)
        //    {
        //        SqlCommand command = new SqlCommand();
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.CommandText = "UpdateCustomerInfo";
        //        command.Parameters.AddWithValue("@customerID", cust.custID);
        //        command.Parameters.AddWithValue("@firstName", cust.firstName);
        //        command.Parameters.AddWithValue("@lastName", cust.lastName);
        //        command.Parameters.AddWithValue("@addressLine1", cust.addLine1);
        //        command.Parameters.AddWithValue("@addressLine2", cust.addLine2);
        //        command.Parameters.AddWithValue("@city", cust.city);
        //        command.Parameters.AddWithValue("@stateName", cust.state);
        //        command.Parameters.AddWithValue("@zip", cust.zip);

        //        objDB.DoUpdateUsingCmdObj(command);

        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //Matches the customer info to make sure the customer exists
        [WebMethod]
        public DataSet MatchCustomerInfo(Object[] info)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "MatchCustInfo";
            command.Parameters.AddWithValue("@cardNum", info[0]);
            command.Parameters.AddWithValue("@expMonth", info[1]);
            command.Parameters.AddWithValue("@expYear", info[2]);
            command.Parameters.AddWithValue("@cardType", info[3]);
            DataSet myds = objDB.GetDataSetUsingCmdObj(command);

            return myds;

        }
        //Gets the balance for a specific account
        [WebMethod]
        public DataSet GetBalance(String AccountID)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "GetBalance";
            command.Parameters.AddWithValue("@AccountID", AccountID);
            DataSet myds = objDB.GetDataSetUsingCmdObj(command);

            return myds;
        }

        //Updates the account balance based on a purchase
        [WebMethod]
        public Boolean UpdateAccountBalance(Object[] Purchase, string password)
        {
            if (password == this.AccessKey)
            {
                try
                {
                    string accountID = (string)Purchase[0];
                    int purchaseAmt = (int)Purchase[1];

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "UpdateAccountBalance";
                    command.Parameters.AddWithValue("@accountID", accountID);
                    command.Parameters.AddWithValue("@purchase", purchaseAmt);
                    objDB.DoUpdateUsingCmdObj(command);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        //Inserts a new transaction to an account
        [WebMethod]
        public Boolean InsertNewTransaction(Object[] TransactionInfo, string password)
        {
            if (password == this.AccessKey)
            {
                try
                {
                    string transactionID = (string)TransactionInfo[0];
                    string accountID = (string)TransactionInfo[1];
                    int amount = (int)TransactionInfo[2];
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "InsertTransaction";
                    command.Parameters.AddWithValue("@transactionID", transactionID);
                    command.Parameters.AddWithValue("@accountID", accountID);
                    command.Parameters.AddWithValue("@amount", amount);
                    objDB.DoUpdateUsingCmdObj(command);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        //Adds a new account to the DB for a specific customer
        [WebMethod]
        public Boolean InsertNewAccount(Object[] AccountInfo, string password)
        {
            if (password == this.AccessKey)
            {
                try
                {
                    string accountID = (string)AccountInfo[0];
                    string customerID = (string)AccountInfo[1];
                    int cardNum = (int)AccountInfo[2];
                    int expMonth = (int)AccountInfo[3];
                    int expYear = (int)AccountInfo[4];
                    string cardType = (string)AccountInfo[5];
                    int creditLimit = (int)AccountInfo[6];
                    int balance = (int)AccountInfo[7];

                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "InsertNewAccount";
                    command.Parameters.AddWithValue("@accountID", accountID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@cardNum", cardNum);
                    command.Parameters.AddWithValue("@expMonth", expMonth);
                    command.Parameters.AddWithValue("@expYear", expYear);
                    command.Parameters.AddWithValue("@cardType", cardType);
                    command.Parameters.AddWithValue("@creditLimit", creditLimit);
                    command.Parameters.AddWithValue("@creditBalance", balance);
                    objDB.DoUpdateUsingCmdObj(command);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
