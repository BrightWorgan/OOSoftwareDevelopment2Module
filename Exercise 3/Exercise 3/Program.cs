// See https://aka.ms/new-console-template for more information
using Exercise_3;
using System;

Uri test2 = new Uri("http://www.google.com");


Favourite test3 = new Favourite("My Instagram Page", "https://www.instagram.com/vegan_wolf_pack/");
Favourite test4 = new Favourite("Blog Page", "https://wicklowwolfpack.com/");
Favourite test5 = new Favourite("Linked In", "https://www.linkedin.com");
Favourite test6 = new Favourite("GitHub Page", "https://github.com/BrightWorgan?tab=overview&from=2022-10-01&to=2022-10-20");
Favourite test7 = new Favourite("Personal Twitch", "https://www.twitch.com.");
Console.WriteLine(test3.ToString());
test3.UrlName = "Oops";
test3.UrlAddress = "https://www.youtube.com/watch?v=dQw4w9WgXcQ/";
Console.WriteLine(test3.ToString());

FavouritesCollection collection = new FavouritesCollection();

collection.Add(test3);
collection.Add(test4);
collection.Add(test5);
collection.Add(test6);
collection.Add(test7);

foreach (Favourite i in collection)
{
    Console.WriteLine(i.ToString());
}

collection.Remove("GitHub Page");

foreach (Favourite i in collection)
{
    Console.WriteLine(i.ToString());
}