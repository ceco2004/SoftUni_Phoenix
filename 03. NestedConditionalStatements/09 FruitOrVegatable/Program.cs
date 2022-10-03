using System;

namespace _09_FruitOrVegatable
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string type = string.Empty;

            if (name == "banana" || name == "apple" || name == "kiwi"
                || name == "cherry" || name == "lemon" || name == "grapes")
            {
                type = "fruit";
            }
            else if (name == "tomato" || name == "cucumber" || name == "pepper" || name == "carrot")
            {
                type = "vegetable";
            }
            else
            {
                type = "unknown";
            }

            Console.WriteLine(type);
        }
    }
}
