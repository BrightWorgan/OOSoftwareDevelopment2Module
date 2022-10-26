using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice_Question
{
    // library class
  public  class Library : IEnumerable
    {
        // collection of Books
        private List<Book> librarySystem;
        public List<Book> LibrarySystem 
        { 
            get 
            { 
                return librarySystem; 
            } 
        }

        // Constructor
        public Library()
        {
            librarySystem = new List<Book>();
        }
        
        /*
        public Library(Book oneBook)
        {
            librarySystem = new List<Book>();
            librarySystem.Add(oneBook);
        }*/


        // Add Book to Library
        public void Add(Book novel)
        {
            // checks that the book is not already in the library
            foreach (Book book in librarySystem)
            {

                if (novel.BookISBN == book.BookISBN)
                {
                    throw new Exception("\t*** ERROR ***\n\tThat book is already in the Library\n\tISBN must be unique!");
                }
                    
            }
           librarySystem.Add(novel);
        }


        // Remove Book from Library
        public void Remove(Book novel)
        {
            Book toRemove = null;
            //
            foreach (Book book in librarySystem)
            {
                if (novel.BookISBN == book.BookISBN)
                {
                    /*if (book.MaxLoantime == ReferenceBook.MaxLoanTime)
                    {
                        throw new Exception("\t*** ERROR ***\n\tThat book cannot be removed!");
                    }*/
                    toRemove = book;
                    break;
                    
                }

            }
            if (toRemove != null)
            {
                librarySystem.Remove(toRemove);
            }
            else
            {
                throw new Exception("\t*** ERROR ***\n\tThat book is not present in the Library and therefore cannot be removed!");
            }
        }


        // Find book by ISBN
        public Book this[string bookISBN]
        {
            get
            {
                foreach (Book b in librarySystem)
                {
                    if (b.BookISBN == bookISBN)
                    {
                        return b;
                    }
                }
                throw new Exception("\t*** ERROR ***\n\tThat book/ ISBN does not in the Library ");
            }
        }

        // Find Book by Genre
        public Book this[Book.Genre bookCategory]
        {
            get
            {
                foreach (Book c in librarySystem)
                {
                    if (c.BookCategory == bookCategory)
                    {
                       return c;
          
                    }
                }
                throw new Exception("\t*** ERROR ***\n\tThat book/ ISBN does not in the Library ");
            }
        }

        public List<Book> BookCount(Book.Genre bookCategory)
        {
            List<Book> BCount = new List<Book>();
            foreach (Book b in librarySystem)
            {
                if (b.BookCategory == bookCategory)
                {
                    BCount.Add(b);
                }
            }
            if (BCount.Count <= 0)
            {
                throw new Exception("\t*** ERROR ***\n\tThere are no books under the Genre " + " currently in the TU Library!");
            }
            return BCount;
        }

        // emumerator
        public IEnumerator GetEnumerator()
        {
            return librarySystem.GetEnumerator();
        }

    }
}
