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

            if (nums.Length == 0)
                return 0;
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int tempSum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    tempSum += nums[j]; // -2  -1  -4  0  -1  1  3
                    if (tempSum > max)
                        max = tempSum;  // -2  -1  -1  0   0  1  3
                }
            }
            return max;
        }
    }
}
