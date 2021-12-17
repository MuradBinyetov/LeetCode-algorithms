using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class HappyNumber
    {
        public static bool IsHappy(int n) // 133
        {
            if (n == 1 || n == 7) return true;
            int sum = n;

            while (sum > 9)
            {
                sum = 0;
                while (n > 0)
                {
                    int lastNum = n % 10;
                    n = (n - lastNum) / 10;
                    sum += lastNum * lastNum;
                }
                if (sum == 1)
                {
                    Console.WriteLine("happy num");
                    return true;
                }
                n = sum;
                
            }

            if (sum == 7) return true;
            

            Console.WriteLine("Unhappy num");
            return false;
        }
    }
}
