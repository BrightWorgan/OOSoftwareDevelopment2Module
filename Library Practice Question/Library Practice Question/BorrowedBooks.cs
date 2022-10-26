using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Library_Practice_Question
{
    public class BorrowedBooks : IEnumerable
    {

            // collection of Books
            private List<Book> outOnLoan;
            public List<Book> OutOnLoan
        {
                get
                {
                    return outOnLoan;
                }
            }

            // Constructor
            public BorrowedBooks()
            {
                outOnLoan = new List<Book>();
            }
        public int lenghOfList = outOnLoan.Count;
        // adds books to Student Book Collection
        public void Add(Book novel, string StudentID, string maxOnLoan)
        {
            // 
            

            if (StudentID.Length < 10)
            {
                if (outOnLoan.Count < maxOnLoan)
                {
                    outOnLoan.Add(novel);
                }

            }
            else throw new Exception("\t*** ERROR ***\n\tThat is not a vaild Studnet ID");

        }


        // Remove Book from Library
        public void Remove(Book novel)
        {
            Book toRemove = null;
            //
            foreach (Book book in outOnLoan)
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
                outOnLoan.Remove(toRemove);
            }
            else
            {
                throw new Exception("\t*** ERROR ***\n\tThat book is not present in the Library and therefore cannot be removed!");
            }
        }

        public IEnumerator GetEnumerator()
        {
            return OutOnLoan.GetEnumerator();
        }
    }
     
    }
