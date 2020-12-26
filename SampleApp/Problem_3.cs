//Given an array of integers, find the first missing positive integer in linear time and 
//constant space.In other words, find the lowest positive integer that does not 
//exist in the array.The array can contain duplicates and negative numbers as well.

//For example, the input [3, 4, -1, 1] should give 2. The input [1, 2, 0] should give 3.
//You can modify the input array in-place.

using System;
using System.Collections.Generic;

namespace SampleApp
{
    internal static class Problem_3
    {
        public static void Solve(int[] nums)
        {
            HashSet<int> hashSet = new HashSet<int>(nums);
            int minValue = 1;

            while (true)
            {
                if (!hashSet.Contains(minValue))
                {
                    break;
                }

                minValue++;
            }

            Console.WriteLine(minValue);
        }
             
    }
}
