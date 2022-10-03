using System;
using System.Linq;

namespace Ex10._PairsOfDiffrence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int diff = int.Parse(Console.ReadLine());

            int count = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] - nums[j] == diff || nums[j] - nums[i] == diff)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
