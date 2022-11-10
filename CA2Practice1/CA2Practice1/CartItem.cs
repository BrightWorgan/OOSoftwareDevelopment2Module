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
        private int quantity;
        public int Quantity {
            get
            {
                return quantity;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("\n\t***** ERROR *****\n\tVaild Quantity Required!");
                }
                if (value == 500)
                {
                    throw new Exception("\n\t***** ERROR *****\n\tStock Levels Low!");
                }

                quantity = value;
            } 
        }

        // constructor
        public CartItem(string ProductId, string ProductDescription, double Price, int _Quantity) : base(ProductId, ProductDescription, Price)
        {
            Quantity = _Quantity;
        }


        // ToString()
        public override string ToString()
        {
            return base.ToString() + "\n\tProduct Quantity: " + Quantity;
        }

    }
}
