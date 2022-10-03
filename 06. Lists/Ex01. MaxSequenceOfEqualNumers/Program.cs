using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex01._MaxSequenceOfEqualNumers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            List<int> current = new List<int>();
            List<int> maxSequence = new List<int>();

            int currentIndex = 0;
            bool isRestarted = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    current.Add(nums[i]);
                }
                else if (isRestarted)
                {
                    current.Add(nums[i]);
                    currentIndex = 0;
                    isRestarted = false;
                }
                else if (nums[i] == current[currentIndex])
                {
                    current.Add(nums[i]);
                    currentIndex++;
                }
                else
                {
                    if (current.Count > maxSequence.Count)
                    {
                        maxSequence.Clear();
                        maxSequence.AddRange(current);
                    }
                    current.Clear();
                    current.Add(nums[i]);
                    isRestarted = true;
                }
            }
            

            if (current.Count > maxSequence.Count)
            {
                maxSequence.Clear();
                maxSequence.AddRange(current);
            }

            Console.WriteLine(string.Join(' ', maxSequence));
        }
    }
}
