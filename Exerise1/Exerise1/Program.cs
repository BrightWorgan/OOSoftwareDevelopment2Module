// See https://aka.ms/new-console-template for more information
using System;

namespace Exerise1
{
    // 
    public class Program
    {
        static void Main()
        {
            //  create current account opbject
            CurrentAccount a1 = new CurrentAccount("asdf");
            a1.MakeDeposit(600.23);
            a1.MakeWithdrawl(250.50);
            a1.Overdraft = 700;
            a1.MakeWithdrawl(500);
            Console.WriteLine(a1);
        }
    }
}

