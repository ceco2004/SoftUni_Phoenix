using _01._BankAccounts;
using System.Collections.Generic;
using System.Linq;

namespace _02._PersonClass
{
    public class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            accounts = new List<BankAccount>();
        }

        public Person(string name, int age, List<BankAccount> accounts):this(name, age)
        {
            accounts.AddRange(accounts);
        }

        public decimal GetBalance()
        {
            return accounts.Sum(a => a.Balance);
        }
    }
}
