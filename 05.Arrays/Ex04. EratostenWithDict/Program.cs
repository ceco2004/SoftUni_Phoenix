using System;
using System.Collections.Generic;

namespace Ex04._EratostenWithDict
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedDictionary<int, bool> tableNonPrime
                = new SortedDictionary<int, bool>();

            for(int i = 2; i <= num; i++)
            {
                for(int j = 2; j <= num; j++)
                {
                    bool stop = false;

                      decimal  temp = i * j;
                        if (temp > num)
                        {
                            stop = true;
                            break;

                        }

                        if (tableNonPrime.ContainsKey((int)temp) == false)
                        {
                        tableNonPrime[(int)temp] = false;
                        }
                    
                    if (stop)
                    {
                        continue;
                    }
                }
                
            }

            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if(tableNonPrime.ContainsKey(i) == false)
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
            Console.WriteLine($"--= {count} =--");
        }
    }
}
