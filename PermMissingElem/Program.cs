using System;
using System.Collections.Generic;

namespace PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            var myEmptyArray = new int[] {2, 3 };
            var result = solution(myEmptyArray);

            Console.WriteLine(result);
        }

        static public int solution(int[] A) {
            var matchesDictionary = new Dictionary<int, bool>();
            foreach (var number in A)
            {
                matchesDictionary.Add(number, true);
            }
            
            int result = -1;
            for (int i = 1; i < A.Length + 2; i++)
            {
                if(!matchesDictionary.ContainsKey(i)) {
                    result = i;
                    break;
                }
            }
            
            return result;
    }
    }
}
