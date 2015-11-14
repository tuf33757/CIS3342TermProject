using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    class Merchant
    {
        string merchantID;
        public string storeName;
        public string firstName;
        public string lastName;
        string APIKey;
        public string storeDescrip;

        public Merchant()
        {
        }

        public Merchant(string ID, string storename, string fname, string lname, string api, string login, string descrip)
        {
            merchantID = ID;
            storeName = storename;
            firstName = fname;
            lastName = lname;
            APIKey = api;
            storeDescrip = descrip;
        }

       public string getMerchantID()
       {
           return merchantID;
       }
       public string getAPIKey()
       {
           return APIKey;
       }

       public void generateAPIKey()
       {
           //WRITE THE LOGIC TO GENERATE AN API KEY HERE
       }
        
    }
}
