namespace Ex06._Animals.Models
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, "Male")
        {
        }

        public Tomcat(string name, int age, string gender) : this(name, age)
        {
        }

        public override string ProduceSound()
        {
           return "MEOW";
        }
    }
}
