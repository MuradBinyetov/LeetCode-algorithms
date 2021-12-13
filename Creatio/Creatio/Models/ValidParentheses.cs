using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class ValidParentheses
    { 
        public static bool IsValid(string s) // s = "{[]}"
        {
            var map = new Dictionary<char, char>
            {
                { '}', '{' },
                { ']', '[' },
                { ')', '(' }
            };
            var sChar = s.ToCharArray();
            var stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                var c = sChar[i]; //
                if (map.ContainsKey(c))
                {
                    var top = stack.Any() ? stack.Pop() : '#';
                    if (top != map[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);  //{ [
                }
            }
            return !stack.Any();
        }
    }
}
