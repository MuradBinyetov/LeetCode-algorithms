using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PowerOfThree
    {
        public static bool IsPowerOfThree(int n)
        {
            if (n == 0) return false;
            while(n%3 == 0)
            {
                n = n / 3;
            }
            if (n == 1) return true;

            return false; 
        }
    }
}
