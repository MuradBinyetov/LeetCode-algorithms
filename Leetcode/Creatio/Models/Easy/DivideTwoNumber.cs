using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DivideTwoNumber
    {

        public static long divide(long dividend,
                          long divisor)
        {

            // Calculate sign of divisor
            // i.e., sign will be negative
            // only iff either one of them
            // is negative otherwise it
            // will be positive
            long sign = ((dividend < 0) ^
                         (divisor < 0)) ? -1 : 1;

            // remove sign of operands
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            // Initialize the quotient
            long quotient = 0;

            // test down from the highest
            // bit and accumulate the
            // tentative value for
            // valid bit
            while (dividend >= divisor)
            {
                dividend -= divisor;
                ++quotient;
            }
            //if the sign value computed earlier is -1 then negate the value of quotient
            if (sign == -1)
                quotient = -quotient;
             return quotient;
        }


        public static int MethodTest(int x,int y)
        {
            int ferq = 1;
            int a = y;
            while (x > a)
            {
                a = a * 2;
                ferq = ferq * 2;
            }

            while (a > x)
            {
                a = a - y;
                ferq--;
            }


            return ferq;
        }
    }
}
