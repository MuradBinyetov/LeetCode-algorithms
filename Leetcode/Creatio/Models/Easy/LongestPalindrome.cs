using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LongestPalindrome
    {
        public static int LongestPalindromeMethod(string s)
        {  
            if (s.Length == 1) return 1;
            List<char> chars = new List<char>(s);
            int count = 0;
            for (int i = 0; i < chars.Count; i++)
            { 
                for (int f = i+1; f < chars.Count; f++)
                {
                    if(chars[i] == chars[f])
                    {
                        count++;
                        chars.Remove(chars[i]);
                        chars.Remove(chars[f-1]);
                        i--;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if(chars.Count != 0)
            {
                return count * 2 + 1;
            }
            if(chars.Count == 0 && count >= 1)
            {
                return s.Length;
            }
            return 0;
        }
    }
}
