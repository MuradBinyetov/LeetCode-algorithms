using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Easy
{
    public class MaximumAverageSubarray1
    {
        public static double FindMaxAverage(int[] nums, int k) //nums = [1,12,-5,-6,50,3]
        { 
            
          long sum = 0;
            for (int i = 0; i < k; i++)
            {
                sum += nums[i];
            }
            
         long max = sum;
            for (int i = k; i < nums.Length; i++)
            {
                sum += nums[i] - nums[i - k];
                max = Math.Max(max, sum); 
            }
            return max * 1.0 / k;
        }
    }
}
