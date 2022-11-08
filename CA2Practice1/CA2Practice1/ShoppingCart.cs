using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2Practice1
{
    public class ShoppingCart
    {
        // collection of cart items
        private List<CartItem> cart = new List<CartItem>();

        // Add a method to add an Item into the cart
        public void UpdateCart(Item _product)
        {
            CartItem found = cart.FirstOrDefault(p => p.ProductId == _product.ProductId);
            
            if (found == null)
            {
                cart.Add(new CartItem() { ProductId = _product})
            }
            else
            {
                found.Quantity++;
            }
        }


        // Add a read-only indexer to the class

        // Add a method which calculates and reports the total price of all items in the cart

        /*public int CalculateTotal(CartItem product)
        {
            int count = 0;
            foreach (i in cart)
            {
                count += 1;
            }
        }*/

        public CartItem this[String _code]
        {
            get
            {
                CartItem found = cart.FirstOrDefault(p=>p.ProductId.ToUpperInvariant().Equals(_ProductId.ToUpper)

            }
        }

    }
}
