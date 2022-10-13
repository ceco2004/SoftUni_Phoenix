using System;
using System.Collections.Generic;
using System.Text;

namespace _01._BankAccount
{
    class BankAccount
    {
        private int id;

        private decimal balance;

        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }

        public decimal Balance
        {
            get { return this.balance; }
            private set { this.balance = value; }
        }

        public BankAccount() { }

        public BankAccount(int id, decimal balance = 0)
        {
            Id = id;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
        }


        public override string ToString()
        {
            return $"Bank account with ID {this.id} have {this.balance} money.";
        }
    }
}
