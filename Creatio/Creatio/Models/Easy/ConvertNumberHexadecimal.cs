using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ConvertNumberHexadecimal
    {
        public static string ToHex(int num)
        {
            string resp = "";
            int number = num;
            Dictionary<int, string> dict = new Dictionary<int, string>()
            {
                {10,"A"},{11,"B"},{12,"C"}, {13,"D"},{14,"E"},{15,"F"}
            };
            Stack<string> stack = new Stack<string>();

            if (num < 0)
            {
                while (num * -1 >= 16)
                {
                    int a = num % 16;
                    num = num / 16;

                    if (16 + a >= 10 && 16 + a <= 15)
                    {
                        stack.Push(dict[16 + a]);
                    }
                    else
                    {
                        stack.Push((16 + a).ToString());
                    }
                }

                if (16 + num - 1 >= 10)
                {
                    stack.Push(dict[16 + num]);
                }
                else
                {
                    stack.Push((16 + num).ToString());
                }
            }
            else
            {

                while (num >= 16)
                {
                    int a = num % 16;
                    num = num / 16;
                    if (a >= 10 && a <= 15)
                    {
                        stack.Push(dict[a]);
                    }
                    else
                    {
                        stack.Push(a.ToString());
                    }
                }
                if (num >= 10 && num <= 15)
                {
                    stack.Push(dict[num]);
                }
                else
                {
                    stack.Push(num.ToString());
                }
            }

            if (number < 10)
            {
                if (stack.Count < 8)
                {
                    while (stack.Count != 8)
                    {
                        stack.Push("f");
                    }
                }
            }

            foreach (var item in stack)
            {
                resp += item.ToLower();
            }
            return resp;
        } 
    }
}
