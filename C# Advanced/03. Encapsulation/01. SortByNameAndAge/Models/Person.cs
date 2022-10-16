namespace _01._SortByNameAndAge.Models
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public string FirstName { get => firstName; private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int Age { get => age; private set => age = value; }
        public decimal Salary { get => salary; private set => salary = value; }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName, int age, decimal salary)
                        :this(firstName, lastName, age)
        {
            Salary = salary;
        }

        public void	IncreaseSalary(decimal percent)
        {
            if(Age < 30)
            {
                percent = percent / 2;
            }

            Salary += Salary * percent / 100;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} recives {Salary:f2} leva.";
        }
    }
}
