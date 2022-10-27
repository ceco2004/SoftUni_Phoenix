using System;

namespace _01._BoxOfT
{
    public class Program
    {
        static void Main()
        {
            IMyBox<int> box = new MyBox<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            Console.WriteLine(box.Remove());
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());

        }
    }
}
