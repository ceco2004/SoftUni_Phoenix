using System;
using System.Linq;

namespace _04._DistanceBetwenPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[2];

            for(int i = 0; i < 2; i++)
            {
                int[] coordinate = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                Point p = new Point(coordinate[0], coordinate[1]);
                points[i] = p;
            }

            double distance = CalculateDistance(points[0], points[1]);
            Console.WriteLine($"{distance:f3}");

        }

        private static double CalculateDistance(Point point1, Point point2)
        {
            double sideA = Math.Abs(point1.X - point2.X);
            double sideB = Math.Abs(point1.Y - point2.Y);

            double distance = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

            return distance;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
