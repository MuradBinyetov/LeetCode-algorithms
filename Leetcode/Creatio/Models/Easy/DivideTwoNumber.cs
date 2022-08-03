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

        public static int MethodOnlySumAndSub(int a,int b)
        {
            int resp = 1;
            int temp = b;
            a=Math.Abs(a);
            temp =Math.Abs(temp);
            b = Math.Abs(b);
            while (a > temp)
            {
                temp += temp;
                resp += resp;
            }
            while (temp > a)
            {
                temp = temp - b;
                resp--;
            }
            return resp;
        }
    }
}
