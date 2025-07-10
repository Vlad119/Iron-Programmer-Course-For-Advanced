using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            BankAccount accountA = new BankAccount() { Balance = 200 };
            BankAccount accountB = new BankAccount() { Balance = 300 };
            Console.WriteLine(accountA + accountB);
        }
    }
}
