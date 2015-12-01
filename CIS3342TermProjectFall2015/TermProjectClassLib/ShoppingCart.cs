using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TermProjectClassLib
{
    [Serializable]
    public class ShoppingCart
    {
        public ArrayList CartItems = new ArrayList();
        public string cartID;
        public string customerID;

        public ShoppingCart()
        {
            
        }

        public ShoppingCart( string customerID)
        {
            this.customerID = customerID; 
        }

        public void addItemToCart(Product prod)
        {
            CartItems.Add(prod);
        }

    }
}
