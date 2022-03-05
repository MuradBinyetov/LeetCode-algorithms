using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class _3SumCLosest
    {
        public static int ThreeSumClosest(int[] nums, int target)
        {
            List<int> num = new List<int>(nums);
            if (num == null || num.Count < 3)
            {
                return int.MaxValue;
            }

            num.Sort();

            var diff = int.MaxValue;
            for (var i = 0; i < num.Count; i++)
            {
                var next = i + 1;
                var last = num.Count - 1;
                while (next < last)
                {
                    var sum = num[i] + num[next] + num[last];
                    var tempdiff = Math.Abs(sum - target);
                    if (tempdiff < Math.Abs(diff))
                    {
                        diff = sum - target;
                    }
                    if (sum >= target)
                    {
                        last--;
                    }
                    else if (sum < target)
                    {
                        next++;
                    }
                }
            }

            return diff + target;
        }
    }
}
