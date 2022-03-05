using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class LongestContinuousIncreasingSubsequence
    {
        public static int FindLengthOfLCIS(int[] nums) //[1,3,5,4,7]
        {
            int count = 1;
            int maxCount = 1;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i + 1] > nums[i])
                {
                    count++;
                    if (maxCount < count)
                    {
                        maxCount = count;
                    };
                }
                else
                {
                    count = 1;
                }
            }
            return maxCount;
        }
    }
}
