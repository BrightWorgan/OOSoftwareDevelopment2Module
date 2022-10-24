using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice_Question
{
    // Book Class
    public class Book
    {
        // Enum of Book Genres available
        public enum Genre
        {
            Fiction,
            Fantasy,
            Science_Fiction,
            Dystopian,
            Action,
            Adventure,
            Mystery,
            Horror,
            Comedy,
            Thriller,
            True_Crime,
            Historical_Fiction,
            Romance,
            Biography,
            History,
            Religion,
            Travel,
            Language,
            Guides,
            Young_Adult,
            Childrens,
        }


        // class fields
        //ISBN
        private string bookISBN;
        public string BookISBN 
        { 
            get { return bookISBN; } 
            set { bookISBN = value; } 
        }
            
        //Name
        private string bookName;
        public string BookName 
        {
            get { return bookName; } 
            set { bookName = value; } 
        }

        // Main Category
        private Genre bookCategory;
         public Genre BookCategory
        { 
            get { return bookCategory; } 
            set { bookCategory = value; }
        }

        // Extra Category

        // Constructor
        public Book (string _bookISBN, string _bookName, Genre _bookCategory)
        {
            this.bookISBN = _bookISBN;
            this.bookName = _bookName;
            this.bookCategory = _bookCategory;
        }

        // ToString()
        public override string ToString()
        {
            return "\tTitle: " + bookName + "\tISBN: " + bookISBN + "\tGenre: " + bookCategory;
        }
    }
}
