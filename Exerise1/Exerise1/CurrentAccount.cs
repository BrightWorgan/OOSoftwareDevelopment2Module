namespace Exerise1
{
    class CurrentAccount : BankAccount
    {

        // list of transaction history
        private List<AccountTransaction> accountTransactions;

        // overdraft
        private double overdraft;

        public double Overdraft { get { return overdraft; } set { overdraft = value; } }

        // constructor
        public CurrentAccount(string inputAccNum) : base(inputAccNum)
        {
            overdraft = 0;
            accountTransactions = new List<AccountTransaction>();
        }

        // overinding abstract methods from Super Class/ Bank Account
        public override void MakeDeposit(double amount)
        {
            AccountTransaction t1 = new AccountTransaction(TransactionType.Deposit, amount);
            AccountBalance += amount;
            accountTransactions.Add(t1);
        }

        public override void MakeWithdrawl(double amount)
        {
            if (amount > AccountBalance + overdraft)
            {
                throw new Exception("\t ***\t ERROR \t ****\n\t Insufficient Funds");
            }
            AccountTransaction t1 = new AccountTransaction(TransactionType.Withdrawal, amount);
            AccountBalance -= amount;
            accountTransactions.Add(t1);
        }

        public override string ToString()
        {
            //
            string txt = "\tAccount Details: \n";
            txt += "\tAccount Number: " + AccountNumber + "\n\tCurrent Balance: " + AccountBalance;
            foreach (AccountTransaction item in accountTransactions)
            {
                txt += "\n\t" + item.ToString();
            }
            return txt;
        }
    }
}

