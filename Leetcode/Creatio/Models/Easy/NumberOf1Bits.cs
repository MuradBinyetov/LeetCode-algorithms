using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class NumberOf1Bits
    {
        public static int HammingWeight(uint n)
        {
            int count = 0;
            for (var i = 0; i < 32; i++)
            {
                if ((n & 1) == 1) count++;
                n = n >> 1;
            } 

            return count;
        }
    }
}
