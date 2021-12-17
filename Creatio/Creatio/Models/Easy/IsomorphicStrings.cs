using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, char> dict1 = new Dictionary<char, char>();
            Dictionary<char, char> dict2 = new Dictionary<char, char>();


            for (int i = 0; i < s.Length; i++) // egg add   badc   baba
            {
                bool key = dict1.ContainsKey(s[i]); 
                if (!key)
                { 
                    dict1.Add(s[i], t[i]);
                }
                else
                {
                    if (dict1[s[i]] != t[i]) return false;
                }

                key = dict2.ContainsKey(t[i]);
                if (!key)
                {
                    dict2.Add(t[i], s[i]);
                }
                else
                {
                    if (dict2[t[i]] != s[i]) return false;
                }
            } 
             

            return true;
        }
    }
}
