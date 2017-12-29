using System;
using System.Collections.Generic;

namespace TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var myEmptyArray = new int[] {1, 6 };
            var result = solution(myEmptyArray);

            Console.WriteLine(result);
        }

        static public int solution(int[] A) {
            long accumulator = 0;
            foreach (var currentNumber in A)
            {
                accumulator += (long)currentNumber;
            }

            var result = 100001;
            long sum = 0;

            var difference = result;
            var lastDiff = difference;

            for (int i = 0; i < A.Length - 1; i++)
            {
                var currentNumber = A[i];
                sum += currentNumber;
                accumulator -= (long)currentNumber;
                lastDiff = difference;
                difference = Math.Abs(accumulator - sum);
                if(lastDiff < difference) break;
                if(difference < result) {
                    result = difference;
                }
            }

            return result;
    }
    }
}
