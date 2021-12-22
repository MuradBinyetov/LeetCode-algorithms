using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class WordPattern
    {
        public static bool WordPatternMethod(string pattern, string s)  // abba  s = "dog cat cat dog"
        { 
            Dictionary<char, string> dict1 = new Dictionary<char, string>(); 
            Dictionary<string, char> dict2 = new Dictionary<string, char>(); 

            List<string> list = new List<string>(s.Split(' '));

            if (pattern.Length != list.Count) return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                if (!dict1.ContainsKey(pattern[i]))
                {
                    dict1.Add(pattern[i], list[i]);
                }
                else
                {
                    if (dict1[pattern[i]] == list[i])
                        continue;
                    else
                        return false;
                }

                if (!dict2.ContainsKey(list[i]))
                {
                    dict2.Add(list[i], pattern[i]);
                }
                else
                {
                    if (dict2[list[i]] == pattern[i])
                        continue;
                    else
                        return false;
                }

            }

            return true;
        }
    }
}
