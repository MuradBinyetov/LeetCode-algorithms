using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class Factorial
    {
        public static int FactorialMethod(int n) // 5 --> 5*4*3*2*1
        { 

            if (n == 0) return 1; 
            return n * FactorialMethod(n-1); 
        }
    }
}
