using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class ArrangingCoins
    {
        public static int ArrangeCoins(int n)
        {
            int level = 0, coin = 1;
            while (n >= coin)
            {
                n -= coin;
                coin++;
                level++;
            }
            return level;
        }
    }
}
