namespace Ex06._Animals.Models
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, null)
        {
        }

        public Kitten(string name, int age, string gender) : this(name, age)
        {
        }

        public override string ProduceSound()
        {
            return"Meow";
        }
    }
}
