using System;

namespace _01._BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(1, 100);
            Console.WriteLine(ba.ToString());

            ba.Deposit(1000);
            Console.WriteLine(ba.ToString());
            ba.Withdraw(2000);
            Console.WriteLine(ba.ToString());
            ba.Withdraw(1100);
            Console.WriteLine(ba.ToString());

        }
    }
}
