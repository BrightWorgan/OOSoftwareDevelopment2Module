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
            CartItem found = cart.FirstOrDefault(p => p.ProductId.ToUpperInvariant().Equals(_product.ProductId.ToUpperInvariant()));
            if (found == null)
            {
                cart.Add(new CartItem() { ProductId = _product.ProductId, ProductDescription = _product.ProductDescription, Price = _product.Price, Quantity = 1 });
            }
            else
            {
                found.Quantity++;
            }
        }


        // Add a read-only indexer to the class

        // Add a method which calculates and reports the total price of all items in the cart

        public int CalculateTotal()
        {
            return (int)cart.Sum(p => p.Price * p.Quantity);
        }

        public int Count()
        {
            return cart.Count();
        }

        /*public CartItem this[String _ProductId]
        {
            get
            {
                CartItem found = cart.FirstOrDefault(p => p.ProductId.ToUpperInvariant().Equals(_ProductId.ToUpperInvariant));

            }
        }*/

    }
}
