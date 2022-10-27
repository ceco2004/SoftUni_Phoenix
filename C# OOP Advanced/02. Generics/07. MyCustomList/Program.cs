using System;

namespace _07._MyCustomList
{
    public class Program
    {
        public static void Main()
        {
            ICustomList<string> data = new CustomList<string>();


            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] args = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (args[0])
                {
                    case "Add": Add(args[1]);
                        break;

                    case "Remove":
                        int index = int.Parse(args[1]);
                        Remove(index);
                        break;

                    case "Contains": Console.WriteLine(Contains(args[1]));
                        break;

                    case "Swap":
                        int index1 = int.Parse(args[1]);
                        int index2 = int.Parse(args[2]);
                        Swap(index1, index2);
                        break;

                    case "Greater": Console.WriteLine(CountGreaterThan(args[1]));
                        break;

                    case "Max": Console.WriteLine(Max());
                        break;

                    case "Min": Console.WriteLine(Min());
                        break;

                    case "Print": Print();
                        break;

                }


                input = Console.ReadLine();
            }

            void Add(string element)
            {
                data.Add(element);
            }

            bool Contains(string element)
            {
                return data.Contains(element);
            }

            int CountGreaterThan(string element)
            {
                return data.CountGreaterThan(element);
            }

            string Max()
            {
                return data.Max();
            }

             string Min()
            {
                return data.Min();
            }

            string Remove(int index)
            {
                return Remove(index);
            }

            void Swap(int index1, int index2)
            {
                data.Swap(index1, index2);
            }

            void Print()
            {
                foreach (string item in data)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
