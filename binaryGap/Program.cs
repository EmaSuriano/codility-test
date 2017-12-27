using System;

namespace binaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = solution(328);
            Console.WriteLine(result);
        }

        static int solution(int N)
        {
            var binaryNumber = Convert.ToString(N, 2);
            var result = 0;
            var count = 0;
            bool startCounting = false;
            foreach (var bit in binaryNumber)
            {
                if (bit == '0' && startCounting)
                {
                    count++;
                    continue;
                }

                if (bit == '1')
                {
                    startCounting = true;

                    if (count > 0)
                    {
                        if (count > result) result = count;
                        count = 0;
                    }
                }

            }
            return result;
        }
    }
}
