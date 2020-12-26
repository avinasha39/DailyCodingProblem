using System;

namespace SampleApp
{
    public class Driver_Program
    {
        public static void Main(string[] Args)
        {

            int numberoftestcase = 1;
            while (numberoftestcase-- > 0)
            {
                int arraySize = Int32.Parse(Console.ReadLine());
                string[] arrstr1 = Console.ReadLine().Split(' ');
                int[] arr = new int[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    arr[i] = Int32.Parse(arrstr1[i]);
                }

                //var program_4 = new Problem_4();
                //program_4.Solve();
                //Problem_2.Solve(arr);
                Problem_3.Solve(arr);
                Console.ReadKey();

            }
        }
    }
}