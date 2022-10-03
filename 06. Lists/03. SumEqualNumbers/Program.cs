using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._SumEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            bool haveMoreIndexes = true;
            while (haveMoreIndexes)
            {
                for (int i = 0; i < nums.Count - 1; i++)
                {
                    int indexNum = nums[i];
                    int nextNum = nums[i + 1];

                    if (indexNum == nextNum)
                    {
                        nums[i] += nextNum;
                        nums.RemoveAt(i + 1);
                        break;
                    }

                    if(i == nums.Count - 2)
                    {
                        haveMoreIndexes = false;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
