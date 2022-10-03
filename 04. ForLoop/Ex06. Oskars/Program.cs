using System;

namespace Ex06._Oskars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actiorName = Console.ReadLine();
            double actiorPoints = double.Parse(Console.ReadLine());
            int jorey = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for(int i = 0; i < jorey; i++)
            {
                string jName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());
                double extraPoints = jName.Length * points / 2;
                actiorPoints +=extraPoints;
                if(actiorPoints >= 1250.5)
                {
                    message = $"Congratulations, {actiorName} got a nominee for leading role with {actiorPoints:f1}!";
                    break;
                }
            }

            if(message == string.Empty)
            {
                message = $"Sorry, {actiorName} you need {(1250.5 - actiorPoints):f1} more!";
            }
            Console.WriteLine(message);
        }
    }
}
