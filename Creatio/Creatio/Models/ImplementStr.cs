using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class ImplementStr
    {
        public static int StrStr(string haystack, string needle) //hello
        {
            bool isHave = haystack.Contains(needle);
            if (haystack == "" && needle == "") return 0;

            if (!isHave) return -1; 

            for (int i = 0; i < haystack.Length; i++)
            {
                string partStr = haystack.Substring(i, needle.Length);
                if(partStr.Equals(needle))
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
