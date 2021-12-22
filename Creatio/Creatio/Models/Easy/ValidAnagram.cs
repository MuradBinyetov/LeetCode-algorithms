using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ValidAnagram
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            List<char> list = new List<char>();
            foreach (var item in s)
            {
                list.Add(item);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (!list.Contains(t[i])) return false;
                list.Remove(t[i]);
                continue;
            }
            return true;
        }
    }
}