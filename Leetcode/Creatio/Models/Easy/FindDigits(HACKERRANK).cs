using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class FindDigits_HACKERRANK_
    {
        public static int findDigits(int n)
        {
            int count = 0;
            int baseNum = n;
            while (n > 0)
            {
                int rem = n % 10;
                n = (n - rem) / 10;
                if(rem!= 0 && baseNum % rem == 0)
                {
                    count++;
                }
            } 

            return count;
        }

    }
}
