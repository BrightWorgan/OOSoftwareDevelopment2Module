using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2Practice1
{
   public class Item
    {
        // the product code (it must be 5 characters in length at minimum and must not contain white space characters)
        private string productId;
        public string ProductId 
        {
            get
            {
                return productId;
            }
            set 
            {
                if (String.IsNullOrWhiteSpace(value) || (value.Length < 5))
                {
                    throw new ArgumentException("\n\t*** ERROR ***\n\tInvaild Product ID!");
                }
                productId = value;
            }
        }
        // the product description – no validation required
       
        public string ProductDescription { get; set; }

        // the product price(euros) – no validation required
        public double Price { get; set; }

        // constructor
        public Item(string _ProductId, string _ProductDescription, double _Price)
        {
             ProductId = _ProductId;
            ProductDescription = _ProductDescription;
            Price = _Price;
        }

        // ToString()
        public override string ToString()
        {
            return String.Format("\n\tProduct ID: {0}\n\tProduct Description: {1}\n\tProduct Price: {2}", ProductId, ProductDescription, Price) ;
        } 

    }
}
