using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class Polindrome
    { 
        public static bool IsPolindrome(int x) //151  15  1
        {
            if (x < 0)
            {
                return false;
            }

            int firstNum = x;
            int revertNum = 0; //1  15  151

            while (x > 0)
            {
                revertNum = revertNum * 10 + x % 10;
                x /= 10;
            }

            return firstNum == revertNum;
        }

    }
}
