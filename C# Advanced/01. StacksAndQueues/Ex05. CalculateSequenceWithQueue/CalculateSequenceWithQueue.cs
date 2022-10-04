using System;
using System.Collections.Generic;

namespace Ex05._CalculateSequenceWithQueue
{
    class CalculateSequenceWithQueue
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Queue<double> numbers = new Queue<double>();
            Queue<double> nForPrint = new Queue<double>(50);

            numbers.Enqueue(n);
            nForPrint.Enqueue(n);

            while(nForPrint.Count < 50)
            {
                double s2 = numbers.Peek() + 1;
                numbers.Enqueue(s2);
                nForPrint.Enqueue(s2);
                if(nForPrint.Count == 50) break;

                double s3 = 2 * numbers.Peek() + 1;
                numbers.Enqueue(s3);
                nForPrint.Enqueue(s3);
                if (nForPrint.Count == 50) break;

                double s4 = numbers.Dequeue() + 2;
                numbers.Enqueue(s4);
                nForPrint.Enqueue(s4);

            }

            Console.WriteLine(string.Join(" ", nForPrint));
        }
    }
}
