// See https://aka.ms/new-console-template for more information
using Library_Practice_Question;
using System;
using System.Diagnostics;
using static Library_Practice_Question.Book;

//creating new books
ReferenceBook Book0 = new ReferenceBook("TULB1FG150000001", "The Prehistoric Archaeology of Ireland Paperback", Genre.History, 2);
Book Book1 = new Book("TULB1FG170000007", "Lonely Planet Ireland - Travel Guide (Paperback)", Genre.Travel);
Book Book2 = new Book("TULB1FG170000029", "Lonely Planet Japan (Travel Guide) Paperback", Genre.Travel);
Book Book3 = new Book("TULB3FG080002069", "The Call of Cthulhu", Genre.Horror);
Book Book4 = new Book("TULB3FG080002070", "At the Mountains of Madness and Other Weird Tales", Genre.Horror);
Book Book5 = new Book("TULB3FG080002072", "The Best of H.P. Lovecraft: Bloodcurdling Tales of Horror and the Macabre", Genre.Horror);
Book Book6 = new Book("TULB4FG080002120", "River God", Genre.Fiction);
Book Book7 = new Book("TULB4FG080002123", "The New Kingdom", Genre.Fiction);
Book Book8 = new Book("TULB4FG120003000", "Sharpe's Tiger:", Genre.Historical_Fiction);
Book Book9 = new Book("TULB4FG120003001", "Sharpe's Triumph:", Genre.Historical_Fiction);
Book Book10 = new Book("TULB4FG120003002", "Sharpe's Fortress:", Genre.Historical_Fiction);
Book Book11 = new Book("TULB4FG120003003", "Sharpe's Trafalgar:", Genre.Historical_Fiction);
Book Book12 = new Book("TULB4FG120003004", "Sharpe's Prey:", Genre.Historical_Fiction);
Book Book13 = new Book("TULB4FG120003005", "Sharpe's Rifles:", Genre.Historical_Fiction);
Book Book14 = new Book("TULB4FG120003006", "Sharpe's Havoc:", Genre.Historical_Fiction);
Book Book15 = new Book("TULB2FG14000", "The Autobiography of Peig Sayers of the Great Blasket Island", Genre.Biography);

//
Library TULibrary = new Library();

// adding newly created books to the library collection
TULibrary.Add(Book0);
TULibrary.Add(Book1);
TULibrary.Add(Book2);
TULibrary.Add(Book3);
TULibrary.Add(Book4);
TULibrary.Add(Book5);
TULibrary.Add(Book6);
TULibrary.Add(Book7);
TULibrary.Add(Book8);
TULibrary.Add(Book9);
TULibrary.Add(Book10);
TULibrary.Add(Book11);
TULibrary.Add(Book12);
TULibrary.Add(Book13);
TULibrary.Add(Book14);
TULibrary.Add(Book15);
    
    

// ToString() to print out all books from the library
foreach (Book b in TULibrary)
{
    Console.WriteLine(b.ToString());
}

// removing books from the Library
TULibrary.Remove(Book5);


// ToString() to print out all books from the library
foreach (Book b in TULibrary)
{
    Console.WriteLine(b.ToString());
}

// Find book by ISBN

// Find Book by Genre
foreach (Book c in TULibrary.BookCount(Genre.History))
{
    Console.WriteLine(c.ToString());
}
