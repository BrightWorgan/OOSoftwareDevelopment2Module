using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice_Question
{
    // ReferenceBook a sub class of Book
    public class ReferenceBook : Book
    {

        // fields
        private int maxLoanTime;
        public int MaxLoanTime 
        { 
            get { return maxLoanTime; } 
            set { maxLoanTime = value; } 
        }

        // Constructor
        public ReferenceBook(string _bookISBN, string _bookName, Genre _bookCategory, int _maxLoanTime) : base(_bookISBN, _bookName, _bookCategory)
        {
            this.maxLoanTime = _maxLoanTime;
        }

        // ToString()
        public override string ToString()
        {
            return "\t*** URGENT ***\n\t This Book as a maximum loan of " + maxLoanTime + " days\n" + "\n\tBook Details: " + base.ToString();
        }
    }
}
