using System;

namespace Ex08._Tenis
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfMach = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int turnirPoints = 0;
            int wineTurnir = 0;

            for(int i = 0; i < numbersOfMach; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "W": wineTurnir++; turnirPoints += 2000; break;
                    case "F": turnirPoints += 1200; break;
                    case "SF": turnirPoints += 720; break;
                }
            }

            string message = string.Empty;
            message = $"Final points: {startPoints + turnirPoints}";
            message += $"\nAverage points: {Math.Ceiling((turnirPoints) / numbersOfMach * 1.0)}";
            message += $"\n{wineTurnir /(numbersOfMach * 1.0) * 100:f2}%";
            Console.WriteLine(message);
        }
    }
}
