using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DivideTwoNumber
    {  
        public static int MethodTest(int x,int y)
        {
            int ferq = 1;
            int a = y;
            while (x > a)
            {
                a = a * 2;
                ferq = ferq * 2;
            }

            while (a > x)
            {
                a = a - y;
                ferq--;
            }


            return ferq;
        }
    }
}
