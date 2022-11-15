// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Program
{
    static void Main()
    {
       Console.WriteLine( Pow(2, 4));
    }

    static double Pow(double num, int n)
    {
        if (n == 0)
        {
            return 1;
        }

        if (n == 1)
        {
            return num;
        }

        return num * Pow(num, n - 1);
    }
}