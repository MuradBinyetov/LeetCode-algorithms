using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class Base7
    {
        public static string ConvertToBase7(int num)
        {
            Stack<int> stack = new Stack<int>();
            int number = num;
            if (number < 0)
            {
                while (num <= -7)
                {
                    int a = num % 7*-1;
                    num = num / 7;
                    stack.Push(a);
                }
            }
            else
            {
                while (num >= 7)
                {
                    int a = num % 7;
                    num = num / 7;
                    stack.Push(a);
                }
            }
            

            stack.Push(num);
            string resp = "";
            foreach (var item in stack)
            {
                resp += item;
            }

            return resp;
        }
    }
}
