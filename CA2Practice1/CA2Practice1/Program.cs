// See https://aka.ms/new-console-template for more information
using CA2Practice1;

Console.WriteLine("Hello, World!");


// ProductId, ProductDescription, Price
static void Main()
{
    
    Item prd1 = new Item() { productID = "00001", ProductDescription = "Hue LED Bulb", Price = 25 };
    Item itm1 = new Item() { ProductID = "123XY", ProductDescription = "Cuddly Toy", Price = 5.95 };
    Item itm2 = new Item() { ProductID = "ABC444", ProductDescription = "Hoover", Price = 79.55 };
    Item itm3 = new Item() { ProductID = "ABB77", ProductDescription = "Playstation 5", Price = 150.99 };
    Item itm4 = new Item() { ProductID = "AZG999", ProductDescription = "Settee", Price = 250.99 };
    Item itm5 = new Item() { ProductID = "HDC890", ProductDescription = "Coffee Grinder", Price = 59.65 };
    /*ew Item("00002", "Raspberry Pie", 150, 5),
    new Item("00003", "Alexa Echo", 55, 10),
    new Item("00004", "IPhone 12 Pro", 165, 2),
    new Item("00005", "Mac Air", 450, 3)*/

    ShoppingCart cart = new ShoppingCart();

    // Testing from eari-ler:
    /*CartItem test1 = new CartItem("00001, "Hue LED Bulb", 25, 22);
    Console.WriteLine(test1.ToString());*/


    for (int i = 0; i < cart.Count(); i++)
    {
        Console.WriteLine(cart[i]);
    }

    Console.WriteLine();
}

