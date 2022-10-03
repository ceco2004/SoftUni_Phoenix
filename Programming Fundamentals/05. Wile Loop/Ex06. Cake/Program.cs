using System;

namespace Ex06._Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int cakePices = a * b;
            string msg = string.Empty;

            while(cakePices >= 0)
            {
                string input = Console.ReadLine();
                if(input == "STOP")
                {
                    msg = $"{cakePices} pieces are left.";
                    break;
                }

                int neededPices = int.Parse(input);

                cakePices -= neededPices;
            }

            if (msg == string.Empty)
            {
                msg = $"No more cake left! You need {Math.Abs(cakePices)} pieces more.";
            }

            Console.WriteLine(msg);
        }
    }
}
