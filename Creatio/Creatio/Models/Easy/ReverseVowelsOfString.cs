using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ReverseVowelsOfString
    {
        public static string ReverseVowels(string s)
        {
            List<char> list = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            Stack<char> stack = new Stack<char>();
            var arr = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (list.Contains(s[i])) stack.Push(s[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (list.Contains(arr[i])) arr[i] = stack.Pop();
            } 
              
            return new String(arr);
        }
    }
}
