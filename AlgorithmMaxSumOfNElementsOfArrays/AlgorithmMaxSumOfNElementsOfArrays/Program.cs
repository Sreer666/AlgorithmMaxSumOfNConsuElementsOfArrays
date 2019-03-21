using System;

namespace AlgorithmMaxSumOfNElementsOfArrays
{
    class Program
    {
        //    How to find the maximum sum of n consecutive numbers of an array? For example if our array is {2,5,3,4,6}
        //and n == 2 then output should be 10 (i.e. 6 + 4).
        static void Main(string[] args)
        {
            int[] array = { 2, 5, 3, 4, 6 };
            int n = 2;
            Console.WriteLine(GetLargestSum(array, n));

        }

        static int GetLargestSum(int[] array, int n)
        {
            int largestSum = 0;
            int previousSum = 0;

            for (int i = 0; i <= array.Length - n; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < n; j++)
                    {
                        largestSum += array[j];
                    }

                    previousSum = largestSum;
                }
                else
                {
                    int currentSum = previousSum - array[i - 1] + array[i + n - 1];
                    if (currentSum > largestSum)
                    {
                        largestSum = currentSum;
                    }
                    previousSum = currentSum;
                }
            }

            return largestSum;
        }
    }
}
