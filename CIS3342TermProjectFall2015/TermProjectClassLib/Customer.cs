using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    public class Customer
    {
        string custID;
        string userName;
        public string firstName;
        public string lastName;
        public string email;
        string password;
        public string userType;

        string shipAddress1;
        string shipAddress2;
        string shipCity;
        string shipState;
        int shipZip;

        string billAddress1;
        string billAddress2;
        string billCity;
        string billState;
        int billZip;

        float totalDollarSales;


        public Customer()
        {
        }

        public Customer(string fName, string lName, string email, string password, string userType)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.email = email;
            this.password = password;
            this.userType = userType;
            totalDollarSales = 0;
        }

        public void setUserName(string username)
        {
            this.userName = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public Boolean setShippingAddress(string add1, string add2, string city, string state, string zip)
        {
            shipAddress1 = add1;
            shipAddress2 = add2;
            shipCity = city;
            shipState = state;
            string stringZip = zip;
            bool result = Int32.TryParse(stringZip, out shipZip);
            if (result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean setBillingAddress(string add1, string add2, string city, string state, string zip)
        {
            billAddress1 = add1;
            billAddress2 = add2;
            billCity = city;
            billState = state;
            string stringZip = zip;
            bool result = Int32.TryParse(stringZip, out billZip);
            if (result)
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
