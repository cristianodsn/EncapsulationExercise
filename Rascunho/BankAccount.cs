using System;
using System.Globalization;

namespace Rascunho
{
    class BankAccount
    {
        private double _rate = 5.00;
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
            Balance = 0.0;
        }

        public BankAccount(int number, string holder, double balance) : this(number, holder)
        {
            Deposit(balance);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount + _rate)
            {
                Balance -= amount + _rate;
            }

            else if (amount <= Balance && Balance <= amount + _rate)
            {
                Console.WriteLine("You do not have a balance to withdraw this amount  and cover the fee.");
            }

            else
            {
                Console.WriteLine("You do not have sufficient balance to make the withdrawal.");
            }
        }

        public override string ToString()
        {
            return $"Account: {Number}, Holder: {Holder}, Banck balance: {Balance.ToString()}";
        }
    }
}
