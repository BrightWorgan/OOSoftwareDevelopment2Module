// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using OverLoad;

namespace Overload
{
    public class Progran
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
        }

        Account acc1 = new Account("qwerty", 121.23);
        Account acc2 = new Account("Woah", 25533.99);

        Account both = acc1 + acc2;
    }
}
