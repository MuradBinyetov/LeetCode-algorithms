using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BinaryNumberAlternatingBits
    {
        public static bool HasAlternatingBits(int n)
        {
            Stack<int> stack = new Stack<int>();
            while (n >= 2)
            {
                int qalixxx = n % 2;
                n = n / 2;
                stack.Push(qalixxx);
            }

            stack.Push(n);

            while (stack.Count > 1)
            {
                if(stack.Pop() == stack.Peek())
                { 
                    return false;
                }
            }
            return true;
        }
    }
}
