using _04._Telephony.Models;
using _04._Telephony.Models.Interfaces;
using System;

namespace _04._Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            
            if (char.IsDigit(input[0][0]))
            {
                ICallable smartfone = new Smartphone();
                foreach(var number in input)
                {
                    Console.WriteLine(smartfone.Call(number));
                }
            }
            else
            {
                IBrowsable smartphone = new Smartphone();
                foreach(var url in input)
                {
                    Console.WriteLine(smartphone.Browse(url));
                }
            }
        }
    }
}
