using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TermProjectClassLib;
using System.Data;
using System.Data.SqlClient;

namespace WebServices
{
    /// <summary>
    /// Summary description for TP_WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TP_WebService : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();


        [WebMethod]
        public DataSet getDepartment()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TP_GetDepartment";
            DataSet myds = objDB.GetDataSetUsingCmdObj(command);
            return myds;
        }

        [WebMethod]
        public DataSet getCatalog(int departmentNumber)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TP_GetCatalog";
            DataSet myds = objDB.GetDataSetUsingCmdObj(command);
            return myds;

        }

        [WebMethod]
        public ArrayList getColNames(DataSet ds)
        {
            ArrayList names = new ArrayList();
            foreach (DataTable table in ds.Tables)
            {
                foreach (DataColumn column in table.Columns)
                    names.Add(column.ColumnName);
            }
            return names;
        }

        [WebMethod]
        public void addMerchant(Merchant merch)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "TP_AddMerchant";

            command.Parameters.AddWithValue("@merchID", merch.getMerchantID());
            command.Parameters.AddWithValue("@storeName", merch.storeName);
            command.Parameters.AddWithValue("@storeDescrip", merch.storeDescrip);
            command.Parameters.AddWithValue("@firstName", merch.firstName);
            command.Parameters.AddWithValue("@lastName", merch.lastName);
            command.Parameters.AddWithValue("@APIKey", merch.getAPIKey());
            command.Parameters.AddWithValue("@loginID", merch.loginID);


            objDB.DoUpdateUsingCmdObj(command);
        }

        [WebMethod]
        public Boolean Purchase(string ProductID, int Quantity, String MerchantID, String APIKey,
            String[] CustomerCreditInformation)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "TP_ValidateAPIKey";
                cmd.Parameters.AddWithValue("@MerchantID", MerchantID);
                cmd.Parameters.AddWithValue("@APIKey", APIKey);

                DataSet result = objDB.GetDataSetUsingCmdObj(cmd);
                if (result != null)
                {
                    SqlCommand command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "TP_AddPurchase";

                    command.Parameters.AddWithValue("@LoginID", CustomerCreditInformation[0].ToString());
                    command.Parameters.AddWithValue("@MerchantID", MerchantID);
                    command.Parameters.AddWithValue("@Quantity", Quantity);
                    command.Parameters.AddWithValue("@CardType", CustomerCreditInformation[1].ToString());

                    objDB.DoUpdateUsingCmdObj(command);

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
