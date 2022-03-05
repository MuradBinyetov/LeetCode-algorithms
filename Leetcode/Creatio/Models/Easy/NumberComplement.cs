using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class NumberComplement
    {
        public static int FindComplement(int num)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> reverseStack = new Stack<int>();
            while (num > 1)
            {
                int a = num % 2;
                num = num / 2;
                stack.Push(a);
            }
            stack.Push(num);

            foreach (var item in stack)
            {
                if(item ==0)
                {
                    reverseStack.Push(1);
                }
                else
                {
                    reverseStack.Push(0);
                }
            }

            int count = 1;
            int resp = 0;
            foreach (var item in reverseStack)
            {
                resp += count * item;
                count = count * 2;
            }

                return resp;
        }
    }
}
