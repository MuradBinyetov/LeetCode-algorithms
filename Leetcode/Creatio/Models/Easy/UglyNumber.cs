using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class UglyNumber
    {
        public static bool IsUgly(int num)
        {
            if (num <= 0) return false;

            while (num % 2 == 0) num /= 2;
            while (num % 3 == 0) num /= 3;
            while (num % 5 == 0) num /= 5;

            if (num == 1) return true;
            return false;
        }
    }
}
