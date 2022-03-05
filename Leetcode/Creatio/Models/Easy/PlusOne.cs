using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class PlusOne
    {
        public static int[] PlusOneMethod(int[] digits) //digits = [1,2,3]-->[1,2,4]  [8,5,9,9]-->[8,6,0,0]  [9]-->[1,0]  [7,6,9]-->[7,7,0] 
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            int count = 1;

            foreach (var item in digits)
            {
                stack.Push(item);
            }

            int lastNum = stack.Pop();
            if(lastNum != 9)
            {
                lastNum++;
                stack.Push(lastNum);
            }
            else
            {
                if (stack.Count > 0)
                {
                    int beforeLastNum = stack.Pop(); 
                    while(beforeLastNum == 9)
                    {
                        if (stack.Count > 0)
                        {
                            beforeLastNum = stack.Pop();
                        }
                        else
                        {
                            beforeLastNum = 0;
                        }

                        count++;
                    } 
                    if(beforeLastNum != 9)
                    {
                        beforeLastNum++;
                        stack.Push(beforeLastNum);
                    }

                    for (int i = 0; i < count; i++)
                    { 
                        stack.Push(0);
                    }
                }
                else
                {
                    stack.Push(count);
                    stack.Push(0);
                }
            }



            foreach (var item in stack)
            {
                stack2.Push(item);
            }
            int[] array = stack2.ToArray();

            foreach (var item in array)
            {
                Console.WriteLine("arrayin elementleri:{0}",item);
            }
            return array;
        }
    }
}
