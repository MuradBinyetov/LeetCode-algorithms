using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s) //abcabcbb
        {
            if (s == "") return 0;
            int max = 1;
            for (int i = 0; i < s.Length; i++)
            { 
                string wordPart = s[i].ToString();
                for (int f = i+1; f < s.Length; f++)
                { 
                    if (!wordPart.Contains(s[f]))
                    {
                        wordPart += s[f]; 
                        if (wordPart.Length > max)
                        {
                            max = wordPart.Length;
                        }
                    } 
                    else
                    {
                        break;
                    } 
                }
            }
            return max;
        }
    }
}
