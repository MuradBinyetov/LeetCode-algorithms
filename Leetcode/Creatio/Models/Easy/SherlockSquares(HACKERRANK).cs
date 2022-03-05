using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class SherlockSquares_HACKERRANK_
    {
        public static int squares(int a, int b)
        {
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (isPerfectSquare(i))
                {
                    count++;
                }
            }

            return count;
        }
        static bool isPerfectSquare(int n)
        {
            for (int i = 1; i * i <= n; i++)
            { 
                if ((n % i == 0) && (n / i == i))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
