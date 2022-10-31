// See https://aka.ms/new-console-template for more information
class LambdasAndDelegates
{
    public static void addNumbersAndPrint(int x, int y)
    {
        Console.WriteLine(x + y);
    }
    public static void doMyThing(Action<int, int> myFunc)
    {
        myFunc(2,3);
    }
    public static void Main()
    {
        addNumbersAndPrint(2, 3);
        doMyThing((x, y) =>
        {
            Console.WriteLine(x * y);
        });
    }
}
