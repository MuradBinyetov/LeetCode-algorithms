using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models
{
    public class MaximumSubarray
    {
        public static int MaxSubArray(int[] nums)
        {
            int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            var max = int.MinValue;
            var tempMax = 0;
            foreach (var t in nums)
            {
                tempMax += t;
                if (tempMax > max)
                {
                    max = tempMax;
                }
                if (tempMax < 0)
                {
                    tempMax = 0;
                }
            }

            return max;
        }
    }
}
