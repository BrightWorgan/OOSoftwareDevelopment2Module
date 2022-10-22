// See https://aka.ms/new-console-template for more information
using Exercise_3;
using System;

Uri test2 = new Uri("http://www.google.com");


Favourite test3 = new Favourite("My Instagram Page", "https://www.instagram.com/vegan_wolf_pack/");
Console.WriteLine(test3.ToString());
test3.UrlName = "Oops";
test3.UrlAddress = "https://www.instagram.com/";
Console.WriteLine(test3.ToString());

FavouritesCollection collection = new FavouritesCollection();
collection.Add(test3);
collection.Add(test3);
