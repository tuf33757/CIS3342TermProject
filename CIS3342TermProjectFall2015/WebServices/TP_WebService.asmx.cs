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
            command.CommandText = "TP_GetDepartment";
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

    }
}
