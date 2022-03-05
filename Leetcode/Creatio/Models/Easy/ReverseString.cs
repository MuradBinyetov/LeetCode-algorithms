using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReverseString
    {
        public static void ReverseStringMethod(char[] s)
        {
            Stack<char> stack = new Stack<char>();
            List<char> list = new List<char>();

            foreach (var item in s)
            {
                stack.Push(item);
            }

            foreach (var item in stack)
            {
                list.Add(item);
            }
            s= list.ToArray();
        }
    }
}
