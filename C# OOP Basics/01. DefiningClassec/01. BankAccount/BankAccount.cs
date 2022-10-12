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
            set
            {
                if(value > 0)
                {
                    this.balance = value;
                }
            }
        }

        public BankAccount() { }

        public BankAccount(int id, decimal balance)
        {
            this.id = id;
           // this.balance = balance;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"Bank account with ID {this.id} have {this.balance} money.";
        }
    }
}
