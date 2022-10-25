using System;

namespace MaxValueofSum
{
    class Program
    {
        public int sumMax(int[] arr)
        {
            int sum = 0;
            int currSum = 0;
            int maxSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                currSum += i * arr[i];
            }


            int tempValue = currSum;
            maxSum = currSum;

            for (int i = 1; i < arr.Length; i++)
            {
                currSum = 0;
                currSum += tempValue + sum - (arr.Length * arr[arr.Length - i]);

                if (currSum > maxSum)
                    maxSum = currSum;
            }

            return maxSum;
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 10, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int maxSum = program.sumMax(arr);

            Console.WriteLine("Max sum " + maxSum);
        }
    }
}
