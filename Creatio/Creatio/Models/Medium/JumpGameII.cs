using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class JumpGameII
    {
        public static int Jump(int[] nums) //[1,1,1,1] --->1
        {
            var step = 0;
            var curEnd = 0;
            var curfastjump = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                curfastjump = Math.Max(nums[i] + i, curfastjump);
                if (i == curEnd)
                {
                    step++;
                    curEnd = curfastjump;
                }
            }
            return step;
        }
    }
}
