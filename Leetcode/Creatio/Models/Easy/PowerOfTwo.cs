using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class PowerOfTwo
    {
        public static bool IsPowerOfTwo(int n)
        { 
            if (n == 1) return true;
            if (n == 0) return false;
            while (n % 2 == 0)
            {
                n /= 2 ;
            }

            if(n == 1)
            {
                Console.WriteLine("trueeee");
                return true;
            }
            Console.WriteLine("falseeee");
            return false;
        }
    }
}
