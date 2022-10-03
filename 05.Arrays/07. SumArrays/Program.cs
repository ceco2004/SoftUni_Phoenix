using System;
using System.Linq;

namespace _07._SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bigArr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] smallArr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            MakeBigArrBig(ref bigArr, ref smallArr);
           
            int smallIndex = 0;
            for (int i = 0; i < bigArr.Length; i++)
            {

                if (smallIndex > smallArr.Length - 1)
                {
                    smallIndex = 0;
                }

                Console.Write($"{bigArr[i] + smallArr[smallIndex]} ");
                smallIndex++;

            }


        }

        private static void MakeBigArrBig(ref int[] bigArr, ref int[] smallArr)
        {
            if(smallArr.Length > bigArr.Length)
            {
                //int[] temp = new int[0];
                //Array.Resize(ref temp, bigArr.Length);
                //Array.Copy(bigArr, temp, bigArr.Length);

                //Array.Resize(ref bigArr, smallArr.Length);
                //Array.Copy(smallArr, bigArr, smallArr.Length);

                //Array.Resize(ref smallArr, temp.Length);
                //Array.Copy(temp, smallArr, temp.Length);

                int[] temp = smallArr;
                smallArr = bigArr;
                bigArr = temp;
                
            }
        }
    }
}
