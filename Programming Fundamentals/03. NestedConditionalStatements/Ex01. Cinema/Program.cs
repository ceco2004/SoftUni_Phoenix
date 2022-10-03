using System;

namespace Ex01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double price = 0;

            switch (type)
            {
                case "Premiere":
                    price = 12;
                    break;
                case "Normal":
                    price = 7.5;
                    break;
                case "Discount":
                    price = 5;
                    break;
            }

            double income = price * row * col;

            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
