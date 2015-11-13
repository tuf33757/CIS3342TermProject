using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    class CreditCard
    {
        private String cardNumber;
        private String cardType;
        private int expirationMonth;
        private int expirationYear;


        public void setCardNum(string number)
        {
            cardNumber = number;
        }

        public void setCardType(string type)
        {
            cardType = type;
        }

        public void setExpMonth(int month)
        {
            expirationMonth = month;
        }

        public void setExpYear(int year)
        {
            expirationYear = year;
        }

        public String getCardNum()
        {
            return cardNumber;
        }

        public String getCardType()
        {
            return cardType;
        }

        public int getExpMonth()
        {
            return expirationMonth;
        }

        public int getExpYear()
        {
            return expirationYear;
        }
    }
}
