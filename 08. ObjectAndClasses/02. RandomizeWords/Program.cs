using System;
using System.Linq;

namespace _02._RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random rd = new Random();

            for(int i = 0; i < words.Length; i++)
            {
                string temp = words[i];
                int random = rd.Next(0, words.Length);

                words[i] = words[random];
                words[random] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
