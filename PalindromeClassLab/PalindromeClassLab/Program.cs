// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// is the string given a palindrome
// 
namespace PalinDo
{
    static void Main(string[] args)
    {
        if (!CheckArgs(args))
        {
            return;
        }
    }

    private static bool CheckArgs(string[] args)
    {
        if (args.Length)
        {
            Console.WriteLine("");
                return;
        }
    }
}