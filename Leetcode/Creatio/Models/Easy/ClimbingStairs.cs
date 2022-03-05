using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class ClimbingStairs
    {
         
        public static int ClimbStairs(int n)
        {
            ///4 ---> 1+1+1+1       2+2         1+1+2       2+1+1       1+2+1
            ///3 ---> 1+1+1         1+2         2+1 
            ///5 ---> 1+1+1+1+1     1+2+1+1     1+1+2+1     1+1+1+2     2+1+1+1     2+2+1   2+1+2
            ///6 ---> 1+1+1+1+1+1   1+2+1+1+1   1+1+2+1+1   1+1+1+2+1   1+1+1+1+2   2+2+2   2+2+1+1  2+1+2+1  2+1+1+2   
            int p1 = 0, p2 = 0, p0 = 1;
            for (int i = 1; i <= n; i++)
            {
                p1 = p2;
                p2 = p0;
                p0 = p1 + p2;
            }
            return p0;
        }
    }
}
