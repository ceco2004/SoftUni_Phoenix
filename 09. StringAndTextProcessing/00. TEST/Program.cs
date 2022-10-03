using System;
using System.Diagnostics;
using System.Text;

namespace _00._TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            string text = string.Empty;
            sw.Start();
            for(int i = 0; i < 1000000; i++)
            {
                text += 'a';
            }
            // > 450 sec
            Console.WriteLine(sw.Elapsed);


            StringBuilder sb = new StringBuilder();
            sw.Restart();
            for(int i = 0; i < 1000000; i++)
            {
                sb.Append('a');
            }
            // < 0.001 sec
            Console.WriteLine(sw.Elapsed);
        }
    }
}
