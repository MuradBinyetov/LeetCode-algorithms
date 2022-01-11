using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class ReverseInteger
    {
        public static int Reverse(int x) //321
        {
            Queue<int> stack = new Queue<int>();
            int num = x;

            x = Math.Abs(x);
            while (x>0)
            { 
                int qaliq = x % 10;
                x = (x - qaliq) / 10;
                stack.Enqueue(qaliq);
            }

            string resp = "";
            foreach (var item in stack)
            {
                resp += item;
            }

            if (num < 0)
            {
                return -int.Parse(resp);
            }
            else
            {
                return int.Parse(resp);
            } 
        }
    }
}
