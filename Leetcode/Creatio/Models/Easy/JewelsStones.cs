using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class JewelsStones
    {
        public static int NumJewelsInStones(string jewels, string stones)
        {
            int count = 0;

            foreach (var item in stones)
            {
                if (jewels.Contains(item))
                {
                    count++;
                }
            }


            return count;
        }
    }
}
