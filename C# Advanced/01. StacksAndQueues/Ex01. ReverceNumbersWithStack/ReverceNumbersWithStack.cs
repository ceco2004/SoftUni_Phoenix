using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01._ReverceNumbersWithStack
{
    class ReverceNumbersWithStack
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
           // Console.WriteLine(nums.Peek());
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
