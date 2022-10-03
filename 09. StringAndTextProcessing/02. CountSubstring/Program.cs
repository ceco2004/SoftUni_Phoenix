using System;

namespace _02._CountSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();

            int count = 0;

            int index = text.IndexOf(subString);

            while(index >= 0)
            {
                count++;
                index = text.IndexOf(subString, index + 1);
            }


            Console.WriteLine(count);
        }
    }
}
