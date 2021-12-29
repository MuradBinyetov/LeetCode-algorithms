using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class DistributeCandies
    {
        public static int DistributeCandiesMethod(int[] candyType)
        {
            int count = candyType.Length / 2;
            IEnumerable<int> a = candyType.Distinct();
            if (count > a.Count())
            {
                return a.Count();
            }
            else
            {
                return count;
            } 
        }
    }
}
