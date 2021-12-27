using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PerfectNumber
    {
        public static bool CheckPerfectNumber(int num)
        {
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if(num %i == 0)
                {
                    sum += i;
                }
            }

            if (sum == num) return true;
            return false;
        }
    }
}
