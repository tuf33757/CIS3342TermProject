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
        public string firstName;
        public string lastName;
        string email;
        string password;
        string userType;

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
        }

        public void setShippingAddress(string add1, string add2, string city, string state, int zip)
        {
            shipAddress1 = add1;
            shipAddress2 = add2;
            shipCity = city;
            shipState = state;
            shipZip = zip;
        }

        public void setBillingAddress(string add1, string add2, string city, string state, int zip)
        {
            billAddress1 = add1;
            billAddress2 = add2;
            billCity = city;
            billState = state;
            billZip = zip;
        }
    }
}
