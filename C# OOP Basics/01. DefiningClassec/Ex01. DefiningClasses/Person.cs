namespace Ex01._DefiningClasses
{
    public class Person
    {
        private int age;
        private string name;

        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Age = 1;
            Name = "No name";
        }

        public Person (int age): this()
        {
            Age = age;
        }

        public Person(string name, int age): this(age)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Person name: {Name}, person age: {Age} Years";
        }
    }
}
