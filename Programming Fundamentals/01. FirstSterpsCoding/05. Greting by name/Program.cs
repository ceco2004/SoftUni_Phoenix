using System;
using System.Threading;

namespace _05._Greting_by_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
             for(int i=0; i<=10; i++)
            {
                if(i < 10)
                {
                    Console.Write('.');
                }
                else
                {
                    Console.WriteLine('.');
                }
                Thread.Sleep(500);
            }
            Console.WriteLine($"How are You today {name}?");
        }
    }
}
