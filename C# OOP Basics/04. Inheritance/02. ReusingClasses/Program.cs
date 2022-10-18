using _02._ReusingClasses.Models;
using System;

namespace _02._ReusingClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomList cl = new CustomList();

            try
            {
                Console.WriteLine(cl.IsEmpy());
                cl.Push("First");
                Console.WriteLine(cl.Peek());
                Console.WriteLine(cl.Pop());

            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            

        }
    }
}
