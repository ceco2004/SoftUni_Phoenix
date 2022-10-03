using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            List<Point> points = new List<Point>();

            for(int i = 0; i < quantity; i++)
            {
                int[] dot = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                Point point = new Point(dot[0], dot[1]);
                points.Add(point);
            }

            Point p1 = new Point();
            Point p2 = new Point();
            double shortDistance = double.MaxValue;

            for(int i = 0; i < points.Count - 1; i++)
            {
                Point first = points[i];

                for(int j = i + 1; j < points.Count; j++)
                {
                    Point second = points[j];
                    double distance = CalculateDistance(first, second);

                    if(shortDistance > distance)
                    {
                        shortDistance = distance;
                        p1 = first;
                        p2 = second;
                    }
                }
            }

            Console.WriteLine($"{shortDistance:f3}");
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

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

        public override string ToString()
        {
            return $"({this.X}, {this.Y})";
        }
    }
}
