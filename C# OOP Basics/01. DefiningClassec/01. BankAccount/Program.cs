using System;
using System.Collections.Generic;

namespace _01._BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<int, BankAccount> bank = new Dictionary<int, BankAccount>();

            while(input != "END")
            {
                string[] data = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (data[0])
                {
                    case "Create": Create(data, bank);
                        break;
                    case "Deposit": Deposit(data, bank);
                        break;
                    case "Withdraw": Withdraw(data, bank);
                        break;
                    case "Print": Print(int.Parse(data[1]), bank);
                        break;
                }
                input = Console.ReadLine();
            }
        }

        private static void Print(int id, Dictionary<int, BankAccount> bank)
        {
            string msg = string.Empty;

            if (bank.ContainsKey(id) == false)
            {
                msg = $"Account with ID- {id} does not exist!";
            }
            else
            {
                msg = bank[id].ToString();
            }

            PrintMessage(msg);
        }

        private static void Withdraw(string[] data, Dictionary<int, BankAccount> bank)
        {
            int id = int.Parse(data[1]);
            int amount = int.Parse(data[2]);
            string msg = string.Empty;

            if(bank.ContainsKey(id) == false)
            {
                msg = $"Account with ID- {id} does not exist!";
            }
            else if(bank[id].Balance < amount)
            {
                msg = "You havn't enought money!";
            }
            else
            {
                bank[id].Withdraw(amount);
                msg = $"You successful withdraw {amount} money!";
            }

            PrintMessage(msg);
        }


        private static void Deposit(string[] data, Dictionary<int, BankAccount> bank)
        {
            int id = int.Parse(data[1]);
            int amount = int.Parse(data[2]);
            string msg = string.Empty;

            if (bank.ContainsKey(id))
            {
                bank[id].Deposit(amount);
                msg = $"You successful deposit {amount} money!";
            }
            else
            {
                msg = $"Account with ID- {id} does not exist!";
            }

            PrintMessage(msg);
        }

        private static void Create(string[] data, Dictionary<int, BankAccount> bank)
        {
            int id = int.Parse(data[1]);
            string msg = string.Empty;

            if (bank.ContainsKey(id))
            {
                msg = $"Account with ID- {id} already exists!";
            }
            else
            {
                BankAccount ba = new BankAccount(1);
                bank[id] = ba;
                msg = $"Bank account with ID-{id}, was sucsesfull created!";
            }

            PrintMessage(msg);
        }

        private static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
