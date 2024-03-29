﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TermProjectClassLib
{
    public class Merchant
    {
        public string merchantID;
        public string storeName;
        public string firstName;
        public string lastName;
        string APIKey;
        public string storeDescrip;
        public string loginID;

        public Merchant()
        {
            APIKey = generateAPIKey();
        }

        public Merchant(string ID, string storename, string fname, string lname, string login, string descrip, string loginID)
        {
            merchantID = ID;
            storeName = storename;
            firstName = fname;
            lastName = lname;
            APIKey = generateAPIKey();
            storeDescrip = descrip;
            this.loginID = loginID;
        }

        public string getMerchantID()
        {
            return merchantID;
        }
        public string getAPIKey()
        {
            return APIKey;
        }
        public void setAPIKey(string key)
        {
            APIKey = key;
        }

        public string generateAPIKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 20)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    }
}
