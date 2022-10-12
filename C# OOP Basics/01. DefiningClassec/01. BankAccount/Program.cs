using System;

namespace _01._BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount(1, 10);
            ba.Balance = -10;

            Console.WriteLine(ba.ToString());
        }
    }
}
