using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Creatio.Models.Medium
{
    public class JumpGameII
    {
        public static int Jump(int[] nums) //[3,2,1] --->1
        {

            if (nums.Length == 1) return 0;
            if (nums.Length == 2) return 1;
            int length = nums.Length; 
           
            // if (1 + nums[1] >= length -1) return 2;

            int count = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                while(i+ nums[i] >= nums.Length - 1)
                {
                    count++;
                    while (i + nums[i] < nums.Length)
                    {
                        i = i + nums[i];
                    }
                     
                }
            }

            return count;
        }
    }
}
