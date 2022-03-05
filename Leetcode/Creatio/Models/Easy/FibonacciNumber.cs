using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FibonacciNumber
    {
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            int first = 0;
            int second = 1;

            for (int i = 2; i <= n; ++i)
            {
                int sum = first + second;

                first = second;
                second = sum;
            }

            return second;
        }

        public static int Fib2(int n) //Recursion Method
        {
            if (n <= 2) return 1;
            return Fib(n-1) + Fib(n-2);
        }
    }
}
