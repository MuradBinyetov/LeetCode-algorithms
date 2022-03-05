using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class StrangeAdvertising_HACKERRANK_
    {
        public static int viralAdvertising(int n)
        {
            int shared = 5;
            int cumulative = 0;
            while (n > 0)
            {
                int liked = shared / 2;
                cumulative += liked;
                shared = liked * 3;
                n--;
            }
            return cumulative;
        }
    }
}
