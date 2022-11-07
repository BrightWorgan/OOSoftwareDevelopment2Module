using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2Practice1
{
    public  class CartItem : Item
    {
        // quantity of the item in the cart – use an auto-implemented property
        int Quantity { get; set; }

        // constructor
        public CartItem(int ProductId, string ProductDescription, double Price, int Quantity) : base(int ProductId, string ProductDescription, double Price)
        {
            Quantity = 0;
        }


        // ToString()
        public override string ToString()
        {
            return base.ToString() + "\n\tProduct Quantity: " + Quantity;
        }

    }
}
