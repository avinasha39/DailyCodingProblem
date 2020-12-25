//Given an array of integers, find the first missing positive integer in linear time and 
//constant space.In other words, find the lowest positive integer that does not 
//exist in the array.The array can contain duplicates and negative numbers as well.

//For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
//You can modify the input array in-place.

using System;

namespace SampleApp
{
    internal static class Problem_3
    {
        public static void Solve(int[] nums)
        {
            int arraySize = Int32.Parse(Console.ReadLine());
            string[] arrstr1 = Console.ReadLine().Split(' ');
            int[] arr = new int[arraySize];
            int temp = Int32.MinValue;
            bool containsAllNegative = true;
            for (int i = 0; i < arraySize; i++)
            {
                arr[i] = Int32.Parse(arrstr1[i]);

                if (Int32.Parse(arrstr1[i]) == 0)
                {
                    isZero = true;
                }
                if (Int32.Parse(arrstr1[i]) >= 0)
                {
                    containsAllNegative = false;
                }



            }

            if (containsAllNegative)
            {
                Console.WriteLine(0);
            }
        }
             
    }
}
