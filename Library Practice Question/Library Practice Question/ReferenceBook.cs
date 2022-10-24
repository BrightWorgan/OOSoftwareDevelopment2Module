using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice_Question
{
    public class ReferenceBook : Book
    {

        // fields
        private string maxLoantime;
        public string MaxLoanTime { get; set; }

        // Constructor
        public ReferenceBook(string _bookISBN, string _bookName, Genre _bookCategory, string _maxLoantime) : base(_bookISBN, _bookName, _bookCategory)
        {
            this.MaxLoanTime = _maxLoantime;
        }
    }
}
