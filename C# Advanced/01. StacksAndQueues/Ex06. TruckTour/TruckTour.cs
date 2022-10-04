using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex06._TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {
            int petrolStations = int.Parse(Console.ReadLine());

            Queue<int[]> stations = new Queue<int[]>();

            for (int i = 0; i < petrolStations; i++)
            {
                stations.Enqueue(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            }


            for (int j = 0; j < petrolStations; j++)
            {
                    int fuel = 0;

                for(int i = 0; i < petrolStations; i++)
                {
                    fuel += stations.Peek()[0];
                    int distance = stations.Peek()[1];
                    stations.Enqueue(stations.Dequeue());

                    if (distance > fuel)
                    {
                        fuel = 0;

                        //re-order the queue for next station
                        for (int c = 0; c < i; c++)
                        {
                            stations.Enqueue(stations.Dequeue());
                        }

                        break;
                    }

                    fuel -= distance;

                    if(i == petrolStations - 1)
                    {
                        Console.WriteLine(j);
                        return;
                    }
                }
            }
        }
    }
}
