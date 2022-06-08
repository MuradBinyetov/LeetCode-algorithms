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
            int resp = 1;
            int a = y;
            while (x > a)
            {
                a += a;
                resp += resp;
            }

            while (a > x)
            {
                a = a - y;
                resp--;
            }


            return resp;
        }
    }
}
