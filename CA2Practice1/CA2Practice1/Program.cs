// See https://aka.ms/new-console-template for more information
using CA2Practice1;

Console.WriteLine("Hello, World!");


// ProductId, ProductDescription, Price

var cart = new List<CartItem>() 
{
    new CartItem(00001, "Hue LED Bulb", 25, 22),
    new CartItem(00002, "Raspberry Pie", 150, 5),
    new CartItem(00003, "Alexa Echo", 55, 10),
    new CartItem(00004, "IPhone 12 Pro", 165, 2),
    new CartItem(00005, "Mac Air", 450, 3)
};

CartItem test1 = new CartItem(00001, "Hue LED Bulb", 25, 22);
Console.WriteLine(test1.ToString());