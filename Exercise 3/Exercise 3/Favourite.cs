using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    public class Favourite
    {
        // fields
        private string urlName;
        public string UrlName {
            get
            {
                return urlName;
            }
            set {
                if (value == "")
                {
                    throw new ArgumentException();
                }
               urlName = value;
            }
        }

        private Uri urlAddress;
        public string UrlAddress { 
            get
                {
                return urlAddress.ToString(); 
            }
            set
            {
                if (value == "")
                {
                    throw new UriFormatException();
                }
                urlAddress = new Uri(value);
            }
        }

        // constructor
        public Favourite(string _urlName, string _urlAddress) 
        {
            urlName = _urlName;

            UrlAddress = _urlAddress;
        }

        // ToString
        public override string ToString()
        {
            return "\tFavourite URL Name: " + urlName + "\n\tURL: " + UrlAddress;
        }

    }
}
