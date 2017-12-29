using System;
using System.Collections.Generic;

namespace FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = solution(10, 85, 30);

            Console.WriteLine(result);
        }

        static public int solution(int X, int Y, int D) {
            var diff = Y - X;
            var divider = Decimal.Divide(diff, D);
            return (int)Math.Ceiling(divider);
        }
    }
}
