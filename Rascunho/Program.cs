using System;
using System.Globalization;

namespace Rascunho
{
    class Program
    {      
        static void Main(string[] args)
        {
            BankAccount bankAccount;
            double amount;
            Console.Write("Enter the account number:");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the holder account:");
            string hoder = Console.ReadLine();
            Console.Write("Is there an initial deposit (S/N)? ");
            char isThereDeposit = char.Parse(Console.ReadLine().ToUpper());
            if(isThereDeposit == 'S')
            {
                Console.Write("Enter the amount to initial deposit: ");
                amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bankAccount = new BankAccount(number, hoder, amount);
            }
            else
            {
                bankAccount = new BankAccount(number, hoder);
            }
            Console.WriteLine("Account data:");
            Console.WriteLine(bankAccount);
            Console.Write("Enter the amount to deposit: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bankAccount.Deposit(amount);
            Console.WriteLine(bankAccount);
            Console.Write("Enter the amount to withdraw: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            bankAccount.Withdraw(amount);
            Console.WriteLine(bankAccount);

            Console.ReadKey();
        }      

    }
}
