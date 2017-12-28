using System;
using System.Collections.Generic;

namespace oddOccurencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new int[] { 1, 2, 3, 4 };
            var result = solution(list, 2);

            Console.WriteLine(result);
        }

        static public int[] solution(int[] A, int K)
        {
            var result = new int[A.Length];
            if (A.Length == 0) return result;
            var i = K % A.Length;
            var count = 0;
            while (count != A.Length)
            {
                result[i] = A[count];
                count++;
                i = i < A.Length - 1 ? i + 1 : 0;
            }
            return result;
        }
    }
}
