using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    public class Customer
    {
        string userName { get; set; }
        public string firstName;
        public string lastName;
        public string email;
        string password { get; set; }
        public string userType;

        public string shipAddress1;
        public string shipAddress2;
        public string shipCity;
        public string shipState;
        public int shipZip;

        public string billAddress1;
        public string billAddress2;
        public string billCity;
        public string billState;
        public int billZip;

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

        public string getUsername()
        {
            return userName;
        }
        public string getPassword()
        {
            return password;
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
