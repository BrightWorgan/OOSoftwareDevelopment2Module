using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoad
{
    internal class Account
    {
        public string Name { get;}    
        public double Balance { get; }

        // constructor
        public Account()
        {
            Name = "Qwerty";
            Balance = 0;
        }

        public Account(string _name, double _balance)
        {
            Name = _name;
            Balance = _balance;
        }


        public Account operator +(Account acLeft, Account acRight)
        {
            return new Account(acLeft.Name, acLeft.Balance, + acRight.Balance);
        }
    }
