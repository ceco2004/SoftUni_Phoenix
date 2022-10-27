using System;

namespace _03._GenericScale
{
    class Program
    {
        static void Main()
        {
            Cat pufi = new Cat("Pufi", 3, 4);
            Cat maca = new Cat("Maca", 5, 3);

            var hevier = Scale.GetHeavier(pufi, maca);
            Console.WriteLine(hevier);
        }
    }

    public class Cat : IComparable<Cat>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weith { get; set; }

        public Cat(string name, int age, double weith)
        {
            Name = name;
            Age = age;
            Weith = weith;
        }

        public override string ToString()
        {
            return $"{Name} - {Age} years, {Weith}kg.";
        }
        public int CompareTo(Cat other)
        {
            if(this.Weith > other.Weith)
            {
                return 1;
            }
            else if(this.Weith < other.Weith)
            {
                return -1;
            }

            return 0;
        }
    }
}
