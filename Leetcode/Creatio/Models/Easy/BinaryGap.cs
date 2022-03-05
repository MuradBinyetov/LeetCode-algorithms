using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BinaryGap
    {
        public static int BinaryGapMethod(int n) //10110
        {
            Stack<int> stack = new Stack<int>();
            while (n >= 2)
            {
                int qaliq = n % 2;
                n = n / 2;
                stack.Push(qaliq);
            }

            stack.Push(n);

            int max = 0;
            for (int i = 0; i < stack.Count; i++)
            {
                for (int f = i+1; f < stack.Count; f++)
                {
                    if(stack.ElementAt(i) == 0)
                    {
                        break;
                    }
                    if(stack.ElementAt(f) == 0)
                    {
                        continue;
                    }
                    else
                    {
                        if (f - i > max)
                        {
                            max = f - i;
                        }
                        break;
                    }
                }
            }


            return max;
        }
    }
}
