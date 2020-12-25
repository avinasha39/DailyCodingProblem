//Given an array of integers, return a new array such that each 
//element at index i of the new array is the product of all the numbers in the original array except the one at i.

//For example, if our input was[1, 2, 3, 4, 5], the expected output would be[120, 60, 40, 30, 24]. 
//If our input was [3, 2, 1], the expected output would be[2, 3, 6].

//Follow-up: what if you can't use division?

using System;

namespace SampleApp
{
    internal static class Problem_2 
    {
        public static void Solve(int[] Nums)
        {

            int arraySize = Nums.Length;
            int temp = 1;
            bool isZero = false;
            int numberZeros = 0;

            for (int i = 0; i < arraySize; i++)
            {
                if (Nums[i] == 0)
                {
                    isZero = true;
                    numberZeros += 1;
                }
                else
                {
                    temp = temp * Nums[i];
                }

            }

            int[] result = new int[arraySize];

            if (!isZero && numberZeros < 0)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    result[i] = temp / Nums[i];
                }
            }
            else if (numberZeros == 1)
            {
                for (int i = 0; i < arraySize; i++)
                {
                    if (Nums[i] != 0)
                    {
                        result[i] = 0;
                    }
                    else
                    {
                        result[i] = temp;
                    }
                }
            }
            else
            {

                for (int i = 0; i < arraySize; i++)
                {
                    result[i] = 0;
                }
            }


            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();

            
        }
    }
}


////leetcode solution
//class Solution
//{
//    public int[] productExceptSelf(int[] nums)
//    {

//        // The length of the input array
//        int length = nums.length;

//        // The left and right arrays as described in the algorithm
//        int[] L = new int[length];
//        int[] R = new int[length];

//        // Final answer array to be returned
//        int[] answer = new int[length];

//        // L[i] contains the product of all the elements to the left
//        // Note: for the element at index '0', there are no elements to the left,
//        // so L[0] would be 1
//        L[0] = 1;
//        for (int i = 1; i < length; i++)
//        {

//            // L[i - 1] already contains the product of elements to the left of 'i - 1'
//            // Simply multiplying it with nums[i - 1] would give the product of all
//            // elements to the left of index 'i'
//            L[i] = nums[i - 1] * L[i - 1];
//        }

//        // R[i] contains the product of all the elements to the right
//        // Note: for the element at index 'length - 1', there are no elements to the right,
//        // so the R[length - 1] would be 1
//        R[length - 1] = 1;
//        for (int i = length - 2; i >= 0; i--)
//        {

//            // R[i + 1] already contains the product of elements to the right of 'i + 1'
//            // Simply multiplying it with nums[i + 1] would give the product of all
//            // elements to the right of index 'i'
//            R[i] = nums[i + 1] * R[i + 1];
//        }

//        // Constructing the answer array
//        for (int i = 0; i < length; i++)
//        {
//            // For the first element, R[i] would be product except self
//            // For the last element of the array, product except self would be L[i]
//            // Else, multiple product of all elements to the left and to the right
//            answer[i] = L[i] * R[i];
//        }

//        return answer;
//    }
//}