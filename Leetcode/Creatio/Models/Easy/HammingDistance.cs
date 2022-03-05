using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class HammingDistance
    {
        public static int HammingDistanceMethod(int x, int y)
        {
            Stack<int> stackX = new Stack<int>();
            Stack<int> stackY = new Stack<int>();
            while (x > 1)
            {
                int a = x % 2;
                x = x / 2;
                stackX.Push(a);
            }
            stackX.Push(x);


            while (y > 1)
            {
                int a = y % 2;
                y = y / 2;
                stackY.Push(a);
            }
            stackY.Push(y);
             
            int count = 0;

            if(stackX.Count != stackY.Count)
            {
                while(stackX.Count != stackY.Count)
                {
                    if(stackX.Count < stackY.Count)
                    {
                        stackX.Push(0);
                    }
                    else
                    {
                        stackY.Push(0);
                    }
                }
            } 
            for (int i = 0; i < stackX.Count; i++)
            {
                if(stackX.Pop() != stackY.Pop())
                {
                    count++; 
                }
                i = -1;
            }


            return count;
        }
    }
}
