using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class HappyNumber
    {
        public static bool IsHappy(int n) // 548
        {
            int sum = 0;
            while (n > 0)
            {
                int lastNum = n % 10;
                n = (n - lastNum) / 10;
                sum += lastNum * lastNum; 
            }
            

            return true;
        }
    }
}
