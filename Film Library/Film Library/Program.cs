// See https://aka.ms/new-console-template for more information
using Film_Library;

Console.WriteLine("Hello, World!");

/*
 * Films to Add! 
The Deer Hunter
Snatch
Old Boy
Leon: The Professional
Scarface
Monty Pythons Life of Brian
In Bruges
3 Idiots
Dirty Dancing
Lawrence of Arabia
Mary & Max
This is Spinal Tap
The Intouchables
American History X
Seven Samurai
The Great Dictator
Boyz in the Hood
Trainspotting
The Pianist
Dr. Strangelove
Vertigo
Amadeus
Enter the Dragon
Gangs of New York*/

// Films
Film f1 = new Film("Casablanca", new DateOnly(1942, 01, 23), Genres.Drama, Genres.War, Genres.Romance, 0 );
Film f2 = new Film("Enter the Dragon", new DateOnly(1973, 07, 26), Genres.Martial_Arts, Genres.Action, Genres.Adventure, 4);
Film f3 = new Film("Endless", new DateOnly(2017, 04, 21), Genres.Sci_Fi, Genres.Fantasy, Genres.Adventure, 5);
Film f4 = new Film("The Matrix", new DateOnly(1999, 1, 1), Genres.Action, Genres.Sci_Fi, Genres.Adventure, 4);
Film f5 = new Film("The Terminator", new DateOnly(1984, 1, 1), Genres.Sci_Fi, Genres.Fantasy, Genres.Adventure, 4);
Film f6 = new Film("City of God", new DateOnly(2022, 1, 1), Genres.Sci_Fi, Genres.Fantasy, Genres._____, 0);
Film f7 = new Film("Endless", new DateOnly(2002, 1, 1), Genres.Crime, Genres.Drama, Genres.Adventure, 5);
Film f8 = new Film("Alien", new DateOnly(1979, 1, 1), Genres.Sci_Fi, Genres.Action, Genres.Horror, 5);
Film f9 = new Film("No Country for Old Men", new DateOnly(2007, 1, 1), Genres.Crime, Genres.Drama, Genres.Thriller, 5);
Film f10 = new Film("Up", new DateOnly(2009, 1, 1), Genres.Animation, Genres.Adventure, Genres.Family, 5);
Film f11 = new Film("Braveheart", new DateOnly(1995, 1, 1), Genres.Biography, Genres.Drama, Genres.History, 0);
Film f12 = new Film("Psycho", new DateOnly(1960, 1, 1), Genres.Horror, Genres.Mystery, Genres.Thriller, 0);
Film f13 = new Film("Jaws", new DateOnly(1975, 1, 1), Genres.Adventure, Genres.Thriller, Genres._____, 5);
Film f14 = new Film("Back to the Future", new DateOnly(1985, 1, 1), Genres.Adventure, Genres.Comedy, Genres.Sci_Fi, 0);
Film f15 = new Film("Inception", new DateOnly(2010, 1, 1), Genres.Action, Genres.Adventure, Genres.Sci_Fi, 0);
Film f16 = new Film("The Notebook ", new DateOnly(2004, 1, 1), Genres.Drama, Genres.Romance, Genres._____, 0);
Film f17 = new Film("Little Miss Sunshine", new DateOnly(2006, 1, 1), Genres.Comedy, Genres.Drama, Genres._____, 3);
Film f18 = new Film("The Silence of the Lambs", new DateOnly(1991, 1, 1), Genres.Crime, Genres.Drama, Genres.Thriller, 4);
Film f19 = new Film("Four Weddings and a Funeral", new DateOnly(1994, 06, 3), Genres.Comedy, Genres.Romance, Genres.Drama, 0);
Film f20 = new Film("Gladiator", new DateOnly(2000, 1, 1), Genres.Action, Genres.Adventure, Genres.History, 0);


//Film f00 = new Film("____", new DateOnly(1991, 1, 1), Genres._, Genres._, Genres._, 0);

// Checklist List
List<Film> checklList = new List<Film>();

// adding Film objects to the Checklist List
checklList.Add(f1);
checklList.Add(f2);
checklList.Add(f3);
checklList.Add(f4);
checklList.Add(f5);
checklList.Add(f6);
checklList.Add(f7);
checklList.Add(f8);
checklList.Add(f9);
checklList.Add(f10);
checklList.Add(f11);
checklList.Add(f12);
checklList.Add(f13);
checklList.Add(f14);
checklList.Add(f15);
checklList.Add(f16);
checklList.Add(f17);
checklList.Add(f18);
checklList.Add(f19);
checklList.Add(f20);

//
//Console.WriteLine("\tPlease enter a film!\n\t: ");

// 
//public string userFilm = Console.ReadLine();


// AddItem() RemoveFilm AddFiveStarItem

watchList.AddItem();
