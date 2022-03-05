using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class AssignCookies
    {
        public static int FindContentChildren(int[] g, int[] s)
        {

            int count = 0, child = 0, cookie = 0;
            Array.Sort(g);
            Array.Sort(s);
            while (child < g.Length && cookie < s.Length)
            {
                if (g[child] <= s[cookie])
                {
                    count++;
                    child++;
                }
                cookie++;
            }
            return count;
        }
    }
}
