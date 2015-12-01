using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermProjectClassLib
{
    [Serializable]
    class ShoppingCart
    {
        public Product[] CartItems;
        public string cartID;
        public string customerID;

        public ShoppingCart()
        {
        }

        public ShoppingCart(Product[] CartItems, string customerID)
        {
            this.CartItems = CartItems;
            this.customerID = customerID;
        }

    }
}
