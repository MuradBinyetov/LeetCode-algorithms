using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BeatifulDays_HACKERRANK_
    {
        public static int beautifulDays(int i, int j, int k)
        {
            int count = 0; 

            for (int n = i; n <= j; n++)
            {
                if((n - ReverseNumber(n))%k == 0)
                {
                    count++;
                }
            }

            return count; 
        }

        public static int ReverseNumber(int n)
        { 
            int reverse = 0, rem; 
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                rem = n % 10;
                reverse = reverse * 10 + rem;
                n /= 10;
            }
            return reverse;
        }
    }
}
