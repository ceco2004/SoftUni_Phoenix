using System;
using System.Linq;

namespace Ex02._RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int rotateCount = int.Parse(Console.ReadLine());

            int[] sum = new int[nums.Length];

            for(int i = 0; i < rotateCount; i++)
            {
                int[] rotated = RotateAray(nums);

                for(int j = 0; j < rotated.Length; j++)
                {
                    sum[j] += rotated[j];
                }

                nums = rotated;
            }




            // Reverced version
            //for(int i = 0; i < rotateCount; i++)
            //{
            //    int[] rotated = new int[nums.Length];
            //    Array.Copy(nums, rotated, nums.Length);
            //    Array.Reverse(rotated);

            //    for(int j = 0; j < rotated.Length; j++)
            //    {
            //        sum[j] += rotated[j];
            //    }

            //    nums = rotated;
            //}

            Console.WriteLine(string.Join(" ", sum));
        }

        static int[] RotateAray(int[] nums)
        {
            int[] rotated = new int[nums.Length];
            rotated[0] = nums[nums.Length - 1];

            for(int i = 0; i < nums.Length - 1; i++)
            {
                rotated[i + 1] = nums[i];
            }

            return rotated;
        }
    }
}
