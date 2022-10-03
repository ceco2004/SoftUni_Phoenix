using System;

namespace _06._BigestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int bigestNum = int.MinValue;

            while(input != "Stop")
            {
                int.TryParse(input, out int num);
                if(num > bigestNum)
                {
                    bigestNum = num;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(bigestNum);

        }
    }
}
