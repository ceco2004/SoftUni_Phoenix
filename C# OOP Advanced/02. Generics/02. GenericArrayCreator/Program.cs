using System;

namespace _02._GenericArrayCreator
{
    public class Program
    {
        static void Main()
        {
            int[] nums = ArrayCreator.Create(10, 33);
            var strings = ArrayCreator.Create(22, "Pesho");

            Console.WriteLine(nums.GetType().Name);
            Console.WriteLine(nums.Length);
            Console.WriteLine(strings.GetType().Name);
            Console.WriteLine(strings.Length);
        }
    }
}
