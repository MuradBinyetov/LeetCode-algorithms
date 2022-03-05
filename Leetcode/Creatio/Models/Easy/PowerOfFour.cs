using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PowerOfFour
    {
        public static bool IsPowerOfFour(int n)
        {
            if (n == 0) return false;
            while (n % 4 == 0)
            {
                n = n / 4;
            }
            if (n == 1) return true;

            return false;
        }
    }
}
