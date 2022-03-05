using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class BuddyStrings
    {
        public static bool BuddyStringsMethod(string s, string goal)
        {
            if (s.Length != goal.Length) return false;

            if (s.Equals(goal))
            {
                int[] count = new int[26];
                for (int i = 0; i < s.Length; ++i)
                    count[s[i] - 'a']++;

                foreach (int c in count)
                    if (c > 1) return true;
                return false;
            }
            else
            {
                int first = -1, second = -1;
                for (int i = 0; i < s.Length; ++i)
                {
                    if (s[i] != goal[i])
                    {
                        if (first == -1)
                            first = i;
                        else if (second == -1)
                            second = i;
                        else
                            return false;
                    }
                }

                return (second != -1 && s[first] == goal[second] && s[second] == goal[first]);
            }
           
        }
    }
}
