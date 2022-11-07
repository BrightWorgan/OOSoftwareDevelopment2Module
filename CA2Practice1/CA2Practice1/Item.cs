using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2Practice1
{
   public class Item
    {
        // a.	the product code (it must be 5 characters in length at minimum and must not contain white space characters)
        public int ProductId { 
            get
            {
                if (ProductId < 5)
                {
                    return ProductId;
                }
            }
            set 
            { 
                ProductId = value; 
            }
        }
        // b.the product description – no validation required
       
        public string ProductDescription { get; set; }

        // c.the product price(euros) – no validation required
        public double Price { get; set; }

        // constructor
        public Item(int ProductId, string ProductDescription, double Price)
        {
            ProductId = 0;
            ProductDescription = "";
            Price = 0;
        }

        // ToStrigg()
        public override string ToString()
        {
            return "\n\tProduct ID: " + "\n\tProduct Description: " + ProductDescription + "\n\tProduct Price: "  + Price;
        } 

    }
}
