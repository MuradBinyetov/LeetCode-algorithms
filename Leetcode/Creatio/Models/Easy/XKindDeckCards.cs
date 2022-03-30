using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class XKindDeckCards
    {
        public static bool HasGroupsSizeX(int[] deck)
        {
            int[] count = new int[10000];
            foreach (int c in deck)
                count[c]++;

            int g = -1;
            for (int i = 0; i < 10000; ++i)
                if (count[i] > 0)
                {
                    if (g == -1)
                        g = count[i];
                    else
                        g = gcd(g, count[i]);
                }

            return g >= 2;
        }
        public static int gcd(int x, int y)
        {
            return x == 0 ? y : gcd(y % x, x);
        }
    }
    
}
