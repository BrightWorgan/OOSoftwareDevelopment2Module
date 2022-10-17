using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerise1
{
    abstract class BankAccount
    {
        public string AccountNumber { get; }
        public double AccountBalance { get; set; }

        // constructor that sets acc num to input value
        // and constructor that sets bal to zero
        public BankAccount(string inputAccNum)
        {
            AccountNumber = inputAccNum;
            AccountBalance = 0;
        }

        // abstract methods
        // MakeDeposit
        public abstract void MakeDeposit( double amount);

        // MakeWithdrawl
        public abstract void MakeWithdrawl(double amount);
    }
}
