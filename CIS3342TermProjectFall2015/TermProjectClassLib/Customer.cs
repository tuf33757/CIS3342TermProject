using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    public class Customer
    {
        public string userName;
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public string userType;

        public string shipAddress1;
        public string shipAddress2;
        public string shipCity;
        public string shipState;
        public string shipZip;

        public string billAddress1;
        public string billAddress2;
        public string billCity;
        public string billState;
        public string billZip;

        public float totalDollarSales;


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
            try
            {
                shipAddress1 = add1;
                shipAddress2 = add2;
                shipCity = city;
                shipState = state;
                shipZip = zip;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Boolean setBillingAddress(string add1, string add2, string city, string state, string zip)
        {
            try
            {
                billAddress1 = add1;
                billAddress2 = add2;
                billCity = city;
                billState = state;
                billZip = zip;
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public Customer(Customer cust)
        { 
        this.userName = cust.userName;
        this.firstName = cust.firstName;
        this.lastName = cust.lastName;
        this.email = cust.email;
        this.password = cust.password;
        this.userType = cust.userType;
        this.shipAddress1 = cust.shipAddress1;
        this.shipAddress2 = cust.shipAddress2;
        this.shipCity = cust.shipCity;
        this.shipState = cust.shipState;
        this.shipZip = cust.shipZip;
        this.billAddress1 = cust.billAddress1;
        this.billAddress2 = cust.billAddress2;
        this.billCity = cust.billCity;
        this.billState = cust.billState;
        this.billZip = cust.billZip;

        this.totalDollarSales = cust.totalDollarSales;
        }
    }
}
